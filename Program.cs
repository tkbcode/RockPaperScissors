using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Disable compile warnings that nag about not overloading the Equals and GetHashCode
// Methods for the Fist class
#pragma warning disable CS0660
#pragma warning disable CS0661

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Fist MyFist = new Fist();
            Fist YourFist = new Fist();
            ConsoleKeyInfo Keypress;
            int GameCount = 1, WinCount = 0, LossCount = 0, TieCount = 0;

            Console.WriteLine("ROCK, PAPER, SCISSORS");
            Console.WriteLine("=====================");
            do
            {
                Console.WriteLine("Press R to throw Rock, P for Paper, S for Scissors, ");
                Console.WriteLine("and any other key to throw randomly.  ");
                Console.WriteLine("Press Escape to exit the program.");

                Keypress = Console.ReadKey(true);
                MyFist.Throw();

                switch (Keypress.Key)
                {
                    case ConsoleKey.R:
                        YourFist.SetState(FistType.rock);
                        break;
                    case ConsoleKey.P:
                        YourFist.SetState(FistType.paper);
                        break;
                    case ConsoleKey.S:
                        YourFist.SetState(FistType.scissors);
                        break;
                    default:
                        YourFist.Throw();
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Game " + GameCount++);
                Console.WriteLine("Your fist threw " + YourFist.ToString());
                Console.WriteLine("My fist threw " + MyFist.ToString());

                if (MyFist > YourFist)
                {
                    Console.WriteLine("I win!");
                    WinCount++;
                }
                else if (MyFist < YourFist)
                {
                    Console.WriteLine("You win!");
                    LossCount++;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                    TieCount++;
                }
                Console.WriteLine("Wins: {0}, Losses:  {1}, Ties:  {2}", LossCount, WinCount, TieCount);
                Console.WriteLine();

            } while (Keypress.Key != ConsoleKey.Escape);
        }
    }
}

public enum FistType : byte { unthrown = 0, rock = 1, paper = 2, scissors = 3};

class Fist
{
    FistType state;
    static readonly Random random = new Random();
    public FistType State()
    {
        return this.state;
    }

    public FistType SetState(FistType NewState)
    {
        state = NewState;
        return state;
    }

    public Fist()
    {
        this.state = FistType.unthrown;
    }

    public static bool operator >(Fist Fist1, Fist Fist2)
    {
        return Comparison(Fist1, Fist2) > 0;
    }
    public static bool operator <(Fist Fist1, Fist Fist2)
    {
        return Comparison(Fist1, Fist2) < 0;
    }

    public static bool operator ==(Fist Fist1, Fist Fist2)
    {
        return Comparison(Fist1, Fist2) == 0;
    }
    public static bool operator !=(Fist Fist1, Fist Fist2)
    {
        return !(Comparison(Fist1, Fist2) == 0);
    }
    public static int? Comparison(Fist Fist1, Fist Fist2)
    {
        switch (Fist1.State())
        {
            case FistType.rock:
                switch (Fist2.State())
                {
                    case FistType.rock:
                        return 0;
                    case FistType.paper:
                        return -1;
                    case FistType.scissors:
                        return 1;
                }
                break;
            case FistType.paper:
                switch (Fist2.State())
                {
                    case FistType.rock:
                        return 1;
                    case FistType.paper:
                        return 0;
                    case FistType.scissors:
                        return -1;
                }
                break;
            case FistType.scissors:
                switch (Fist2.State())
                {
                    case FistType.rock:
                        return -1;
                    case FistType.paper:
                        return 1;
                    case FistType.scissors:
                        return 0;
                }
                break;
        }
        return null;
    }

    public FistType Throw()
    {
        state = (FistType)random.Next(1, 4);
        return this.State();
    }

    public void Unthrow()
    {
        state = FistType.unthrown;
    }

    public override string ToString()
    {
        switch (state)
        {
            case FistType.rock:
                return "Rock";
            case FistType.paper:
                return "Paper";
            case FistType.scissors:
                return "Scissors";
            default:
                return "Nothing";
        }
    }
}
    
