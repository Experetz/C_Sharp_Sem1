//  Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Please put a number");
int numA = int.Parse(Console.ReadLine());

int numB = numA % 2;
Console.WriteLine(numB);

if (numB == 0){
   Console.WriteLine("Yes, your number is even");
}
else 
Console.WriteLine("No, your number is not even");

