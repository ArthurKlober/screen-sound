# 🎵 ScreenSound - C#

Projeto desenvolvido durante o curso **"C#: aplicando a Orientação a Objetos"**, com o objetivo de aplicar conceitos de **Programação Orientada a Objetos (POO)** utilizando C#.

O projeto simula uma aplicação de gerenciamento musical, permitindo criar músicas, organizar músicas dentro de álbuns e exibir informações detalhadas utilizando classes, propriedades e métodos.

> 🚧 **Projeto em desenvolvimento**
>
> Este projeto ainda não está finalizado. Novas funcionalidades, melhorias na estrutura do código e novos conceitos de orientação a objetos serão adicionados conforme o avanço dos estudos.

## 📌 Sobre o projeto

O ScreenSound foi desenvolvido para praticar a criação de modelos utilizando orientação a objetos, aplicando conceitos como:

- Criação de classes;
- Instanciação de objetos;
- Encapsulamento de atributos;
- Propriedades calculadas;
- Métodos de comportamento;
- Associação entre objetos.

---

## 🎯 Funcionalidades desenvolvidas

A aplicação permite:

- Criar músicas com informações como:
  - Nome;
  - Artista;
  - Duração;
  - Disponibilidade.

- Criar álbuns contendo uma lista de músicas;
- Adicionar músicas a um álbum;
- Exibir a ficha técnica de uma música;
- Exibir todas as músicas pertencentes a um álbum;
- Calcular automaticamente a duração total do álbum.

---

## 🏗️ Estrutura do projeto

O projeto possui as seguintes entidades principais:

### 🎼 Classe `Musica`

Representa uma música dentro do sistema.

Possui informações como:

- Nome da música;
- Artista;
- Duração em segundos;
- Disponibilidade.

Também possui propriedades responsáveis por:

- Converter a duração total da música para o formato **minutos:segundos**;
- Exibir uma descrição resumida da música.

Além disso, conta com o método `ExibirFichaTecnica()`, responsável por apresentar os detalhes da música no console.

---

### 💿 Classe `Album`

Representa um álbum musical contendo uma coleção de músicas.

Possui funcionalidades como:

- Armazenar uma lista de músicas;
- Adicionar novas músicas ao álbum;
- Calcular a duração total das músicas;
- Exibir todas as músicas cadastradas no álbum.

A duração total do álbum é calculada automaticamente através da soma das durações individuais de cada música.
