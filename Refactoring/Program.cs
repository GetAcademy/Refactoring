/*
 * 1: Innfør variabel
 * 2: Innføre metode (eller lage bedre og mer generelle metoder)
 * 3: Innføre klasse
 *
 * top down vs bottom up
 * 
 */

using Refactoring;

var questions = new Question[]
{
    new Question("Hva er 2+2?", "c", "2", "3", "4", "5"),
    new Question("Hvilken by er norsk?", "a", "Oslo", "Ohio"),
    new Question("Hvilken farge er ikke i den norske flagget?", "b", "Rød", "Grønn", "Blå")
};
var points = 0;
foreach (var question in questions)
{
    points += question.Ask();
}
Console.WriteLine($"Du fikk {points} riktige.");
             





/*
var points = Ask("Hva er 2+2?", "c", "2", "3", "4", "5")
+ Ask("Hvilken by er norsk?", "a", "Oslo", "Ohio")
+ Ask("Hvilken farge er ikke i den norske flagget?", "b", "Rød", "Grønn", "Blå");
Console.WriteLine($"Du fikk {points} riktige.");

int CheckAnswer(string correctAnswer)
{
    Console.Write("Skriv inn a, b eller c: ");
    var answer = Console.ReadLine();
    var isCorrect = answer == correctAnswer;
    var text = isCorrect ? "Riktig!" : "Feil";
    Console.WriteLine(text);
    var points = isCorrect ? 1 : 0;
    return points;
}

int Ask(string questionText, string correctAnswer, params string[] options)
{
    Console.WriteLine(questionText);
    for (var index = 0; index < options.Length; index++)
    {
        var letter = (char) ('A' + index);
        var option = options[index];
        Console.WriteLine($" {letter}: {option}");
    }
    return CheckAnswer(correctAnswer);
}
*/