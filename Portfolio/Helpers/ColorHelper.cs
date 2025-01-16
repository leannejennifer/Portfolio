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
        private static int? _currentColorIndex;
        public static Colors GetColorFromEnum(int index)
        {
            var lengthEnum = typeof(Colors).GetEnumValues().Length;

            if (lengthEnum -1 < index)
                throw new IndexOutOfRangeException();
            
            return (Colors)index;
        }
        
        public static Colors GetRandomColor()
        {
            var lengthEnum = typeof(Colors).GetEnumValues().Length;

            var index = NumberHelper.GetRandomNumber(lengthEnum,_currentColorIndex);
            _currentColorIndex = index;

            return (Colors)index;
            
        }
    }
}
