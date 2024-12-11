# aspnet-core

# AtendoCloudSystemAPI

## Descrição do Projeto

O **AtendoCloudSystemAPI** é uma plataforma completa para o gerenciamento de pedidos e entregas em restaurantes. O sistema foi desenvolvido utilizando os princípios de SOLID e a arquitetura DDD (Domain-Driven Design), garantindo uma solução robusta, escalável e fácil de manter. 

O projeto é dividido em duas partes principais:

1. **Backend**: Desenvolvido em .NET 6.0, expõe uma API RESTful para ser consumida pelo frontend.

## Requisitos

- .NET 6.0 SDK
- Git

## Clonando o Repositório

Para obter uma cópia local do projeto, você pode clonar o repositório usando o seguinte comando:

```bash
git clone https://github.com/pablosilvamachado/AtendoCloudSystemAPI.git
```

##Configuração do Backend
Após clonar o repositório, navegue até a pasta raiz do projeto e siga as etapas abaixo para configurar o backend.

1. Restaurar os Pacotes NuGet
Navegue até a pasta do projeto backend e restaure as dependências do projeto:

```bash
cd AtendoCloudSystemAPI
dotnet restore
```

2. Configurar o Banco de Dados
Antes de rodar o projeto, configure o banco de dados no arquivo appsettings.json, substituindo as informações de conexão para o seu ambiente local:

```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=AtendoCloudDB;User Id=seu_usuario;Password=sua_senha;"
}
```

3. Executar Migrações do Entity Framework
Para criar o banco de dados e aplicar as migrações necessárias, execute:

```bash
dotnet ef database update
```

4. Executar o Projeto
Para rodar o backend, execute o seguinte comando:

```bash
dotnet run
```

O backend estará disponível em https://localhost:5001.
=============================================================================================================================================================================================================================================================================








