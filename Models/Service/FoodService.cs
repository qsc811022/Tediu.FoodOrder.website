using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Tediu.FoodOrder.website.Models.EFModel;
using Tediu.FoodOrder.website.Models.Repository;

namespace Tediu.FoodOrder.website.Models.Service
{
    public class FoodService
    {
        private FoodRepository repo = new FoodRepository();

        public List<FoodTableModel> getall()
        {
            return repo.getall();
        }
        
        public void Create(FoodTableModel model)
        {
           if(model.Name)
           repo.Create(model);
        }

    }
}
