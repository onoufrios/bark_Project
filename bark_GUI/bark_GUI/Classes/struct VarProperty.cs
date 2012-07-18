using System.Collections.Generic;

namespace bark_GUI
{
    struct VarProperty
    {
        //first name is the elements name
        //second name is part of an attribute name
        //possible second names: time_unit & temperature_unit
        public string name1;
        public string name2;
        public List<string> values1;
        public List<string> values2;
        public string unit1;
        public string unit2;
    }
}