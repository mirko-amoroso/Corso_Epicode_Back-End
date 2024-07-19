using Microsoft.Extensions.Configuration;
using Prog_S1_V.Interfacce;
using Prog_S1_V.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Service
{
    internal class TrasgressoreDao : Dao_SQL, ITrasgressoreDao
    {
        private const string commandGetAllTrasgressori = "SELECT * FROM ANAGRAFICA";
        private const string commandWriteTrasgressori = "INSERT INTO ANAGRAFICA(Cognome, Nome, Indirizzo, Città, CAP, Cod_Fisc) VALUES(@Cognome, @Nome, @Indirizzo, @Città, @CAP, @Cod_Fisc)";


        public TrasgressoreDao(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<Anagrafica> GetAllTrasgressori()
        {
            List<Anagrafica> Trasgressori = new List<Anagrafica>();
            var _connection = GetConnection();
            var command = GetCommand(commandGetAllTrasgressori);
            _connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Trasgressori.Add(CreaTrasgressore(reader));
            }
            return Trasgressori;
        }

        public Anagrafica CreaTrasgressore(DbDataReader reader)
        {
            return new Anagrafica
            {
                IdAnagrafica = reader.GetInt32(reader.GetOrdinal("IdAnagrafica")),
                Cognome = reader.GetString(reader.GetOrdinal("Cognome")),
                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                Indirizzo = reader.GetString(reader.GetOrdinal("Indirizzo")),
                Citta = reader.GetString(reader.GetOrdinal("Città")),
                CAP = reader.GetString(reader.GetOrdinal("CAP")),
                Cod_Fisc = reader.GetString(reader.GetOrdinal("Cod_Fisc"))
            };
        }

        //****************************************************************************

        public void WriteTrasgressori(Anagrafica Trasgressori)
        {
            var _connection = GetConnection();
            var command = GetCommand(commandWriteTrasgressori);
            command.Parameters.Add(new SqlParameter("@Nome", Trasgressori.Nome));
            command.Parameters.Add(new SqlParameter("@Cognome", Trasgressori.Cognome));
            command.Parameters.Add(new SqlParameter("@Indirizzo", Trasgressori.Indirizzo));
            command.Parameters.Add(new SqlParameter("@Città", Trasgressori.Citta));
            command.Parameters.Add(new SqlParameter("@CAP", Trasgressori.CAP));
            command.Parameters.Add(new SqlParameter("@Cod_Fisc", Trasgressori.Cod_Fisc));
            _connection.Open();
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
