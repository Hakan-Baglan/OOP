﻿ using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySqlServer mySqlServer = new MySqlServer();
            mySqlServer.Add();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Delete by default");
        }
    }

    class SqlServer: Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by SqlCode");
            //base.Add();
        }
    }

    class MySqlServer: Database
    {

    }
}
