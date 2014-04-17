using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Helper;
using NHibernate.Entity;
namespace NHibernateSample
{
    class Program
    {
        static void Main(string[] args)
        {
              NHibernate.Helper.UserDao UserDao = new NHibernate.Helper.UserDao();
            IList<User> list=UserDao.GetUsers();
            foreach (var a in list)
            {
                Console.WriteLine(a.ID+":"+a.Code +":"+a.Name); 
            }
            Console.ReadLine();
        }
    }
}
