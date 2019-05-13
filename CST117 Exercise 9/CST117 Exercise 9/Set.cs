//Corrected by Seth Thompson
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST117_Exercise_9
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            //for (int i = 0; i < elements.Count; i++)
            //{
            //    if (val == elements[i])
            //        return true;
            //    else
            //        return false;
            //}
            //return false;

            //code fix: replaced code with the built in .Contains method for the List<T> class
            return elements.Contains(val);
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            //code fix: method needs to return a new Set object instead of altering a pre-existing object
            Set union = new Set();

            //code fix: new union Set object has the current elements added to it.
            for (int i = 0; i < this.elements.Count; i++)
            {
                union.addElement(this.elements[i]);
            }

            //code fix: new union Set object has the new elements added to it.
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                //this.addElement(rhs.elements[i]);
                union.addElement(rhs.elements[i]);
            }

            //new return is given
            //return rhs
            return union;
        }
    }
}
