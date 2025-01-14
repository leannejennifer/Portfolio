using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portfolio.Enums;

namespace Portfolio.Helpers
{
    public static class ColorHelper
    {
        public static Colors GetColorFromEnum(int index)
        {
            var lengthEnum = typeof(Colors).GetEnumValues().Length;

            if (lengthEnum -1 < index)
                throw new IndexOutOfRangeException();
            
            return (Colors)index;
        }
    }
}
