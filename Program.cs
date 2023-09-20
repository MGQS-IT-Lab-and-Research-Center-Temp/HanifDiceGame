// Build Dice Game
Console.WriteLine("===Simple Dice Game===\nType 'Play' or 'P' to roll the dice:");

string playGame = Console.ReadLine()!;

if (!(playGame.Equals("Play", StringComparison.OrdinalIgnoreCase) || playGame.Equals("p", StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine("Enter 'Play' or 'p'to play the game"); 
    return;
}

Random random = new();
int diceOne = random.Next(1, 7);
int diceTwo = random.Next(1, 7);
int diceThree = random.Next(1, 7);
int originalScore = diceOne + diceTwo + diceThree;
const int DOUBLE_POINT = 2;
const int TRIPLE_POINT = 6;
int totalPoint = originalScore;

if (diceOne == diceTwo && diceTwo == diceThree)
{
    totalPoint += TRIPLE_POINT;

    Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a trple! You have a total of {totalPoint} points");

}
else if (diceOne == diceTwo || diceTwo == diceThree || diceOne == diceThree)
{
    totalPoint += DOUBLE_POINT;

    Console.WriteLine($"Dice One: {diceOne}\nDice Two: {diceTwo}\nDice Three: {diceThree}.\nYou rolled a double! You have a total of {totalPoint} points");    
}
else if(diceOne != diceTwo && diceTwo != diceThree && diceOne != diceThree)
{
    Console.WriteLine($"Dice one: {diceOne}\nDice two: {diceTwo}\nDice three: {diceThree}");
    Console.WriteLine("oops! the three value doesn't match");
}

if(totalPoint >= 10 && totalPoint <= 13)
{
 Console.WriteLine("Congratulations you won a Ballon"); 
}

if(totalPoint >= 14 && totalPoint <= 16)
{
    Console.WriteLine("congratulations you won an exercise book");
}

if(totalPoint == 17)
{
    Console.WriteLine("Congratulations you won a 5000mah powerbank");
}

if(totalPoint >= 18 && totalPoint <= 20)
{
    Console.WriteLine("congratulations you won a free ticket to silverbird");
}

 if(totalPoint == 21)
 {
    Console.WriteLine("congratulations you won a samsungA24");
 }   

   if(totalPoint >= 22 && totalPoint <= 24)
   {
    Console.WriteLine("congratulations you won all items");
   } 
    
