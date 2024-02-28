using Aula02RH.Models;
using Aula02RH.Models.Enuns;

namespace Aula02RH
{
    class Program
    {
        static TipoFuncionarioEnum verificarOpcao() {
            Console.WriteLine("\nEscolha o Tipo de Contrato (1 ou 2):\n1 - CLT\n2 - Aprendiz");
            int opcao = int.Parse(Console.ReadLine());
            TipoFuncionarioEnum enumeracao = (opcao == 1) ? TipoFuncionarioEnum.CLT : (opcao == 2) ? TipoFuncionarioEnum.Aprendiz : TipoFuncionarioEnum.Invalido;
            if(enumeracao == TipoFuncionarioEnum.Invalido) {
                Console.WriteLine("\nOpção inválida, tente novamente:");
                return verificarOpcao();
            }
            return enumeracao;
        }

        static void Main(string[] args)
        {
            bool validOpt = false;
            Funcionarios func = new Funcionarios();

            Console.WriteLine("\nDigite o ID do fucionário: ");
            func.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o nome do funcionário: ");
            func.Nome = Console.ReadLine();
            
            Console.WriteLine("\nDigite o CPF: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("\nDigite a data de Admissão (dd/mm/yyyy): ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Salário: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            func.TipoFuncionario = verificarOpcao();
            func.ReajustarSalario();
            func.ValorReajustadoSalario();
            decimal valorDescontoVT = func.CalcularDescontoVR(6);

            Console.WriteLine("\n==========================================");
            Console.WriteLine($"O desconto do VT em folha é R$ {valorDescontoVT}.");
            Console.WriteLine($"O salário reajustado em 10% é R$ {func.Salario}.");
            Console.WriteLine($"O valor do reajuste é {func.Reajuste}");
            Console.WriteLine("==========================================\n");

            Console.WriteLine("Registro efetuado com sucesso. Qual(is) informação(ões) deseja exibir?\n1 - ID\n2 - Nome\n3 - CPF\n4 - Data de Admissão\n5 - Salário\n6 - Tipo de contrato\n7 - Todas as opções\n8 - Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha) {
                case 1:
                    //FINALIZAR
                    break;
            }
        }
    }
}
