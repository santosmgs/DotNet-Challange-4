# UpStyle API

**Descrição**  

A UpStyle API é uma aplicação desenvolvida em .NET Core para gerenciar operações CRUD de empresas da área de UpStyle, utilizando autenticação via Firebase e conexão com banco de dados Oracle. A aplicação segue uma arquitetura monolítica e aplica práticas de Clean Code e SOLID.

## Requisitos do Projeto

- **.NET Core SDK**
- **Banco de Dados Oracle**
- **Conta Firebase** para autenticação

## Funcionalidades

1. **Autenticação com Firebase**: Endpoint de login que gera um token JWT.
2. **Operações CRUD**: Para a entidade `UpStyle`, com validação de CNPJ.
3. **Autorização**: Requer token válido para acesso aos endpoints protegidos.
4. **Documentação**: Swagger configurado para visualização dos endpoints.

## Como Rodar o Projeto

### Passos para Configuração

1. **Clonar o Repositório**:
    ```bash
    git clone https://github.com/seu-repositorio/upstyle-api.git
    cd upstyle-api
    ```

2. **Configurar o Banco de Dados**:
   - Configure o acesso ao banco de dados Oracle no arquivo `appsettings.json` com as credenciais do banco.
   - Atualize o contexto de conexão em `AppDbContext`.

3. **Configurar o Firebase**:
   - Crie um projeto no [Firebase Console](https://console.firebase.google.com/).
   - Adicione o arquivo JSON da chave de serviço do Firebase ao projeto.
   - Atualize o caminho da chave no `appsettings.json`.

4. **Instalar os Pacotes Necessários**:
   ```bash
   dotnet add package FirebaseAdmin
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Oracle.EntityFrameworkCore
   dotnet add package Swashbuckle.AspNetCore

5. **Link da 3 entrega (como referência)**
   url:
  ```bash
    
