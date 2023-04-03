using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    class HibasIsbnSzamException:Exception
    {
        long hibasIsbnSzam;

        public long HibasIsbnSzam
        {
            get { return hibasIsbnSzam; }
            set { hibasIsbnSzam = value; }
        }

    }

}
