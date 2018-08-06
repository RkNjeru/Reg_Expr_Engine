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
        private int op, cl;
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
            theRegEx.Trim();
            theRegEx.Replace(" ", string.Empty);
            
            // implement my own algorithm to check if input is valid
            for (int i = 0; i < theRegEx.Length - 1; i++)
            {
                if (theRegEx[i].Equals('+'))
                {
                    if(theRegEx[i+1].Equals('.') || theRegEx[i+1].Equals('*') || theRegEx[i+1].Equals('(') || theRegEx[i+1].Equals(')') || theRegEx[i + 1].Equals('+')) { return false; }
                }
                if (theRegEx[i].Equals('.'))
                {
                    if(theRegEx[i + 1].Equals('+') || theRegEx[i + 1].Equals('.') || theRegEx[i + 1].Equals('*') || theRegEx[i + 1].Equals('(') || theRegEx[i + 1].Equals(')')) { return false; }
                }
                if (theRegEx[i].Equals('*'))
                {
                    if(theRegEx[i + 1].Equals('*') || theRegEx[i + 1].Equals('(')) { return false; }
                }
                if (theRegEx[i].Equals('('))
                {
                    if(theRegEx[i + 1].Equals('+') || theRegEx[i + 1].Equals('.') || theRegEx[i + 1].Equals('*')) { return false; }
                }
                if(theRegEx[i].Equals(')'))
                {
                    if (!theRegEx[i + 1].Equals('+') && !theRegEx[i + 1].Equals('.') && !theRegEx[i + 1].Equals('*') && !theRegEx[i + 1].Equals('(') && !theRegEx[i + 1].Equals(')')) { return false; }
                }

                // no repeating Literals e.g aa 
                if (!theRegEx[i].Equals('+') && !theRegEx[i].Equals('.') && !theRegEx[i].Equals('*') && !theRegEx[i].Equals('(') && !theRegEx[i].Equals(')'))
                {
                    if (!theRegEx[i+1].Equals('+') && !theRegEx[i+1].Equals('.') && !theRegEx[i+1].Equals('*') && !theRegEx[i+1].Equals('(') && !theRegEx[i+1].Equals(')')) { return false; }
                }
                if (theRegEx[i].Equals('(')){ op++; }
                if (theRegEx[i].Equals(')')){ cl++; }
            }
            if (op != cl) { return false; }
            
            
            return true;
        }

        public void myParser()
        {
            // implement Shunting-yard algorithm?
        }
    }
}
