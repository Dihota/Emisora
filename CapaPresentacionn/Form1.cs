using CapaNegocios;
using System;
using System.Windows.Forms;

namespace CapaPresentacionn
{
    public partial class Form1 : Form
    {
        CN_Artistas objetoCN = new CN_Artistas();
        string filtro;
        bool update = false;
        string id;
        string sms;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CN_cancion objetoCancion2 = new CN_cancion();
            Mostrar();
            pnArtista.Visible = true;
            pnCancion.Visible = false;
            pnAgregarArtista.Visible = false;
            pnAgregarCancion.Visible = false;
            comboBox2.DataSource = objetoCancion2.listarArtista();
            comboBox2.DisplayMember = "nombre";
        }

        private void aRTISTAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnCancion.Visible = false;
            pnArtista.Visible = true;
            pnAgregarArtista.Visible = false;
            limpiar();
        }

        private void cANCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnArtista.Visible = false;
            pnCancion.Visible = true;
            pnAgregarCancion.Visible = false;
            limpiar2();
        }

        //Artistas
        private void btnBucarArtista_Click(object sender, EventArgs e)
        {
            CN_Artistas objetoArtista1 = new CN_Artistas();
            filtro = txtFiltroArtista.Text;
            dgvArtista.DataSource = "";
            dgvArtista.DataSource = objetoArtista1.Filtrar(filtro);
          
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (update == false)
            {
                try
                {
                    if (txtNombre.Text.Length == 0 || txtPais.Text.Length == 0 || txtCasa.Text.Length == 0)
                    {
                        MessageBox.Show("Diligencie todos los datos.");
                    }
                    else
                    {
                        sms = objetoCN.Insertar(txtNombre.Text, txtPais.Text, txtCasa.Text);
                        MessageBox.Show(sms);
                        Mostrar();
                        limpiar();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("No se pudo crear el registro por :" + er);
                }
            }
            else
            {
                try
                {
                    if (txtNombre.Text.Length == 0 || txtPais.Text.Length == 0 || txtCasa.Text.Length == 0)
                    {
                        MessageBox.Show("Diligencie todos los datos.");
                    }
                    else
                    {
                        sms = objetoCN.actualizar(id,txtNombre.Text, txtPais.Text, txtCasa.Text);
                        MessageBox.Show(sms);
                        Mostrar();
                        limpiar();
                    }
                }
                catch (Exception er)
                {

                    MessageBox.Show("No se pudo actualizar el registro por :" + er);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            update = false;
            pnAgregarArtista.Visible = true;
            label2.Text = "Agregar artista";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            label2.Text = "Actualizar artista";
            if (dgvArtista.SelectedRows.Count >0)
            {
                pnAgregarArtista.Visible = true;
                update = true;
                id = dgvArtista.CurrentRow.Cells["IdArtista"].Value.ToString();
                txtNombre.Text = dgvArtista.CurrentRow.Cells["Nombre"].Value.ToString();
                txtPais.Text = dgvArtista.CurrentRow.Cells["Pais"].Value.ToString();
                txtCasa.Text = dgvArtista.CurrentRow.Cells["CasaDisquera"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArtista.SelectedRows.Count > 0)
            {
            
                id = dgvArtista.CurrentRow.Cells["IdArtista"].Value.ToString();
                sms = objetoCN.eliminar(id);
                MessageBox.Show(sms);
                Mostrar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }


        ///Cancion
        private void btnFiltrarCancion_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text.Length > 0 )
            {
                CN_cancion objetocancion1 = new CN_cancion();
                filtro = comboBox2.Text;
                dgvCancion.DataSource = objetocancion1.Filtrar(filtro);
            }
            else
            {
                Mostrar();
            }
        }

        private void btnagregarCancion_Click(object sender, EventArgs e)
        {
            CN_cancion objetoCancion3 = new CN_cancion();
            update = false;
            pnAgregarCancion.Visible = true;
            label12.Text = "Agregar cancion";
            comboBox1.DataSource = objetoCancion3.listarArtista();
            comboBox1.DisplayMember = "nombre";

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddCancion_Click(object sender, EventArgs e)
        {
            CN_cancion objetoCancion4 = new CN_cancion();
            if (update == false)
            {
                try
                {
                    if (comboBox1.Text.Length == 0 || txtcancion.Text.Length == 0)
                    {
                        MessageBox.Show("Diligencie todos los datos.");
                    }
                    else
                    {
                        sms = objetoCancion4.Insertar(comboBox1.Text, txtcancion.Text, txtDuracion.Text);
                        MessageBox.Show(sms);
                        Mostrar();
                        limpiar2();
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("No se pudo crear el registro por :" + er);
                }
            }
            else
            {
                try
                {
                    if (comboBox1.Text.Length == 0 || txtcancion.Text.Length == 0)
                    {
                        MessageBox.Show("Diligencie todos los datos.");
                    }
                    else
                    {
                        sms = objetoCancion4.actualizar(id, txtcancion.Text, txtDuracion.Text);
                        MessageBox.Show(sms);
                        Mostrar();
                        limpiar2();
                    }
                }
                catch (Exception er)
                {

                    MessageBox.Show("No se pudo actualizar el registro por :" + er);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label12.Text = "Actualizar cancion";
            if (dgvCancion.SelectedRows.Count > 0)
            {
                pnAgregarCancion.Visible = true;
                update = true;
                id = dgvCancion.CurrentRow.Cells["IdCancion"].Value.ToString();
                comboBox1.Text = dgvCancion.CurrentRow.Cells["Artistas"].Value.ToString();
                txtcancion.Text = dgvCancion.CurrentRow.Cells["Cancion"].Value.ToString();
                txtDuracion.Text = dgvCancion.CurrentRow.Cells["Duracion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEliminarCancion_Click(object sender, EventArgs e)
        {
            CN_cancion objetoCancion6 = new CN_cancion();
            if (dgvCancion.SelectedRows.Count > 0)
            {

                id = dgvCancion.CurrentRow.Cells["IdCancion"].Value.ToString();
                sms = objetoCancion6.eliminar(id);
                MessageBox.Show(sms);
                Mostrar();

            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodos

        private void Mostrar()
        {
            CN_Artistas objetoArtista = new CN_Artistas();
            CN_cancion objetoCancion = new CN_cancion();
            dgvArtista.DataSource = objetoArtista.Mostrarartistas();
            dgvCancion.DataSource = objetoCancion.Mostrararcancion();
        }

        public void limpiar()
        {
            txtNombre.Clear();
            txtPais.Clear();
            txtCasa.Clear();
            pnAgregarArtista.Visible = false;
        }

        public void limpiar2()
        {
            comboBox1.Text="";
            txtcancion.Clear();
            txtDuracion.Text = "00:00";
            pnAgregarCancion.Visible = false;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

      

    }
}
