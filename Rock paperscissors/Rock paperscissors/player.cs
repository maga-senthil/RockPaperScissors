using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paperscissors
{
    class Player
    {
        string person;
        string computer;
        string again;
        int run;
        int numberOfRun;

        public Player()
        {
            this.run = 1;
            this.numberOfRun = 10;
        }
       
        public string GetInput()
        {
            Console.WriteLine("enter your option:");
            this.person =( Console.ReadLine().ToLower ());

            Random random = new Random();
            int randomnumber = random.Next(1, 4);

            if (randomnumber == 1)
            {
                this.computer = "rock";
            }
            else if (randomnumber == 2)
            {
                this.computer = "paper";
            }
            else 
            {
                this.computer = "scissors";
            }

            Console.WriteLine("Computer option:");
            Console.WriteLine(computer);
            return person;
        }

        public void GetWinner()
        {
            Game newGame = new Game(person, computer);
            newGame.ChooseWinner();
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to play the Rock Paper Scissors Game:");

            while (this.run < this.numberOfRun)
            {
               GetInput();
               GetWinner();
                Console.WriteLine("Do you want to play Again.");
                Console.Write("Enter Yes or No:");
                again = (Console.ReadLine().ToLower());
                if (again == "yes")
                {
                    run++;
                }
                else
                {
                    Environment.Exit(0);
                }
                
            }
        }

    }
}
