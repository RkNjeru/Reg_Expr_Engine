using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExEngine
{
    class NFA
    {
        private string theRegEx;
        public NFA(string aRegExpr)
        {
            theRegEx = aRegExpr;
        }

        public bool isValidInput()
        {
            // check if input is a valid Regular Expression

            if(theRegEx.Equals(null))   // check for empty string 
            {
                return false;
            }
            // implement my own algorithm to check if input is valid

            return false;
        }

        public void myParser()
        {
            // implement Shunting-yard algorithm?
        }
    }
}
