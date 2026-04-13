using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPart1
{
    internal class InputHandler
    {
        public static void ProcessInput(string input, string name)
        {
            input = input.ToLower();

            if (input.Contains("how are you"))
            {
                BotResponses.HowAreYou(name);
            }

            else if (input.Contains("purpose"))
            {
                BotResponses.Purpose(name);
            }

            else if (input.Contains("ask") || input.Contains("help"))
            {
                BotResponses.AskTopics(name);
            }

            else if (input.Contains("phishing"))
            {
                BotResponses.Phishing(name);
            }

            else if (input.Contains("password"))
            {
                BotResponses.PasswordSafety(name);
            }

            else if (input.Contains("browsing") || input.Contains("safe"))
            {
                BotResponses.SafeBrowsing(name);
            }

            else if (input.Contains("hi") || input.Contains("hello"))
            {
                BotResponses.GreetUser(name);
            }

            else
            {
                BotResponses.Unknown(name);
            }
        }
    }
}
