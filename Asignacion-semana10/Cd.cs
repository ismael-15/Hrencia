using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion_semana10
{
    class Cd:Item
    {
        public string _artist;
        public string _numberOfTracks;


        //metodo
        public string getartist()
        {
            return "Nombre del artista:"+ _artist;
        }
        public void setartist(string artist)
        {
            _artist = artist;
        }

        public override string print()
        {
            return "Sony music "+base.print();
        }

        public string getnumberOfTracsk()
        {
            return "El numero de pistas son:"+ _numberOfTracks;
        }
        public void setnumberOfTracsk(string numberOfTracks)
        {
            _numberOfTracks = numberOfTracks;
            
        }



       
    }
   
    
}
