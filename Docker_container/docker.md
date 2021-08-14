# Docker

Escalonamento vertical é aumentar a disponibilidade de CPU e memória
Escalonamento horizontal é aumentar a disponibilidade de VMs e containers

## O que é o Docker?
É uma tecnologia de conteinerização que permite a criação e o uso de contêineres.

Possui um **container imagem** que é um pacote com todas as dependencias para criar o container (a aplicação)
**Dockerfile** é o arquivo de texto com todas as instruções para realizar o build na imagem
**Build** é a ação que cria uma imagem a partir do dockerfile 
Com a imagem criada, podemos instanciar o **container**, que é uma instancia da imagem que representa a execução de uma aplicação, processo ou serviço
**Volumes** permitem que o container armazene arquivos, armazene dados em disco, para persistencia do volume no caso da falha do container
**tag** é a forma de versionar as imagens
**Multi-stage Build** são varios estágios de build. Uma imagem compilando a outra.
**Repository** é uma coleção de imagens
**Registry** prove o acesso do docker ào repositório
**docker hub** é como o github para as imagens
**Compose** é uma ferramenta para criar diversos container com um simples comando  

## Como utilizar?
Para utilizar o docker sem instalar, como um playground, podemos acessar o site https://labs.play-with-docker.com/

## Principais comandos
- Docker Run. Usado para criar o container
- Docker Ps. Vai listar os containers
- Docker Info. Para mostrar informações do docker
- Docker images. São as imagens usadas para criar os container
- Docker Exec. Usa serve para executar um binario do container
- Docker Stop, Docker Start.
- Docker logs. Para listar os outputs e usuários
- Docker Inspect. Listar todas as configurações em utilização no container.
- Docker Pull
- Docker Commit
- Docker tag
- Docker login, Docker logout
- d