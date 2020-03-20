using System.Collections.Generic;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDAO : Base
    {
        public List<Drink> getSpecificDrinks() {
            string query = "SELECT id, price, btw, amount, name FROM drink WHERE amount > 1 AND price > 1 ORDER BY amount DESC, price DESC";
            return drinksMapper(ExecuteSelectQuery(query));
        }

        private List<Drink> drinksMapper(DataTable table)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow row in table.Rows)
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
