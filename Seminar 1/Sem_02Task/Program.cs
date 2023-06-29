
Console.Write("Please put a number    ");
int numberA = int.Parse(Console.ReadLine());
if ((numberA >= 1) && (numberA <= 7)){
        if (numberA == 1){
        Console.WriteLine("Monday");
}
        else if
        (numberA == 2){
        Console.WriteLine("Tuesday");
        }
        else if
        (numberA == 3){
        Console.WriteLine("Wednesday");
        }
        else if
        (numberA == 4){
        Console.WriteLine("Thursday");
        }
        else if
        (numberA == 5){
        Console.WriteLine("Friday");
        }
        else if
        (numberA == 6){
        Console.WriteLine("Saturday");
        }
        else {
        Console.WriteLine("Sunday");    
        }
}
else{
    Console.WriteLine("Wrong number");
    }


