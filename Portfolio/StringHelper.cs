using System.Text;

namespace Portfolio
{
    public static class StringHelper
    {
        //could use linq to improve this
        public static string PigLatin(string input)
        {
            var inputWords = input.Split(" ");
            var outputWords = new string[inputWords.Length];

            for (var i = 0; i < inputWords.Length; i++)
            {
                var word = inputWords[i];
                var firstLetter = word[0];
                var restOfWord = word.Substring(1);
                outputWords[i] = restOfWord + firstLetter + (char.IsPunctuation(firstLetter) ? "" : "ay" );
            }

            return string.Join(' ', outputWords);

        }

        public static string ReverseString(string inputString)
        {
            var lowercaseInput = inputString.ToLower();

            // Use string builder as it is more efficient
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = lowercaseInput.Length-1; i>=0; i--)
            {
                stringBuilder.Append(lowercaseInput[i]);
            }

            return stringBuilder.ToString();
        }

        // array method is slower as the values are not unique
        private static readonly char[] _vowels = [ 'a', 'e', 'i', 'o', 'u' ];

        public static int CalculateVowelCount(string inputString)
        {
            var vowelCount = 0;

            var lowercaseInput = inputString;
            for (int i = 0; i < lowercaseInput.Length; i++)
            {
                if (_vowels.Contains(lowercaseInput[i])){
                    vowelCount++;
                }

            }

            return vowelCount;
        }

        public static int CalculateVowelCountLinq(string inputString)
        {
            return inputString.ToLowerInvariant().Count(c => _vowels.Contains(c));
        }

        // faster lookup times because hashset is a set of unique values
        private static readonly HashSet<char> _hashVowels = ['a', 'e', 'i', 'o', 'u'];

        public static int CalculateVowelCountHash(string inputString)
        {
            var vowelCount = 0;

            var lowercaseInput = inputString;
            for (int i = 0; i < lowercaseInput.Length; i++)
            {
                if (_hashVowels.Contains(lowercaseInput[i]))
                {
                    vowelCount++;
                }

            }

            return vowelCount;
        }

    }
}
