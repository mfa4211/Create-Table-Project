using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Table_Project
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=WINDOWS-CD7O5KF\\User;DATABASE=ProdiTI");
                con.Open();

                SqlCommand cm = new SqlCommand("Create table Mahasiswa_Coba(NIM char(12) not nu primary key," +
                    "Nama varchar(50), Alamat varchar(255), Jenis_Kelamin char (1))", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Tabel sukses dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops, sepertinya ada yang salah. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
    }
}