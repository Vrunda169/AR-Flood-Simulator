using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.TestBL_DL
{

    /// <summary>
    /// Class to save/fetch data related to Projects.
    /// </summary>
    public class ProjectDL
    {
        Project pr;
        public ProjectDL()
        {
            pr = new Project() {
            ProjectName="New Project",
            FloodLevel=5
            };
        }
        /// <summary>
        /// Method to save whole project into firebase.
        /// </summary>
        /// <param name="project">Project object</param>
        /// <returns>True if saved successfully otherwise false.</returns>
        public bool Save_Project(Project project)
        {
            bool isSaved = false;
            if (project != null)
            {
                pr.ProjectID = project.ProjectID;
                pr.FloodLevel = project.FloodLevel;
                pr.ProjectName = project.ProjectName;
                isSaved = true;
            }
            return isSaved;
        }

        /// <summary>
        /// Method to delete project from firebase based on project ID.
        /// </summary>
        /// <param name="project">Project Obj with project ID.</param>
        /// <returns>Returns true if project is deleted successfully otherwise false.</returns>
        public bool Delete_Project(string projectID)
        {
            bool isDeleted = true;

            return isDeleted;
        }

        /// <summary>
        /// Method to get the project data by project id from firebase.
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public Project Open_Project(string projectId)
        {
            return pr;
        }

    }
}

