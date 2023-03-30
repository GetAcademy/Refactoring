/*
 * 1: Innfør variabel
 * 2: Innføre metode (eller lage bedre og mer generelle metoder)
 * 3: Innføre klasse
 */

var points = 0;
Console.WriteLine("Hva er 2+2?");
Console.WriteLine(" A: 2");
Console.WriteLine(" B: 3");
Console.WriteLine(" C: 4");
points += CheckAnswer("c");

Console.WriteLine("Hvilken by er norsk?");
Console.WriteLine(" A: Oslo");
Console.WriteLine(" B: Ohio");
Console.WriteLine(" C: Omaha");
points += CheckAnswer("a");

Console.WriteLine("Hvilken farge er ikke i den norske flagget?");
Console.WriteLine(" A: Rød");
Console.WriteLine(" B: Grønn");
Console.WriteLine(" C: Blå");
points += CheckAnswer("b");

Console.WriteLine($"Du fikk {points} riktige.");

int CheckAnswer(string correctAnswer)
{
    Console.Write("Skriv inn a, b eller c: ");
    var answer = Console.ReadLine();
    var isCorrect = answer == correctAnswer;
    Console.WriteLine(isCorrect ? "Riktig!" : "Feil");
    return isCorrect ? 1 : 0;
}