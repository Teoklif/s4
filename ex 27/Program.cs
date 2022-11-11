Console.Clear();
Console.Write("Enter number:");

int num = int.Parse(Console.ReadLine()); 
Console.WriteLine(Sum(num));
int Sum(int number)
{int sum = 0;
for (int i = 10; i<number*10; i=10)
{
    sum += number%i;
    number=number/10;
   
    

}
return sum;
}
