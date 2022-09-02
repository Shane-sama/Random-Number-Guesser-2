using System;
using System.Reflection.Emit;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    public static void Main(string[] args)
    {
        bool Skip = Intro.Skip();
        if (Skip == false)
        {
            Intro.Play();
        }

        int GameMode = GameChoice.Pick();

        if (GameMode == 100)
        {
            Game1to100.Game();
        }
        else if (GameMode == 1000)
        {
            Game1to1000.Game();
        }
        else if (GameMode == 0)
        {
            Environment.Exit(0);
        }
        else
        {
            Environment.Exit(0);
        }
    }
}