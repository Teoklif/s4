Console.Clear();
Console.Write("Write A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Write B:");
int b = Convert.ToInt32(Console.ReadLine());
double number = Math.Pow(a, b);
Console.WriteLine(a + "^" + b +"="+number);