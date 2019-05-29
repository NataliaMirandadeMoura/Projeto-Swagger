using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Entities;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Projeto.Repository.Contracts
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly string connectionString;

        public ClienteRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Create(Cliente cliente)
        {
            var query = "INSERT INTO CLIENTE(NOME, EMAIL, DATACRIACAO) "
                + " VALUES(@Nome, @Email, GETDATE())";

            using (var con = new SqlConnection(connectionString))
            {
                con.Execute(query, cliente);
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public void Remove(Cliente cliente)
        {
            var query = "delete from Cliente where IdCliente = @IdCliente";
            using (var con = new SqlConnection(connectionString))
            {
                con.Execute(query, cliente);
            }

        }

        public List<Cliente> SelectAll()
        {
            var query = "Select * from Cliente";

            using (var con = new SqlConnection(connectionString))
            {
               return con.Query<Cliente>(query).ToList();
            }
        }

        public Cliente SelectById(int IdCliente)
        {
            var query = "select * from where IdCliente = @IdCliente";
            using (var con = new SqlConnection(connectionString))
            {
                return con.QuerySingleOrDefault(query, new { IdCliente });

            }
        }

        public void Update(Cliente cliente)
        {
            var query = "UPDATE CLIENTE SET NOME = @Nome, EMAIL = @Email "
                + "WHERE IdCliente = @IdCliente";

            using (var con = new SqlConnection(connectionString))
            {
                con.Execute(query, cliente);
            }
        }
    }
}
