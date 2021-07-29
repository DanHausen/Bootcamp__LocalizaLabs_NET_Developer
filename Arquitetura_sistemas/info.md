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