Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Sum(int a){

    int sum = 0;
    while(a > 0)
    {
       sum = sum + a % 10;
       a = a / 10;    
    }
    return sum;
}
int result = Sum(a);
Console.WriteLine(result);

