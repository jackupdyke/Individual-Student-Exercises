using System;
using System.Collections.Generic;
using System.Text;

namespace PetInfo.Classes.DAO
{
    class ActivityDAO
    {
        private string connectionString;

        public ActivityDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
