using Microsoft.Extensions.Configuration;
using Soluzione_S2_M2.Connessione;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Service
{
    public class ServiceCamereDao : ServiceSql, IServiceCamereDao
    {
        public ServiceCamereDao(IConfiguration configuration) : base(configuration)
        {
        }

        private const string GetAll = "SELECT * FROM Camere";

        public IEnumerable<Camere> GetAllCamere()
        {
            List<Camere> ListaCamere = new List<Camere>();
            try
            {
                 var _connection = GetConnection();
                 var command = GetCommand(GetAll);
                _connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    ListaCamere.Add(CreaCamera(reader));
                }
                return ListaCamere;
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Errore chiamata {ex}");
                return ListaCamere;
            }
        }
        public Camere CreaCamera(DbDataReader reader)
        {
            return new Camere
            {
                IDCamera = reader.GetInt32(reader.GetOrdinal("IdCamera")),
                NumCam = reader.GetInt32(reader.GetOrdinal("NumCam")),
                Descrizione = reader.GetString(reader.GetOrdinal("Descrizione")),
                Doppia = reader.GetBoolean(reader.GetOrdinal("Doppia")),
            };
        }
    }
}
