using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCRUDApplication
{
    public class Person
    {
        private string name = null;
        private string surName = null;
        private string sourceBalance = null;

        // encapsulation
        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string SourceBalance { get => sourceBalance; set => sourceBalance = value; }

        public Person(string _name, string _surName, string _sourceBalance)
        {
            this.Name = _name;
            this.SurName = _surName;
            this.SourceBalance = _sourceBalance;
        }

        public bool AddPerson(ConnectionHelper connectionHelper)
        {
            return this.ExecuteProc(connectionHelper, "add_Person");
        }

        int ID;
        public bool UpdatePerson(ConnectionHelper connectionHelper, int _ID)
        {
            ID = _ID;
            return this.ExecuteProc(connectionHelper, "update_Person");
        }

        public bool DeletePerson(ConnectionHelper connectionHelper, int _ID)
        {
            ID = _ID;
            return this.ExecuteProc(connectionHelper, "delete_Person");
        }

        public bool ExecuteProc(ConnectionHelper connectionHelper, string prcdName)
        {
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = prcdName;
                    command.Connection = connectionHelper.Con;

                    if (prcdName == "add_Person")
                    {
                        SqlParameter[] parameters = new SqlParameter[3] {
                            new SqlParameter("@_name", this.Name),  // input variable must be same as in input variable in stored procedure in sql
                        new SqlParameter("@_surname", this.SurName),
                        new SqlParameter("@_SourceBalance", this.SourceBalance)
                        };

                        foreach (SqlParameter p in parameters)
                        {
                            p.Direction = ParameterDirection.Input;
                            command.Parameters.Add(p);
                        }
                        command.ExecuteNonQuery();
                    }

                    else if (prcdName == "update_Person")
                    {
                        SqlParameter[] parameters = new SqlParameter[4] {
                            new SqlParameter("@_personId", this.ID),
                            new SqlParameter("@_newName", this.Name),  // input variable must be same as in input variable in stored procedure in sql
                        new SqlParameter("@_newSurname", this.SurName),
                        new SqlParameter("@_newSourceBalance", this.SourceBalance)
                        };

                        foreach (SqlParameter p in parameters)
                        {
                            p.Direction = ParameterDirection.Input;
                            command.Parameters.Add(p);
                        }
                        command.ExecuteNonQuery();
                    }

                    else if (prcdName == "delete_Person")
                    {
                        SqlParameter param = new SqlParameter("@_ID", this.ID);
                        param.Direction = ParameterDirection.Input;
                        command.Parameters.Add(param);
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
