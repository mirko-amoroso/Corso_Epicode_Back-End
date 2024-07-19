using Microsoft.Extensions.Configuration;
using Prog_S1_V.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_S1_V.Service
{
    public class TipoViolazioneDao : Dao_SQL
    {
        public TipoViolazioneDao(IConfiguration configuration) : base(configuration)
        {
        }

        public IEnumerable<TipoViolazione> getAllViolazione( )
        {
            List<TipoViolazione> listaViolazione = new List<TipoViolazione>();
            var _connection = GetConnection();
            var command = GetCommand("SELECT * FROM TIPO_VIOLAZIONE");
            _connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                listaViolazione.Add(CraeTipoViolazione(reader));
            }
            _connection.Close();
            return listaViolazione;
        }

        public TipoViolazione CraeTipoViolazione(DbDataReader reader)
        {
            return new TipoViolazione
            {
                IdViolazione = reader.GetInt32(reader.GetOrdinal("IdViolazione")),
                Descrizione = reader.GetString(reader.GetOrdinal("Descrizione"))
            };
        }
    }
}
