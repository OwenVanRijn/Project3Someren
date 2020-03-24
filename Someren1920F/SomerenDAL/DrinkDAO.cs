using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDAO : Base
    {
        public List<Drink> getSpecificDrinks() {
            string query = "SELECT id, price, btw, amount, name FROM drink WHERE amount > 1 AND price > 1 ORDER BY amount DESC, price DESC";
            return drinksMapper(ExecuteSelectQuery(query));
        }

        private List<Drink> drinksMapper(DataTable drinksTable)
        {
            List<Drink> drinks = new List<Drink>();

            if (drinksTable == null)
            {
                MessageBox.Show("There are no drinks in the database", "No drinks found",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return drinks;
            }

            foreach (DataRow row in drinksTable.Rows)
            {
                Drink drink = new Drink()
                {
                    id = (int)row["id"],
                    price = (decimal)row["price"],
                    btw = (decimal)row["btw"],
                    amount = (int)row["amount"],
                    name = (string)row["name"]
                };

                drinks.Add(drink);
            }

            return drinks;
        }
    }
}
