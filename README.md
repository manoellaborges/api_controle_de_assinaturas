# ApiControleDeAssinaturas

Este é um projeto de uma API para gerenciamento de assinaturas. Foi desenvolvido na linguagem C# e está seguindo os padrões RESTful. A arquitetura segue os cinco princípios SOLID: SRP, OCP, LSP, ISP, e DIP. Utiliza o PostgreSQL para armazenar os dados.

## Índice
- [Pré-requisitos](#pré-requisitos)
- [Instalação](#instalação)
- [Instanciar o Banco de Dados](#instanciar-o-banco-de-dados)
- [Executar a Aplicação](#executar-a-aplicação)
- [Testar a API](#testar-a-api)
- [Endpoints](#endpoints)

## Pré-requisitos
- .NET 8.0 SDK
- PostgreSQL
- Postman (opcional, para testar as requisições)

## Instalação

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/ApiControleDeAssinaturas.git
cd ApiControleDeAssinaturas
```

2. Configure a string de conexão do banco de dados no arquivo appsettings.json:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Database=nome_do_banco;Username=seu_usuario;Password=sua_senha"
  }
}

```
3. Instale as dependências do projeto:
```bash
dotnet restore
```

## Instanciar o Banco de Dados

1. Conecte-se ao PostgreSQL e crie o banco de dados:
```sql
CREATE DATABASE nome_do_banco;
```

2. Crie a tabela controledeassinaturas:
```sql
CREATE TABLE controledeassinaturas (
    id UUID PRIMARY KEY,
    datacriacao TIMESTAMP NOT NULL,
    datapagamento TIMESTAMP,
    status VARCHAR(50),
    idlinkpagamento VARCHAR(255),
    valor DECIMAL(18,2),
    idcliente VARCHAR(255),
    idpagamento VARCHAR(255),
    idassinatura VARCHAR(255),
    numerofatura VARCHAR(255),
    nomecliente VARCHAR(255),
    email VARCHAR(255),
    telefone VARCHAR(50),
    estado VARCHAR(50),
    cidade VARCHAR(50)
);

```
## Executar a Aplicação

1. Compile e execute a aplicação:

    ```bash
    dotnet run
    ```
2. A aplicação estará disponível em [https://localhost:7112](https://localhost:7171).

## Testar a API

1. **Usando o Swagger UI**:

    Abra o navegador e acesse [https://localhost:7112/swagger](https://localhost:7171/swagger) para acessar a documentação e testar os endpoints da API.

## Endpoints

### Assinaturas

- `GET /api/ControleDeAssinaturas`: Retorna todas as assinaturas.
- `GET /api/ControleDeAssinaturas/{id}`: Retorna uma assinatura específica pelo ID.
- `POST /api/ControleDeAssinaturas`: Cria uma nova assinatura.
- `PUT /api/ControleDeAssinaturas/{id}`: Atualiza uma assinatura existente pelo ID.
- `DELETE /api/ControleDeAssinaturas/{id}`: Deleta uma assinatura específica pelo ID.
