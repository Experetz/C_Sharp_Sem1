//Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Please put number one   ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Please put number two   ");
int numB = int.Parse(Console.ReadLine());

if (numA > numB){
    Console.WriteLine("Number One is bigger than Two");
    }
    else if (numA == numB){
        Console.WriteLine("Your numbers are equal");
        }
else {
    Console.WriteLine("Number Two is bigger than One");
}        