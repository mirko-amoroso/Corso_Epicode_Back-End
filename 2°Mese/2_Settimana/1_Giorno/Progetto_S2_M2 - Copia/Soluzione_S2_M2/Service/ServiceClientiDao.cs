using Microsoft.Extensions.Configuration;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;


namespace Soluzione_S2_M2.Service
{
    internal class ServiceClientiDao : ServiceSql, IServiceClientDao
    {
        public ServiceClientiDao(IConfiguration configuration) : base(configuration)
        {
        }

        private const string GetAll = "SELECT * FROM Clienti";

        public IEnumerable<Clienti> GetAllClienti()
        {
            List<Clienti> ListaClienti = new List<Clienti>();
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(GetAll);
                _connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListaClienti.Add(CreaClienti(reader));
                }
                return ListaClienti;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore chiamata {ex}");
                return ListaClienti;
            }
        }

        public Clienti CreaClienti(DbDataReader reader)
        {
            return new Clienti
            {
                IdClienti = reader.GetInt32(reader.GetOrdinal("IdClienti")),
                Cod_Fisc = reader.GetString(reader.GetOrdinal("Cod_Fisc")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Citta = reader.GetString(reader.GetOrdinal("Citta")),
                Provincia = reader.GetString(reader.GetOrdinal("Provincia")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
            };
        }

    }
}
