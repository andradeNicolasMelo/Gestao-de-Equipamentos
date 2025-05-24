
namespace Gestao_de_Equipamentos.ConsoleApp1
{
    public class TelaUsuario
    {
        Repositorio repositorio = new Repositorio();

        public void Cabecalho()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Equipamentos");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
        }

        public void ExibirOpcoes()
        {
            Console.WriteLine("1 - Registrar item");
        }

        public char ObterOpcaoUsuario()
        {
            Console.Write("Qual opção você escolhe? ");
            return Console.ReadLine()![0];
        }

        public void Registrar()
        {
            Cabecalho();

            Console.WriteLine("Cadastro de Equipamento");

            Console.WriteLine();

            Equipamentos equipamento = ObterDados();

            repositorio.CadastrarEquipamento(equipamento);
        }

        public Equipamentos ObterDados()
        {
            Console.Write("Digite o nome do equipamento: ");
            string nome = Console.ReadLine()!;
            Console.WriteLine();

            Console.Write("Digite o preço de aquisição do equipamento: ");
            decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Digite o numero de série do equipamento: ");
            string numeroSerie = Console.ReadLine()!;
            Console.WriteLine();

            Console.Write("Digite a data de fabricação do equipamento: ");
            DateTime dataFabricacao = DateTime.Parse(Console.ReadLine()!);
            Console.WriteLine();

            Console.Write("Digite fabricante do equipamento: ");
            string fabrincante = Console.ReadLine()!;
            Console.WriteLine();

            Equipamentos equipamento = new Equipamentos();

            equipamento.nome = nome;
            equipamento.precoAquisicao = precoAquisicao;
            equipamento.serie = numeroSerie;
            equipamento.fabricante = fabrincante;
            equipamento.dataFabricacao = dataFabricacao;

            return equipamento;
        } 
    }
}
