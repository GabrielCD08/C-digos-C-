class Program
{
    static void Main(string[] args)
    {
        int var = 1;
        ConsoleKeyInfo keyInfo;
        Dictionary<string, string> emails = new Dictionary<string, string>();
        emails.Add("usuario", "senha");
        inicio:
        Console.WriteLine("Se já tiver uma conta pressione S, se não, pressione N");
        keyInfo = Console.ReadKey();
        if (keyInfo.Key == ConsoleKey.S)
        {
            var = 2;
        }
        else if (keyInfo.Key == ConsoleKey.N)
        {
            var = 3;
        }
        if (var == 2)
        {
            Console.WriteLine(" Digite seu nome de usuário: ");
            string Email = Console.ReadLine();
            Console.WriteLine(" Digite sua senha: ");
            string Password = Console.ReadLine();
            if (emails.ContainsKey(Email) && emails[Email] == Password)
            {
                Console.WriteLine("Login bem sucedido!");
            }
            else
            {
            Console.WriteLine("Usuário ou senha são inválidos");
            }
            Console.Readkey();
        }
        else if (var == 3)
        {
            Console.WriteLine(" Digite um nome de usuário: ");
            string EmailN = Console.ReadLine();
            Console.WriteLine(" Digite uma senha: ");
            string PasswordN = Console.ReadLine();
            if (emails.ContainsKey(EmailN))
            {
                Console.WriteLine("Esse nome de usuario já é existente");
            }
            else 
            {
                emails.Add(EmailN, PasswordN);
                Console.WriteLine("Conta criada com sucesso!");
            }
            Console.WriteLine("Aperte qualquer tecla para fazer o login");
            Console.ReadKey();
            var = 2;
            goto inicio;
        }
    }
}
