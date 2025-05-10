namespace Bank.Management.Infraestructure.Data.PostgreSQL.Scripts
{
    public sealed class ScriptsInsert
    {
        public const string sqlCustomer =  @"INSERT INTO public.customer (id, name, cpf, email) VALUES
            ('e1d6a8c2-1f47-4a8d-a6c2-f8a45e8b9abc', 'João Silva', '123.456.789-00', 'joao.silva@example.com'),
            ('f2b1d4e3-8e3d-4e7d-9b3d-7e0b8d5eab12', 'Maria Oliveira', '987.654.321-00', 'maria.oliveira@example.com');
        ";

        public const string sqlWallet = @"
            INSERT INTO public.wallet (id, customerid, balance, agency, createdat) VALUES
            (1001, 'e1d6a8c2-1f47-4a8d-a6c2-f8a45e8b9abc', 1200.50, '001', now()),
            (1002, 'f2b1d4e3-8e3d-4e7d-9b3d-7e0b8d5eab12', 850.75, '002', now());
        ";

        public const string sqlDeposit = @"
            INSERT INTO public.deposit (wallet_id, amount) VALUES
            (1001, 500.00),
            (1002, 300.00);
        ";

        public const string sqlWalletTranfer = @"
            INSERT INTO public.wallet_transfer (origin_wallet_id, destination_wallet_id, amount, description) VALUES
            (1001, 1002, 150.00, 'Transferência entre clientes'),
            (1002, 1001, 200.00, 'Reembolso parcial');
        ";
    }
}
