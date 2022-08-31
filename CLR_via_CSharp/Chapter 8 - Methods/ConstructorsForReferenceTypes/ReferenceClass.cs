using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsForReferenceTypes
{
    internal class ReferenceClass
    {
        public ReferenceClass MemberwiseCopy()
        {
            return (ReferenceClass)this.MemberwiseClone();
        }
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
    abstract class AbstractReferenceClass
    {
        //can't reproduce the "protected constructor"//TODO for later/question for the group pg 182
    }

    internal sealed class RandomTypeToLookAtInIl
    {
        private Int32 m_x = 6;
    }
}

