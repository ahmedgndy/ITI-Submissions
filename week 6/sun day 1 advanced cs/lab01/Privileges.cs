using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    [Flags]
    public enum Privileges {
        guest = 1,
        admin = 2,
        developer = 4,
        DBA = 16 ,
        secreary = developer | admin | guest | DBA,
    }
}
