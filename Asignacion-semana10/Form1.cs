using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignacion_semana10
{
    public partial class txtartist : Form
    {
        public txtartist()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // instancia
            Cd cd = new Cd();

            cd.settitle(" MINUTOS");
            cd.setcomment(" esta bonita ");
            cd._playinTime = " 2 horas";
            cd._artist = " RICARDO ARJONA";
            cd._numberOfTracks = "10";

            


            


 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = txttype.Text;
            if (answer == "CD")
            {
                Item item = new Item();
                Cd cd = new Cd();
                cd.settitle(txttitulocd.Text);
                cd.setartist(txtartista.Text);
                cd.setnumberOfTracsk(txtNumberoftrack.Text);
                cd._playinTime = txtplayintrack.Text;
                cd.setcomment(txtcommentcd.Text);
                lstcontenido.Items.Add(cd.gettitle());
                lstcontenido.Items.Add(cd.getartist());
                lstcontenido.Items.Add(cd.getnumberOfTracsk());
                lstcontenido.Items.Add("La duracion del CD es:" + cd._playinTime);
                lstcontenido.Items.Add(cd.getcomment());
                lstcontenido.Items.Add(cd.print());
            }
            else
            {
                if (answer == "DVD")
                {
                    Dvd dvd = new Dvd();
                    dvd.settitle(txttitulodvd.Text);
                    dvd._Director = txtdirector.Text;
                    dvd.setcomment(txtcomentariodvd.Text);
                    lstcontenido.Items.Add(dvd.gettitle());
                    lstcontenido.Items.Add(dvd._Director);
                    lstcontenido.Items.Add(dvd.getcomment());
                   

                        }
                
            }
            }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnend_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

