using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SomerenModel;

namespace SomerenDAL
{
    public class OrderDrinkDAO : Base
    {
        public Rapport makeRapport(DateTime begintime, DateTime endtime)
        {
            int afzet = 0, klanten;
            decimal omzet = 0;

            string query = "select od.amount AS drinkamount, d.price AS drinkprice from order_drink AS od join orders AS o on od.[order] = o.id join drink AS d on od.drink = d.id where o.creationDate > @begindate AND o.creationDate < @enddate";
            SqlParameter[] args = {
                new SqlParameter("@begindate", begintime),
                new SqlParameter("@enddate", endtime)
            };
            DataTable table = ExecuteSelectQuery(query, args);

            foreach(DataRow row in table.Rows)
            {
                afzet += (int)row["drinkamount"];
                omzet += (int)row["drinkamount"] * (decimal)row["drinkprice"];
            }

            SqlParameter[] args2 = {
                new SqlParameter("@begindate", begintime),
                new SqlParameter("@enddate", endtime)
            };

            query = "select COUNT(DISTINCT person) AS [customercount] from orders where creationDate > @begindate AND creationDate < @enddate";
            table = ExecuteSelectQuery(query, args2);
            klanten = (int)table.Rows[0]["customercount"];

            Rapport rapport = new Rapport();
            rapport.Afzet = afzet;
            rapport.Omzet = omzet;
            rapport.Klanten = klanten;

            return rapport;
        }
    }
}
