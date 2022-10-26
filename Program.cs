bool letsPlay = true;

while(letsPlay == true)
//Review: Michelle M. 
//It works, nicely done!
{
bool isCorrect = false;
string answer;
int guess;
int guessNumber = 0;

void playGame ()  // call the void thing (Function?) instead?
{

    Console.WriteLine("Welcome to Guess a Number. Do you want to play Easy (E), Medium (M), Hard (H), or God Mode (G)?");
    answer = Console.ReadLine().ToUpper();



    if (answer == "E")
    {
        Random numberGen = new Random();
        int number = numberGen.Next(0, 11);
        while(isCorrect == false){
        Console.WriteLine("Try to guess a random number between 1 and 10.");
        guess = Convert.ToInt32(Console.ReadLine());
        
        if (guess == number)
        {
            guessNumber++;
            Console.WriteLine("That's right! You guessed it! :D");
            Console.WriteLine("It took you " + guessNumber + " tries!");
            isCorrect = true;
            
        }
        else if (guess < number)
        {
            Console.WriteLine("Sorry, you guessed too low. Try again.");
            guessNumber++;
            //guess = Convert.ToInt32(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("Sorry, you guessed too high. Try again.");
            guessNumber++;
            //guess = Convert.ToInt32(Console.ReadLine());
        }
        }
    }

    else if (answer == "M")
    {
        Random numberGen = new Random();
        int number = numberGen.Next(0, 51);
        while(isCorrect == false){
        Console.WriteLine("Try to guess a random number between 1 and 50.");
        guess = Convert.ToInt32(Console.ReadLine());
        if (guess == number)
        {
            Console.WriteLine("That's right! You guessed it! :D");
            guessNumber++;
            Console.WriteLine("It took you " + guessNumber + " tries!");
            isCorrect = true;
    
        }
        else if (guess < number)
        {
            Console.WriteLine("Sorry, you guessed too low. Try again.");
            guessNumber++;
        }
        else
        {
            Console.WriteLine("Sorry, you guessed too high. Try again.");
            guessNumber++;
        }
        }
    }
    else if (answer == "H")
        {
            Random numberGen = new Random();
            int number = numberGen.Next(0, 101);
            while(isCorrect == false){
            Console.WriteLine("Try to guess a random number between 1 and 100.");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == number)
            {
                Console.WriteLine("That's right! You guessed it! :D");
                guessNumber++;
                Console.WriteLine("It took you " + guessNumber + " tries!");
                isCorrect = true;
                
            }
            else if (guess < number)
            {
                Console.WriteLine("Sorry, you guessed too low. Try again.");
                guessNumber++;
            }
            else
            {
                Console.WriteLine("Sorry, you guessed too high. Try again.");
                guessNumber++;
            }
            }
        }
    else if (answer == "G")
        {
            Random numberGen = new Random();
            Console.WriteLine("Choose the lower end of the range of numbers from which you want to guess.");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose the upper end of the range of numbers from which you want to guess.");
            int j = Convert.ToInt32(Console.ReadLine());
            int number = numberGen.Next(i, j);
            while(isCorrect == false){
            Console.WriteLine("Try to guess a random number between " + i + " and " + j + ".");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess == number)
            {
                Console.WriteLine("That's right! You guessed it! :D");
                guessNumber++;
                Console.WriteLine("It took you " + guessNumber + " tries!");
                isCorrect = true;
                    
            }
            else if (guess < number)
            {
                Console.WriteLine("Sorry, you guessed too low. Try again.");
                guessNumber++;
            }
            else
            {
                Console.WriteLine("Sorry, you guessed too high. Try again.");
                guessNumber++;
            }
            }
        }
    else
        {
            Console.WriteLine("Please choose a valid option.");
        }
            
}       
playGame();     

bool question = true;
while(question == true)
{
Console.WriteLine("Do you want to play again? Y/N");
string playAgain = Console.ReadLine().ToUpper();

if(playAgain == "Y")
{
    letsPlay = true;
    question = false;
}
else if(playAgain == "N")
{
    letsPlay = false;
    question = false;
    Console.WriteLine("Goodbye.");
}
else
{
    Console.WriteLine("Please enter a valid option: Y or N");
    question = true;
}
}
}