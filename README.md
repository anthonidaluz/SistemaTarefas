# Sistema de Tarefas - API
<img width="1920" height="929" alt="chrome_lsEWUeOUds" src="https://github.com/user-attachments/assets/2e6f2379-c710-4e08-8c63-45eb0da9d112" />

Uma API RESTful desenvolvida em **ASP.NET Core** para o gerenciamento de tarefas, usuários e busca de CEP.

## Sobre o Projeto

Este projeto tem como objetivo fornecer um back-end robusto para controle de tarefas. Ele aplica conceitos de segurança com **autenticação JWT** e consome APIs externas, organizando o acesso a dados de forma desacoplada através do padrão **Repository**.

## Principais Funcionalidades

- **Gerenciamento de Usuários:** Cadastro, listagem, atualização e exclusão de usuários.
- **Gerenciamento de Tarefas:** Criação de tarefas vinculadas a usuários específicos, com acompanhamento de status.
- **Autenticação e Segurança:** Login seguro utilizando **JWT**, protegendo as rotas privadas da API.
- **Integração Externa (ViaCEP):** Consulta automática de endereços utilizando o CEP informado pelo usuário.
- **Documentação Interativa:** Swagger/OpenAPI configurado para visualizar e testar os endpoints da API.
- **Repository Pattern:** Separação das responsabilidades relacionadas ao acesso aos dados.

## Tecnologias Utilizadas

- C#
- .NET 8
- ASP.NET Core
- Entity Framework Core
- SQL Server
- JWT (JSON Web Tokens)
- Swagger / OpenAPI
- Refit
- Repository Pattern

## Estrutura do Projeto

```text
SistemaTarefas/
│
├── Controllers/
│   ├── UsuarioController.cs
│   └── TarefaController.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Integrations/
│   └── ViaCep/
│
├── Repositories/
│   ├── UsuarioRepository.cs
│   └── TarefaRepository.cs
│
├── Models/
│   ├── Usuario.cs
│   └── Tarefa.cs
│
├── Migrations/
│
├── appsettings.json
├── Program.cs
└── SistemaTarefas.csproj
