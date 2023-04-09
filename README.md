# PW26S-Seminario

[Academic Work] [C#] - Basic CRUD

---

Tecnologias:

- ASP .NET
- C#
- Swagger (Documentação)
- SqlServer

---

Models:

- Users
- Tasks

---

Estrutura:

- Controllers
  - UserController.cs
- Data
  - TaskSystemDBContext.cs
- Models
  - TaskModel.cs
  - UserModel.cs
- Repositories
  - Interfaces
    - IUserRepository.cs
  - UserRepository.cs

---

`Add-Migration InitialDB -Context TaskSystemDBContext`

`Update-Database -Context TaskSystemDBContext`
