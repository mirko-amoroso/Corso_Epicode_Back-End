using Microsoft.Extensions.Configuration;
using Soluzione_S2_M2.Connessione;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
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
        private const string GetAllUnion = "SELECT * FROM Prenotazioni AS P JOIN Camere AS C ON P.IdCamera = C.IdCamera WHERE P.IdPrenotazione = @IdPrenotazione ";

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
                IdCamera = reader.GetInt32(reader.GetOrdinal("IdCamera")),
                NumCam = reader.GetInt32(reader.GetOrdinal("NumCam")),
                Descrizione = reader.GetString(reader.GetOrdinal("Descrizione")),
                Doppia = reader.GetBoolean(reader.GetOrdinal("Doppia")),
            };
        }

        public IEnumerable<UPrenotazioniCamere> GetUninon(int idPren)
        {
            List<UPrenotazioniCamere> ListaCamPren = new List<UPrenotazioniCamere>();
            try
            {
                Console.WriteLine(idPren);
                var _connection = GetConnection();
                var command = GetCommand(GetAllUnion);
                command.Parameters.Add(new SqlParameter("@IdPrenotazione", idPren));
                _connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                { 
                    ListaCamPren.Add(CreaPrenCam(reader));
                    Console.WriteLine(reader.GetInt32(reader.GetOrdinal("IdPrenotazione")));
                }
                return ListaCamPren;

            }
            catch (Exception ex) 
            {
                Console.WriteLine($"errore GetUnion: {ex})");
                return ListaCamPren;
            }
        }

        public UPrenotazioniCamere CreaPrenCam(DbDataReader reader)
        {
            return new UPrenotazioniCamere
            {
                IdClienti = reader.GetInt32(reader.GetOrdinal("IdClienti")),
                IdPrenotazione = reader.GetInt32(reader.GetOrdinal("IdPrenotazione")),
                IdCamera = reader.GetInt32(reader.GetOrdinal("IdCamera")),
                DataPrenotazione = reader.GetDateTime(reader.GetOrdinal("DataPrenotazione")),
                DataInizio = reader.GetDateTime(reader.GetOrdinal("DataInizio")),
                DataFine = reader.GetDateTime(reader.GetOrdinal("DataFine")),
                Caparra = reader.GetDecimal(reader.GetOrdinal("Caparra")),
                Importo = reader.GetDecimal(reader.GetOrdinal("Importo")),
                PensioneCompleta = reader.GetBoolean(reader.GetOrdinal("PensioneCompleta")),
                MezzaPensione = reader.GetBoolean(reader.GetOrdinal("MezzaPensione")),
                PernottamentoPrimaColazione = reader.GetBoolean(reader.GetOrdinal("PernottamentoPrimaColazione")),
                NumCam = reader.GetInt32(reader.GetOrdinal("NumCam")),
                Descrizione = reader.GetString(reader.GetOrdinal("Descrizione")),
                Doppia = reader.GetBoolean(reader.GetOrdinal("Doppia")),
                
            };
        }
    }
}
