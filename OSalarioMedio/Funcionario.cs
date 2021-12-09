using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSalarioMedio
{
    class Funcionario
    {
        public string Nome { get; set; }
        public decimal Salario { get; set; }

        public Funcionario LerDados()
        {
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Nome:");
            funcionario.Nome = Console.ReadLine();
            Console.WriteLine("Salario:");
            funcionario.Salario = int.Parse(Console.ReadLine());

            return funcionario;
        }
    }
}
