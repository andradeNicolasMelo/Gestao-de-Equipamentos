﻿namespace Gestao_de_Equipamentos.ConsoleApp1.ModuloEquipamento
{
    public class Repositorio
    {
        Equipamentos[] historicoDeRegistros = new Equipamentos[101];
        public int indiceHistorico = 0;
        public int id = 0;

        public void CadastrarEquipamento(Equipamentos dadosObtidos)
        {
            dadosObtidos.id = indiceHistorico;
            historicoDeRegistros[indiceHistorico] = dadosObtidos;

            indiceHistorico++;
            id++;
        }

        public void VisualizarEquipamentos()
        {

            for (int i = 0; i < historicoDeRegistros.Length; i++)
            {

                Equipamentos e = historicoDeRegistros[i];

                if (e == null)
                    continue;

                Console.WriteLine(
                "{0, -3} | {1, -20} | {2, -15} | {3, -15} | {4, -20} | {5, -15}",
                e.id, e.nome, e.precoAquisicao.ToString("C2"), e.serie, e.fabricante, e.dataFabricacao.ToShortTimeString()
                );
            }
            Console.ReadLine();
        }

        public void EditarRegistro(int novoRegistro)
        {
            for (int i = 0; i < historicoDeRegistros.Length; i++)
            {
                TelaEquipamento telaUsuario = new TelaEquipamento();
                Equipamentos e = historicoDeRegistros[i];

                if (e == null)
                    continue;

                if(novoRegistro == e.id)
                {
                    historicoDeRegistros[i] = telaUsuario.ObterDados();
                }
            }
        }

        public void ExcluirRegistro(int idParaExclusao)
        {
            for(int i = 0; i < historicoDeRegistros.Length; i++)
            {
                Equipamentos e = historicoDeRegistros[i];
                if (e == null)
                    continue;
                if (idParaExclusao == e.id)
                {
                    historicoDeRegistros[i] = null;
                    Console.WriteLine("Equipamento excluído com sucesso!");
                    Console.ReadLine();
                    return;
                }
            }
        }
    }
}
