using SWEN5232.TestBL_DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.BusinessLayer
{
  public class ProjectBL
    {

        public ProjectDL projectBusinessLayer;

        public ProjectBL()
        {
            projectBusinessLayer = new ProjectDL();
        }
        public bool Save_Project(string projectID,int floodLevel,string projectName)
        {
            Project p = new Project();
            p.ProjectID = projectID;
            p.FloodLevel = floodLevel;
            p.ProjectName = projectName;
            return projectBusinessLayer.Save_Project(p);
        }
        public bool Delete_Project(string projectID)
        {
            return projectBusinessLayer.Delete_Project(projectID);
        }
        public Project Open_Project(string projectID)
        {
            return projectBusinessLayer.Open_Project(projectID);
        }
        public bool Update_Project(string projectID, int floodLevel, string projectName)
        {
            Project p= Open_Project(projectID);
            p.FloodLevel = floodLevel;
            p.ProjectName = projectName;
            return projectBusinessLayer.Save_Project(p);
        }

    }
}

    