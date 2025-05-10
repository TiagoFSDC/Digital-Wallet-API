# Digital Wallet API

API REST para gerenciamento de carteiras digitais, permitindo operações como login, depósitos, transferências e consulta de saldo. Desenvolvida com ASP.NET Core, PostgreSQL e Dapper.

## 🛠 Tecnologias

- ASP.NET Core
- PostgreSQL
- Dapper
- JWT (Autenticação)

## 🔐 Autenticação

A autenticação é feita via JWT. Para obter o token, utilize o endpoint de login:

### Login

```bash
curl --location 'http://localhost:7274/api/v1/authentication/login' \
--header 'Content-Type: application/json' \
--data '{
    "username": "admin",
    "Password": "admin"
}'

Response:
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```