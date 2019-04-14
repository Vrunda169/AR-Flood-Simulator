using SWEN5232.TestBL_DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.BusinessLayer
{
    public class ModelBL
    {
        public ModelDL modelBusinessLayer;
        public ModelBL()
        {
            modelBusinessLayer = new ModelDL();
        }

        /// <summary>
        /// Method to get the Building 
        /// </summary>
        /// <returns>Building height,length,width,name,shape,type</returns>

        public Model GetModel()
        {
            return modelBusinessLayer.Get_Model();
        }
        /// <summary>
        /// set the values of building
        /// </summary>
        /// <param name="height"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="name"></param>
        /// <param name="shape"></param>
        /// <param name="type"></param>
        /// <returns>Sets the values for building</returns>
        public bool Set_Model(int height, int length, int width, string name, string shape, string type)
        {
            Model bl = new Model();
            bl.Height = height;
            bl.Length = length;
            bl.Width = width;
            bl.Name = name;
            bl.Shape = shape;
            bl.Type = type;

            return modelBusinessLayer.Set_Model(bl);
        }
    }
}
