using System;
using System.Media;

namespace ChatBott
{
    internal class great_voice
    {
        public void greet_voice()
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

        }
        public void voice()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\ChatBott\\Cybersecurityawarenessbot.wav");
                player.Load();
                player.PlaySync();
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠ Voice file not found.");
                Console.ResetColor();
            }
        }
    }
}
