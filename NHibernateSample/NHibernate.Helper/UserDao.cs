using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Entity;

namespace NHibernate.Helper
{
   public class UserDao
    {
       private NHibernateHelper nhibernateHelper = new NHibernateHelper();

        protected ISession Session { get; set; }

        public UserDao() {
            this.Session = nhibernateHelper.GetSession();
        }

        public UserDao(ISession session)
        {
            this.Session = session;
        }

        public void CreateUser(User user)
        {
            Session.Save(user);
            Session.Flush();
        }

    

        public User GetUserById(int userId)
        {
            return Session.Get<User>(userId);
        }

        public IList<User> GetUsers()
        {
            IList<User> list = null;
            list = Session.QueryOver<User>().List();
            return list;
        }

    }
}
