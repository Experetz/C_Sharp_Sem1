//Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает последнюю цифру этого числа


Console.WriteLine("Put a three-digit number    ");
int A = int.Parse(Console.ReadLine());
int B;

if (A > 99 && A < 1000){
    B = A % 10;
Console.WriteLine($"Last digit of the number = {B}");    
}
else {
    Console.WriteLine("Wrong number");
}