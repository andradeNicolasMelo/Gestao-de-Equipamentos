using Gestao_de_Equipamentos.ConsoleApp1.ModuloChamado;
using Gestao_de_Equipamentos.ConsoleApp1.ModuloEquipamento;

namespace Gestao_de_Equipamentos.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaEquipamento telaEquipamento = new TelaEquipamento();
            TelaChamado telaChamado = new TelaChamado();
            Repositorio repositorio = new Repositorio();
            while (true)
            {
                Console.WriteLine("Você deseja verificar a tela de equipamentos ou de chamados? ");
                char telaEscolhida = Console.ReadLine()![0];

                if (telaEscolhida == '1')
                {
                    telaEquipamento.Cabecalho();
                    telaEquipamento.ExibirOpcoes();

                    switch (telaEquipamento.ObterOpcaoUsuario())
                    {
                        case '1':
                            telaEquipamento.Registrar();
                            break;

                        case '2':
                            telaEquipamento.Visualizar();
                            break;

                        case '3':
                            telaEquipamento.Editar();
                            break;

                        case '4':
                            telaEquipamento.Excluir();
                            break;
                    }
                }

                else if(telaEscolhida == '2')
                {
                    switch (telaEquipamento.ObterOpcaoUsuario())
                    {
                        case '1':
                            telaChamado.Registrar();
                            break;

                        case '2':
                            telaChamado.Visualizar();
                            break;

                        case '3':
                            telaChamado.Editar();
                            break;

                        case '4':
                            telaChamado.ExcluirChamado();
                            break;
                    }
                }
            }
        }
    }
}
