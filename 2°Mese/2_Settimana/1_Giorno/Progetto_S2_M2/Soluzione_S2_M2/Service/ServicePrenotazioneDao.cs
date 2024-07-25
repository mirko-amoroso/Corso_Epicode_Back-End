using Microsoft.Extensions.Configuration;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soluzione_S2_M2.Service
{
    public class ServicePrenotazioneDao : ServiceSql, IServicePrenotazioneDao
    {
        public ServicePrenotazioneDao(IConfiguration configuration) : base(configuration)
        {
        }

        private const string CraeFormPren = @"INSERT INTO Prenotazioni(DataPrenotazione, DataInizio, DataFine, Caparra, Importo, MezzaPensione, PensioneCompleta, PernottamentoPrimaColazione, IdCamera, IdClienti)
                                         VALUES(@DataPrenotazione, @DataInizio, @DataFine, @Caparra, @Importo, @MezzaPensione, @PensioneCompleta, @PernottamentoPrimaColazione, @IdCamera, @IdClienti)";

        private const string GetAllPren = "SELECT * FROM Prenotazioni AS P JOIN Cliente AS C ON P.IdClienti = C.IdCliente";
        public void CreaFormPreno(Prenotazioni P)
        {
            try
            {
                // Verifica intervallo delle date
                if (P.DataInizio < new DateTime(1753, 1, 1) || P.DataFine > new DateTime(9999, 12, 31))
                {
                    throw new ArgumentOutOfRangeException("La data è fuori dall'intervallo valido.");
                }

                var _connection = GetConnection();
                var command = GetCommand(CraeFormPren);
                command.Parameters.Add(new SqlParameter("@DataPrenotazione", SqlDbType.DateTime2) { Value = P.DataPrenotazione });
                command.Parameters.Add(new SqlParameter("@DataInizio", SqlDbType.DateTime2) { Value = P.DataInizio });
                command.Parameters.Add(new SqlParameter("@DataFine", SqlDbType.DateTime2) { Value = P.DataFine });

                command.Parameters.Add(new SqlParameter("@Caparra", P.Importo * 0.20m));
                command.Parameters.Add(new SqlParameter("@Importo", P.Importo));
                command.Parameters.Add(new SqlParameter("@MezzaPensione", P.MezzaPensione));
                command.Parameters.Add(new SqlParameter("@PensioneCompleta", P.PensioneCompleta));
                command.Parameters.Add(new SqlParameter("@PernottamentoPrimaColazione", P.PernottamentoPrimaColazione));
                command.Parameters.Add(new SqlParameter("@IdCamera", P.IdCamera));
                command.Parameters.Add(new SqlParameter("@IdClienti", P.IdClienti));
                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"non funziona CreaForm {ex}");
            }
        }

        public IEnumerable<UPrenotazioniCliente> CreaPreno()
        {
            List<UPrenotazioniCliente> ListaPrenotazioni = new List<UPrenotazioniCliente>();
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(GetAllPren);
                _connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read()) 
                {
                    ListaPrenotazioni.Add(CreaPren(reader));
                }
                return ListaPrenotazioni;

            }
            catch (Exception ex)
            {
                // Fornisci maggiori dettagli sull'eccezione
                throw new Exception("Errore durante la creazione delle prenotazioni: " + ex.Message, ex);
            }
        }

        public UPrenotazioniCliente CreaPren(DbDataReader reader)
        {
            return new UPrenotazioniCliente
            {
                IdClienti = reader.GetInt32(reader.GetOrdinal("IdClienti")),
                IdPrenotazioni = reader.GetInt32(reader.GetOrdinal("IdPrenotazione")),
                IdCamera = reader.GetInt32(reader.GetOrdinal("IdCamera")),
                DataPrenotazioni = reader.GetDateTime(reader.GetOrdinal("DataPrenotazione")),
                DataInizio = reader.GetDateTime(reader.GetOrdinal("DataInizio")),
                DataFine = reader.GetDateTime(reader.GetOrdinal("DataFine")),
                Caparra = reader.GetDecimal(reader.GetOrdinal("Caparra")),
                Importo = reader.GetDecimal(reader.GetOrdinal("Importo")),
                PensioneCompleta = reader.GetBoolean(reader.GetOrdinal("PensioneCompleta")),
                MezzaPensione = reader.GetBoolean(reader.GetOrdinal("MezzaPensione")),
                PernottamentoPrimaColazione = reader.GetBoolean(reader.GetOrdinal("PernottamentoPrimaColazione")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                Citta = reader.GetString(reader.GetOrdinal("Citta")),
                Provincia = reader.GetString(reader.GetOrdinal("Provincia")),
                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),

            };
        }
    }
}
