using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise04.classes;
using System.Xml.Serialization;
using System.IO;


namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListOfShapes = new List<shapes>
            {new Circle {color="Red",Radius=2.5 },
            new Rectangle {color="Blue",Height=20.0,Width=10.0 },
            new Circle {color="Green",Radius=8.0 },
            new Circle {color="Purple",Radius=12.3 },
            new Rectangle {color="Blue",Height=45.0,Width=18.0 }

            };
            shapes srialed = new shapes();

            srialed.Serialize(ListOfShapes);
        }
        
    }
}
