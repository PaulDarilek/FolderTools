namespace ImageFiler
{
    /// <summary>The Exchangeable Image File (EXIF) format is a Japan Electronic Industry Development Association (JEIDA) standard, revised June 1998 as version 2.1.</summary>
    /// <see cref="https://docs.microsoft.com/en-gb/windows/win32/gdiplus/-gdiplus-constant-property-item-descriptions"/>
    public enum PropertyTag
    {
        /// <summary>
        /// Version of the Global Positioning Systems (GPS) IFD, given as 2.0.0.0. 
        /// This tag is mandatory when the <see cref="GpsIFD"/> tag is present. 
        /// When the version is 2.0.0.0, the tag value is 0x02000000</summary>
        [ImageTag(PropertyTagType.Byte, 4, "Version of GPS IFD")]
        GpsVer = 0x0000,

        /// <summary>Null-terminated character string that specifies whether the latitude is north or south. N specifies north latitude, and S specifies south latitude.</summary>
        [ImageTag(PropertyTagType.ASCII, 2, "Null-terminated character string that specifies whether the latitude is north or south. N specifies north latitude, and S specifies south latitude.")]
        GpsLatitudeRef = 0x0001,

        /// <summary>
        /// Latitude. 
        /// Latitude is expressed as three rational values giving the degrees, minutes, and seconds respectively. 
        /// When degrees, minutes, and seconds are expressed, the format is dd/1, mm/1, ss/1. 
        /// When degrees and minutes are used and, for example, fractions of minutes are given up to two decimal places, the format is dd/1, mmmm/100, 0/1.
        /// </summary>
        [ImageTag(PropertyTagType.Rational, 3, "Latitude is expressed as three rational values giving the degrees, minutes, and seconds")]
        GpsLatitude = 0x0002,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsLongitudeRef = 0x0003,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsLongitude = 0x0004,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsAltitudeRef = 0x0005,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsAltitude = 0x0006,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsGpsTime = 0x0007,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsGpsSatellites = 0x0008,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsGpsStatus = 0x0009,

        [ImageTag(PropertyTagType.Undefined, 0, "")]
        GpsGpsMeasureMode = 0x000A,
        GpsGpsDop = 0x000B,
        GpsSpeedRef = 0x000C,
        GpsSpeed = 0x000D,
        GpsTrackRef = 0x000E,
        GpsTrack = 0x000F,
        GpsImgDirRef = 0x0010,
        GpsImgDir = 0x0011,
        GpsMapDatum = 0x0012,
        GpsDestLatRef = 0x0013,
        GpsDestLat = 0x0014,
        GpsDestLongRef = 0x0015,
        GpsDestLong = 0x0016,
        GpsDestBearRef = 0x0017,
        GpsDestBear = 0x0018,
        GpsDestDistRef = 0x0019,
        GpsDestDist = 0x001A,
        NewSubfileType = 0x00FE,
        SubfileType = 0x00FF,
        ImageWidth = 0x0100,
        ImageHeight = 0x0101,
        BitsPerSample = 0x0102,
        Compression = 0x0103,
        PhotometricInterp = 0x0106,
        ThreshHolding = 0x0107,
        CellWidth = 0x0108,
        CellHeight = 0x0109,
        FillOrder = 0x010A,
        DocumentName = 0x010D,
        ImageDescription = 0x010E,
        EquipMake = 0x010F,
        EquipModel = 0x0110,
        StripOffsets = 0x0111,
        
        /// <summary>
        /// 1 - The 0th row is at the top of the visual image, and the 0th column is the visual left side. 
        /// 2 - The 0th row is at the visual top of the image, and the 0th column is the visual right side. 
        /// 3 - The 0th row is at the visual bottom of the image, and the 0th column is the visual right side. 
        /// 4 - The 0th row is at the visual bottom of the image, and the 0th column is the visual left side. 
        /// 5 - The 0th row is the visual left side of the image, and the 0th column is the visual top. 
        /// 6 - The 0th row is the visual right side of the image, and the 0th column is the visual top. 
        /// 7 - The 0th row is the visual right side of the image, and the 0th column is the visual bottom. 
        /// 8 - The 0th row is the visual left side of the image, and the 0th column is the visual bottom.
        /// </summary>
        [ImageTag(PropertyTagType.Short,1,"Orientation. 1=Top,Left")]
        Orientation = 0x0112,
        
        SamplesPerPixel = 0x0115,
        RowsPerStrip = 0x0116,
        StripBytesCount = 0x0117,
        MinSampleValue = 0x0118,
        MaxSampleValue = 0x0119,
        XResolution = 0x011A,
        YResolution = 0x011B,
        PlanarConfig = 0x011C,
        PageName = 0x011D,
        XPosition = 0x011E,
        YPosition = 0x011F,
        FreeOffset = 0x0120,
        FreeByteCounts = 0x0121,
        GrayResponseUnit = 0x0122,
        GrayResponseCurve = 0x0123,
        T4Option = 0x0124,
        T6Option = 0x0125,
        ResolutionUnit = 0x0128,
        PageNumber = 0x0129,
        TransferFunction = 0x012D,
        SoftwareUsed = 0x0131,

        /// <summary>Date and time the image was created</summary>
        DateTime = 0x0132,
        
        Artist = 0x013B,
        HostComputer = 0x013C,
        Predictor = 0x013D,
        WhitePoint = 0x013E,
        PrimaryChromaticities = 0x013F,
        ColorMap = 0x0140,
        HalftoneHints = 0x0141,
        TileWidth = 0x0142,
        TileLength = 0x0143,
        TileOffset = 0x0144,
        TileByteCounts = 0x0145,
        InkSet = 0x014C,
        InkNames = 0x014D,
        NumberOfInks = 0x014E,
        DotRange = 0x0150,
        TargetPrinter = 0x0151,
        ExtraSamples = 0x0152,
        SampleFormat = 0x0153,
        SMinSampleValue = 0x0154,
        SMaxSampleValue = 0x0155,
        TransferRange = 0x0156,
        JPEGProc = 0x0200,
        JPEGInterFormat = 0x0201,
        JPEGInterLength = 0x0202,
        JPEGRestartInterval = 0x0203,
        JPEGLosslessPredictors = 0x0205,
        JPEGPointTransforms = 0x0206,
        JPEGQTables = 0x0207,
        JPEGDCTables = 0x0208,
        JPEGACTables = 0x0209,
        YCbCrCoefficients = 0x0211,
        YCbCrSubsampling = 0x0212,
        YCbCrPositioning = 0x0213,
        REFBlackWhite = 0x0214,
        Gamma = 0x0301,
        ICCProfileDescriptor = 0x0302,
        SRGBRenderingIntent = 0x0303,
        ImageTitle = 0x0320,
        ResolutionXUnit = 0x5001,
        ResolutionYUnit = 0x5002,
        ResolutionXLengthUnit = 0x5003,
        ResolutionYLengthUnit = 0x5004,
        PrintFlags = 0x5005,
        PrintFlagsVersion = 0x5006,
        PrintFlagsCrop = 0x5007,
        PrintFlagsBleedWidth = 0x5008,
        PrintFlagsBleedWidthScale = 0x5009,
        HalftoneLPI = 0x500A,
        HalftoneLPIUnit = 0x500B,
        HalftoneDegree = 0x500C,
        HalftoneShape = 0x500D,
        HalftoneMisc = 0x500E,
        HalftoneScreen = 0x500F,
        JPEGQuality = 0x5010,
        GridSize = 0x5011,
        ThumbnailFormat = 0x5012,
        ThumbnailWidth = 0x5013,
        ThumbnailHeight = 0x5014,
        ThumbnailColorDepth = 0x5015,
        ThumbnailPlanes = 0x5016,
        ThumbnailRawBytes = 0x5017,
        ThumbnailSize = 0x5018,
        ThumbnailCompressedSize = 0x5019,
        ColorTransferFunction = 0x501A,
        ThumbnailData = 0x501B,
        ThumbnailImageWidth = 0x5020,
        ThumbnailImageHeight = 0x5021,
        ThumbnailBitsPerSample = 0x5022,
        ThumbnailCompression = 0x5023,
        ThumbnailPhotometricInterp = 0x5024,
        ThumbnailImageDescription = 0x5025,
        ThumbnailEquipMake = 0x5026,
        ThumbnailEquipModel = 0x5027,
        ThumbnailStripOffsets = 0x5028,
        ThumbnailOrientation = 0x5029,
        ThumbnailSamplesPerPixel = 0x502A,
        ThumbnailRowsPerStrip = 0x502B,
        ThumbnailStripBytesCount = 0x502C,
        ThumbnailResolutionX = 0x502D,
        ThumbnailResolutionY = 0x502E,
        ThumbnailPlanarConfig = 0x502F,
        ThumbnailResolutionUnit = 0x5030,
        ThumbnailTransferFunction = 0x5031,
        ThumbnailSoftwareUsed = 0x5032,
        ThumbnailDateTime = 0x5033,
        ThumbnailArtist = 0x5034,
        ThumbnailWhitePoint = 0x5035,
        ThumbnailPrimaryChromaticities = 0x5036,
        ThumbnailYCbCrCoefficients = 0x5037,
        ThumbnailYCbCrSubsampling = 0x5038,
        ThumbnailYCbCrPositioning = 0x5039,
        ThumbnailRefBlackWhite = 0x503A,
        ThumbnailCopyRight = 0x503B,
        LuminanceTable = 0x5090,
        ChrominanceTable = 0x5091,
        FrameDelay = 0x5100,
        LoopCount = 0x5101,
        GlobalPalette = 0x5102,
        IndexBackground = 0x5103,
        IndexTransparent = 0x5104,
        PixelUnit = 0x5110,
        PixelPerUnitX = 0x5111,
        PixelPerUnitY = 0x5112,
        PaletteHistogram = 0x5113,
        Copyright = 0x8298,
        ExifExposureTime = 0x829A,

        /// <summary>F number</summary>
        [ImageTag(PropertyTagType.Rational, 1, "F Number (F-Stop?)")]
        ExifFNumber = 0x829D,

        ExifIFD = 0x8769,
        ICCProfile = 0x8773,
        ExifExposureProg = 0x8822,
        ExifSpectralSense = 0x8824,
        
        GpsIFD = 0x8825,

        /// <summary>ISO speed and ISO latitude of the camera or input device as specified in ISO 12232.</summary>
        [ImageTag(PropertyTagType.Short, -1, "ISO speed and ISO latitude of the camera or input device as specified in ISO 12232")]
        ExifISOSpeed = 0x8827,
        
        ExifOECF = 0x8828,
        ExifVer = 0x9000,

        /// <summary>
        /// Date and time when the original image data was generated. 
        /// For a DSC, the date and time when the picture was taken. 
        /// The format is YYYY:MM:DD HH:MM:SS with time shown in 24-hour format and the date and time separated by one blank character (0x2000). 
        /// The character string length is 20 bytes including the NULL terminator. 
        /// When the field is empty, it is treated as unknown
        /// </summary>
        [ImageTag(PropertyTagType.ASCII, 20, "Date and time when the original image data was generated/taken")]
        ExifDTOrig = 0x9003,

        /// <summary>
        /// Date and time when the image was stored as digital data. 
        /// If, for example, an image was captured by DSC and at the same time the file was recorded, then DateTimeOriginal and DateTimeDigitized will have the same contents.
        /// The format is YYYY:MM:DD HH:MM:SS with time shown in 24-hour format and the date and time separated by one blank character (0x2000). 
        /// The character string length is 20 bytes including the NULL terminator. 
        /// When the field is empty, it is treated as unknown.
        /// </summary>
        [ImageTag(PropertyTagType.ASCII, 20, "Date and time when the image was stored as digital data.")]
        ExifDTDigitized = 0x9004,

        [ImageTag(PropertyTagType.Undefined, 4, "Information specific to compressed data.")]
        ExifCompConfig = 0x9101,
        
        [ImageTag(PropertyTagType.Rational, 1, "Information specific to compressed data.")]
        ExifCompBPP = 0x9102,

        [ImageTag(PropertyTagType.SRational, 1, "Shutter speed. The unit is the Additive System of Photographic Exposure (APEX) value.")]
        ExifShutterSpeed = 0x9201,

        [ImageTag(PropertyTagType.SRational, 1, "Lens aperture. The unit is the APEX value.")]
        ExifAperture = 0x9202,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifBrightness = 0x9203,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifExposureBias = 0x9204,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifMaxAperture = 0x9205,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifSubjectDist = 0x9206,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifMeteringMode = 0x9207,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifLightSource = 0x9208,

        /// <summary>Flash status. This tag is recorded when an image is taken using a strobe light (flash). Bit 0 indicates the flash firing status, and bits 1 and 2 indicate the flash return status.</summary>
        [ImageTag(PropertyTagType.Short, 1, "0x0000 - flash did not fire 0x0001 - flash fired 0x0005 - strobe return light not detected")]
        ExifFlash = 0x9209,

        /// <summary>Actual focal length, in millimeters, of the lens. Conversion is not made to the focal length of a 35 millimeter film camera.</summary>
        [ImageTag(PropertyTagType.Rational, 1, "Actual focal length, in millimeters, of the lens. Conversion is not made to the focal length of a 35 millimeter film camera.")]
        ExifFocalLength = 0x920A,

        /// <summary>Note tag. A tag used by manufacturers of EXIF writers to record information. The contents are up to the manufacturer.</summary>
        [ImageTag(PropertyTagType.Undefined, 0, "Note tag. A tag used by manufacturers of EXIF writers to record information. The contents are up to the manufacturer.")]
        ExifMakerNote = 0x927C,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifUserComment = 0x9286,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifDTSubsec = 0x9290,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifDTOrigSS = 0x9291,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifDTDigSS = 0x9292,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifFPXVer = 0xA000,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifColorSpace = 0xA001,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifPixXDim = 0xA002,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifPixYDim = 0xA003,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifRelatedWav = 0xA004,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifInterop = 0xA005,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifFlashEnergy = 0xA20B,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifSpatialFR = 0xA20C,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifFocalXRes = 0xA20E,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifFocalYRes = 0xA20F,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifFocalResUnit = 0xA210,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifSubjectLoc = 0xA214,

        [ImageTag(PropertyTagType.Undefined, -1, "")]
        ExifExposureIndex = 0xA215,

        /// <summary>Image sensor type on the camera or input device</summary>
        /// <remarks>
        /// 1 - not defined 
        /// 2 - one-chip color area sensor 
        /// 3 - two-chip color area sensor 
        /// 4 - three-chip color area sensor 
        /// 5 - color sequential area sensor 
        /// 7 - trilinear sensor 
        /// 8 - color sequential linear sensor 
        /// Other - reserve
        /// </remarks>
        [ImageTag(PropertyTagType.Short, 1, "Image sensor type on the camera or input device.")]
        ExifSensingMethod = 0xA217,

        [ImageTag(PropertyTagType.Undefined, 1, "The image source. If a DSC recorded the image, the value of this tag is 3.")]
        ExifFileSource = 0xA300,

        [ImageTag(PropertyTagType.Undefined, 1, "The type of scene. If a DSC recorded the image, the value of this tag must be set to 1, indicating that the image was directly photographed.")]
        ExifSceneType = 0xA301,

        [ImageTag(PropertyTagType.Undefined, 0, "The color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods.")]
        ExifCfaPattern = 0xA302,
    }
}
