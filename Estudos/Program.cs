//Calculadora em português
//Início
//Escreve e determina a variável a partir do que é digitado
Console.WriteLine("Digite um número: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a expressão utilizada: ");
char signal = char.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
float b = float.Parse(Console.ReadLine());
// Determina o resultado a partir da operação realizada
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
//Escreve o resultado
Console.WriteLine("O resultado da expressão é: " + c);
//Final

