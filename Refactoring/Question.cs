namespace Refactoring
{
    internal class Question
    {
        private string _questionText;
        private string _correctAnswer;
        private string[] _options;

        public Question(string questionText, 
            string correctAnswer, 
            params string[] options)
        {
            _questionText = questionText;
            _correctAnswer = correctAnswer;
            _options = options;
        }

        public int Ask()
        {
            Console.WriteLine(_questionText);
            for (var index = 0; index < _options.Length; index++)
            {
                var letter = (char)('A' + index);
                var option = _options[index];
                Console.WriteLine($" {letter}: {option}");
            }
            return CheckAnswer(_correctAnswer);
        }

        private static int CheckAnswer(string correctAnswer)
        {
            Console.Write("Skriv inn a, b eller c: ");
            var answer = Console.ReadLine();
            var isCorrect = answer == correctAnswer;
            var text = isCorrect ? "Riktig!" : "Feil";
            Console.WriteLine(text);
            var points = isCorrect ? 1 : 0;
            return points;
        }
    }
}
