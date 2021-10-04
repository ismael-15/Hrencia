using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asignacion_semana10
{
    class Item
    {
        //propiedades
        private string _title;
       
        public string _playinTime { get; set; }

        private string _comment;

        //metodo
     

        public string gettitle()
        {
            return "El titulo es:" + _title;
        }
        public void settitle(string title)
        {
            _title = title;
        }

        public string getcomment()
        {
            return "Comentarios:"+ _comment;
        }
        public void setcomment(string comment)
        {
            _comment = comment;
        }
        public virtual string print()
        {
            return "La empresa que lo publica es:";
        }
       
    }    
}
