using System;
using System.Reflection.Emit;
using System.Threading;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class GameChoice
{
	public static int Pick()
	{
        string Text = "What to play?";
        foreach (char c in Text)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.WriteLine("");
        Console.WriteLine("<Pick Game Mode by typing either 100 or 1000>");
        string Check = Console.ReadLine();
        Console.Clear();
        if (Check == "100")
        {
            return 100;
        }
        else if (Check == "1000")
        {
            return 1000;
        }
        else
        {
            string TextSad = "Wanna End Already? Goodbye then.";
            foreach (char c in TextSad)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine("");
            Console.WriteLine("<press enter to continue>");
            Console.ReadLine();
            return 0;
        }
    }
}
