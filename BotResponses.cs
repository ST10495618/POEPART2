using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace POEPart1
{
    internal class BotResponses
    {
         public static void Divider(char symbol = '-', int length = 50)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(new string(symbol, length));
            Console.ResetColor();
        }
        //
        static void Header(string title)
        {
            Divider();
            Console.ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"{title.ToUpper()}");
            Console.ResetColor();
            Divider();
            
        }
        public static void GreetUser(string name)
        {
            Divider();
            Console.ForegroundColor = ConsoleColor.Blue;
            UIHelper.TypeText($"\nHi {name}!  Ask me anything about cybersecurity.");
            UIHelper.TypeText("Type 'exit' anytime to quit.\n");
            Console.ResetColor();
            Divider();
        }

        public static void HowAreYou(string name)
        {
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            UIHelper.TypeText($"Hi {name}, I’m doing great—thanks for asking!  I’m always ready to help you stay safe online.");
            Console.ResetColor();
            Divider();
        }

        public static void Purpose(string name)
        {
            Divider();
            Header("    PURPOSE ");
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            UIHelper.TypeText($"Hi {name}, my purpose is to help you stay safe online by guiding you on cyber threats and best practices.");
            Console.ResetColor();
            Divider();
        }

        public static void AskTopics(string name)
        {
            Divider();
            Header("    WHAT YOU CAN ASK ABOUT ");
            Divider();
            Console.WriteLine($"Hi {name}, you can ask me about:\n");
            Console.WriteLine("• Phishing emails and scams");
            Console.WriteLine("• Password safety");
            Console.WriteLine("• Safe browsing");
            Console.WriteLine("• Data protection\n");

            Console.WriteLine("Example questions:");
            Console.WriteLine("• 'What is phishing?'");
            Console.WriteLine("• 'How do I create a strong password?'");
            Divider();
        }

        public static void Phishing(string name)
        {
            Divider();
            Header("    PHISHING ");
            Divider();
            Console.ForegroundColor = ConsoleColor.Yellow;

            UIHelper.TypeText($"\nHi {name}, let’s talk about phishing:\n");

            Console.ForegroundColor = ConsoleColor.Red;
            UIHelper.TypeText(" Phishing is when attackers trick you into giving sensitive information.\n");

            Console.ForegroundColor = ConsoleColor.White;
            UIHelper.TypeText("They often use fake emails, messages, or websites that look real.\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            UIHelper.TypeText("Be careful of:");
            UIHelper.TypeText("• Urgent messages asking you to act fast");
            UIHelper.TypeText("• Suspicious links or attachments");
            UIHelper.TypeText("• Poor spelling or strange email addresses\n");

            Console.ResetColor();
            Divider();
        }

        public static void PasswordSafety(string name)
        {
            Divider();
            Header("   PASSWORD SAFETY ");
            Divider();
            UIHelper.TypeText($"Hi {name}, use strong, unique passwords for each account.");
            UIHelper.TypeText("Include letters, numbers, and symbols, and enable MFA where possible.");
            Divider();
        }

        public static void SafeBrowsing(string name)
        {
            Divider();
            Header("    SAFE BROWSING ");
            Divider();
            Console.ForegroundColor = ConsoleColor.Blue;
            UIHelper.TypeText($"Hi {name}, always browse safely by using trusted websites.");
            UIHelper.TypeText("Look for 'https://' and avoid suspicious downloads or public Wi-Fi risks.");
            Console.ResetColor();
            Divider();
        }

        public static void Unknown(string name)
        {
            Divider();
            Header("    UNKNOWN INPUT ");
            Divider();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            UIHelper.TypeText($"Hi {name}, I didn’t quite understand that.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            UIHelper.TypeText("Try asking about:");
            UIHelper.TypeText("* Phishing");
            UIHelper.TypeText("* Password safety");
            UIHelper.TypeText("* Safe browsing\n");

            Console.ResetColor();
            Divider();
        }
    }
}
