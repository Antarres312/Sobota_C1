using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Lokacje
{
    public abstract class Lokacja
    {
        public virtual Lokacja Start()
        {
            return null;
        }
    }
}
