/* Ask for two numbers and an operator (+ - * / %), then pick the calculation with if/else if. Use double so division gives decimals; check for division by zero.
 * 
 * if/else if, ReadKey(true).KeyChar, double, division-by-zero check*/

Console.Title = "Two Number Calculator";


Console.Write("Type in 1st Number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Type in the operator: ");
char calculousOperation = Console.ReadKey().KeyChar;
Console.WriteLine("");

Console.Write("Type in the 2nd Number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
