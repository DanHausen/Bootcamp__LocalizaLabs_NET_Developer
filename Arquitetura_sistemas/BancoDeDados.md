# Bancos de dados

É imporante que um banco de dados ofereça:
- Estruturação
- Durabilidade
- Velocidade
- Controle de Acesso
- Isolamento

## SGDB - Sistema Gerenciador de Banco de Dados

Possuem 3 pilares:
- Linguagem de definição. Que é a linguagem que define a estrutura dos dados
- Linguagem de manipulação. Que é como eu recupero ou altero estes dados.
- Dicionário de dados. Que é um banco de dados dentro do banco de dadso que guarda toda a estrutura.

Modelos de bancos de dados:
- Flat. São registros anotados em linhas. Como uma tabela tipo excel.
- Hierarquico. Para controle de informações, dividindo acesso de dados em forma hierarquico. É muito rápido para obter informações, mas pode conter redundancia e é dificil de se manter.
- Relacional. Conjunto de tabelas flat que se relacionam entre em si.
- Redes ou Grapho. 
- Orientado a objetos. Informação de objetos complexos inseridos no banco.
- Objeto-relacional. É a mistura do modelo relacional e do orientado a objetos.
- Big Data. Engloba modelo não estruturado, semi estruturado, estruturado. Grande massa de informação.

## Bancos de dados relacionais SGDBR ou RDBMS

As tabelas se relacionam através das chaves. 
Para iniciar a criação do banco relacional, são necessárias modelagens:
1. Modelo Conceitual MER - Modelo Entidade Relacionamento. Pode ser realizado através ro DER (Diagrama Entidade Relacionamento), o DER é um diagrama gráfico que utilizamos para representar as entidades, valores e relacionamentos, ele facilita nossa compreensão do comportamento do modelo.
2. Modelo lógico - implementação. 

Entidades:
- Fraca. Depende de outras entidades para existir (como uma venda que precisa de produto e cliente para acontecer)
- Forte. Não depende de nenhum outro dado para existir

Quantidades no relacionamento:
- 