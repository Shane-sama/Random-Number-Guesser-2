using System;
using System.Reflection.Emit;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

public class Intro
{
    public static void Play()
    {
        string[] Text =
        {
            "It's a beautiful day outside.",
            "Birds are singing, flowers are blooming...",
            "On days like these, kids like you...",
            "SHOULD BE BURNING IN HE-",
            "...",
            "...",
            "...",
            "*cough",
            "Oh, sorry kid, I seemingly mixed you up...",
            "I guess you're here to guess some numbers?"
        };
        int[] TextSpeed =
        {
            75, 75, 90, 150, 450, 550, 700, 50, 75, 75
        };
        int Repeat = Text.Length - 1;
        int TextLine = -1;

        while (TextLine != Repeat)
        {
            TextLine++;
            foreach (char c in Text[TextLine])
            {
                Console.Write(c);
                Thread.Sleep(TextSpeed[TextLine]);
            }
            Console.WriteLine("");
            Console.WriteLine("<press enter to continue>");
            Console.ReadLine();
            Console.Clear();
        }
    }
    public static bool Skip()
    {
        string text0 = "Do you want to read the Dialogue?";
        foreach (char c in text0)
        {
            Console.Write(c);
            Thread.Sleep(50);
        }
        Console.WriteLine("");
        Console.WriteLine("<Type no to skip, type anything else to read.>");
        string Check = Console.ReadLine();
        Console.Clear();
        if (Check == "no")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
