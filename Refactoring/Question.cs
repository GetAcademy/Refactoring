namespace Refactoring
{
    internal class Question
    {
        public string QuestionText { get; set; }
        public string CorrectAnswer { get; set; }
        public string[] Options { get; set; }

        public Question()
        {
        }

        public Question(string questionText, 
            string correctAnswer, 
            params string[] options)
        {
            QuestionText = questionText;
            CorrectAnswer = correctAnswer;
            Options = options;
        }

        public int Ask()
        {
            Console.WriteLine(QuestionText);
            for (var index = 0; index < Options.Length; index++)
            {
                var letter = (char)('A' + index);
                var option = Options[index];
                Console.WriteLine($" {letter}: {option}");
            }
            return CheckAnswer(CorrectAnswer);
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
