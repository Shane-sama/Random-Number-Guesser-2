using System;
using System.Reflection.Emit;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

public class Game1to100
{
    public static void Game()
    {
        int Rounds = -1;
        retry1to100:
        int Guess = 0;
        int Tries = 0;
        int Typo = -1;
        int Result = One2Hundret();

        string[] HereWeGoAgain =
        {
            "Make a first guess!",
            "Second round, here we go!",
            "You really like this game, don't you, kid?",
            "We're gonna be here all day? I'm in!",
            "Make your guess, kid!"
        };

        if (Rounds <= 4)
        {
            Rounds++;
        }
        string Text = HereWeGoAgain[Rounds];
        foreach (char c in Text)
        {
            Console.Write(c);
            Thread.Sleep(75);
        }
        Console.WriteLine("");

        while (Guess != Result)
        {
            try
            {
                Guess = Convert.ToInt32(Console.ReadLine());

                if (Guess < 1 || Guess > 100)
                {
                    throw new Exception();
                }
                else if (Guess == Result)
                {
                    string[] GoodJob =
                    {
                        "Good job, you actually got it!",
                        "Only took you " + Tries + " retries",
                        "Wanna go again?"
                    };
                    int GoodJobLine = -1;

                    while (GoodJobLine != GoodJob.Length - 1)
                    {
                        GoodJobLine++;
                        foreach (char c in GoodJob[GoodJobLine])
                        {
                            Console.Write(c);
                            Thread.Sleep(75);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("<press enter to continue>");
                        Console.ReadLine();
                    }
                    Console.WriteLine("<Type yes to go again, type anything else to end program.>");
                    string Again = Console.ReadLine();
                    Console.Clear();
                    if (Again == "yes")
                    {
                        goto retry1to100;
                    }
                    else
                    {
                        Console.WriteLine("Have a nice day kid!");
                        Console.WriteLine("<press enter to continue>");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                else if (Guess > Result)
                {
                    Tries++;

                    string[] TooBig =
                    {
                        "I think you're overestimating the size of the number.",
                        "Too Big, go lower!",
                        "C'mon kid, i know you can think smaller!",
                        "What's the difference between quantums and your guess? Quantums aren't big!",
                        "You gotta think smaller, kid!"
                    };
                    int BigOutput = new Random().Next(0, 4);

                    string text14 = TooBig[BigOutput];
                    foreach (char c in text14)
                    {
                        Console.Write(c);
                        Thread.Sleep(40);
                    }
                    Console.WriteLine("");
                    string text15 = "Try again!";
                    foreach (char c in text15)
                    {
                        Console.Write(c);
                        Thread.Sleep(40);
                    }
                    Console.WriteLine("");
                }
                else if (Guess < Result)
                {
                    Tries++;

                    string[] TooLow =
                    {
                        "Too Low, next time go higher!",
                        "I know your brain is able to think bigger!",
                        "My brother Papyrus is taller then I, your guesses should be able to reach further up too!",
                        "Think Big, kid!",
                        "You're thinking too low, kid, you can go way higher than this!"
                    };
                    int SmallOutput = new Random().Next(0, 4);

                    string text16 = TooLow[SmallOutput];
                    foreach (char c in text16)
                    {
                        Console.Write(c);
                        Thread.Sleep(40);
                    }
                    Console.WriteLine("");
                    string text17 = "Try again!";
                    foreach (char c in text17)
                    {
                        Console.Write(c);
                        Thread.Sleep(40);
                    }
                    Console.WriteLine("");
                }
            }
            catch
            {
                Typo++;
                string[] NoU =
                {
                    "Stop it kid, only numbers from 1 to 100!",
                    "Already told you, only numbers from 1 to 100!",
                    "You didn't understand me? Only numbers from 1 to 100!",
                    "Listen kid, you dont have to go too crazy with this, just use numbers from 1 to 100!",
                    "Seriously, 5 times? C'mon kid, play this game like it's supposed to be played! ",
                    "Welp, you didn't want to listen!"
                };
                foreach (char c in NoU[Typo])
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }
                Console.WriteLine("");
                Console.WriteLine("<press enter to continue>");
                Console.ReadLine();

                if (Typo == 5)
                {
                    Environment.Exit(0);
                }
            }
        }
    }

    public static int One2Hundret()
    {
        int rndNumber = new Random().Next(1, 100);
        return rndNumber;
    }
}