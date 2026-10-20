// Triangle calcualtion program

////Console.WriteLine("Write the base of the triangle:");
////string triangleBase = Console.ReadLine();
////float triBase = Convert.ToInt32(triangleBase);

////Console.WriteLine("Write the height of the triangle:");
////string triangleHeight = Console.ReadLine();
////float triHeight = Convert.ToInt32(triangleHeight);

////float area = triBase * triHeight / 2;

////Console.WriteLine($"The area of a triangle with base of {triBase} and a height of {triHeight} is {area}");


//Division & RemainderProgram to Calculate what is Divided and what is Left over.

////Console.WriteLine("How many chocolate eggs are there?");
////int chocolateEggs = Convert.ToInt32(Console.ReadLine());

////Console.WriteLine("How many will the four sisters get when they are divided evenly and how much is left over.");
////int sisterShare = chocolateEggs / 4;
////int remainder = chocolateEggs % 4;

////Console.WriteLine($"Each sister gets {sisterShare} chocolate eggs. The remainder, {remainder}, will be given to the pet.");

// Program that calculates incremental values of a number by 1, 3, and 6.

////Console.WriteLine("Please enter the amount of estates you posses?");
////int estates = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Please enter the amount of duchys you possess");
////int duchys = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Please enter the amount of provinces you possess");
////int provinces = Convert.ToInt32(Console.ReadLine());

////int estatesTotalValue = estates;
////int duchysTotalValue = duchys * 3;
////int provincesTotalValue = provinces * 6;

////Console.WriteLine($"Your current holdings value is: Estates = {estatesTotalValue}, Duchys = {duchysTotalValue}, Provinces = {provincesTotalValue} which totals to {estatesTotalValue + duchysTotalValue + provincesTotalValue}");
///


Console.Title = "Defense of Consolas";
Console.WriteLine("Enter the targets Row and Column?" );

Console.Write("Target Row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

int aboveRow = targetRow - 1;
int belowRow = targetRow + 1;
int leftColumn = targetColumn - 1;
int rightColumn = targetColumn + 1;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"""
     Deploy to:
     ({targetRow}, {leftColumn})
     ({aboveRow}, {targetColumn})
     ({targetRow}, {rightColumn})
     ({belowRow}, {targetColumn})
    """);
Console.Beep(440, 1000);







