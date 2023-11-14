/**
 * @file Funcionario.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe que representa um Funcionário
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections.Generic;

namespace Autoprem
{
	public class Funcionario
	{
        // Propriedades da classe Funcionario
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cargo { get; set; }

        // Construtor para criar instâncias de Funcionario
        public Funcionario(int id, string nome, string cargo)
        {
            ID = id;
            Nome = nome;
            Cargo = cargo;
        }

        // Método para adicionar um novo funcionário
        public static void AdicionarFuncionario(List<Funcionario> funcionarios, Funcionario novoFuncionario)
        {
            // Verificar se o funcionário já existe com base no ID
            if (funcionarios.Any(f => f.ID == novoFuncionario.ID))
            {
                Console.WriteLine($"Já existe um funcionário com o ID {novoFuncionario.ID}. Não foi possível adicionar.");
            }
            else
            {
                // Adicionar o novo funcionário
                funcionarios.Add(novoFuncionario);
                Console.WriteLine("Funcionário adicionado com sucesso!");
            }
        }


        // Método para listar todos os funcionários
        public static void ListarFuncionarios(List<Funcionario> funcionarios)
        {
            if (funcionarios.Count == 0)
            {
                Console.WriteLine("Nenhum funcionário encontrado.");
            }
            else
            {
                Console.WriteLine("Lista de Funcionários:");
                foreach (var funcionario in funcionarios)
                {
                    Console.WriteLine(funcionario);
                }
            }
        }

        // Sobrescrevendo o método ToString para formatar a exibição de um funcionário
        public override string ToString()
        {
            return $"ID: {ID}, Nome: {Nome}, Cargo: {Cargo}";
        }

    }
}

