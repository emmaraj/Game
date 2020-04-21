using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTries = 0;
            int number = 0;
            int maxNumber = 0;

            string userLevel = string.Empty;
            string[] levels = {"EASY", "MEDIUM", "HARD"};

            Console.WriteLine("Welcome to this Game developed by emmaraj");
            Console.WriteLine("This is a guessing game.");
            Console.WriteLine("Select a Level by entering the number for the level");
            Console.WriteLine("1 EASY \n2 MEDIUM \n3 HARD\n");
            string value = Console.ReadLine();

            if (value == "1"){
                userLevel = levels[0]; //for Easy 
            } else if (value == "2"){
                userLevel = levels[1]; //for Medium
            } else {
                userLevel = levels[2]; //for Hard
            }

            Random random = new Random();

            switch(userLevel){
                case "EASY":
                    maxNumber = 10;
                    number = random.Next(1, maxNumber+1);//generate a number between 1 and 10
                    numberOfTries = 6;
                    break;

                case "MEDIUM":
                    maxNumber = 20;
                    number = random.Next(1, maxNumber+1);//generate a number between 1 and 10
                    numberOfTries = 4;
                    break;

                case "HARD":
                    maxNumber = 50;
                    number = random.Next(1, maxNumber+1);//generate a number between 1 and 50
                    numberOfTries = 3;
                    break;
            }

        Console.WriteLine("You've selected {0} level of difficulty", userLevel);
        Console.WriteLine("You have {0} number of attempts to get the right response", numberOfTries);
        int userReponse = 0;

        while(numberOfTries != 0){
            Console.Write("Choose as number between 1 and {0} :",maxNumber);
            userReponse = Int32.Parse(Console.ReadLine());

            if(userReponse == number){
                Console.WriteLine("You got it right");
                break;
            } else {
                Console.WriteLine("That was wrong");
            }
            
            numberOfTries--;
            Console.WriteLine("You have {0} number of attempts left",numberOfTries);

            //check the person didn't get the answer and has also exhausted all attempts.
            if((userReponse != number) && (numberOfTries == 0)){
             Console.WriteLine("Game Over");
            }
        }

        

        }
    }
}
