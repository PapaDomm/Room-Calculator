//Welcome the user to the program
Console.WriteLine("Welcome to the Room Calculator! Enter the dimensions of your room and we will run some quick calculations!");
Console.WriteLine();

//Ask the user for their rooms dimension sizes
Console.Write("What is the length of your room?: ");
double length = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("What is the width of your room?: ");
double width = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("What is the height of your room?: ");
double height = double.Parse(Console.ReadLine());
Console.WriteLine();

//Calculate further dimensions using user input
double area = length * width;
double perimeter = 2 * (length + width);
double volume = length * width * height;
double surfaceArea = 2 * ((width * length) + (height * length) + (height * width));

//Display area, perimeter, volume and surface area to user
Console.WriteLine($"The area of your room is {area}");
Console.WriteLine($"The perimeter of your room is {perimeter}");
Console.WriteLine($"The volume of your room is {volume}");
Console.WriteLine($"The surface area of your room is {surfaceArea}");
Console.WriteLine();

//Calculate and tell the user the size of their room
if (area <= 250)
{
    Console.WriteLine("Your room is small!");
}
else if (area < 650 &&  area > 250)
{
    Console.WriteLine("Your room is medium.");
}
else
{
    Console.WriteLine("Your room is big!");
}