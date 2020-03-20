using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class OrderDrinkService
    {
        private OrderDrinkDAO orderDrinkDAO = new OrderDrinkDAO();

        public Rapport CreateReport(DateTime begintime, DateTime endtime)
        {
            DateTime newendtime = new DateTime(endtime.Year, endtime.Month, endtime.Day + 1);

            if (begintime > endtime)
                throw new Exception("Begin staat op een latere datum dan Eind");

            if (endtime > DateTime.Now)
                throw new Exception("Eind is later dan vandaag");

            return orderDrinkDAO.makeRapport(begintime, newendtime);
        }
    }
}
