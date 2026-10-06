// Triangle calcualtion program

Console.WriteLine("Write the base of the triangle:");
string triangleBase = Console.ReadLine();
float triBase = Convert.ToInt32(triangleBase);

Console.WriteLine("Write the height of the triangle:");
string triangleHeight = Console.ReadLine();
float triHeight = Convert.ToInt32(triangleHeight);

float area = triBase * triHeight / 2;

Console.WriteLine($"The area of a triangle with base of {triBase} and a height of {triHeight} is {area}");



