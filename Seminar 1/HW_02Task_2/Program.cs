//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.

Console.WriteLine("Please put 3 numbers");
int numA = int.Parse(Console.ReadLine());
int numB = int.Parse(Console.ReadLine());
int numC = int.Parse(Console.ReadLine());
int Max = numA;

if (numB > Max) {
    Max = numB;
}
if (numC > Max) {
    Max = numC;
}
Console.WriteLine($"Maximum number is {Max}");