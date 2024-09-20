using RouletteV2;

Console.WriteLine("BID for Color or Number: ");
string userChoise = Console.ReadLine();

bool userPlaying = true;

Random rand = new();
int randNumber = rand.Next(0, 37);

string userBidColor;
int userBidNumber;



while (userPlaying)

    if (userChoise == "c")
    {
        Console.WriteLine("enter Color R or B :");
        userBidColor = Console.ReadLine();
        if (userBidColor == "r")
        {
            Console.WriteLine("RED");
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
