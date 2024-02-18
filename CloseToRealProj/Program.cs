using System.Runtime.InteropServices;
using Newtonsoft.Json;

namespace CloseToRealProj
{
    internal class Program:Person
    {
        static void Main(string[] args)
        {
            
            List<Person> list = new List<Person>();
            Console.Write("How many Backend programmers do you wanna add: ");
            int Num = int.Parse(Console.ReadLine());
            for (int i = 0; i < Num; i++)
            {
                Console.Write($"{i + 1} - Programmer\nFirstname: "); string _FirstName = Console.ReadLine();
                Console.Write("Lastname: "); string _LastName = Console.ReadLine();
                Console.Write("Age: "); int _Age = int.Parse(Console.ReadLine());
                Programmer programmer = new(TypeOfProgrammers.Backend);
                programmer.SetInfo(_FirstName, _LastName, _Age);
                list.Add(programmer);
            }
            string OutPut = JsonConvert.SerializeObject(list);

            // Remove => ]
            OutPut = OutPut.Remove(0,1);
            OutPut = OutPut.Remove(OutPut.Length - 1);

            if (!File.Exists("d:/users.json")) File.Create("d:/users.json").Close();

            try
            {
                string Contain = File.ReadLines("d:/users.json").First();
                File.AppendAllText("d:/users.json", "," + OutPut);
            }
            catch
            {
                File.AppendAllText("d:/users.json", OutPut);
            }

            string RJs = $"[{File.ReadAllText("d:/users.json")}]";
            List<Person> people = JsonConvert.DeserializeObject<List<Person>>(RJs);
            foreach (var Out in people)
            {
                Console.WriteLine($"{Out.FirstName} {Out.LastName} - {Out.Age} yosh");
            }
            Console.ReadKey();
        }
    }
}
