// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + false(n - 2)

/*int Fibonachi(int n)
{
    if(n ==1 || n== 2) return 1;
    else return Fibonachi(n-1) + Fibonachi(n-2);
}

for(int i = 1; i < 15; i++)
{
    Console.WriteLine(Fibonachi(i));
}*/

double Fibonachi(int n)
{
    if(n ==1 || n== 2) return 1;
    else return Fibonachi(n-1) + Fibonachi(n-2);
}

for(int i = 1; i < 60; i++)
{
    Console.WriteLine(Fibonachi(i));
}
