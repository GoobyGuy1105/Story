Console.WriteLine("Oh no! School's out but your friend has a problem! He forgot all his 7 notebooks at school and doesn't have time to go get them! Will you be kind enough to go all the way back to school to find them for him?");

// bool t = 4 == 4 || 3 < 6;
string choice = Console.ReadLine();
choice = choice.ToLower();

if (choice == "yes")
{
    Console.WriteLine("You decide to go back to the school to get his notebooks for him... Finally you arrive and walk through the entrance doors... Inside the lights are all out so you pull out a flashlight to be able to navigate through the halls. You stand at the entrance and Infront of you are two classroom doors, one on the left, the other on the right.");
    Console.WriteLine("Which one will you go for first?");
}

else
{
    Console.WriteLine("You decide you don't want to go all the way back to school and tell him he can get them back himself tomorrow and start playing games instead.");
    Console.WriteLine("Refusal Ending");
}

    Console.ReadLine();