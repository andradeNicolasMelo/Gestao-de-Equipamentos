using Gestao_de_Equipamentos.ConsoleApp1.ModuloEquipamento;

namespace Gestao_de_Equipamentos.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaUsuario = new TelaEquipamento();
            Repositorio repositorio = new Repositorio();
            while (true)
            {
                Console.WriteLine("Você deseja verificar a tela de equipamentos ou de chamados? ");
                char telaEscolhida = Console.ReadLine()![0];

                if (telaEscolhida == '1')
                {
                    telaUsuario.Cabecalho();
                    telaUsuario.ExibirOpcoes();

                    switch (telaUsuario.ObterOpcaoUsuario())
                    {
                        case '1':
                            telaUsuario.Registrar();
                            break;

                        case '2':
                            telaUsuario.Visualizar();
                            break;

                        case '3':
                            telaUsuario.Editar();
                            break;

                        case '4':
                            telaUsuario.Excluir();
                            break;
                    }
                }

                else if(telaEscolhida == '2')
                {

                }
            }
        }
    }
}
