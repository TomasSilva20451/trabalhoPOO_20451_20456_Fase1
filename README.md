# AUTOPREM - Software de Gestão Automóvel

Uma aplicação para a gestão de vendas de veículos, peças e serviços no setor automóvel.

O AUTOPREM é uma solução abrangente projetada para simplificar e melhorar a experiência no setor automóvel. Esta aplicação oferece aos clientes a capacidade de explorar, comprar e agendar serviços para veículos e peças. Ao mesmo tempo, proporciona aos funcionários um sistema eficiente para gerir informações, com ênfase na usabilidade e eficácia. O AUTOPREM promove uma experiência segura, oferecendo funcionalidades essenciais para clientes e funcionários.

## Instruções de Instalação

1. Clone o repositório para sua máquina local.
2. Certifique-se de ter o ambiente de desenvolvimento C# configurado.
3. Abra o projeto no Visual Studio ou na sua IDE preferida.
4. Compile e execute o projeto.

## Estrutura do Projeto

O projeto AUTOPREM possui a seguinte estrutura:

Program.cs: Ponto de entrada do aplicativo.

Veiculos:
**Veiculo.cs:** Classe para representar um veículo.

Componentes:
**Componente.cs:** Classe para representar um componente.
**ComponenteConcreto.cs:** Classe concreta que herda de Componente. Representa um componente específico.

Funcionarios:
**Funcionario.cs:** Classe para representar um funcionário.

Manutencoes:
**ManutencaoCarro.cs:** Classe para representar a manutenção de um carro.
**ManutencaoMoto.cs:** Classe para representar a manutenção de uma moto. 

Servicos:
**Servico.cs:** Classe base para representar um serviço genérico.
**ServicoManutencao.cs:** Classe para representar um serviço de manutenção.

## Obeservações

Encapsulamento: As classes foram projetadas com as propriedades e métodos encapsulados, garantindo controlo sobre o acesso aos dados internos.

Herança: A herança foi utilizada nas classes ManutencaoCarro e ManutencaoMoto, que herdam da classe Veiculo. Também foi utilizada na classe ServicoManutencao, que herda da classe base Servico.

Polimorfismo: O polimorfismo é evidenciado no uso de listas de veículos genéricas que podem conter instâncias de classes derivadas, como ManutencaoCarro e ManutencaoMoto. O método RealizarManutencao() é chamado de maneira polimórfica.

Abstração: A abstração é evidenciada na classe abstrata Componente, que define um método abstrato RealizarManutencao(), permitindo que as subclasses concretas forneçam implementações específicas.

## Dependências

- .NET Core 7.0

## Como Contribuir

1. Faça um fork do repositório.
2. Crie uma branch para suas alterações.
3. Faça commits explicativos.
4. Abra um pull request.

## Licença

Este projeto é licenciado sob a AUTOPREM. 

## Contato

Para dúvidas ou sugestões, entre em contato através do email: a20451@alunos.ipca.pt ou a20456@alunos.ipca.pt

