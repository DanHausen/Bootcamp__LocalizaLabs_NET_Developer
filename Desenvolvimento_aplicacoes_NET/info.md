# Desenvolvimento de aplicações com .NET

## Entity framework

**O que é?**
É um ORM(Object Relational Mapper) que permite que os desenvolvedores de .NET trabalhem com um banco de dados usando objetos .NET

**Possui 3 linhas principais de utilização:**
- Database first. Serve para realizar engenharia reversa nos casos dos banco de dados relacionais que não são orientados a objetos, assim podemos reutilizar dentro do .NET
- Model first. Permite gerar o modelo do banco antes de gerar a base de dados. Essa montagem do modelo é feita através do EDM Designer, geralmnete usando os componentes Entity (classes e tabelas) e Association (relações)
- Code first. Aqui, primeiro criamos as classes de entidade (Classes POCO) e deixamos para o Entity Framework a responsabilidade de criar o banco de dados.

**Data annotations**
É um recurso que permite a alteração de convenção padrão e personalização de componentes, através da adição de atributos e métodos

### Migrations
É um recurso que oferece uma maneira de atualizar de forma incremental o esquema de banco de dados para manter em sincronia o modelo de classe do seu projeto, preservando os dados existentes no banco de dados. É possível manter histórico de alterações e através delas realizar o rollback ou commit.

## ASP .NET 
### MVC

MVC é um padrão de arquitetura que divide a aplicação em 3 camadas:
- Model. É a camada responsável pela leitura e escrita de dados, e também de suas validações.
- View. É a camada de interação com o usuário. Apenas faz a interação do usuário, seja por HTML ou por XML.
- Controller. É a camada responsável por receber todas as requisições e por controlar qual model e qual view será mostrado ao usuário.

O MVC traz o isolamento das regras de negócio da interface do usuário, o que permita que exista várias interfaces de usuários que podem ser modificadas sem afetar a regra do negócio.

As requisições do navegador são enviadas para uma ação da camada Controller, tirando a necessidade de cada URL possuir um arquivo físico.

Quando uma aplicação ASP .NET MVC é criada, já é configurado um padrão de rota default. Mas é possível criar padrões personalizados, que servem para maior flexibilidade, e assim é possível gerar URLs mais amigaveis para o usuário.

![image-20210818182515809](https://i.loli.net/2021/08/19/97fVwNsnTrEo2hL.png)

### Web forms
As requisições do navegador são enviadas para as páginas, que deveriam existir fisicamente. Cada URL deveria ter uma página física que a represente.

### Action Result
É o resultado de uma ação processada por uma controller, o action result possui diversos tipos.

### HTTP Verbs
São métodos de protocolo HTTP que informa ao servidor qual ação ele deve executar (GET, POST, PUT, DELETE)

### Razor
É uma View Engine utilizada no ASP .NET MVC.
Seu principal objetivo é simplificar o desenvolvimento de aplicações ASP .NET pois deixa o código mais simples, fácil e legível.

Benefícios:
- Menor curva de aprendizagem, por sem baseado em C#
- Por possuir uma sintaxe limpa, requer que o programador digite menos para chegar a um resultado
- E possui Intellisense no Visual Studio

### Middlewares
São componentes (classes) que são executado em todas as solicitações na aplicação ASP .NET
Normalmente existem vários middlewares na aplicação e nós definimos sua ordem de execução.
Cada middleware adiciona 

![image-20210818182940419](https://i.loli.net/2021/08/19/RsqGbM6aoOcl1AV.png)



### Startup.cs

Essa classe é responsável por ser o ponto inicial do projeto. Dentro dessa classe existem métodos que são responsáveis por configurar o projeto:

- ConfigureServices. Esse método é responsável por registrar as classes ao container de dependência, após isso a classe poderá ser usada em qualquer local da aplicação desde que seja incluída no construtor da classe em que desejo utilizar.
- Configure. Esse método controla o pipeline da aplicação, é nesse métodos que são especificados os middlewares a serem utilizados. É recomendado especificar apenas os métodos que serão utilizados para evitar queda na performance.

