using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

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
        private string TableName="FoodTable";

        public void Create(FoodTableModel Model)
        {
            using (var conn = new SqlConnection(datasouce))
            {
                //string sql = $"INSERT INTO {tableName}(Name,Capacity,Enabled)VALUES(@Name,@Capacity,@Enabled)";
                var sql = $"INSERT INTO {TableName}(FoodName,FoodPrice,dep,Name)VALUES(@FoodName,@FoodPrice,@dep,@Name)";
                conn.Execute(sql,Model);

            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FoodTableModel> getall()
        {
            using (var conn =new SqlConnection(datasouce))
            {
                var sql = $"select * from {TableName}";
                return conn.Query<FoodTableModel>(sql).ToList();
            }

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
