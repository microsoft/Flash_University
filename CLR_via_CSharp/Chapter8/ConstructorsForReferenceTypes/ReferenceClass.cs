using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsForReferenceTypes
{
    internal class ReferenceClass
    {
        ////these are   not valid because constructors can't be inherited
        //virtual ReferenceClass()
        //{
        //    //virtual --> can be overridden later
        //}

        //new ReferenceClass()
        //{
        //    //new --> redefine method in derived class
        //}

        //override ReferenceClass()
        //{
        //    // new implemention from a base class
        //}

        //sealed ReferenceClass()
        //{
        //    // class cannot be derived form
        //}

        //abstract ReferenceClass()
        //{
        //    //will be overridden in a derived class
        //}
    }
}
