Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int Pow(int A, int B){

    int pow = A;

    for(int i = 1; i < B; i++){
        pow*= A;
    }
    return pow;

}
int result = Pow(A, B);
Console.WriteLine(result);
