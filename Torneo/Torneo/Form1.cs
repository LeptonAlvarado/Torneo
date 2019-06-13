using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Torneo
{
    public partial class Form1 : Form
    {
        Juego miJuego;
        Equipo miEquipo;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearequipo_Click(object sender, EventArgs e)
        {
            miJuego.agregarEquipo(txtNomEquipo.Text, Convert.ToInt32(txtNumEquipo.Text));
        }

        private void btnCrearjugador_Click(object sender, EventArgs e)
        {
            miEquipo.agregarJugador(txtNomJugador.Text, Convert.ToInt32(txtNumJugador.Text));
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            miJuego.Jugar();
        }

        private void btnBorrarjugador_Click(object sender, EventArgs e)
        {
            miEquipo.eliminarJugador(Convert.ToInt32(txtNumJugador.Text));
        }

        private void btnBorrarequipo_Click(object sender, EventArgs e)
        {
            miJuego.eliminarEquipo(Convert.ToInt32(txtNumEquipo.Text));
        }

        private void btnMostrarequipo_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i=0; i<miJuego.Equipos.Count; i++)
            {
                listBox1.Items.Add(miJuego.Equipos[i]);
            }
        }

        private void btnMostrarjugadores_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add(miEquipo.Jugadores[Convert.ToInt32(txtNumJugador.Text)]);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string rutaArchivo;
            rutaArchivo = saveFileDialog1.FileName;
            FileStream fs = new FileStream(rutaArchivo, FileMode.Create);
            StreamWriter escritor = new StreamWriter(fs);

            for (int i = 0; i < listBox1.Items.Count; i++)
                escritor.WriteLine(listBox1.Items[i].ToString());

            escritor.WriteLine("JUEGO" + Environment.NewLine + miJuego.Jugar());
            
        }
    }

 }

