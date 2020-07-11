using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        protected readonly int id;
        private static int currentId =0;
        public AbstractEntity()
        {
            currentId += 1;
            id = currentId;
        }

    }
}
