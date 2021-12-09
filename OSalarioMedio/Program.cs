using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSalarioMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();
            decimal salarioMedio = 0;

            Console.WriteLine("Média de salários.");
            Console.WriteLine("Dados do primeiro funcionário:");
            funcionario1 = funcionario1.LerDados();

            Console.WriteLine("Dados do segundo funcionário:");
            funcionario2 = funcionario2.LerDados();

            salarioMedio = ((funcionario1.Salario + funcionario2.Salario) / 2);

            Console.WriteLine("Salário médio: " + salarioMedio.ToString());
            Console.Read();

        }
    }
}
