Console.WriteLine("Oh no! School's out but your friend has a problem! He forgot his 2 notebooks at school and doesn't have time to go get them! Will you be kind enough to go all the way back to school to find them for him?");


string choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "yes")
{
    Console.WriteLine("You decide to go back to the school to get his notebooks for him... Finally you arrive and walk through the entrance doors... Inside the lights are all out so you pull out a flashlight to be able to navigate through the halls. You stand at the entrance and Infront of you are two classroom doors, one on the left, the other on the right.");
    Console.WriteLine("Which one will you go for first?");
    //Console.ReadLine();

       string choiceleftright = Console.ReadLine();

    if (choiceleftright == "left")
    {
        Console.WriteLine("You walk into the classroom to your left and find his blue notebook.");
        Console.WriteLine("1/2 Notebooks");
        Console.WriteLine("You then decide to go check the classroom to the right and find his second green notebook.");
        Console.WriteLine("2/2 Notebooks");
        Console.ReadLine();
    }
    else if (choiceleftright == "right")
    {
        Console.WriteLine("You walk into the classroom to your right and find his green notebook.");
        Console.WriteLine("1/2 Notebooks");
        Console.WriteLine("You then decide to go check the classroom to the left and find his second blue notebook.");
        Console.WriteLine("2/2 Notebooks");
        Console.ReadLine();
    }

    {
        Console.WriteLine("You step out of the classroom and suddenly hear a noise behind the double swinging doors that lead into the halls.");
        Console.WriteLine("There are three double doors at your current location, one infront of you, one to your left and one to your right.");
        Console.WriteLine("Do you run out and leave or do you run straight forward (where the noise came from) to see what it was?");
        //Console.ReadLine();
    }

    string choiceleaveorcheck = Console.ReadLine();

    if (choiceleaveorcheck == "leave")
    {
        Console.WriteLine("You have what you came for and instantly leave the school and run home, ignoring what the sound was and later contact your friend, saying you got his notebooks.");
        Console.WriteLine("GOOD ENDING! :D");
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }

else if (choiceleaveorcheck == "check")
    {
        Console.WriteLine("You walk through the front double doors to see what that noise was...");
        Console.WriteLine("IT WAS THE PRINCIPAL!!");
        Console.WriteLine("The principal sees you are in school after hours and you try to run but get caught and now have to stay in the school...");
        Console.WriteLine("The principal also contacts your parents and you are about to get in some serious trouble...");
        Console.WriteLine("BAD ENDING! D:");
        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }

}

    else
    {
        Console.WriteLine("You decide you don't want to go all the way back to school and tell him he can get them back himself tomorrow and you start playing games instead.");
        Console.WriteLine("REFUSAL ENDING! :O");
        Console.WriteLine("Press Enter to exit");
        Console.ReadLine();
    }
