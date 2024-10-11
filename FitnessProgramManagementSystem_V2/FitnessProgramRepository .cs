using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FitnessProgramManagementSystem_V2
{
    internal class FitnessProgramRepositary
    {

        public string Connectionstring = "server=(localdb)\\MSSQLLocalDB) Intial Calatog=FitnessProgramManagement";



        public void CreateFitnessProgram(Fitnessprogram fitnessprogram)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {

                con.Open();
                string sql = "INSERT INTO FitnessPrograms(FitnessProgramId,Title,Duration,Price) VALUES(@FitnessProgramId,@Title,@Duration,@Price)";

                using (SqlCommand cmd = con.CreateCommand())
                {

                    cmd.Parameters.AddWithValue("@FitnessProgramId", fitnessprogram.FitnessProgramId);
                    cmd.Parameters.AddWithValue("@Title", fitnessprogram.Title);
                    cmd.Parameters.AddWithValue("@Duration", fitnessprogram.Duration);
                    cmd.Parameters.AddWithValue("@Price", fitnessprogram.Price);



                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Create successfully");


                }







            }

        }

        public void UpdateFitnessProgram(Fitnessprogram fitnessprogram)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {

                con.Open();
                string sql = "Update  FitnessPrograms set FitnessProgramId=@FitnessProgramId,Title=@Title,Duration=@Duration,Price=@Price where FitnessProgramId=@FitnessProgramId ";

                using (SqlCommand cmd = con.CreateCommand())
                {

                    cmd.Parameters.AddWithValue("@FitnessProgramId", fitnessprogram.FitnessProgramId);
                    cmd.Parameters.AddWithValue("@Title", fitnessprogram.Title);
                    cmd.Parameters.AddWithValue("@Duration", fitnessprogram.Duration);
                    cmd.Parameters.AddWithValue("@Price", fitnessprogram.Price);


                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    var row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {


                        Console.WriteLine("Update Suucessfully");


                    }

                    else
                    {
                        Console.WriteLine("Invalid Id");
                    }


                }







            }



        }

        public void DeleteFitnessProgram(string id)
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {

                con.Open();
                string sql = "delete from FitnessPrograms where FitnessProgramId=@FitnessProgramId ";

                using (SqlCommand cmd = con.CreateCommand())
                {

                    cmd.Parameters.AddWithValue("@FitnessProgramId", id);


                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    var row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {


                        Console.WriteLine("Delete Suucessfully");


                    }

                    else
                    {
                        Console.WriteLine("Invalid Id");
                    }


                }







            }



        }



        public string GetAll()
        {

            using (SqlConnection con = new SqlConnection(Connectionstring))
            {

                con.Open();
                string sql = "select * from FitnessPrograms";

                using (SqlCommand cmd = con.CreateCommand())
                {



                    string retuenstr = "";
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();

                    while (sqlDataReader.Read())
                    {


                        retuenstr += $"Id{sqlDataReader["FitnessProgramId"]} ,Title{sqlDataReader["Title"]}, Duration {sqlDataReader["Duration"]},Price{sqlDataReader["Price"]} ";





                    }

                    return retuenstr;


                }


















            }
        }




        public string Capitalizeletter(string title)
        {

            string letter = title.Substring(0, 1);
            string rem = title.Substring(1, title.Length - 1);

            return $"{letter.ToUpper()}{rem}";



        }














    }
}