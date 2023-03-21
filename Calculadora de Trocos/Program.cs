using System;
class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo keyInfo;
        float result = 0;
        bool final = false;
        float finalresult = 0;
        do
        {
            Console.WriteLine("Total a pagar: " + result);
            Console.WriteLine("Aperte S para adicionar mais produtos ou qualquer outra tecla para finalizar");

            keyInfo = Console.ReadKey(true);
            if (keyInfo.KeyChar == 'S' || keyInfo.KeyChar == 's')
            {
                Console.WriteLine("Digite o valor do produto: ");
                float a = float.Parse(Console.ReadLine());
                result += a;
            }
            else
            {
                final = true;
            }
                
        }
        while (!final);
        Console.WriteLine("Total a pagar: " + result);

        Console.WriteLine("Valor pago pelo cliente: ");
        float val = float.Parse(Console.ReadLine());
        finalresult = val - result;
        
        if (finalresult >= 0)
        {
            Console.WriteLine("O troco vai ser igual a: R$" + finalresult);
        }
        else
        {
            Console.WriteLine("O cliente falta pagar R$" + (finalresult*-1));
        }
    }
}
