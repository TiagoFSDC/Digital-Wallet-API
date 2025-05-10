namespace Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1
{
    public class TransactionQueryBuilder
    {
        public const string CreateTransaction = @"INSERT INTO wallet_transfer 
          (origin_wallet_id, destination_wallet_id, amount, transfer_date, description) 
          VALUES (@OriginWalletId, @DestinationWalletId, @Amount, NOW(), @Description);";

        public const string GetTransaction = @"SELECT
        wt.id AS transferid,
        wt.origin_wallet_id AS originwalletid,
        wt.destination_wallet_id AS destinationwalletid,
        wt.amount,
        wt.transfer_date AS transferdate,
        wt.status,
        wt.description,
        wo.customerid AS origincustomerid,
        wd.customerid AS destinationcustomerid
        FROM public.wallet_transfer wt
        JOIN public.wallet wo ON wt.origin_wallet_id = wo.id
        JOIN public.wallet wd ON wt.destination_wallet_id = wd.id
        WHERE
            (
                wo.customerid = '56ef5dcd-9ba1-4bc6-9740-83f6e6bd5836'
                OR wd.customerid = '56ef5dcd-9ba1-4bc6-9740-83f6e6bd5836'
            )
            AND ('2025-05-10 00:00:00' IS NULL OR wt.transfer_date >= '2025-05-10 00:00:00')
            AND ('2025-05-11 00:00:00' IS NULL OR wt.transfer_date <= '2025-05-11 00:00:00')
        ORDER BY wt.transfer_date DESC;";
    }
}
