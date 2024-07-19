using Dao_2M_1S.Model;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace Dao_2M_1S
{
    public class ClientiDao : DaoBase, IClientiDao
    {
        public ClientiDao(IConfiguration configuration) : base(configuration)
        {
        }

        private const string commandGetAll = "SELECT * FROM Clienti";

        private const string commandGetById = "SELECT * FROM Clienti WHERE IdClienti = @Id";

        private const string commandDeleteCliente = "DELETE FROM Clienti WHERE IdClienti = @Id";
        private const string commandDeleteClienteOrdini = "DELETE FROM Ordini WHERE IdClienti = @Id";

        private const string commandCreaPrivato = "INSERT INTO Clienti(Nome, Cognome, Eta, IsPrivate, Cf) VALUES(@Nome, @Cognome, @Eta, @IsPrivate, @Cf)";

        private const string commandCreaAzienda = "INSERT INTO Clienti(Nome, IsPrivate, P_Iva) VALUES(@Nome, @IsPrivate, @P_Iva)";

        public IEnumerable<Clienti> GetAllClienti()
        {
            List<Clienti> clienti = new List<Clienti>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAll);
            _connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    clienti.Add(CreaCliente(reader));
                }
                return clienti;
            }
        }
        public Clienti CreaCliente(DbDataReader reader)
        {
            return new Clienti
            {
                IdClienti = reader.IsDBNull(reader.GetOrdinal("IdClienti"))
                    ? 0
                    : reader.GetInt32(reader.GetOrdinal("IdClienti")),
                Nome = reader.IsDBNull(reader.GetOrdinal("Nome"))
                    ? string.Empty
                    : reader.GetString(reader.GetOrdinal("Nome")),
                Cognome = reader.IsDBNull(reader.GetOrdinal("Cognome"))
                    ? string.Empty
                    : reader.GetString(reader.GetOrdinal("Cognome")),
                Eta = reader.IsDBNull(reader.GetOrdinal("Eta"))
                    ? 0
                    : reader.GetInt32(reader.GetOrdinal("Eta")),
                IsPrivate = reader.IsDBNull(reader.GetOrdinal("IsPrivate"))
                    ? false
                    : reader.GetBoolean(reader.GetOrdinal("IsPrivate")),
                Cf = reader.IsDBNull(reader.GetOrdinal("Cf"))
                    ? string.Empty
                    : reader.GetString(reader.GetOrdinal("Cf")),
                P_Iva = reader.IsDBNull(reader.GetOrdinal("P_Iva"))
                    ? string.Empty
                    : reader.GetString(reader.GetOrdinal("P_Iva"))
            };
        }

        //****************************************************************************************

        public void EliminaClienti(int id)
        {
            EliminaClienteOrdini(id);

            var _connection = GetConnection();
            var command = GetCommand(commandDeleteCliente);
            command.Parameters.Add(new SqlParameter("@Id", id));
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void EliminaClienteOrdini(int id)
        {

            var _connection = GetConnection();
            var command = GetCommand(commandDeleteClienteOrdini);
            command.Parameters.Add(new SqlParameter("@Id", id));
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }


        //****************************************************************************************
        public void AddClientiPrivato(Clienti cliente)
        {
            var _connection = GetConnection();
            var command = GetCommand(commandCreaPrivato);
            command.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            command.Parameters.Add(new SqlParameter("@Cognome", cliente.Cognome));
            command.Parameters.Add(new SqlParameter("@Eta", cliente.Eta));
            command.Parameters.Add(new SqlParameter("@IsPrivate", cliente.IsPrivate));
            command.Parameters.Add(new SqlParameter("@Cf", cliente.Cf));
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();

        }

        public void AddClientiAzienda(Clienti cliente)
        {
            var _connection = GetConnection();
            var command = GetCommand(commandCreaPrivato);
            command.Parameters.Add(new SqlParameter("@Nome", cliente.Nome));
            command.Parameters.Add(new SqlParameter("@IsPrivate", cliente.IsPrivate));
            command.Parameters.Add(new SqlParameter("@P_Iva", cliente.P_Iva));
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();

        }



    }
}
