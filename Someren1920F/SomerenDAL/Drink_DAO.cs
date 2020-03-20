using System.Collections.Generic;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class DrinkDAO : Base
    {
        public List<Drink> getSpeficDrinks() {
            string query = "SELECT price, btw, amount, name FROM drink WHERE amount > 1 AND price > 1 ORDER BY amount DESC, price DESC";
            return drinksMapper(ExecuteSelectQuery(query));
        }

        private List<Drink> drinksMapper(DataTable studentsTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow studentRow in studentsTable.Rows)
            {
                Drink drink = new Drink()
                {
                    price = (decimal)studentRow["price"],
                    btw = (decimal)studentRow["btw"],
                    amount = (int)studentRow["amount"],
                    name = (string)studentRow["name"]
                };

                drinks.Add(drink);
            }

            return drinks;
        }
    }
}
