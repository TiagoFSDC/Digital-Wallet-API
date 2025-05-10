# 💳 Digital Wallet API

API REST para gerenciamento de carteiras digitais, permitindo:

- Cadastro de clientes
- Criação de carteiras
- Depósitos
- Transferências entre carteiras
- Consulta de saldo
- Histórico de transações

---

## 🚀 Tecnologias

- ASP.NET Core 8
- PostgreSQL
- Dapper
- JWT para autenticação

---

## 🔐 Autenticação

### Login

Obtenha o token de acesso JWT:

```bash
curl --location 'http://localhost:7274/api/v1/authentication/login' \
--header 'Content-Type: application/json' \
--data '{
  "username": "admin",
  "Password": "admin"
}'
```

**Resposta:**
```json
{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}
```

Use o token no header das próximas requisições:
```
Authorization: Bearer {token}
```

---

## 📬 Endpoints

### 👤 Criar Cliente

```http
POST /api/v1/customer
```

```json
{
  "name": "João Cruz",
  "cpf": "99977467620",
  "email": "r@r.com"
}
```

---

### 💼 Criar Carteira

```http
POST /api/v1/wallet
```

```json
{
  "customerId": "uuid"
}
```

---

### 📈 Consultar Saldo da Carteira

```http
GET /api/v1/wallet?walletId={id}
```

---

### 💰 Realizar Depósito

```http
POST /api/v1/wallet/deposit
```

```json
{
  "walletId": "638824900974081731",
  "amount": 1000
}
```

---

### 🔄 Transferência entre Carteiras

```http
POST /api/v1/transaction
```

```json
{
  "originWalletId": "638824900974081731",
  "destinationWalletId": "638824900207510522",
  "amount": 100,
  "description": "teste"
}
```

---

### 🧾 Histórico de Transações

```http
GET /api/v1/transaction?CustomerId={uuid}&StartDate={yyyy-MM-dd HH:mm:ss}&EndDate={yyyy-MM-dd HH:mm:ss}
```

Parâmetros:
- `CustomerId`: obrigatório
- `StartDate`: opcional
- `EndDate`: opcional

---

## ▶️ Como Executar

1. Clone o repositório
2. Configure a string de conexão no `appsettings.json`
3. Os script para a inserção de valores das tabelas do banco, estão na pasta de scripts no seguinte caminho src\Bank.Management.Infraestructure.Data.PostgreSQL\Scripts.
4. Rode o projeto:

```bash
dotnet run
```

---

## 📝 Licença

MIT License
