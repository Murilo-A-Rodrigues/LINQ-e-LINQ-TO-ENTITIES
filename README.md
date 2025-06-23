# Projetos: LINQ e LINQ_TO_ENTITIES

Este repositório contém dois projetos em C# para estudo e prática de LINQ e Entity Framework Core com SQLite:

- **LINQ:** Demonstra operações LINQ em memória.
- **LINQ_TO_ENTITIES:** CRUD de alunos usando Entity Framework Core e SQLite.

---

## LINQ

### Descrição

Projeto de console simples para praticar consultas LINQ em coleções em memória (listas, arrays, etc). Ideal para aprender e testar filtros, projeções, ordenações e agrupamentos usando LINQ.

### Estrutura

```
LINQ/
├── LINQ.sln
└── LINQ.Console/
    ├── LINQ.Console.csproj
    └── Program.cs
```

### Como Executar

1. Acesse a pasta do projeto:
   ```sh
   cd LINQ/LINQ.Console
   ```
2. Execute:
   ```sh
   dotnet run
   ```

---

## LINQ_TO_ENTITIES

### Descrição

Aplicação de console para cadastro, listagem, atualização e remoção de alunos, utilizando Entity Framework Core com SQLite. O banco de dados é criado automaticamente.

### Estrutura

```
LINQ_TO_ENTITIES/
├── escola.db
├── LINQ_TO_ENTITIES.sln
├── LINQ_TO_ENTITIES.Console/
│   ├── LINQ_TO_ENTITIES.Console.csproj
│   └── Program.cs
└── LINQ_TO_ENTITIES.Model/
    ├── LINQ_TO_ENTITIES.Model.csproj
    ├── Alunos.cs
    ├── EscolaContext.cs
    └── Migrations/
```

### Como Executar

1. Acesse a pasta do projeto:
   ```sh
   cd LINQ_TO_ENTITIES/LINQ_TO_ENTITIES.Console
   ```
2. Execute:
   ```sh
   dotnet run
   ```

Se for o primeiro uso, gere e aplique as migrations para criar o banco:
```sh
dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate --project ../LINQ_TO_ENTITIES.Model --startup-project . --context EscolaContext
dotnet ef database update --project ../LINQ_TO_ENTITIES.Model --startup-project . --context EscolaContext
```

### Funcionalidades

- **Cadastrar aluno:** Insere um novo aluno com nome e nota.
- **Listar alunos:** Exibe todos os alunos cadastrados.
- **Atualizar nota:** Permite alterar a nota de um aluno existente.
- **Remover aluno:** Remove um aluno pelo nome.

---

## Créditos

Este projeto foi desenvolvido por Murilo Andre Rodrigues e por Pablo Emanuel Cechim de Lima como parte da disciplina de Programação Orientada a Objetos.
---

> Projeto acadêmico para fins de estudo. Sinta-se livre para contribuir ou adaptar!
