using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Soluzione_S2_M2.Interfacce;
using Soluzione_S2_M2.Model;

namespace Soluzione_S2_M2.Service
{
    public class ServiceServiziDao : ServiceSql, IServiceServiziDao
    {
        public ServiceServiziDao(IConfiguration configuration)
            : base(configuration) { }

        private const string CreaFormServ =
            "INSERT INTO Servizi(Descrizione, Costo) VALUES(@Descrizione, @Costo)";
        private const string AllServizi = "SELECT * FROM Servizi";
        private const string AggiungiServizio =
            @"INSERT INTO PrenotazioneServizi(IdServizio, IdPrenotazione, DataInizio, DataFine, Quantita) 
                                            VALUES(@IdServizio, @IdPrenotazione, @DataInizio, @DataFine, @Quantita)";

        public void CreaFormServizi(Servizi S)
        {
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(CreaFormServ);
                command.Parameters.Add(new SqlParameter("@Descrizione", S.Descrizione));
                command.Parameters.Add(new SqlParameter("@Costo", S.Costo));
                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"non funziona CreaForm {ex}");
            }
        }

        public void AddServizi(PrenotazioniServizi SGestione)
        {
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(AggiungiServizio);
                command.Parameters.Add(new SqlParameter("@IdServizio", SGestione.IdServizio));
                command.Parameters.Add(new SqlParameter("@IdPrenotazione", SGestione.IdPrenotazione));
                command.Parameters.Add(new SqlParameter("@DataInizio", SGestione.DataInizio));
                command.Parameters.Add(new SqlParameter("@DataFine", SGestione.DataFine));
                command.Parameters.Add(new SqlParameter("@Quantita", SGestione.Quantita));
                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"non funziona AddServizi {ex}");
                // Aggiungi log dettagliato dei parametri se necessario
            }
        }


        public IEnumerable<Servizi> TuttiServizi()
        {
            List<Servizi> _TuttiServizi = new List<Servizi>();
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(AllServizi);
                _connection.Open();
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _TuttiServizi.Add(CreaServizi(reader));
                }
                _connection.Close();
                return _TuttiServizi;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"non funziona AddServizi {ex}");
                return _TuttiServizi;
            }
        }

        public Servizi CreaServizi(DbDataReader reader) 
        {
            return new Servizi
            {
                IdServizio = reader.GetInt32(reader.GetOrdinal("IdServizio")),
                Descrizione = reader.GetString(reader.GetOrdinal("Descrizione")),
                Costo = reader.GetDecimal(reader.GetOrdinal("Costo")),
            };
        }
    }
}
