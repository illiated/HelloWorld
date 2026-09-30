Console.WriteLine("What kind of thing are we talking about?");

//The name of the object goes in string a:
string a = Console.ReadLine(); 
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

/*This is a descriptive word for the object in the text*/
string b = Console.ReadLine();

string c = "of Doom"; //This variable contains further words for the title of the thing
string d = "3000";// This addd to the things decriptive title
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
