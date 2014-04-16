using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建数据库访问网关            
            using (ORMSAMPLEEntities model = new ORMSAMPLEEntities())           
            {
                string sql = "Insert into [User] (innerid,code1,name) VALUES ('"+Guid.NewGuid().ToString()+"','05','lukf') ";
                int rowCount = model.ExecuteStoreCommand(sql, args);
              
                //User user = (from c in model.User   
                //            where c.ID == 1                         
                //            select c).SingleOrDefault<User>();                
                         
                //  //user = new User();
            
                // user.InnerID = Guid.NewGuid();
                // user.Code = "01";
                // user.Name = "lukefeng1";
                ////将创建的实体，放入网关的数据实体的集合               
                // //model.User.AddObject(user);                
                ////写回数据库  
                // model.SaveChanges();           
            }            
            Console.WriteLine("OK");        
        }
    }
}
