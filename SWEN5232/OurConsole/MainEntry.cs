using System;

/// <summary>
/// User Interface Layer
/// </summary>
namespace SWEN5232.OurConsole
{
    using SWEN5232.BusinessLayer;
    using SWEN5232.TestBL_DL;
    class MainEntry
    {
        static void Main(string[] args)
        {
            //Testing Project Business Layer

          Console.WriteLine("Project Business Layer Test Start:");
         Console.WriteLine("Testing Save_Project Method...");
            Console.WriteLine("Enter Project ID:");
           string projectID=Console.ReadLine();
            int FloodLevel = 0;
            Console.WriteLine("Enter Flodd level:");
            int.TryParse(Console.ReadLine(), out FloodLevel);
            Console.WriteLine("Enter Project Name:");
            string projectName=Console.ReadLine();
            ProjectBL pbl = new ProjectBL();
            bool status=pbl.Save_Project(projectID, FloodLevel, projectName);
            if(status==true)
            {
                Console.WriteLine("Project Added Successfully..");
            }
            else
            {
               Console.WriteLine("Unable to add Project");

            }


            ////test delete project
            Console.WriteLine("Testing Delete_Project Method...");
            Console.WriteLine("Enter Project ID:");
            string pidForDelete = Console.ReadLine();
            bool statusOfDelete = pbl.Delete_Project(pidForDelete);
            if (statusOfDelete == true)
            {
               Console.WriteLine("Project Delete Successfully..");
            }
            else
            {
              Console.WriteLine("Unable to Delete Project");

            }

            ////test Open_Project 
            Console.WriteLine("Testing Open_Project Method...");
            Console.WriteLine("Enter Project ID:");
            string pidForOpenProject = Console.ReadLine();
            Project p = pbl.Open_Project(pidForOpenProject);
            if(p!=null)
            {
               Console.WriteLine("Project ID is {0}", p.ProjectID);
                Console.WriteLine("Project Name is {0}", p.ProjectName);
                Console.WriteLine("Flood Level is {0}", p.FloodLevel);


            }


            // End Testing Project Business Layer

            // Start Testing Location Business Layer

            Console.WriteLine("Location Business Layer Test Start:");
            Console.WriteLine("Testing Set_currentlocation Method...");
            Console.WriteLine("Enter Address:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Longitude:");

            string longitude = Console.ReadLine();
            Console.WriteLine("Enter Latitude:");

            string latitude = Console.ReadLine();
            LocationBL lbl = new LocationBL();
            lbl.Set_currentlocation(address, longitude, latitude);
            Console.WriteLine("Location save success.");
            Console.WriteLine("");

            Console.WriteLine("Testing Get_currentlocation Method...");
            Console.WriteLine("");

            Location lc = lbl.Get_currentlocation();
            if (lc != null)
            {
                Console.WriteLine("Address for current location is {0}", lc.Address);
                Console.WriteLine("");

                Console.WriteLine("Longitude current location is {0}", lc.Longitude);
                Console.WriteLine("");

                Console.WriteLine("Latitude current location is {0}", lc.Latitude);
                Console.WriteLine("");

            }
            Console.WriteLine("");

            Console.WriteLine("Testing Get_Location Method...");
            Console.WriteLine("");

            Location lct = lbl.Get_currentlocation();
            if (lct != null)
            {
           Console.WriteLine("Address found for given address line is {0}", lct.Address);
              Console.WriteLine("");

               Console.WriteLine("Longitude found for given address line is {0}", lct.Longitude);
                Console.WriteLine("");

                Console.WriteLine("Latitude found for given address line is {0}", lct.Latitude);
                Console.WriteLine("");

            }
          // Console.WriteLine("Project Business Layer Test Start:");
          // Console.WriteLine("Testing Update_Project Method...");
          // Console.WriteLine("Enter Project ID:");
          // string projectID=Console.ReadLine();
          // int FloodLevel = 0;
          // Console.WriteLine("Enter Flodd level:");
          // int.TryParse(Console.ReadLine(), out FloodLevel);
          // Console.WriteLine("Enter Project Name:");
          // string projectName=Console.ReadLine();
          // ProjectBL pbl = new ProjectBL();
          //  bool status=pbl.Update_Project(projectID, FloodLevel, projectName);
          // if(status==true)
          // {
          //  Console.WriteLine("Project updated Successfully..");
          // }
          // else
          // {
          //  Console.WriteLine("Unable to update Project");

          //}


           // End Location BL Test1


            //start Building BL test
            Console.WriteLine("Model Business Layer Test Start:");
            Console.WriteLine("Testing Set_Model Method...");
        int height = 0;
        Console.WriteLine("Enter Height:");
            int.TryParse(Console.ReadLine(), out height);
            int length = 0;
            Console.WriteLine("Enter length:");
            int.TryParse(Console.ReadLine(), out length);
            int width = 0;
            Console.WriteLine("Enter width:");
            int.TryParse(Console.ReadLine(), out width);
            Console.WriteLine("Enter Name:");
           string name= Console.ReadLine();

            Console.WriteLine("Enter shape:");
            string shape = Console.ReadLine();
            Console.WriteLine("Enter type:");
            string type = Console.ReadLine();
            ModelBL bbl = new ModelBL();
            bool setModel=bbl.Set_Model(height, length, width, name, shape, type);
            if (setModel == true)
            {
                Console.WriteLine("Model details saved Successfully..");
            }
            else
            {
                Console.WriteLine("Unable to get Model details");
            }

            Console.WriteLine("");

            Console.WriteLine("Testing Get_Model Method...");
            Console.WriteLine("");

            Model bdl = bbl.GetModel();
            if (bdl != null)
            {
                Console.WriteLine("Height of the model is {0}", bdl.Height);
                Console.WriteLine("");

                Console.WriteLine("Length of the model is {0}", bdl.Length);
                Console.WriteLine("");

                Console.WriteLine("Width of the model is {0}", bdl.Width);
                Console.WriteLine("");

                Console.WriteLine("Type of the model is {0}", bdl.Type);
                Console.WriteLine("");


                Console.WriteLine("Shape of the building is {0}", bdl.Shape);
                Console.WriteLine("");
                Console.WriteLine("Name of the building is {0}", bdl.Name);
                Console.WriteLine("");
            }
            //end Building BL test

        }
    }
}
