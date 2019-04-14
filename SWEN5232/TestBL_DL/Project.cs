using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.TestBL_DL
{
    public class Project
    {
        public string ProjectID { get; set; }

        
        private string projectName;
        
        private int floodLevel;
    
        private Model building;
       
        private Location location;

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
        public Model Building
        {
            get { return building; }
            set { building = value; }
        }
        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }
        public int FloodLevel
        {
            get { return floodLevel; }
            set { floodLevel = value; }
        }
    }
}

    
