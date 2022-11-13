using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringBuilderExtensions
    {
        //public static Int32 IndexOf(StringBuilder sb, Char Value)
        //{
        //    for (int i = 0; i < sb.Length; i++)
        //        if (sb[i] == Value) return i;
        //    return -1;
        //}

        public static Int32 IndexOf(this StringBuilder sb, Char Value)
        {
            for (int i = 0; i < sb.Length; i++)
                if (sb[i] == Value) return i;
            return -1;
        }
    }
}
