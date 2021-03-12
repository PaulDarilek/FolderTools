using System;

namespace ImageFiler
{
    /// <summary></summary>
    /// <remarks>From https://docs.microsoft.com/en-us/windows/win32/gdiplus/-gdiplus-constant-image-property-tag-type-constants</remarks>
    public enum PropertyTagType
    {
        /// <summary>Array of bytes</summary>
        Byte = 1,

        /// <summary>Null Terminated ASCII String.  Length includes null '\0' character.</summary>
        ASCII = 2,

        /// <summary>Array of unsigned 16 bit integers (<see cref="ushort"/>) integers.</summary>
        Short = 3,

        /// <summary>Array of unsigned 32 bit integers (<see cref="uint"/>) integers.</summary>
        Long = 4,

        /// <summary>Array of pairs of unsigned long integers. Each pair represents a fraction; the first integer is the numerator and the second integer is the denominator.</summary>
        Rational = 5,

        /// <summary>Array of bytes that can hold values of any data type.</summary>
        Undefined = 7,

        /// <summary>Array of signed 32 bit integers (<see cref="int"/>) integers.</summary>
        SLong = 9,

        /// <summary>Array of pairs of signed long integers. Each pair represents a fraction; the first integer is the numerator and the second integer is the denominator.</summary>
        SRational = 10,

        /// <summary>Specifies that the format is 4 bits per pixel, indexed.</summary>
        PixelFormat4bppIndexed = 197634,
    }
}
