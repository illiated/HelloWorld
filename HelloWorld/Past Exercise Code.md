Triangle calcualtion program

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

//"The Defense of Consolas" A program that calculates the coordinates of a target and the coordinates of the surrounding area.
////Console.Title = "Defense of Consolas";
////Console.WriteLine("Enter the targets Row and Column?" );

////Console.Write("Target Row? ");
////int targetRow = Convert.ToInt32(Console.ReadLine());
////Console.Write("Target Column? ");
////int targetColumn = Convert.ToInt32(Console.ReadLine());

////int aboveRow = targetRow - 1;
////int belowRow = targetRow + 1;
////int leftColumn = targetColumn - 1;
////int rightColumn = targetColumn + 1;

////Console.ForegroundColor = ConsoleColor.Cyan;
////Console.WriteLine($"""
////     Deploy to:
////     ({targetRow}, {leftColumn})
////     ({aboveRow}, {targetColumn})
////     ({targetRow}, {rightColumn})
////     ({belowRow}, {targetColumn})
////    """);
////Console.Beep(440, 1000);


Repairing the Clocktower Program (Page 75)
/* The attackes from the Defense of Consolas program have damaged the clocktower.We need to repair its 'Tick Tock' feature using rational and boolean operators. 
 * Numbers flow into the clock to make it go. If a number is even the clock pendulum will tick to the left. If the number is odd the clock pendulum will tick to the right.
 * 
 * Objectives:
 * Take a number as input from the console
 * Display the word as "Tick" if the number is even and "Tock" if the number is odd.
 * Reminder: Use the remainder operator to determine if a number is even or odd.*/
//Console.Write("Please enter the clock seconds number here ");

//int clockSeconds = Convert.ToInt32(Console.ReadLine());

//int evenNo;
//int oddNo;  

//if (clockSeconds % 2 == 0)
//{
//    Console.ForegroundColor = ConsoleColor.Cyan;
//    evenNo = clockSeconds;
//    Console.WriteLine("Tick");
//}
//else
//{
//    Console.ForegroundColor = ConsoleColor.Yellow;
//    oddNo = clockSeconds;
//    Console.WriteLine("Tock");
//}


Watchtower Program (Page 78)
/* Watchtower program to alert on which direction the enemy is coming from.
 * Ask the user for an x and a y value. These are coordinates of the enemy relative to the watchtower's location.
 * Using the image on page 78, if statments and relational operators, display a message to the user telling them which direction the enemy is coming from.
 * For example "The enemy is coming from the North West!" or "The enemy is here!" */

//First get the x and y coordinates values in numbers from negative to positive numberto determine the direction and sdave those values.
//Console.WriteLine("The enemy is launching an attack. Stay sharp an enemy has been spotted! Enter the position of the enemies (x y) coordinates:");

//Console.Write("Enter the enemies x coordinate values in numbers from negative to positive: ");
//int enemyXPosition = Convert.ToInt32(Console.ReadLine());
//Console.Write("Enter ememies y coordinate values in numbers from negative to positive: ");
//int enemyYPosition = Convert.ToInt32(Console.ReadLine());

////Use if statments and relational operators, display a message to the user telling them which direction the enemy is coming from.

//bool isNorth = enemyYPosition > 0;
//bool isSouth = enemyYPosition < 0;
//bool isEast = enemyXPosition > 0;
//bool isWest = enemyXPosition < 0;
//// The below if statments will only work if you follow thew rule "Specific conditions first then General ones last". 
//if (isNorth && isWest)
//{
//    Console.WriteLine("The enemy is coming from the North West!");
//}
//else if (isNorth && isEast)
//{
//    Console.WriteLine("The enemy is coming from the North East!");
//}
//else if (isSouth && isWest)
//{
//    Console.WriteLine("The enemy is coming from the South West!");
//}
//else if (isSouth && isEast)
//{
//    Console.WriteLine("The enemy is coming from the South East!");
//}
//else if (isNorth)
//{
//    Console.WriteLine("The enemy is coming from the North!");
//}
//else if (isSouth)
//{
//    Console.WriteLine("The enemy is coming from the South!");
//}
//else if (isEast)
//{
//    Console.WriteLine("The enemy is coming from the East!");
//}
//else if (isWest)
//{
//    Console.WriteLine("The enemy is coming from the West!");
//}
//else
//{
//    Console.WriteLine("The enemy is here!");
//}


//The below is far less readable as the above but it is order proof. Any order of if/else placements will do.
//if (enemyXPosition < 0 && enemyYPosition > 0)
//{
//    Console.WriteLine("The enemy is coming from the North West!");
//}
//else if (enemyXPosition == 0 && enemyYPosition > 0)
//{
//    Console.WriteLine("The enemy is coming from the North!");
//}
//else if (enemyXPosition > 0 && enemyYPosition > 0)
//{
//    Console.WriteLine("The enemy is coming from the North East!");
//}
//else if(enemyXPosition < 0 && enemyYPosition == 0)
//{
//    Console.WriteLine("The enemy is coming from the West!");
//}
//else if (enemyXPosition == 0 && enemyYPosition == 0)
//{
//    Console.WriteLine("The enemy is here!");
//}
//else if (enemyXPosition > 0 && enemyYPosition == 0)
//{
//    Console.WriteLine("The enemy is coming from the East!");
//}
//else if (enemyXPosition < 0 && enemyYPosition < 0)
//{
//    Console.WriteLine("The enemy is coming from the South West!");
//}
//else if (enemyXPosition == 0 && enemyYPosition < 0)
//{
//    Console.WriteLine("The enemy is coming from the South!");
//}
//else if (enemyXPosition > 0 && enemyYPosition < 0)
//{
//    Console.WriteLine("The enemy is coming from the South East!");
//}

//Shorten the if statments by using bool variables to represent the diffierent directions on the compass