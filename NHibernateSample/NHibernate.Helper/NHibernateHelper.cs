﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Cfg;

namespace NHibernate.Helper
{
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory;

        public NHibernateHelper()
        {
            _sessionFactory = GetSessionFactory();
        }

        private ISessionFactory GetSessionFactory()
        {
            return (new Configuration()).Configure().BuildSessionFactory();
        }

        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }

    }
}
