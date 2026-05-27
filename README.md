CSharp-MusicAPI-Consumer-LINQ-Filter

Descrição do Projeto

Este repositório contém uma série de exercícios práticos em C# focados no consumo de uma API externa de músicas e no processamento desses dados utilizando LINQ (Language Integrated Query). O objetivo principal é demonstrar como integrar uma aplicação C# com serviços web, realizar requisições HTTP para obter dados de músicas, desserializar esses dados de formato JSON para objetos C# e aplicar filtros avançados para análise e exibição das informações.

Conceitos Abordados

Durante o desenvolvimento deste projeto, os seguintes conceitos de programação em C# e .NET são explorados:

•
Programação Orientada a Objetos (POO): Criação e utilização de classes (Musica, LinqFilter), propriedades e métodos.

•
Manipulação de JSON: Uso da biblioteca System.Text.Json para converter strings JSON (obtidas de uma API externa) em objetos C# e vice-versa, utilizando [JsonPropertyName] para mapeamento.

•
Comunicação em Rede: Realização de requisições HTTP assíncronas utilizando a classe HttpClient para interagir com APIs RESTful.

•
Programação Assíncrona: Aplicação de async e await para gerenciar operações de I/O de forma eficiente e não bloqueante, garantindo uma boa responsividade da aplicação.

•
LINQ (Language Integrated Query): Utilização de métodos de extensão LINQ (Select, Distinct, ToList, etc.) para consultar, filtrar e transformar coleções de dados de forma declarativa e eficiente.

•
Coleções: Utilização de listas genéricas (List<T>) para armazenar e manipular múltiplos objetos Musica.

•
Tratamento de Exceções: Implementação de blocos try-catch para garantir a robustez da aplicação e lidar com possíveis erros durante a execução, como falhas na requisição da API ou na desserialização de dados.

Estrutura do Projeto

O projeto é composto pelas seguintes classes principais:

•
Musica.cs: Define a estrutura de um objeto Musica com propriedades como NomeMusica, Artista, Genero e Duracao. Inclui atributos para mapeamento JSON ([JsonPropertyName]) e um método ExibirDetalhesDaMusica() para imprimir as informações no console.

•
LinqFilter.cs: Uma classe utilitária (estática ou com métodos estáticos) que encapsula a lógica de filtragem e manipulação de dados utilizando LINQ. Exemplo: FiltrarTodosOsGenerosMusicais().

•
Program.cs: Contém a lógica principal da aplicação, incluindo a instanciação do HttpClient, a realização da requisição à API de músicas, a desserialização da resposta JSON e a aplicação dos filtros LINQ para exibir os resultados.

Funcionalidades Principais

•
Consumo de API de Músicas: Realiza requisições HTTP para obter uma lista de músicas de uma fonte externa.

•
Desserialização JSON: Converte a resposta JSON da API em uma coleção de objetos Musica.

•
Filtragem por Gênero: Demonstra como extrair e listar todos os gêneros musicais únicos presentes na coleção de músicas utilizando LINQ (FiltrarTodosOsGenerosMusicais).

Como Rodar o Projeto

Para clonar e executar este projeto em sua máquina local, siga os passos abaixo:

1.
Clone o repositório:

Bash


git clone https://github.com/seu-usuario/CSharp-MusicAPI-Consumer-LINQ-Filter.git





2.
Navegue até o diretório do projeto:

Bash


cd CSharp-MusicAPI-Consumer-LINQ-Filter





3.
Restaure as dependências (se necessário ):

Bash


dotnet restore





4.
Execute a aplicação:

Bash


dotnet run





Evolução do Projeto

Este repositório será atualizado conforme o progresso das aulas, com novos exercícios, funcionalidades e filtros LINQ sendo adicionados. Sinta-se à vontade para acompanhar os commits e explorar as diferentes etapas de aprendizado.

