using RouletteV2;

Console.WriteLine("BID for Color or Number: ");
string userChoise = Console.ReadLine();
bool userPlaying = true;
string userBidColor;
int userBidNumber;

string color;

Random rand = new();

static void getColor()
{
    if (randNumber > 0 && randNumber % 2 == 0)
    {
        color = "Black";
    }
    else if (randNumber > 0)
    {
        color = "Red";
    }
    else
    {
        color = "Green";
    }

}




while (userPlaying)
    int randNumber = rand.Next(0, 37);

    if (userChoise == "c")
    {
        Console.WriteLine("enter Color R or B :");
        userBidColor = Console.ReadLine();
        if (userBidColor == "r")
        {
            if (color == "Red")
            {
                Console.WriteLine($"YOU WIN! Ball is in the {randNumber} {color}! ");
            }
            userChoise = null;


        }
        else if (userBidColor == "b")
        {
            Console.WriteLine("BLACK");
            userChoise = null;
        }
        else
        {
            continue;
        }
    }
    else if (userChoise == "n")
    {
        Console.WriteLine("you choose N");
        userChoise = null;
    }

    else
    {
        Console.WriteLine("Choose c, n or q for QUIT... ");
        userChoise = Console.ReadLine();
        if (userChoise == "q")
        {
            userPlaying = false;
        }
        else
        {
            userPlaying = true;
        }
    }
