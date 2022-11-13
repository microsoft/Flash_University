[Flags]
public enum splitSchema : byte
{
    // Bit layout is as follows:
    // [c1]   [c2]   [c3]
    //  7 6   5 4 3   2 1 0
    c3Mask = 0x7, //7        // 00000111
    c2Mask = 0x38, //8+3*16 = 56 // 00111000
    c1Mask = 0xC0, //  11000000

    c3zero = 0,
    //0     00000000

    c3one = 1,
    //1     00000001


    c3two = 2, //2     00000010


    c3three = 3, //3     00000011


    c3four = 4, //4     00000100

    // Schema values
    //factors of 8
    c2zero = 0x00, //0     00000000
    c2one = 0x10, //16     00001000
    c2two = 0x20, // 32    00010000
    c2three = 0x8, //8     00001000
    c2four = 0x18, //24    00011000

    c1zero = 0x00, //0 00000000
    c1one = 0x40, //64 2^6 so 01000000

    Unknown = 0xFF //255
}