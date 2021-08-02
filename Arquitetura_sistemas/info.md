https://web.digitalinnovation.one/course/fundamentos-da-arquitetura-de-sistemas/learning/bd1cf015-6d40-4e38-a409-636ba6a9cb98?back=/track/localizalabs-net-developer

# Fundamentos de arquiteturas de sistemas

## O que são Web Services?

São soluções para aplicações se comunicarem independente de linguagem, software e hardware utilizados.
Inicialmnete serviços web foram criados para trocar mensagens utilizando XML sobre o HTTP.
Podemos dizer que são APIs que se comunicam por rede sobre o protocolo HTTP. Todo serviço web é uma API, mas nem toda API é um serviço web.
As linguagens de marcação mais usadas para troca de mensagens através do webservice são: XML (SOAP) e JSON (REST).

Quais são as vantagens:
- Linguagem comum
- Integração
- Reutilização de implementação
- Segurança
- Custos


## Estrutua SOAP

**O que é?**
SOAP - Simple Object Access Protocol. É um protocolo de acesso aos objetos simples, que são os XMLs.
É um protocolo baseado em XML para acessar web services principalmente por HTTP.
É uma definição de como web services se comunicam e foi desenvolvido para facilitar integrações entre aplicações.

**Quais são as vantagens?**
Permite integrações entre aplicações, independente de linguagem, pois utiliza o XML como linguagem comum.
É independente de plataforma e software.
É um meio de transporte genérico, ou seja, pode ser usado por outros protocolos além do HTTP.

**O que é XML?**
XML - Extensible Markup Language. É uma lingaugem de marcação criada na década de 90 pela W3C, que é uma orgabização de padrões da WorldWideWeb.
Desenvolvida para facilitar a separação de conteúdo, pois utiliza tags.
Não possui limitação para criação de tags.

**Qual a estrutura de uma mensagem SOAP?**
O "SOAP message" possui uma estrutura única que sempre deve ser seguida:
- SOAP Envelope. É o pai, todo o conteúdo vai dentro dele. É o primeiro elemento do documento, e é utilizado para encapsular toda a mensagem SOAP.
- SOAP Header. É o elemento onde possui informações de atributos e metadados da requisição.
- SOAP Body. É o elemento que contém os detalhes da mensagem, os atributos são passados aqui.

## WSDL e XSD

**WSDL - Web Services Description Language**
WSDL é usado para descrever Web Services, funciona como um contrato do serviço.
A descrição é feita em um documento XML, onde é descrito o serviço, especificações de acesso, operações e métodos.

**XSD - XML Schema Definition**
É um Schema no formato XML usado para definir a estrutura de dados  que será validada no XML
O XSD funciona como uma documentação de como deve ser montado o SOAP Message que será enviado através do  Web Service

## REST, API e JSON

**REST - Representational State Transfer**
A ideia é trabalhar com o estado atual do objeto, não como ele foi nem como estará.
É um estilo de arquitetura de software que define a implementação de um serviço web
Podem trabalhar ocm formatos XML, JSON, e outros.

Quais são as vantagens do REST?
- Permite integrações entre aplicações e também entre cliente e servidor em páginas web e aplicações
- Utiliza dos métodos HTTP para definir a operação que está sendo efetuada.
- Arquitetura de fácil compreensão

**API - Application Programming Interface**
São conjuntos de rotinas documentados e disponibilizados por uma aplicação para que outras aplicações possam consumir suas funcionalidades. Empresas de tecnologias disponibilizam APIs para acessos de suas funcionalidades.

Principais métodos HTTP:
- GET - Solicita a representação de um recurso
- POST - Solicita a criação de um recurso
- DELETE - Solicita a exclusão de um recurso
- PUT - Solicita a atualização de um recurso

**JSON - JavaScript Object Notation**
Formatação leve utilizada para troca de mensagens entre sistemas. É um dos formatos mais populares e utilizados que funciona além do JavaScript.

## REST e HTTP na prática
https://developer.mozilla.org/en-US/docs/Web/HTTP/Status

Código de estado
É utilizado pelo servidor para avisar o cliente sobre o estado da operação solicitada:
- 1xx - Informativo
- 2xx - Sucesso
- 3xx - Redirecionamento
- 4xx - Erro do Cliente
- 5xx - Erro do servidor

# Arquiteturas de Sistemas

Tipos de arquitetura:
- Monolito. É uma unica aplicação que tem acesso aos diversos sistemas. É mais simples.
- Microserviços #1. Teremos um serviço para cada aplicação, é diferente do monolito.
- Microserviços #2. Temos agora um message broker e toda comunicação entre os serviços passa por ele, isso gera mais segurança para não perder a mensagem e também deixa mais fácil substituir os serviços.
- Microserviços #3. Estilo pipeline. O proxy passa o request de serviço para o gerenciador de pipeline, e não mais diretamente ao serviço. Aqui, cada serviço possui uma responsabilidae bem específica.

### Monolito

Prós:
- Baixa complexidade
- Monitoriamente simplificado

Contras:
- Stack única
- Compartilhamento de recursus
- Acoplamento
- Mais complexo a escalabilidade

### Microserviços 1

Prós:
- Stack dinâmica
- Simples escalabilidade

Contras:
- Acoplamento
- Monitoramento mais complexo
- Provisionamento mais complexo

### Microserviços 2

Prós:
- Stack dinâmica
- Simples escalabilidade
- Desacoplamento

Contras:
- Monitoramento mais complexo
- Provisionamento mais complexo

### Microserviços 3

Prós:
- Stack dinâmica
- Simples escalabilidade
- Desacoplamento
- Menor complexidade

Contras:
- Provisionamento mais complexo
- Plataforma inteira depende do gerenciador de pipeline

## Gerenciamento de errors e volume de acesso

É algo que todas as arquiteturas possuem em comum.

Onde é mais complexo:
- Processos assíncronos (microserviços #2)
- Pipeline

Solução:
- Dead letter queue
- Filas de re-tentativas