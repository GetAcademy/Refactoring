namespace Refactoring
{
    internal class TextCounter
    {
        private int _range;
        private int[] _counts;

        public TextCounter()
        {
            _range = 250;
            _counts = new int[_range];
        }

        public void ShowCounts()
        {
            for (var i = 0; i < _range; i++)
            {
                if (_counts[i] > 0)
                {
                    var character = (char)i;
                    Console.WriteLine(character + " - " + _counts[i]);
                }
            }
        }

        public void CountChars(string? text)
        {
            foreach (var character in text ?? string.Empty)
            {
                _counts[(int)character]++;
            }
        }
    }
}
