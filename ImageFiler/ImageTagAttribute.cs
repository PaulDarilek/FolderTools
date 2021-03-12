using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageFiler
{
    [AttributeUsage(AttributeTargets.Field)]
    class ImageTagAttribute : Attribute
    {
        public PropertyTagType Type { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

        public ImageTagAttribute(PropertyTagType type, int count, string description)
        {
            Type = type;
            Count = count;
            Description = description;
        }
    }
}
