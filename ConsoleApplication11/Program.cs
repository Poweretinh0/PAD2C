using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Empregados
    {
        public string PrimeiroNome;
        public string Sobrenome;
        public double Salario;

        public string ReceberNome(){
            return PrimeiroNome + Sobrenome;
        }   

        public double ReceberSalario(){
            return Salario;
        }

        public void AumentarOSalario(){
            Salario = Salario + Salario * 0.10;
        }
    }
}
