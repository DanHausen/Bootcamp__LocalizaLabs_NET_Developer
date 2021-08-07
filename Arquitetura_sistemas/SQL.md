# SQL

## Pilares do SQL

### DDL - Data Definition Language

É a linguagem de manipulacao do dicionario, é o mecanismo utilizado para criar e definir todos os objetos e entidades criados dentro do banco (criar tabela, deletar tabela). Não é relacionado com os dados em si.

### DML - Data Manipulation Language

É responsavel pela manipulacao dos dados (incluir, alterar e remover), ou seja, podemos transformar as informações nas entidades

### DQL - Data Query Language

É a linguagem de consulta aos dados (extração e exibição)

## Transações

É o conceito de diversos usuarios podem realizar diversas consultas, atémesmo do mesmo dado, ao mesmo tempo.
O principal foco é controlar as transações de INSERT, DELETE e UPDATE.
Assim como no git, é necessário realizar o commit (ou rollback) das transações para que sejam atualizadas no banco e assim outros usuarios possam acessar as atualizações.

### Conceito ACID para transações

**Atomicidade**. O sistema precisa garantir que todas as operações sejam realizadas com sucesso, precisa garantir que todas as ações possuem um fim (commit ou rollback)
**Consistencia**. Osistema precisa garantir a policidade das chaves, restrições lógicas e outros aspectos que controlem as caracteristicas do nosso modelo. Não podemos infringir regras que foram aplicadas.
**Isolamento**. Diz que as varias transações podem acontecer simultaneamente e o banco deve garantir que cada operação deve ser respeitada em sua ordem de requisição.
**Durabilidade**. Diz que depois de aplicado o commit as alterações precisam ser aplicadas, apesar de queda de energia ou outros eventos. Geralmente os commits são salvos em um log de backup para sempre ter o historico.