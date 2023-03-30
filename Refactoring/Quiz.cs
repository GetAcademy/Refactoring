using System.Text.Json;

namespace Refactoring
{
    internal class Quiz
    {
        public Question[] Questions { get; }

        public Quiz(string filename)
        {
            var json = File.ReadAllText(filename);
            Questions = JsonSerializer.Deserialize<Question[]>(json);
        }

        public Quiz(params Question[] questions)
        {
            Questions = questions;
        }

        //public Quiz()
        //{
        //    _questions = new Question[]
        //    {
        //        new Question("Hva er 2+2?", "c", "2", "3", "4", "5"),
        //        new Question("Hvilken by er norsk?", "a", "Oslo", "Ohio"),
        //        new Question("Hvilken farge er ikke i den norske flagget?", "b", "Rød", "Grønn", "Blå")
        //    };
        //}

        public static Quiz MakeQuiz1()
        {
            return new Quiz(
                new("Hva er 2+2?", "c", "2", "3", "4", "5"), 
                new("Hvilken by er norsk?", "a", "Oslo", "Ohio"), 
                new("Hvilken farge er ikke i den norske flagget?", "b", "Rød", "Grønn", "Blå"));
        }

        public void Run()
        {
            var points = 0;
            foreach (var question in Questions)
            {
                points += question.Ask();
            }
            Console.WriteLine($"Du fikk {points} riktige.");
        }

        public void Save()
        {
            var json = JsonSerializer.Serialize(Questions);
            File.WriteAllText("questions.json", json);
        }
    }
}
