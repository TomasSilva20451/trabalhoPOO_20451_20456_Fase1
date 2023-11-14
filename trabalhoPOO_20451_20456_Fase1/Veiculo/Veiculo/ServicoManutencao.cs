/**
 * @file ServicoManutencao.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe que representa um Serviço de Manutenção
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections.Generic;

namespace Autoprem
{
	public class ServicoManutencao
	{
        // Propriedades da classe ServicoManutencao
        public int ID { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
        public decimal Custo { get; set; }

        // Construtor para criar instâncias de ServicoManutencao
        public ServicoManutencao(int id, DateTime dataAgendamento, string cliente, Veiculo veiculo, decimal custo)
        {
            ID = id;
            DataAgendamento = dataAgendamento;
            Cliente = cliente;
            Veiculo = veiculo;
            Custo = custo;
        }

        // Método para agendar um novo serviço de manutenção
        public static void AgendarServico(List<ServicoManutencao> servicos, ServicoManutencao novoServico)
        {
            // Verificar se o serviço já existe com base no ID
            if (servicos.Any(s => s.ID == novoServico.ID))
            {
                Console.WriteLine($"Já existe um serviço com o ID {novoServico.ID}. Não foi possível agendar.");
            }
            else
            {
                // Adicionar o novo serviço
                servicos.Add(novoServico);
                Console.WriteLine("Serviço agendado com sucesso!");
            }
        }

        // Método para listar todos os serviços agendados
        public static void ListarServicos(List<ServicoManutencao> servicos)
        {
            if (servicos.Count == 0)
            {
                Console.WriteLine("Nenhum serviço agendado.");
            }
            else
            {
                Console.WriteLine("Lista de Serviços Agendados:");
                foreach (var servico in servicos)
                {
                    Console.WriteLine(servico);
                }
            }
        }

        // Sobrescrevendo o método ToString para formatar a exibição de um serviço de manutenção
        public override string ToString()
        {
            return $"ID: {ID}, Data de Agendamento: {DataAgendamento}, Cliente: {Cliente}, Veículo: {Veiculo.Marca} {Veiculo.Modelo}, Custo: {Custo:C}";
        }

    }
}

