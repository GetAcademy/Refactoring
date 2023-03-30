namespace Refactoring
{
    internal class WhatDemo
    {
        public static void Run()
        {
            var textCounter = new TextCounter();
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                textCounter.CountChars(text);
            }
            textCounter.ShowCounts();
        }
    }
}
