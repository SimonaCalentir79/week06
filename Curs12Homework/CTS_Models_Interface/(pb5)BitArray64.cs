using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTS_Models_Interface
{
    public class BitArray64:IEnumerable <int>
    {
        private int[] bits;

        public ulong Value { get; private set; }
        private int[] BitsOfValue { get; }

        public BitArray64(ulong value)
        {
            this.Value = value;

            bits = new int[64];
            int i = 0;
            while (i < 64)
            {
                bits[i] = (int)value % 2;
                value /= 2;
                i++;
            }

            this.BitsOfValue = bits;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                    throw new IndexOutOfRangeException();
                int[] bitsArr = this.BitsOfValue;
                return bitsArr[index];
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] arrBits = this.BitsOfValue;
            for (int i = 63; i >= 0; i--)
            {
                yield return arrBits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is BitArray64))
                return false;

            BitArray64 bitArray64 = obj as BitArray64;
            if (bitArray64 == null)
                return false;
            if (!Object.Equals(this.Value, bitArray64.Value))//reference type
                return false;
            if (this.Value != bitArray64.Value)//value type
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        public static bool operator == (BitArray64 val1, BitArray64 val2)
        {
            return BitArray64.Equals(val1,val2);
        }

        public static bool operator != (BitArray64 val1, BitArray64 val2)
        {
            return !BitArray64.Equals(val1, val2);
        }
    }
}
