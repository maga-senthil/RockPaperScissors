using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paperscissors
{
    class winner
    {
        string  playerOne;
        string  playerTwo;

        public winner(string playerOne,string playerTwo)
        {
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
        }

        public void pickWinner()
        {

            if (playerOne == playerTwo)
            {
                Console.WriteLine("Draw");
            }

            else if (playerOne == "rock")
            {
                if (playerTwo == "paper")
                {
                    Console.WriteLine("you lose");

                }
                else
                {
                    Console.WriteLine("you Won");
                }

            }
            else if (playerOne == "paper")
            {
                if (playerTwo == "rock")
                {
                    Console.WriteLine("you won");

                }
                else
                {
                    Console.WriteLine("you lose");
                }

            }
            else if (playerOne == "scissors")
            {
                if (playerTwo == "paper")
                {
                    Console.WriteLine("you won");

                }
                else
                {
                    Console.WriteLine("you lose");
                }

            }


        }



        }

    }

