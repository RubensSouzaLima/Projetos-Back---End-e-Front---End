using static System.Console;
using static System.DateTime;

namespace String
{
    public class Pessoa
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Pessoa() {Matricula = 123, Nome = "Rubens", SobreNome = "Lima" };
            //WriteLine("Bem vindo " + p.Nome + " " + p.SobreNome + "(" + p.Matricula + "), este é o C#  6");
            //WriteLine(string.Format("Bem-Vindo {0} {1} {2}), este é o C# 6", p.Nome, p.SobreNome, p.Matricula));
            WriteLine($"Bem Vindo {p.Nome, 10} Guilherme {p.SobreNome, 10} ({p.Matricula}), este é o C# 6 ");
            WriteLine($"Olá, agora são {System.DateTime.Now.ToLongTimeString()}");
            ReadLine();
        }
    }
}
