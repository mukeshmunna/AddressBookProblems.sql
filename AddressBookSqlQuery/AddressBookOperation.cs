﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem_ADO
{
    public class AddressBookOperation
    {
        private SqlConnection con;    
        private void connection()
        {
            string connectionStr = "data source = (localdb)\\MSSQLLocalDB; initial catalog=AddressBookService;integrated security = true ";
            con = new SqlConnection(connectionStr);
        }

        public void DatabaseCreated()
        {
            SqlConnection con = new SqlConnection("data source = (localdb)\\MSSQLLocalDB; initial catalog=master;integrated security = true ");
            try
            {
                string query = "Create Database AddressBookService";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("DataBase Created Sucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no database created ");
            }
            finally
            {
                con.Close();
            }
        }
        public void CreateingTable()
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddEmployee", con);
                com.CommandType = CommandType.StoredProcedure;
                string query = "Create table AddressBook(\r\nid int primary key identity(1,1),\r\nfirstName varchar(20),\r\nlastName varchar(20),\r\naddress varchar(30), \r\ncity varchar(20),\r\nstate varchar(20), \r\nzip bigint, \r\nphone varchar(10),\r\nemail varchar(30),\r\n)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table  Created Suucessfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Date Not Updated");
            }
            finally
            {
                con.Close();
            }
        }

        public bool AddEmployee(AddressModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("AddContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FirstName", obj.FirstName);
                com.Parameters.AddWithValue("@LastName", obj.LastName);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@City", obj.City);
                com.Parameters.AddWithValue("@State", obj.State);
                com.Parameters.AddWithValue("@Zip", obj.Zip);
                com.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@Email", obj.Email);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public bool EditData(AddressModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("EditContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FirstName", obj.FirstName);
                com.Parameters.AddWithValue("@LastName", obj.LastName);
                com.Parameters.AddWithValue("@Address", obj.Address);
                com.Parameters.AddWithValue("@City", obj.City);
                com.Parameters.AddWithValue("@State", obj.State);
                com.Parameters.AddWithValue("@Zip", obj.Zip);
                com.Parameters.AddWithValue("@PhoneNumber", obj.PhoneNumber);
                com.Parameters.AddWithValue("@Email", obj.Email);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public bool DeleteDatat(AddressModel obj)
        {
            try
            {
                connection();
                SqlCommand com = new SqlCommand("DeleteContactDetails", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@FirstName", obj.FirstName);
                con.Open();
                int i = com.ExecuteNonQuery();
                con.Close();
                if (i != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public List<AddressModel> GetAllEmployeeDetailsByCity(string City)
        {
            connection();
            List<AddressModel> emplist = new List<AddressModel>();
            SqlCommand com = new SqlCommand("DetailsinCity", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@city", City);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                emplist.Add(
                    new AddressModel
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        FirstName = Convert.ToString(dr["firstname"]),
                        LastName = Convert.ToString(dr["lastname"]),
                        Address = Convert.ToString(dr["address"]),
                        City = Convert.ToString(dr["city"]),
                        State = Convert.ToString(dr["state"]),
                        Zip = Convert.ToInt64(dr["zip"]),
                        PhoneNumber = Convert.ToString(dr["phone"]),
                        Email = Convert.ToString(dr["email"]),

                    }
                    );
            }
            return emplist;

        }
        public List<AddressModel> GetAllEmployeeDetailsByState(string statesearch)
        {
            connection();
            List<AddressModel> emplist = new List<AddressModel>();
            SqlCommand com = new SqlCommand("DetailsinState", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@State", statesearch);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            con.Open();
            da.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                emplist.Add(
                    new AddressModel
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        FirstName = Convert.ToString(dr["firstname"]),
                        LastName = Convert.ToString(dr["lastname"]),
                        Address = Convert.ToString(dr["address"]),
                        City = Convert.ToString(dr["city"]),
                        State = Convert.ToString(dr["state"]),
                        Zip = Convert.ToInt64(dr["zip"]),
                        PhoneNumber = Convert.ToString(dr["phone"]),
                        Email = Convert.ToString(dr["email"]),

                    }
                    );
            }
            return emplist;

        }
        public void DisplayAllDataByCity(string search)
        {
            try
            {

                List<AddressModel> employees = GetAllEmployeeDetailsByCity(search);

                foreach (AddressModel data in employees)
                {
                    Console.WriteLine($"Id: {data.Id}");
                    Console.WriteLine($"firstname: {data.FirstName}");
                    Console.WriteLine($"lastname: {data.LastName}");
                    Console.WriteLine($"Address: {data.Address}");
                    Console.WriteLine($"city: {data.City}");
                    Console.WriteLine($"state: {data.State}");
                    Console.WriteLine($"zip: {data.Zip}");
                    Console.WriteLine($"phone: {data.PhoneNumber}");
                    Console.WriteLine($"email: {data.Email}");
                    Console.WriteLine("$$");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        public void DisplayAllDataByState(string search)
        {
            try
            {

                List<AddressModel> employees = GetAllEmployeeDetailsByState(search);

                foreach (AddressModel data in employees)
                {
                    Console.WriteLine($"Id: {data.Id}");
                    Console.WriteLine($"firstname: {data.FirstName}");
                    Console.WriteLine($"lastname: {data.LastName}");
                    Console.WriteLine($"Address: {data.Address}");
                    Console.WriteLine($"city: {data.City}");
                    Console.WriteLine($"state: {data.State}");
                    Console.WriteLine($"zip: {data.Zip}");
                    Console.WriteLine($"phone: {data.PhoneNumber}");
                    Console.WriteLine($"email: {data.Email}");
                    Console.WriteLine("$$");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

    }

}
