namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] game = { "scissors", "paper", "rock" };


            Console.WriteLine($"Choose one of the next options:\n1.Scissors \n2.Paper \n3.Rock");
            int answer = Convert.ToInt32( Console.ReadLine() );

            Random ra = new Random();
            int y = ra.Next(1,4);
            string rps ( int p1, int p2,string[] game )
            {

                if (p1 == p2)
                {
                    return $"'{game[p1-1]}' vs '{game[p2-1]}'  its a draw";


                }
                else if (p1 == 3 && p2 == 1 || p1 == 2 && p2 == 3 || p1 == 1 && p2 == 2)
                {
                    return $"'{game[p1 - 1]}' vs '{game[p2 - 1]}'  Player 1 won (computer)";

                }
                else if (p2 == 3 && p1 == 1 || p2 == 2 && p1 == 3 || p2 == 1 && p1 == 2)
                {
                    return $"'{game[p1 - 1]}' vs '{game[p2 - 1]}'  Player 2 won (you)";

                }
                else
                {
                    return "write a valid number";
                }


            }

            string finalAnswer = rps(y, answer, game);
            Console.WriteLine(finalAnswer);
        }
    }
}

