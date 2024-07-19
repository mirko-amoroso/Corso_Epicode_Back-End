using Dao_2M_1S.Model;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace Dao_2M_1S
{
    public class OrdiniDao : DaoBase, IOrdiniDao
    {
       

        private const string commandGetAllOrdini = "SELECT * FROM Ordini";

        public OrdiniDao(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<Ordini> GetAllOrdini()
        {
            List<Ordini> ordini = new List<Ordini>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAllOrdini);
            _connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ordini.Add(CreaOrdini(reader));
                }
                return ordini;
            }
        }

        public Ordini CreaOrdini(DbDataReader reader)
        {
            return new Ordini
            {
                IdOrdine = reader.IsDBNull(reader.GetOrdinal("IdOrdine")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdOrdine")),
                IdClienti = reader.IsDBNull(reader.GetOrdinal("IdClienti")) ? 0 : reader.GetInt32(reader.GetOrdinal("IdClienti")),
                DataSpedizione = reader.IsDBNull(reader.GetOrdinal("DataSpedizione")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DataSpedizione")),
                Citta = reader.IsDBNull(reader.GetOrdinal("Citta")) ? string.Empty : reader.GetString(reader.GetOrdinal("Citta")),
                IndirizzoDestinatrio = reader.IsDBNull(reader.GetOrdinal("IndirizzoDestinatrio")) ? string.Empty : reader.GetString(reader.GetOrdinal("IndirizzoDestinatrio")),
                CostoSpedizione = reader.IsDBNull(reader.GetOrdinal("CostoSpedizione")) ? 0 : reader.GetDecimal(reader.GetOrdinal("CostoSpedizione")),
                DataPrevista = reader.IsDBNull(reader.GetOrdinal("DataPrevista")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("DataPrevista"))
            };
        }
    }
}
