using System;

Main();



void Main()
{
    int numberOfGames = 3;
    int player = 0;
    int computer = 0;
    int userChoice = 0;

    Console.WriteLine("Welcome to Rock, Paper, Scissors");
    Console.WriteLine("--------------------------------");
    Console.WriteLine();
    for(int i = 0; i <numberOfGames; i++)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($" |  Player:  {player}  |  Computer:  {computer}  | ");
        Console.WriteLine("-----------------------------------");
        int computerChoice = new Random().Next(1,3);
        Console.WriteLine("What would you like to throw?");
        Console.WriteLine("1) Rock");
        Console.WriteLine("2) Paper");
        Console.WriteLine("3) Scissors");
        userChoice = UserInput();

        switch(computerChoice)
        {
            case 1:
            Rock();
            break;
            case 2:
            Paper();
            break;
            case 3:
            Scissors();
            break;
        }
        if(userChoice == 1 && computerChoice == 1)
        {
            Console.WriteLine("You both chose Rock.  Draw.");
        }
        else if(userChoice == 1 && computerChoice == 2)
        {
            Console.WriteLine("You chose Rock.  Computer chose Paper.  You lose.");
            computer++;
        }
        else if(userChoice == 1 && computerChoice == 3)
        {
            Console.WriteLine("You chose Rock.  Computer chose Scissors.  You win.");
            player++;
        }
        else if(userChoice == 2 && computerChoice == 1)
        {
            Console.WriteLine("You chose Paper.  Computer chose Rock.  You win.");
            player++;
        }
        else if(userChoice == 2 && computerChoice == 2)
        {
            Console.WriteLine("You both chose Paper.  Draw.");
        }
        else if(userChoice == 2 && computerChoice == 3)
        {
            Console.WriteLine("You chose Paper.  Computer chose Scissors.  You lose.");
            computer++;
        }
        else if(userChoice == 3 && computerChoice == 1)
        {
            Console.WriteLine("You chose Scissors.  Computer chose Rock.  You lose.");
            computer++;
        }
        else if(userChoice == 3 && computerChoice == 2)
        {
            Console.WriteLine("You chose Scissors.  Computer chose Paper.  You win.");
            player++;
        }
        else if(userChoice == 3 && computerChoice == 3)
        {
            Console.WriteLine("You both chose Scissors.  Draw.");
        }
    }

    if(player > computer)
    {
        Console.WriteLine("-------------");
        Console.WriteLine("Final Score:");
        Console.WriteLine($"Player - {player}");
        Console.WriteLine($"Computer - {computer}");
        Console.WriteLine("YOU WON!!!");
        Console.WriteLine("-------------");
    }
    else if(player < computer)
    {
        Console.WriteLine("-------------");
        Console.WriteLine("Final Score:");
        Console.WriteLine($"Player - {player}");
        Console.WriteLine($"Computer - {computer}");
        Console.WriteLine("YOU LOST!!!");
        Console.WriteLine("-------------");
    }
    else
    {
        Console.WriteLine("-------------");
        Console.WriteLine("Final Score:");
        Console.WriteLine($"Player - {player}");
        Console.WriteLine($"Computer - {computer}");
        Console.WriteLine("Draw!!!");
        Console.WriteLine("-------------"); 
    }
}

int UserInput()
{
    int userInputInt = int.Parse(Console.ReadLine());

    if(userInputInt == 1)
    {
        Rock();
    }
    else if(userInputInt == 2)
    {
        Paper();
    }
    else if(userInputInt == 3)
    {
        Scissors();
    }
    else
    {
        Console.WriteLine("Please enter a valid number.  1 = Rock, 2 = Paper, 3 = Scissors");
        UserInput();
    }
    return userInputInt;
}

void Rock()
{
    Console.WriteLine(@"
    Rock
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)

    ");
}

void Paper()
{
    Console.WriteLine(@"
    Paper
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
    ");
}

void Scissors()
{
    Console.WriteLine(@"
    Scissors
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
    ");
}
