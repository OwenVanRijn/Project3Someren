using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System;

namespace SomerenLogic
{
    public class BegeleiderService
    {
        BegeleiderDAO begeleiderDAO = new BegeleiderDAO();
        public List<Begeleider> GetBegeleiders()
        {
            return begeleiderDAO.GetBegeleiders();
        }
        public void DeleteBegeleider(string id)
        {
            int begeleider_id = int.Parse(id);
            begeleiderDAO.DeleteBegeleider(begeleider_id);
        }
        public void AddBegeleider(string id)
        {
            int begeleider_id = int.Parse(id);

            begeleiderDAO.AddBegeleider(begeleider_id);
        }
    }
}
