using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Tediu.FoodOrder.website.Models.EFModel;

namespace Tediu.FoodOrder.website.Models.Repository
{
    interface IFoodRepository
    {
        void Create(FoodTableModel Model);
        void Update(int id,FoodTableModel model);

        List<FoodTableModel> getall();

        List<FoodTableModel> getid();

        void Delete(int id);
    }
    public class FoodRepository:IFoodRepository
    {
        private string datasouce =@"Data Source=TEDLIUCOMPUTER\SQLEXPRESS;Initial Catalog=DemoProject;Integrated Security=True";

        public void Create(FoodTableModel Model)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FoodTableModel> getall()
        {
            throw new NotImplementedException();
        }

        public List<FoodTableModel> getid()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, FoodTableModel model)
        {
            throw new NotImplementedException();
        }
    }
}
