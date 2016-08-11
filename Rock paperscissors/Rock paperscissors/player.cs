using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paperscissors
{
    class player
    {
        string person;
        string computer;
        string again;
        int run;
        int numberOfRun;

        public player()
        {
            this.run = 1;
            this.numberOfRun = 10;
        }
       
        public string getInput()
        {
            
            Console.WriteLine("enter your option:");
            this.person =( Console.ReadLine().ToLower ());

            Random random = new Random();
            int randomnumber = random.Next(1, 3);



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

        public void getWinner()
        {

            winner newwinner = new winner(person, computer);
            newwinner.pickWinner();


        }
        public void runGame()

        {
            Console.WriteLine("Welcome to play the Rock Paper Scissors Game:");

            while (this.run < this.numberOfRun)
            {
               getInput();
               getWinner();
                Console.WriteLine("Do you want to play Again:");
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
