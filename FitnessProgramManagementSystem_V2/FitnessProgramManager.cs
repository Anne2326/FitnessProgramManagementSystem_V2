using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessProgramManagementSystem_V2;

namespace FitnessProgramManagementSystem_V2
{
    internal class FitnessProgramManager
    {
        public List<Fitnessprogram> FitnessProgramList = new List<Fitnessprogram>();
        public FitnessProgramRepositary FitnessProgramRepository = new FitnessProgramRepositary();



        public void CreateFitnessProgram()
        {

            Console.WriteLine("Enter FitnessProgram ID: ");
            var id = Console.ReadLine();
            Console.WriteLine("Enter FitnessProgram Title: ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter FitnessProgram Duration:");
            var duration = Console.ReadLine();
            Console.WriteLine("Enter FitnessProgram price: ");

            var prices = decimal.Parse(Console.ReadLine());
            Console.WriteLine("FitnessProgram added successfully.");

            var program = new Fitnessprogram(id, title, duration, prices);


            FitnessProgramRepository.CreateFitnessProgram(program);









        }



        public void ReadFitnessPrograms()
        {
            FitnessProgramRepository.GetAll();


        }


        public void UpdateFitnessProgram()
        {

            Console.WriteLine("Enter Id");
            var id = (Console.ReadLine());

            var program = FitnessProgramList.Find(p => p.FitnessProgramId == id);

            if (program != null)
            {

                Console.WriteLine("Enter the FitnessProgram ID to update: ");
                var newid = Console.ReadLine();
                Console.WriteLine("Enter new Title: ");
                var newtitle = Console.ReadLine();
                var input= Capitalizeletter(Console.ReadLine(newtitle));
                Console.WriteLine("Enter new Duration: ");
                var newduration = Console.ReadLine();

                Console.WriteLine("Enter new price: ");
                var price = Console.ReadLine();

                Console.WriteLine("FitnessProgram updated successfully.");





                FitnessProgramRepository.UpdateFitnessProgram(program);








            }




        }


        public void DeleteFitnessProgram()
        {

            Console.WriteLine("eNTER ID");
            var id = (Console.ReadLine());

            var PROGRAM= FitnessProgramList.Find(p=>p.FitnessProgramId == id);

            if (PROGRAM != null) {




                FitnessProgramRepository.DeleteFitnessProgram(id);


            }







        }














    }    }