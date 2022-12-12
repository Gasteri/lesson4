/* int Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(5));*/

/*int Factorial(int n)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}*/


double Factorial(int n) //тип double помогает от переполнения ячеек! пропадают отрицательные числа!27! = 1,0888869450418352E+28 +28(10 в 28-й степени)
{
    if(n == 1) return 1;
    else return n * Factorial(n - 1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}