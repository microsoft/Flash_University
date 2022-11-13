using System.Runtime.CompilerServices;
using System.Security.AccessControl;

//BitArray2 ba = new BitArray2(14);

//for (int i = 0; i < 14; i++)
//{
//    ba[i] = (i % 2 == 0);
//}

//for (int i = 0; i < 14; i++)
//{
//   Console.WriteLine("Bit "+ i + " is " + (ba[i]?"on": "off"));
//}

Int32 value = 1;

Console.WriteLine((value + 1 / 7).GetType());
Console.WriteLine(1 << 0);
uint x = 0b_1001;
uint y = x >> 2;
Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2).PadLeft(4, '0'),4}");

int i = 0;
while (i < 8)
{
    Console.WriteLine(1 <<i);
    i++;
}

public sealed class BitArray2
{
    private byte[] _byteArray;
    private Int32 _numBits;

    public BitArray2(Int32 numBits)
    {
        if (numBits <= 0)
        {
            throw new ArgumentOutOfRangeException("numBits must be > 0");

        }

        _numBits = numBits;
        // 8 bits in a byte, by adding 7 bits, we can always make sure we superset the number of bytes we need
        // should resolve to a int
        _byteArray = new Byte[(numBits + 7) / 8];
    }

    public Boolean this[Int32 bitPosition]
    {
        get
        {
            if ((bitPosition < 0))
            {
                throw new ArgumentOutOfRangeException("bitPosition");
            }
            // << = left shift
            return (_byteArray[bitPosition / 8] & (1 << (bitPosition % 8))) != 0;
            //so lets just say we have 00000001  and we want position 0. So 0%8  = 0, bit shift 00000000 is still 00000000
            //now lets say we want position 1. 1 is  00000001 in bits. left shift is going to give us 00000010 which is 2 mode 8  ==2
            //so return 
            //So this looks like a way to simplifify truth table. If the bit array at the position minus the 'offset' is true, then we return true false based off of 2nd part. 2nd part is only at 0 when 

            //      T   F
            // T    T   F
            // F    F   F


        }
        set
        {
            if ((bitPosition < 0) || bitPosition >= _numBits)
            {
                throw new ArgumentOutOfRangeException("bitPosition", bitPosition.ToString());
            }

            if (value)
            {
                _byteArray[bitPosition / 8] = (Byte)(_byteArray[bitPosition / 8] | (1 << (bitPosition % 8)));
            }
            else
            {
                _byteArray[bitPosition / 8] = (Byte)(_byteArray[bitPosition / 8] &~ (1 << (bitPosition % 8)));
            }
        }
    }
}

public sealed class BitArray3
{
    [IndexerName("Bit")]
    public Boolean this[Int32 bitPos]
    {
        get
        {
            return true;


        }
    }
}