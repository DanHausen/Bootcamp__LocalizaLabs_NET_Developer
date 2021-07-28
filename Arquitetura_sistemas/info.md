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

