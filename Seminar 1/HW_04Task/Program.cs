//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Please put a number");
int numA = int.Parse(Console.ReadLine());
int i = 1;

for (i = 1; i <= numA; i++){

    if (i % 2 == 0) {
Console.Write(i + "  ");
}
}