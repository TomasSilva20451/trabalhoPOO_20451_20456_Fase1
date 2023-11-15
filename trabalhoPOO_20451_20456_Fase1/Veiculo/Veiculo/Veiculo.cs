/**
 * @file Veiculo.cs
 * @author Tomás (a20451@alunos.ipca.pt)
 * @author Telmo (a20456@alunos.ipca.pt)
 * @brief Classe que representa um Veículo
 * @version 0.1
 * @date 2023-11-14
 * 
 * @copyright Copyright (c) 2023
 */

using System;
using System.Collections.Generic;

namespace Autoprem
{
	public class Veiculo
	{
        /// <summary>
        /// No caso da remoção do set da propriedade ID,
        /// estamos encapsulando o acesso a esse atributo,
        /// permitindo que ele seja definido apenas dentro da própria classe.
        /// Isso ajuda a manter o estado consistente e a aplicar lógica específica,
        /// se necessário, ao modificar esse valor.
        /// Portanto, é uma prática sólida de encapsulamento.
        /// </summary>

        // Campo privado para ID
        private int id;

        // Propriedade pública somente leitura para ID
        public int ID
        {
            get { return id; }
        }

        // Propriedades públicas para acessar Marca, Modelo e Preco
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }

        // Construtor para criar instâncias de Veiculo
        public Veiculo(int id, string marca, string modelo, decimal preco)
        {
            this.id = id;
            Marca = marca;
            Modelo = modelo;
            Preco = preco;
        }

        // Método polimórfico para realizar manutenção
        public virtual void RealizarManutencao()
        {
            Console.WriteLine($"Realizando manutenção no veículo {Marca} {Modelo}");
            // Adicionar a lógica de manutenção específica para veículos
        }

        // Método para adicionar um novo veículo
        public static void AdicionarVeiculo(List<Veiculo> veiculos, Veiculo novoVeiculo)
        {
            // Verificar se o veículo já existe com base no ID
            if (veiculos.Any(v => v.ID == novoVeiculo.ID))
            {
                Console.WriteLine($"Já existe um veículo com o ID {novoVeiculo.ID}. Não foi possível adicionar.");
            }
            else
            {
                // Adicionar o novo veículo
                veiculos.Add(novoVeiculo);
                Console.WriteLine("Veículo adicionado com sucesso!");
            }
        }


        // Método para listar todos os veículos
        public static void ListarVeiculos(List<Veiculo> veiculos)
        {
            if (veiculos.Count == 0)
            {
                Console.WriteLine("Nenhum veículo encontrado!");
            }
            else
            {
                Console.WriteLine("Lista de Veículos:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
        }

        // Sobrescrevendo o método ToString para formatar a exibição de um veículo
        public override string ToString()
        {
            return $"ID: {ID}, Marca: {Marca}, Modelo: {Modelo}, Preço: {Preco:C}";
        }

    }
}

