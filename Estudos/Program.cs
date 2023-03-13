//Calculadora em português
Console.WriteLine("Digite um número: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a expressão utilizada: ");
char signal = char.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
float b = float.Parse(Console.ReadLine());
double c = 0;
if (signal == '+')
{
    c = a + b;
}
else if (signal == '-')
{
    c = a - b;
}
else if (signal == '*')
{
    c = a * b;
}
else if (signal == '/')
{
    c = a / b;
}
else if (signal == '^')
{
    c = Math.Pow(a, b);
}
else if (signal == '%')
{
    c = (a/100)*b;
}
Console.WriteLine("O resultado da expressão é: " + c);

