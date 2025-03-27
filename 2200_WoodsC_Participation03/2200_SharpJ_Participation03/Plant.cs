using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2200_SharpJ_Participation03
{
    // Base, Derived, Super Class

    public class Plant
    {
        // private fields

        private string _environment;
        private string _type;
        private string _name;

        // constructor (no-arg or parameterless)

        public Plant()
        {
            _environment = "";
            _type = string.Empty;
            _name = string.Empty;
        }

        // constructor (parameterized)

        public Plant( string env, string typ, string nm)
        {
            //_environment = env;
            Environment = env; //this uses the method below \/
            _type = typ;
            _name = nm;
        }

        // properties

        public string Environment
        {
            get { return _environment; }
            set { _environment = value; }            
        }

        public string Type
        { get { return _type; } set {  _type = value; } }

        public string Name
        {
            get { return _name; } set { _name = value; }
        }

        // sniff method

        public virtual string Sniff()
        { 
            return "Let's sniff plants.";
        }
    }
}
