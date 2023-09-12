using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowManipulator
{
    public class Human { public void Invalidate() { } }
    public class Parent : Human { }

    public class DaBlueCube : Human
    {
        public List<Parent> Parents = new List<Parent>();
        public string Sleep()
        {
            foreach(var Parent in Parents)
                Parent.Invalidate();

            return "No sleep";
        }
    }
}
