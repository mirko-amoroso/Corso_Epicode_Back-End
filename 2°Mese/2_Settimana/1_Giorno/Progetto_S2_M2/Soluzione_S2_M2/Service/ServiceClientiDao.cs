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
    internal class ServiceClientiDao : ServiceSql, IServiceClientDao
    {
        public ServiceClientiDao(IConfiguration configuration)
            : base(configuration) { }

        private const string GetAll = "SELECT * FROM Cliente";
        private const string GetByCod_Fisc = "SELECT * FROM Cliente WHERE Cod_Fisc = @Cod_Fisc";
        private const string GetByPrenotazioniId = "SELECT * FROM Cliente AS C JOIN Prenotazioni AS P ON C.IdCliente = P.IdClienti WHERE C.IdCliente = @IdClient";
        private const string CraeForm = "INSERT INTO Cliente(Cod_fisc, Cognome, Nome, Citta, Provincia, Email, Telefono) VALUES(@Cod_fisc, @Cognome, @Nome, @Citta, @Provincia, @Email, @Telefono)";

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
                _connection.Close();
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
                IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente")),
                Cod_Fisc = reader.GetString(reader.GetOrdinal("Cod_Fisc")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Citta = reader.GetString(reader.GetOrdinal("Citta")),
                Provincia = reader.GetString(reader.GetOrdinal("Provincia")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
            };
        }

        public Clienti GetByCodFisc(string cod)
        {
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(GetByCod_Fisc);

                _connection.Open();
                command.Parameters.Add(new SqlParameter("@Cod_Fisc", cod));

                using (var reader = command.ExecuteReader())
                {
                    var cliente = new List<Clienti>();
                    while (reader.Read())
                    {
                        cliente.Add(CreaClienti(reader));
                    }
                    _connection.Close();
                    return cliente[0]; // Ritorna il primo cliente trovato
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore chiamata {ex}");
                throw;
            }
        }

        //GRTPLS85M01H501K
        //GRTPLS85M01H501K

        public IEnumerable<UPrenotazioniCliente> GetAllPrenotazioniById(Clienti clienti)
        {
            var PrenClient = new List<UPrenotazioniCliente>();
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(GetByPrenotazioniId);

                _connection.Open();
                command.Parameters.Add(new SqlParameter("@IdClient", clienti.IdCliente));

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PrenClient.Add(CreaUPrenCliente(reader));
                    }
                }
                _connection.Close();
                return PrenClient;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore chiamata {ex}");
                return PrenClient;
            }
        }

        public UPrenotazioniCliente CreaUPrenCliente(DbDataReader reader)
        {
            return new UPrenotazioniCliente
            {
                IdCliente = reader.GetInt32(reader.GetOrdinal("IdCliente")),
                IdPrenotazioni = reader.GetInt32(reader.GetOrdinal("IdPrenotazione")),
                IdCamera = reader.GetInt32(reader.GetOrdinal("IdCamera")),
                Cod_Fisc = reader.GetString(reader.GetOrdinal("Cod_Fisc")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Citta = reader.GetString(reader.GetOrdinal("Citta")),
                Provincia = reader.GetString(reader.GetOrdinal("Provincia")),
                Email = reader.GetString(reader.GetOrdinal("Email")),
                Telefono = reader.GetString(reader.GetOrdinal("Telefono")),
                DataPrenotazioni = reader.GetDateTime(reader.GetOrdinal("DataPrenotazione")),
                DataInizio = reader.GetDateTime(reader.GetOrdinal("DataInizio")),
                DataFine = reader.GetDateTime(reader.GetOrdinal("DataFine")),
                Importo = reader.GetDecimal(reader.GetOrdinal("Importo")), // Nota: decimal per l'importo
                Caparra = reader.GetDecimal(reader.GetOrdinal("Caparra")), // Nota: decimal per la caparra
                MezzaPensione = reader.GetBoolean(reader.GetOrdinal("MezzaPensione")),
                PensioneCompleta = reader.GetBoolean(reader.GetOrdinal("PensioneCompleta")),
                PernottamentoPrimaColazione = reader.GetBoolean(reader.GetOrdinal("PernottamentoPrimaColazione"))
            };
        }


        public void CreaFormClient(Clienti C)
        {
            try
            {
                var _connection = GetConnection();
                var command = GetCommand(CraeForm);
                command.Parameters.Add(new SqlParameter("@Cod_Fisc", C.Cod_Fisc));
                command.Parameters.Add(new SqlParameter("@Cognome", C.Cognome));
                command.Parameters.Add(new SqlParameter("@Nome", C.Nome));
                command.Parameters.Add(new SqlParameter("@Citta", C.Citta));
                command.Parameters.Add(new SqlParameter("@Provincia", C.Provincia));
                command.Parameters.Add(new SqlParameter("@Email", C.Email));
                command.Parameters.Add(new SqlParameter("@Telefono", C.Telefono));
                _connection.Open();
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception ex) { Console.WriteLine($"non funziona CreaForm {ex}"); }
        }

    }
}
