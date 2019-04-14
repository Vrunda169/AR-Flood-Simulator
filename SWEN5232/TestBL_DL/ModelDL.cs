using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.TestBL_DL
{
    public class ModelDL
    {
        Model model;
        public ModelDL()
        {
            model = new Model
            {
                Height = 435,
                Length = 487,
                Width = 444,
                Shape = "Rectangle",
                Name = "Trump Tower",
                Type = "Office Building"
            };
        }
        public Model Get_Model()
        {
           return model;
        }

        public bool Set_Model(Model bl)
        {
            model.Height = bl.Height;
            model.Length = bl.Length;
            model.Width = bl.Width;
            model.Shape = bl.Shape;
            model.Name = bl.Name;
            model.Type = bl.Type;
            return true;
        }
    }
}
