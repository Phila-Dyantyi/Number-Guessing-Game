using System;


namespace NumberGuesser     //Container for classes and functions
{

    
    class Program  //Used to create objects from
    {
        static void Main(string[] args)  //Void is the return type of this function. Static: Don't have instances, you refering to the class itself 
        {
            GetAppInfo();
            GreetUser();
         
           
            while (true)
            {

                
                Random random = new Random(); //generate random number
                int CorrectNumber = random.Next(1, 10); //

                
                int guess = 0;

                Console.WriteLine("Hello there, please guess a number between 1 and 100: ");

                while (guess != CorrectNumber)
                {
                    string inputNumber = Console.ReadLine();
                    if (!int.TryParse(inputNumber, out guess))
                    {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Ooooops!! Please use an actual number");
                        continue;
                    }
                    //Cast to int and put into the guess variable

                    guess = Int32.Parse(inputNumber); // Need the inputNUmber to be an interger so we use this function
                                                     

                    if (guess != CorrectNumber)  
                    {
                       //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again!!");
                    }





                }

                // Output Success Message
                PrintColorMessage(ConsoleColor.Yellow, "YEY!! You are correct.");


                Console.WriteLine("Do you want to play again? [Y or N]");

                string UserAnswer = Console.ReadLine().ToUpper();

                if (UserAnswer == "Y")
                {
                    continue;
                }
                else if(UserAnswer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //This is where you are getting and displaying app info
        static void GetAppInfo()
        {
               //Set app variabless 
            string appName = "Number Guesser";
            string appVersion = "2.2.0";
            string appAuthor = "Phila Dyantyi";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

                //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
                //Reset text color
            Console.ResetColor();

        }
        //Ask users name and greet
        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("What is your name: ");

            //Getting user's input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game. . .", inputName);
        }
        //Printing a color message

        static void PrintColorMessage(ConsoleColor color, string message )
        {
            
            Console.ForegroundColor = color;

            
            Console.WriteLine(message);
            
            Console.ResetColor();
        }

}

}