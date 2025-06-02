namespace Portfolio.Helpers
{
    using Portfolio.Enums;

    public static class ColorHelper
    {
        private static int? currentColorIndex;

        public static Colors GetColorFromEnum(int index)
        {
            var lengthEnum = typeof(Colors).GetEnumValues().Length;

            if (lengthEnum - 1 < index)
            {
                throw new IndexOutOfRangeException();
            }

            return (Colors)index;
        }

        public static Colors GetRandomColor()
        {
            var lengthEnum = typeof(Colors).GetEnumValues().Length;

            var index = NumberHelper.GetRandomNumber(lengthEnum, currentColorIndex);
            currentColorIndex = index;

            return (Colors)index;
        }
    }
}
