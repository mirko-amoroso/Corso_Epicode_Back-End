using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Prog_S1_V.Interfacce;
using Prog_S1_V.Model;

namespace Prog_S1_V.Service
{
    public class VerbaleDao : Dao_SQL, IVerbaleDao
    {
        private const string commandGetAllVerbali = "SELECT * FROM VERBALE";
        private const string commandGetAllVerbaliTrasg =
            @"SELECT  COUNT(V.IdVerbale) AS NumeroVerbali, A.Nome, A.Cognome
                                                            FROM VERBALE AS V
                                                            JOIN ANAGRAFICA AS A ON V.IdAnagrafa = A.IdAnagrafica
                                                            GROUP BY A.Nome, A.Cognome";
        private const string commandGetAllVerbaliTrasgSum =
            @"SELECT  SUM(V.DecurtamentoPunti) AS NumeroDecurtati, A.Nome, A.Cognome
                                                            FROM VERBALE AS V
                                                            JOIN ANAGRAFICA AS A ON V.IdAnagrafa = A.IdAnagrafica
                                                            GROUP BY A.Nome, A.Cognome";

        private const string commandGetAllOverTen =
            @"SELECT  V.DecurtamentoPunti, A.Nome, A.Cognome, V.Importo, V.DataViolazione
                                                            FROM VERBALE AS V
                                                            JOIN ANAGRAFICA AS A ON V.IdAnagrafa = A.IdAnagrafica
                                                            WHERE V.DecurtamentoPunti >= 5
                                                            GROUP BY A.Nome, A.Cognome, V.DecurtamentoPunti, V.Importo, V.DataViolazione";
        private const string commandGetAllOverFour =
            @"SELECT  V.DecurtamentoPunti, A.Nome, A.Cognome, V.Importo, V.DataViolazione
                                                            FROM VERBALE AS V
                                                            JOIN ANAGRAFICA AS A ON V.IdAnagrafa = A.IdAnagrafica
                                                            WHERE V.Importo > 200
                                                            GROUP BY A.Nome, A.Cognome, V.DecurtamentoPunti, V.Importo, V.DataViolazione";

        private const string commandWrite = "INSERT INTO VERBALE(DataViolazione, IndirizzoViolazione, NominativoAgente, DataTrascrizioneVerbale, Importo, DecurtamentoPunti, IdAnagrafa, IdViolazione) VALUES(@DataViolazione, @IndirizzoViolazione, @NominativoAgente, @DataTrascrizioneVerbale, @Importo, @DecurtamentoPunti, @IdAnagrafa, @IdViolazione)";

        public VerbaleDao(IConfiguration configuration)
            : base(configuration) { }

        public IEnumerable<Verbale> GetAllVerbali()
        {
            List<Verbale> verbali = new List<Verbale>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAllVerbali);
            _connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                verbali.Add(CreaVerbale(reader));
            }
            return verbali;
        }

        public Verbale CreaVerbale(DbDataReader reader)
        {
            return new Verbale
            {
                IdVerbale = reader.GetInt32(reader.GetOrdinal("IdVerbale")),
                DataViolazione = reader.GetDateTime(reader.GetOrdinal("DataViolazione")),
                IndirizzoViolazione = reader.GetString(reader.GetOrdinal("IndirizzoViolazione")),
                NominativoAgente = reader.GetString(reader.GetOrdinal("NominativoAgente")),
                DataTrascrizioneVerbale = reader.GetDateTime(
                    reader.GetOrdinal("DataTrascrizioneVerbale")
                ),
                Importo = reader.GetDecimal(reader.GetOrdinal("Importo")),
                DecurtamentoPunti = reader.GetInt32(reader.GetOrdinal("DecurtamentoPunti")),
                IdAnagrafica = reader.GetInt32(reader.GetOrdinal("IdAnagrafa")),
                IdViolazione = reader.GetInt32(reader.GetOrdinal("IdViolazione")),
            };
        }

        //****************************************************************************
        public IEnumerable<Anagrafica_Verbale> GetAllVerbaliTrasgressore()
        {
            List<Anagrafica_Verbale> verbali = new List<Anagrafica_Verbale>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAllVerbaliTrasg);
            _connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                verbali.Add(CreaVerbale_Anagrafe(reader));
            }
            return verbali;
        }

        public Anagrafica_Verbale CreaVerbale_Anagrafe(DbDataReader reader)
        {
            return new Anagrafica_Verbale
            {
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                NumeroVerbali = reader.GetInt32(reader.GetOrdinal("NumeroVerbali"))
            };
        }

        //****************************************************************************

        public IEnumerable<Anagrafica_Verbale> GetAllVerbaliTrasgressoreSum()
        {
            List<Anagrafica_Verbale> verbali = new List<Anagrafica_Verbale>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAllVerbaliTrasgSum);
            _connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                verbali.Add(CreaVerbale_AnagrafeSum(reader));
            }
            return verbali;
        }

        public Anagrafica_Verbale CreaVerbale_AnagrafeSum(DbDataReader reader)
        {
            return new Anagrafica_Verbale
            {
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                NumeroDecurtati = reader.GetInt32(reader.GetOrdinal("NumeroDecurtati"))
            };
        }

        //****************************************************************************

        public IEnumerable<Anagrafica_Verbale> GetAllOverTen()
        {
            List<Anagrafica_Verbale> verbali = new List<Anagrafica_Verbale>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAllOverTen);
            _connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                verbali.Add(CreaVerbaleOverTen(reader));
            }
            return verbali;
        }

        public Anagrafica_Verbale CreaVerbaleOverTen(DbDataReader reader)
        {
            return new Anagrafica_Verbale
            {
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                DecurtamentoPunti = reader.GetInt32(reader.GetOrdinal("DecurtamentoPunti")),
                Importo = reader.GetDecimal(reader.GetOrdinal("Importo")),
                DataViolazione = reader.GetDateTime(reader.GetOrdinal("DataViolazione")),
            };
        }

        //****************************************************************************

        public IEnumerable<Anagrafica_Verbale> GetAllOverFour()
        {
            List<Anagrafica_Verbale> verbali = new List<Anagrafica_Verbale>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAllOverFour);
            _connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                verbali.Add(CreaVerbaleOverFour(reader));
            }
            return verbali;
        }

        public Anagrafica_Verbale CreaVerbaleOverFour(DbDataReader reader)
        {
            return new Anagrafica_Verbale
            {
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                DecurtamentoPunti = reader.GetInt32(reader.GetOrdinal("DecurtamentoPunti")),
                Importo = reader.GetDecimal(reader.GetOrdinal("Importo")),
                DataViolazione = reader.GetDateTime(reader.GetOrdinal("DataViolazione")),
            };
        }

        //****************************************************************************

        public void WriteVerbale(Verbale verb)
        {
            var _connection = GetConnection();
            var command = GetCommand(commandWrite);
            command.Parameters.Add(new SqlParameter("@DataViolazione", verb.DataViolazione));
            command.Parameters.Add(new SqlParameter("@IndirizzoViolazione", verb.IndirizzoViolazione));
            command.Parameters.Add(new SqlParameter("@NominativoAgente", verb.NominativoAgente));
            command.Parameters.Add(new SqlParameter("@DataTrascrizioneVerbale", verb.DataTrascrizioneVerbale));
            command.Parameters.Add(new SqlParameter("@Importo", verb.Importo));
            command.Parameters.Add(new SqlParameter("@DecurtamentoPunti", verb.DecurtamentoPunti));
            command.Parameters.Add(new SqlParameter("@IdAnagrafa", verb.IdAnagrafica));
            command.Parameters.Add(new SqlParameter("@IdViolazione", verb.IdViolazione));
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
