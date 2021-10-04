using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion_semana10
{
    class Dvd:Item
    {
        public string _Director { get; set; }


        public string getDvd()
        {
            return "El director es "+_Director;
        }
       
        
    }
}
