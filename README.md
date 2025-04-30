# Desafio Prático: Angular: 19.2.8 + C# Web API

Este projeto consiste em uma aplicação frontend Angular: 19.2.8 que consome uma API backend mockada feita com C# ASP.NET Core.

## Estrutura do Projeto

- `/PessoasApi`: Contém o projeto backend ASP.NET Core Web API.
- `/pessoas-app`: Contém o projeto frontend Angular 17.

## Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (Versão 8.x recomendada)
- [Node.js e npm](https://nodejs.org/) (Versão LTS recomendada)
- [Angular CLI](https://angular.io/cli) (`npm install -g @angular/cli`)
- Um editor de código (Visual Studio Code, Visual Studio, etc.)

## Executando o Backend (API C#)

1.  Navegue até a pasta da API:
    ```bash
    cd Back-end\PessoasApi
    ```
2.  Restaure as dependências (se necessário):
    ```bash
    dotnet restore
    ```
3.  Execute a API:
    ```bash
    dotnet run
    ```
4.  A API estará rodando em um endereço local (geralmente `http://localhost:5054`). Anote a URL base que aparece no terminal (ex: `http://localhost:5123`).
5.  **Importante:** Certifique-se de que a URL base configurada no serviço Angular (`pessoas-app/src/app/services/pessoa.service.ts`, variável `apiUrl`) corresponde à URL em que a API está rodando.
6.  O endpoint principal é `[URL_BASE]/api/pessoas`.

## Executando o Frontend (Angular)

1.  Abra **outro terminal**.
2.  Navegue até a pasta do frontend:
    ```bash
    cd Front-end\Teste-Plural
    ```
3.  Instale as dependências do Node.js:
    ```bash
    npm install
    ```
4.  Execute a aplicação Angular:
    ```bash
    ng serve -o
    ```
5.  A aplicação será aberta automaticamente no seu navegador padrão no endereço `http://localhost:4200`.
6.  Clique no botão "Carregar Dados da API" para buscar e exibir as informações na tabela. Utilize o campo de filtro e a paginação.

## Observações

- **CORS:** A API C# está configurada para aceitar requisições da origem `http://localhost:4200` (padrão do `ng serve`). Se você executar o Angular em uma porta diferente, ajuste a configuração de CORS no arquivo `PessoasApi/Program.cs`.
- **Dados Mockados:** A API utiliza dados falsos gerados em memória a cada execução (ou na primeira chamada). Não há persistência em banco de dados.
- **Angular Material:** O frontend utiliza componentes do Angular Material para a tabela, paginação, input e botão.
