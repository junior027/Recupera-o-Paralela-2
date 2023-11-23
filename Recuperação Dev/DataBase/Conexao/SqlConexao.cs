using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Conexao
{
    internal class SqlConexao
    {
        /// <summary>
        /// Metodo que <c>StrConexao()</c> retorna a string de conexão sql
        /// </summary>
        /// <returns>string: ConnectionString</returns>
        internal static string StrConexao()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=AdvAbc;User ID=sa;Password=sql2022;Trusted_Connection=False; TrustServerCertificate=True;";
        }
    }
}
