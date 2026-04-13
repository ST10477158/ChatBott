using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChatBott
{
    internal class Program
    {
        static void Main(string[] args)
        {
            great_voice obj = new great_voice();
            obj.greet_voice();
            obj.voice();
            
            Program bot = new Program();
            

            bot.LogoDisplay();
            bot.UserInteraction();
            bot.ResponseSystem();
        }
       
        
           
        public void TypingEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }

        public void LogoDisplay()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("**************************************************");
            Console.WriteLine("*         CyberSecurity Awareness Bot          *");
            Console.WriteLine("****************************************************");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("          ______");
            Console.WriteLine("        /       \\");
            Console.WriteLine("       /         \\");
            Console.WriteLine("     |   ()   ()   |");
            Console.WriteLine("     |     ^       |");
            Console.WriteLine("     |   ___       |");
            Console.WriteLine("     |  |   |      |");
            Console.WriteLine("     |  |___|      |");
            Console.WriteLine("       \\___/");
            Console.WriteLine("         |||||");
            Console.WriteLine("         |||||");
            Console.ResetColor();

            Console.WriteLine();
        }

        public void UserInteraction()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************");
            Console.WriteLine(" Welcome to our Cybersecurity Chat Bot");
            Console.WriteLine("*************");
            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Kindly enter your name:");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            string UserName = Console.ReadLine();
            Console.ResetColor();

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            TypingEffect("Hello " + UserName + "!");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            TypingEffect("You are communicating with a Cybersecurity Awareness Bot.");
            TypingEffect("I am here to take you through all the steps to help you stay safe online.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************");
            Console.ResetColor();
        }

        public void ResponseSystem()
        {
            string input;

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=================================================");
            Console.WriteLine("                 CHAT SECTION                     ");
            Console.WriteLine("=================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            TypingEffect("You can ask me any cybersecurity question of your choice.");
            TypingEffect("Kindly type 'exit' to quit.");
            Console.ResetColor();

            while (true)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("You: ");
                Console.ResetColor();

                input = Console.ReadLine().ToLower();

                if (input == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: Thank you for your enquiry. Stay safe online!");
                    Console.ResetColor();
                    break;
                }

                if (input.Contains("how are you?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: I am working well! I am here to help you.");
                    Console.ResetColor();
                }
                else if (input.Contains("what is your purpose"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: Provides real-time, interactive education to help users recognize scams, understand security policies, and adopt safer digital habits.");
                    Console.ResetColor();
                }
                else if (input.Contains("what can i ask?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: Any topic or questions that are related to password safety, phishing, and safe browsing.");
                    Console.ResetColor();
                }
                else if (input.Contains("how to create a password?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: You must create a strong Password that contains letters, numbers and symbols.");
                    Console.ResetColor();
                }
                else if (input.Contains("is it safe to share your password?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: No it's not safe to share it.");
                    Console.ResetColor();
                }
                else if (input.Contains("what is phishing?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: Phishing is a social engineering technique where attackers use fraudulent emails, websites, or messages to trick victims into revealing sensitive information.");
                    Console.ResetColor();
                }
                else if (input.Contains("what can i do to avoid phishing?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: Always check the sender and avoid suspicious links.");
                    Console.ResetColor();
                }
                else if (input.Contains("what is safe browsing?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: Safe browsing is a security service that protects users by warning them before they visit dangerous websites.");
                    Console.ResetColor();
                }
                else if (input.Contains("how to avoid it?"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    TypingEffect("Bot: Always visit secure websites (https), avoid clicking unknown links, and keep your browser updated.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    TypingEffect("Bot: I didn’t quite understand that. Could you rephrase?");
                    Console.ResetColor();
                }
            }
        }
    }
}

