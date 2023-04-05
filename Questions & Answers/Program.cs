using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> Input = new List<string>();
        List<List<string>> Output = new List<List<string>>();
        Console.WriteLine("Olá, converse comigo!");
        string UserInput;
        while(true)
        {
            Begin:
            Console.WriteLine("Digite algo: ");
            UserInput = Console.ReadLine();
            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i] == UserInput)
                {
                    Random random = new Random();
                    Console.WriteLine(Output[i][random.Next(Output[i].Count)]);
                    goto Begin;
                }
            }
            Console.WriteLine("Eu não sei como responder, como deveria?");
            string NewInput;
            NewInput = Console.ReadLine();
            if (NewInput != "")
            {
                List<string> NewAnswers = new List<string>();
                string[] responses = NewInput.Split('/');
                for(int i = 0; i < responses.Length; i++)
                {
                    NewAnswers.Add(responses[i]);
                }
                Input.Add(UserInput);
                Output.Add(NewAnswers);
                goto Begin;
            }
        }
    }
}

