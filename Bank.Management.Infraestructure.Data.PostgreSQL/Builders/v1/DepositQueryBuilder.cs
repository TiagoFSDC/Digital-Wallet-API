namespace Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1
{
    public sealed class DepositQueryBuilder
    {
        public const string CreateDeposit = @"
            INSERT INTO public.deposit (wallet_id, amount, created_at)
            VALUES (@WalletId, @Amount, NOW());
        ";
    }
}
