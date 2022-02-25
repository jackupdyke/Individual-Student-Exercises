using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo.Classes.DAO
{
    class CustomerDAO
    {
        private string connectionString;

        public CustomerDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

    }
}
