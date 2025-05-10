namespace Bank.Management.Infraestructure.Data.PostgreSQL.Builders.v1
{
    public class CustomerQueryBuilder
    {
        public const string CreateCustomer = @"
            INSERT INTO public.Customer (id, name, cpf, email)
            VALUES (@Id, @Name, @CPF, @Email);
        ";
    }
}
