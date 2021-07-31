using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Exercise04.classes
{
    [XmlInclude(typeof(shapes))]
    [Serializable]
    public class shapes
    {
        private string _color = "";

        public string color
        {
            get { return _color; }
            set { _color = value; }
        }
        public void Serialize(List<shapes> shapess)
        {
            try
            {
               
                XmlSerializer serializer = new XmlSerializer( typeof(List<shapes>),new[] { typeof(shapes) });

                
                using (StreamWriter sw = new StreamWriter("shapes.xml"))
                {
                    
                    serializer.Serialize(sw, shapess);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
    [XmlInclude(typeof(Circle))]
    [Serializable]
    public class Circle : shapes
    {
        private double _Radius = 0;
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }
        public double area()
        {
            double A = 0;
            A = (3.14) * this.Radius * this.Radius;

            return A;
        }
    }
    public class Rectangle : shapes
    {
        private double _Height = 0;
        private double _Width = 0;
        public double Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        public double Width
        {
            get { return _Width; }
            set { _Width = value; }
        }
        public double area()
        {
            double A = 0;
            A = this.Width*this.Height;

            return A;
        }
    }

}
