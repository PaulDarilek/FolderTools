using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Linq;

namespace ImageFiler
{
    public class ImageMetaData
    {
        public string FileName { get; }

        public string ImageType { get; }
        public int Width { get; }
        public int Height { get; }
        public float Resolution { get; }
        public int BitsPerPixel { get; }
        public Dictionary<PropertyTag, string> Tags { get; }

        public ImageMetaData(string fileName) 
        {
            FileName = fileName;
           
            var img = Bitmap.FromFile(fileName);
            ImageType = GetImageType(img);
            Tags = GetProperties(img);
            Width = img.Width;
            Height = img.Height;
            Resolution = img.HorizontalResolution;
            BitsPerPixel = Image.GetPixelFormatSize(img.PixelFormat);
        }

        public static string GetImageType(Image img)
        {

            if (ImageFormat.Jpeg.Equals(img.RawFormat)) return "JPEG Image";
            if (ImageFormat.Gif.Equals(img.RawFormat)) return "GIF Image";
            if (ImageFormat.Tiff.Equals(img.RawFormat)) return "TIFF Image";
            if (ImageFormat.Png.Equals(img.RawFormat)) return "PNG Image";
            return null;
        }

        public static Dictionary<PropertyTag, string> GetProperties(Image img)
        {
            var dict = new Dictionary<PropertyTag, string>();
            var encod = new ASCIIEncoding();
            var parsed = new List<string>();

            // For each PropertyItem in the array, display the id, type, and length.
            for (int count = 0; count < img.PropertyItems.Length; count++)
            {
                var propItem = img.PropertyItems[count];
                PropertyTag tag = (PropertyTag)propItem.Id;
                PropertyTagType type = (PropertyTagType)propItem.Type;
                string value;

                switch (type)
                {
                    case PropertyTagType.Byte:
                        value = $"{type}[{propItem.Len}]";
                        break;

                    case PropertyTagType.ASCII:
                        value = encod.GetString(propItem.Value);
                        if (value.Length > 0 && value[value.Length - 1] == '\0')
                        {
                            value = value.Substring(0, value.Length - 1);
                        }
                        break;
                   
                    case PropertyTagType.Short:
                        for (int i = 0; i < propItem.Value.Length; i += sizeof(ushort))
                        {
                            parsed.Add(ToUInt16(propItem.Value, i).ToString());
                        }
                        value = $"[{string.Join(",", parsed)}]";
                        parsed.Clear();
                        break;

                    case PropertyTagType.Long:
                        for (int i = 0; i < propItem.Value.Length; i+=sizeof(uint))
                        {
                            parsed.Add(ToUInt32(propItem.Value, i).ToString());
                        }
                        value = $"[{string.Join(",", parsed)}]";
                        parsed.Clear();
                        break;

                    case PropertyTagType.Rational:
                        for (int i = 0; i < propItem.Value.Length; i += sizeof(uint) * 2)
                        {
                            var numerator = ToUInt32(propItem.Value, i).ToString();
                            var denominator = ToUInt32(propItem.Value, i + sizeof(uint)).ToString();
                            parsed.Add($"{numerator}/{denominator}");
                        }
                        value = $"[{string.Join(",", parsed)}]";
                        parsed.Clear();
                        break;

                    case PropertyTagType.Undefined:
                        value = $"{type}[{propItem.Len}]";
                        break;

                    case PropertyTagType.SLong:
                        for (int i = 0; i < propItem.Value.Length; i += sizeof(int))
                        {
                            parsed.Add(ToInt32(propItem.Value, i).ToString());
                        }
                        value = $"[{string.Join(",", parsed)}]";
                        parsed.Clear();
                        break;

                    case PropertyTagType.SRational:
                        for (int i = 0; i < propItem.Value.Length; i += sizeof(int) * 2)
                        {
                            var numerator = ToInt32(propItem.Value, i).ToString();
                            var denominator = ToInt32(propItem.Value, i + sizeof(int)).ToString();
                            parsed.Add($"{numerator}/{denominator}");
                        }
                        value = $"[{string.Join(",", parsed)}]";
                        parsed.Clear();
                        break;

                    case PropertyTagType.PixelFormat4bppIndexed:
                        value = $"{type}[{propItem.Len}]";
                        break;

                    default:
                        value = $"{type}[{propItem.Len}]";
                        break;
                }


                dict.Add(tag, value);
            }
            return dict;
        }

        /// <summary>Convert bytes to <see cref="UInt16"/></summary>
        private static ushort ToUInt16(byte[] array, int offset)
            // => BitConverter.IsLittleEndian ?
            // BitConverter.ToUInt16(array.Skip(offset).Take(sizeof(ushort)).Reverse().ToArray(), 0) :
            => BitConverter.ToUInt16(array, offset);

        private static uint ToUInt32(byte[] array, int offset)
            // => BitConverter.IsLittleEndian ?
            // BitConverter.ToUInt32(array.Skip(offset).Take(sizeof(uint)).Reverse().ToArray(), 0) :
            => BitConverter.ToUInt32(array, offset);

        private static int ToInt32(byte[] array, int offset)
            // => BitConverter.IsLittleEndian ?
            // BitConverter.ToInt32(array.Skip(offset).Take(sizeof(int)).Reverse().ToArray(), 0) :
            => BitConverter.ToInt32(array, offset);
    }
}
