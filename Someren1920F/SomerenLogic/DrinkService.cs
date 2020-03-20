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
                List<Drink> drinks = drinkDAO.getSpeficDrinks();
                return drinks;
        }
    }
}
