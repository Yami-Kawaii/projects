using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Class_Thing
{
    class Shoes
    {
        string[] aSizes = {"XS","S","M","L"};
        string[] aModel = { "Air Force" ,"Air Max","Dunks"};

        private string Model;
        private string Size;

        public Shoes(string _Model, string _Size)
        {
            this.model = _Model;
            this.size = _Size;
        }

        public string size
        {
            get { return Size; }
            set { Size = value; }
        }
        public string model
        {
            get { return Model; }
            set { Model = value; }
        }
        
        public string sizeCheck(string size)
        {
            if (aSizes.Contains(size))
            {
                return ("Yes");
            }
            else
            {
                return ("No");
            }
        }

        public string modelCheck(string model)
        {
            if (aModel.Contains(model))
            {
                return("Yes");
            }
            else
            {
                return("No");
            }
        }
    }
}