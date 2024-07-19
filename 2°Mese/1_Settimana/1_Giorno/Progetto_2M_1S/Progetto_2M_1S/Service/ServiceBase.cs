using System.Data;
using System.Data.Common;
using System.Reflection.PortableExecutable;
using Progetto_2M_1S.Models;

namespace Progetto_2M_1S.Service
{
    public class ServiceBase : ServiceSQL, IServiceBase
    {
        public ServiceBase(IConfiguration configuration)
            : base(configuration) { }

        public IEnumerable<Clienti> GetAllClienti()
        {
            List<Clienti> clienti = new List<Clienti>();
            var _connection = GetConnection();
            var command = GetCommand("SELECT * FROM Clienti");
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

        private Clienti CreaCliente(DbDataReader reader)
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

        public IEnumerable<Ordini> AllOrdini()
        {
            List<Ordini> ordini = new List<Ordini>();
            var _connection = GetConnection();
            var command = GetCommand("SELECT * FROM Ordini");
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

        private Ordini CreaOrdini(DbDataReader reader)
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
