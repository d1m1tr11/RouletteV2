using RouletteV2;

Console.WriteLine("BID for Color or Number: ");
string userChoise = Console.ReadLine();
bool userPlaying = true;
string userBidColor;
int userBidNumber;


Random rand = new();
static string GetColor(int randNumber)
{
    string color;
    if (randNumber > 0 && randNumber % 2 == 0)
    {
        color = "Black";
        return color;
    }
    else if (randNumber > 0)
    {
        color = "Red";
        return color;
    }
    else
    {
        color = "Green";
        return color;
    }

}



while (userPlaying)
{


    int randNumber = rand.Next(0, 37);
    if (userChoise == "c")
    {
        Console.WriteLine("enter Color R or B :");
        userBidColor = Console.ReadLine();
        if (userBidColor == "r" && randNumber % 2 != 0)
        {
            Console.WriteLine($"YOU WIN ! [{randNumber} | {GetColor(randNumber)}]");

        }
        else if (userBidColor == "b" && randNumber > 0 && randNumber % 2 == 0)
        {
            Console.WriteLine($"YOU WIN ! [{randNumber} | {GetColor(randNumber)}]");
        }
        else
        {
            Console.WriteLine($"You Loose :( ...  [{randNumber} | {GetColor(randNumber)}]");
        }
        userChoise = null;

    }
    else if (userChoise == "n")
    {
        Console.WriteLine("you choose N");
        userChoise = null;
    }

    else
    {
        Console.WriteLine();
        Console.WriteLine("Choose c, n or q for QUIT... ");
        userChoise = Console.ReadLine();
        randNumber = rand.Next(0, 37);
        if (userChoise == "q")
        {
            userPlaying = false;
        }
        else
        {
            userPlaying = true;
        }
    }
}