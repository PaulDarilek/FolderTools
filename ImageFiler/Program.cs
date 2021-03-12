using System;
using System.IO;
using System.Linq;

namespace ImageFiler
{
    class Program
    {
        internal static void Main(string[] args)
        {

            foreach (var directoryPath in args)
            {
                var directory = new DirectoryInfo(directoryPath);
                if(directory.Exists)
                {
                    IterateJpegFiles(directory);
                }
            }
        }

        private static void IterateJpegFiles(DirectoryInfo directory)
        {
            var images = directory.EnumerateFiles("*.jp*g", SearchOption.AllDirectories);
            foreach (var img in images)
            {
                var info = new ImageMetaData(img.FullName);
                if(info == null || info.Tags.Count == 2)
                {
                    continue;
                }

                //if(info.Tags.ContainsKey(PropertyTag.EquipMake) && info.Tags[PropertyTag.EquipMake].Equals("Samsung",StringComparison.OrdinalIgnoreCase))
                //{
                //    continue;
                //}    

                var tags = new PropertyTag[] { PropertyTag.DateTime, PropertyTag.ExifDTOrig, PropertyTag.ExifDTDigitized };
                var dtKey = tags.FirstOrDefault(t => info.Tags.ContainsKey(t));
                var dt = info.Tags[dtKey];

                Console.WriteLine($"{img.FullName} {info.ImageType} Date={dt} size={info.Width}x{info.Height} res={info.Resolution} bpp={info.BitsPerPixel}");
                foreach (var prop in info.Tags)
                {
                    switch (prop.Key)
                    {
                        case PropertyTag.LuminanceTable:
                        case PropertyTag.ChrominanceTable:
                        case PropertyTag.ThumbnailData:
                        case PropertyTag.ThumbnailCompression:
                        case PropertyTag.ThumbnailResolutionX:
                        case PropertyTag.ThumbnailResolutionY:
                        case PropertyTag.ThumbnailResolutionUnit:
                            break;

                        case PropertyTag.ExifFlash:
                            Console.WriteLine($"\t{prop.Key}={prop.Value}");
                            break;
                        case PropertyTag.ExifFNumber:
                            Console.WriteLine($"\t{prop.Key}={prop.Value}");
                            break;


                        case PropertyTag.ResolutionUnit:
                            var msg =
                                prop.Value == "[2]" ?  "inch" :
                                prop.Value == "[3]" ?  "centimeter" :
                                prop.Value;
                            Console.WriteLine($"\t{prop.Key}={msg}");
                            break;
                        default:
                            Console.WriteLine($"\t{prop.Key}={prop.Value}");
                            break;
                    }
                }

                Console.WriteLine("Press Key for next");
                Console.Read();
            }
        }

    }
}
