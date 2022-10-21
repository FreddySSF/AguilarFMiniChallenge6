// Fernando Aguilar
// 10-20-22
// Mini Challenge 6 Odd Or Even Endpoint
// The program will prompt the user to enter a number and it will output
// whether the number is odd or even. Add data validation and replay option.

Console.Clear();

string playAgain = "";
double leftOver = 0;
double trueNum = 0;
double validNum = 0;
bool inPut = true;
string number;

while(playAgain != "END")
{
    Console.WriteLine(" Steve Harvey: Welcome to Odd or Even! America's favorite game show! ");
    Console.WriteLine(" Steve Harvey: Contestant! Let's find out what number is * Audience chants out * ODD OR EVEN! ");
    Console.WriteLine(" Steve Harvey: Please choose a number! ");

number = Console.ReadLine();
inPut = double.TryParse(number, out validNum);

if(inPut != true)
{
    Console.WriteLine(" Steve Harvey: WHAT THE - That's not a number ya dummy! Give me a number! ");
    Console.WriteLine(" Announcer Bot: Type end to leave the game show, or anything else to continue! BEEP BOOP BEEP- ");
}
else
{
    if(leftOver == (validNum % 2))
    {
        Console.WriteLine($" Steve Harvey: Your number {number} is even! ");
        Console.WriteLine(" Announcer Bot: Even numbers earn you- BOOP BEEP BOOP- $10,000! Congratulations! ");
        Console.WriteLine(" Announcer Bot: Type end to leave the game show, or anything else to continue! BEEP BOOP BEEP- ");

    }
else
{
    Console.WriteLine($" Steve Harvey: Your number {number} is odd! ");
    trueNum = (validNum % 2);
    Console.WriteLine(" Announcer Bot: Odd numbers earn you- BEEP BOOP BEEP- $0! How sad! ");
    Console.WriteLine(" Announcer Bot: Type end to leave the game show, or anything else to continue! BOOP BEEP BOOP- ");
}
}
playAgain = Console.ReadLine().ToUpper();
Console.WriteLine(" Thanks for playing! And remember to tune in to Odd Or Even every Friday at 5pm on The Freddy Network! Good Night Everybody! ");
}