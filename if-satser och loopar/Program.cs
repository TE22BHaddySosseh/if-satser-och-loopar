// uppgift 2

// string Username;
// string Password;

// Console.WriteLine("Type in a username:");

// Username = Console.ReadLine();

// Console.WriteLine("Type in a password:");

// Password = Console.ReadLine();

// if (Username == "noname" && Password == "nopass"){
//     Console.WriteLine("Welcome!");
// }
// else{
//     Console.WriteLine("Wrong username or password");
// }

// Console.ReadLine();

// -----------------------

// uppgift 3

// for (int c = 0; c < 37; c++)
// {
//     System.Console.WriteLine("Hello, world");
// }

// while (true)
// {
//     int counter = 0;
//     Console.WriteLine("Hello, world.");
//     counter += 1;

//     if (counter == 37)
//     {
//         break;
//     }
// }

// ----------------------


Random ran = new Random();
int rannum = ran.Next(1,10);

while (true){
    Console.WriteLine("Guess the number I'm thinking of!");
    string guess = Console.ReadLine();
    int intr = int.Parse(guess);

    if (int.Parse(guess) > rannum){
        Console.WriteLine("Too high! Go a bit lower!");
    }
    if (int.Parse(guess) < rannum){
        Console.WriteLine("Too low! Go a bit higher!");
    }
}

Console.ReadLine();