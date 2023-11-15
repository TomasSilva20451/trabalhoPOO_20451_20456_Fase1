/**
 * @file Servico.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe base que representa um Serviço
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */

using System;

namespace Autoprem
{
    public class Servico
    {
        // Propriedades da classe base Servico
        public int ID { get; set; }
        public DateTime DataAgendamento { get; set; }
        public string Cliente { get; set; }
        public decimal Custo { get; set; }

        // Construtor para criar instâncias de Servico
        public Servico(int id, DateTime dataAgendamento, string cliente, decimal custo)
        {
            ID = id;
            DataAgendamento = dataAgendamento;
            Cliente = cliente;
            Custo = custo;
        }

        // Sobrescrevendo o método ToString para formatar a exibição de um serviço
        public override string ToString()
        {
            return $"ID: {ID}, Data de Agendamento: {DataAgendamento}, Cliente: {Cliente}, Custo: {Custo:C}";
        }
    }
}
