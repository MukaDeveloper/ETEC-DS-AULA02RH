using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args) //Método principal / o código começa a ser executado a partir daqui
        {
            Funcionarios func = new Funcionarios(); //cria-se um obj do tipo "Funcionarios" que vai ser chamado de "func" // o operador "new" é para criar uma ref do obj na memória do computador

            /*func.Id = 10;
            func.Nome = "Neymar";
            func.Cpf = "12345678910";
            func.DataAdmissao = DateTime.Parse("01/01/2000");
            func.Salario = 10000.00M; //M = força para que a tela entenda que trata-se de um decimal
            func.TipoFuncionario = Models.Enuns.TipoFuncionarioEnum.CLT;*/

            Console.WriteLine("Digite o Id do funcionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o Cpf: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de admissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de Funcionário (1 - CLT / 2 - Aprendiz): ");
            int opcao = int.Parse(Console.ReadLine());

            //Operador Ternário - Interpretação: Se a consição dos parênteses for verdadeira,
            //escolhe o que está depois da "?", caso contrário, escolhe o que está depois dos ":"
            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;

            func.ReajustarSalario();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            string periodoExperiencia = func.ExibirPeriodoExperiencia();

            bool onbool = true;
            do
            {
                Console.WriteLine("\n\nEscolha a informação que deseja exibir:\n1 - Id\n2 - Nome\n3 - Cpf\n4 - Data de Admissão\n5 - Salário\n6 - Tipo de contrato\n7 - Valor do desconto do VT\n8 - Período de experiência\n9 - Todas");
                int opt = int.Parse(Console.ReadLine());

                switch (opt)
                {
                    case 1:
                        Console.WriteLine($"Id: {func.Id}.\n");
                        onbool = false;
                        break;
                    case 2:
                        Console.WriteLine($"Nome: {func.Nome}.\n");
                        onbool = false;
                        break;
                    case 3:
                        Console.WriteLine($"Cpf: {func.Cpf}.\n");
                        onbool = false;
                        break;
                    case 4:
                        Console.WriteLine($"Data de admissão: {func.DataAdmissao}.\n");
                        onbool = false;
                        break;
                    case 5:
                        Console.WriteLine($"O salário reajustado é {func.Salario}.\n");
                        onbool = false;
                        break;
                    case 6:
                        Console.WriteLine($"Tipo de contrato: {func.TipoFuncionario}.\n");
                        onbool = false;
                        break;
                    case 7:
                        Console.WriteLine($"O Desconto do VT é {valorDescontoVT}.\n");
                        onbool = false;
                        break;
                    case 8:
                        Console.WriteLine($"{periodoExperiencia}");
                        onbool = false;
                        break;
                    case 9:
                        Console.WriteLine("==============================");
                        Console.WriteLine($"Id: {func.Id}.");
                        Console.WriteLine($"Nome: {func.Nome}.");
                        Console.WriteLine($"Cpf: {func.Cpf}.");
                        Console.WriteLine($"Data de admissão: {func.DataAdmissao}.");
                        Console.WriteLine($"O salário reajustado é {func.Salario}.");
                        Console.WriteLine($"Tipo de contrato: {func.TipoFuncionario}.");
                        Console.WriteLine($"O Desconto do VT é {valorDescontoVT}.");
                        Console.WriteLine($"{periodoExperiencia}");
                        Console.WriteLine("==============================");
                        onbool = false;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Escolha novamente.");
                        onbool = true;
                        break;
                }
            }
            while (onbool);
        }
    }
}
