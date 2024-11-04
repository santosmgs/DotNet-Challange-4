# UpStyle API dotnet

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

## Técnicas Clean Code

O projeto utiliza várias práticas de Clean Code para melhorar a legibilidade, manutenibilidade e clareza do código:

1. **Nomes Significativos**: Nomes de variáveis, métodos e classes foram escolhidos para serem descritivos e claros, representando bem o seu propósito no código. Exemplos incluem `UpStyleController`, `AuthService`, e `CnpjValidator`.

2. **Funções Simples e Pequenas**: As funções são projetadas para realizar apenas uma tarefa e são curtas, facilitando a leitura e compreensão sem complexidade desnecessária.

3. **Separação de Responsabilidades**: Cada classe e método tem uma função específica, seguindo o princípio SOLID do SRP (Single Responsibility Principle). Por exemplo, `AuthService` é dedicado exclusivamente à autenticação.

4. **Evitar Comentários Desnecessários**: O código é autodescritivo, minimizando a necessidade de comentários que podem se tornar obsoletos ou confusos.

5. **Consistência**: Há consistência nos padrões de nomenclatura, espaçamento e estrutura do código em todo o projeto, o que facilita a leitura e manutenção.

6. **Tratamento de Erros**: O código implementa tratamento de exceções adequado, fornecendo mensagens de erro específicas que auxiliam na depuração e fornecem feedback claro ao usuário.

7. **Uso de Enum para Valores Fixos**: O enum `Setor` define categorias fixas, como "Tecnologia" e "Saúde", promovendo clareza e evitando erros ao usar valores constantes.


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
  ```
https://github.com/santosmgs/.NET---Challange-3-Sprint
  ```
    

## Integrantes

- Felipe Morais - RM551463
- João Gabriel - RM 552078
- Miguel Santos - 551640
- Ian Navas – RM 550133
- Renan Vieira - RM 551813
