# UserApiSolution

## Descrição
Solução .NET composta por:
- **UserApi**: ASP.NET Core Web API para CRUD de usuários (nome, email, telefone) com persistência em SQLite.
- **ExternalApiService**: Biblioteca para consumir dados da API pública JSONPlaceholder.

## Como rodar o projeto
1. Restaure os pacotes:
   ```powershell
   dotnet restore
   ```
2. Acesse a pasta UserApi e aplique as migrations (será criado depois):
   ```powershell
   cd UserApi
   dotnet ef database update
   ```
3. Execute a API:
   ```powershell
   dotnet run
   ```

## Especificações técnicas
- ASP.NET Core Web API
- Entity Framework Core com SQLite
- Injeção de dependência para serviços e repositórios
- Integração com API externa via projeto separado
- Boas práticas (SOLID, validação, organização)

## Estrutura
- `UserApi/` - API principal
- `ExternalApiService/` - Serviço para integração externa
