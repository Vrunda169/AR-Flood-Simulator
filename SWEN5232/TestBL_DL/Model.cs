﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWEN5232.TestBL_DL
{
    public class Model
    {
 
        private int height;

      
        private int length;

      
        private int width;

       
        private string name;
        
        private string shape;

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Shape
        {
            get { return shape; }
            set { shape = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Length
        {
            get { return length; }
            set { length = value; }
        }

    }
}

    

