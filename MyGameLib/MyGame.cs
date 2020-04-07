using System;

namespace MyGameLib
{
    // Service Logic
    public class MyGame : IMyGame
    {
        public string GetAnswer(string question)
        {
            string[] answer = { "Yes", "No", "Maybe yes", "Maybe no", "I'm busy. Try again later" };
            Random rand = new Random();
            return answer[rand.Next(answer.Length)];
        }
    }
}