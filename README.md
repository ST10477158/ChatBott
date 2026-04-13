# ChatBott
Screenshort for the workflow.
<img width="1345" height="709" alt="image" src="https://github.com/user-attachments/assets/eb4288d7-bc55-460d-a190-449988c02b11" />
Class Name: great_voice
Methods
greet_voice()

Retrieves the base directory of the application using:

AppDomain.CurrentDomain.BaseDirectory;
(Currently not used, but can be used to build a dynamic audio file path.)
 voice()

Loads and plays a .wav file using:

SoundPlayer player = new SoundPlayer("path_to_file.wav");
player.Load();
player.PlaySync();

If the file is missing, it prints:

 Voice file not found.
 Voice Greeting

When the program starts, it plays a voice file:

obj.voice();
Logo Display

The bot displays an ASCII logo and title:

bot.LogoDisplay();
User Interaction

The bot asks the user for their name and welcomes them:

bot.UserInteraction();
Response System

The bot enters a loop where it responds to cybersecurity questions until the user types:

exit
