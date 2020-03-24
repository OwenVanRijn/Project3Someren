using System;
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
        public void AddOrderDrinks(int studentid, int drinkId, int amount)
        {
            int orderid;
            string query = "INSERT INTO orders (person) VALUES (@user); SELECT SCOPE_IDENTITY() AS orderid";

            SqlParameter[] args = {
                new SqlParameter("@user", studentid)
            };

            DataTable dataTable = ExecuteSelectQuery(query, args);
            orderid = Decimal.ToInt32(((decimal)dataTable.Rows[0]["orderid"]));

            query = "INSERT INTO order_drink ([order], drink, amount) VALUES (@order, @drink, @amount)";

            SqlParameter[] args2 = {
                new SqlParameter("@order", orderid),
                new SqlParameter("@drink", drinkId),
                new SqlParameter("@amount", amount)
            };

            ExecuteEditQuery(query, args2);

            query = "UPDATE drink Set amount = amount - @amount where [id] = @drinkid";

            SqlParameter[] args3 = {
                new SqlParameter("@amount", amount),
                new SqlParameter("@drinkid", drinkId)
            };

            ExecuteEditQuery(query, args3);
        }

        public string getProfit(int btw, DateTime begintime, DateTime endtime)
        {
            string query = "SELECT SUM(price * order_drink.amount * drink.btw) AS test FROM orders INNER JOIN order_drink ON orders.id = order_drink.[order] INNER JOIN drink ON order_drink.drink = drink.id AND drink.btw=@btw AND orders.creationDate > @begindate AND orders.creationDate < @enddate";

            SqlParameter[] args = {
                new SqlParameter("@btw", btw),
                new SqlParameter("@begindate", begintime),
                new SqlParameter("@enddate", endtime)
            };

            DataTable table = ExecuteSelectQuery(query, args);

            return table.Rows[0]["test"].ToString();
        }
    }
}
