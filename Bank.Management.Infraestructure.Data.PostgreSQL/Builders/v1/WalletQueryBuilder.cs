namespace Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1
{
    public sealed class WalletQueryBuilder
    {
        public const string CreateWallet = @"
            INSERT INTO public.wallet (id, Balance, Agency, CreatedAt, CustomerId)
            VALUES (
                @Id,
                @Balance,
                @Agency,
                @CreatedAt,
                @CustomerId
            );
        ";

        public const string GetWalletBalance = @"SELECT balance FROM public.wallet WHERE id = @walletId;";

        public const string DebitWallet = @"UPDATE public.wallet SET balance = balance - @Amount WHERE id = @walletId;";

        public const string CreditWallet = @"UPDATE public.wallet SET balance = balance + @Amount WHERE id = @walletId;";
    }
}
