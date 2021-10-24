using System;
using System.Collections.Generic;
using System.Text;

namespace classExercises
{
    /**
     * Interesting stuff, needto learn more about this... ToTheMoon 
     */
    public class testClass
    {
        public testClass()
        {
            Name = "unknown";
        }
        public testClass(string name)
        {
            Name = name;
        }

        public string Name
        {
            get;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
