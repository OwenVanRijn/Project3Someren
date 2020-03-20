using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class DrinkService
    {
        DrinkDAO drinkDAO = new DrinkDAO();

        public List<Drink> getDrinks()
        {
            List<Drink> drinks = drinkDAO.getSpecificDrinks();
            return drinks;

            // TODO: Add check and notification for zero results
        }
    }
}
