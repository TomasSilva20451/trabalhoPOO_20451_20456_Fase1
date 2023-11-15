/**
 * @file Program.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Programa principal para o projeto Autoprem
 * @version 0.1
 * @date 2023-11-13
 * 
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections.Generic;

namespace Autoprem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar listas para armazenar instâncias de veículos, componentes, funcionários e serviços
            List<Veiculo> veiculos = new List<Veiculo>();
            List<Componente> componentes = new List<Componente>();
            List<Funcionario> funcionarios = new List<Funcionario>();
            List<ServicoManutencao> servicos = new List<ServicoManutencao>();

            // Criar instâncias das classes
            Veiculo veiculo1 = new Veiculo(1, "Toyota", "Supra", 75000);
            Componente componente1 = new ComponenteConcreto(101, "Bateria", 100);
            Funcionario funcionario1 = new Funcionario(1001, "João Silva", "Mecânico");
            ServicoManutencao servico1 = new ServicoManutencao(10001, DateTime.Now.AddDays(1), "Carlos Oliveira", veiculo1, 150);

            // Adicionar instâncias às listas
            Veiculo.AdicionarVeiculo(veiculos, veiculo1);
            Componente.AdicionarComponente(componentes, componente1);
            Funcionario.AdicionarFuncionario(funcionarios, funcionario1);
            ServicoManutencao.AgendarServico(servicos, servico1);

            // Exibir informações das instâncias adicionadas
            Console.WriteLine("Informações do Veículo Adicionado:\n");
            Veiculo.ListarVeiculos(veiculos);

            Console.WriteLine("\nInformações do Componente Adicionado:\n");
            Componente.ListarComponentes(componentes);

            Console.WriteLine("\nInformações do Funcionário Adicionado:\n");
            Funcionario.ListarFuncionarios(funcionarios);

            Console.WriteLine("\nInformações do Serviço Agendado:\n");
            ServicoManutencao.ListarServicos(servicos);

            // Exemplo de utilização do Polimorfismo
            List<Veiculo> veiculosPolimorfismo = new List<Veiculo>();
            veiculosPolimorfismo.Add(new ManutencaoCarro(2, "Toyota", "Corolla", 25000.00m));
            veiculosPolimorfismo.Add(new ManutencaoMoto(3, "Honda", "CBR", 12000.00m));

            Console.WriteLine("\nExemplo de utilização do polimorfismo:\n");
            foreach (var veiculo in veiculosPolimorfismo)
            {
                veiculo.RealizarManutencao(); // Chama o método polimórfico
                Console.WriteLine();
            }

            Console.ReadLine(); // Aguardar antes de fechar o console
        }
    }
}
