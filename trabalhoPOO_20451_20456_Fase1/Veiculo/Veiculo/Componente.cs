/**
 * @file Componente.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe que representa um Componente
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections.Generic;

namespace Autoprem
{
	public class Componente
    {
        // Propriedades da classe Componente
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        // Construtor para criar instâncias de Componente
        public Componente(int id, string nome, decimal preco)
        {
            ID = id;
            Nome = nome;
            Preco = preco;
        }

        // Método para adicionar um novo componente
        public static void AdicionarComponente(List<Componente> componentes, Componente novoComponente)
        {
            // Verificar se o componente já existe com base no ID
            if (componentes.Any(c => c.ID == novoComponente.ID))
            {
                Console.WriteLine($"Já existe um componente com o ID {novoComponente.ID}. Não foi possível adicionar.");
            }
            else
            {
                // Adicionar o novo componente
                componentes.Add(novoComponente);
                Console.WriteLine("Componente adicionado com sucesso!");
            }
        }


        // Método para listar todos os componentes
        public static void ListarComponentes(List<Componente> componentes)
        {
            if (componentes.Count == 0)
            {
                Console.WriteLine("Nenhum componente encontrado!.");
            }
            else
            {
                Console.WriteLine("Lista de Componentes:");
                foreach (var componente in componentes)
                {
                    Console.WriteLine(componente);
                }
            }
        }

        // Sobrescrevendo o método ToString para formatar a exibição de um componente
        public override string ToString()
        {
            return $"ID: {ID}, Nome: {Nome}, Preço: {Preco:€}";
        }


    }
}

