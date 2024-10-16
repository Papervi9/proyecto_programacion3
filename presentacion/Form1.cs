namespace ProyectoForm
{
    public partial class fmprincipal : Form
    {
        public fmprincipal()
        {
            InitializeComponent();
            personalizar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrar(pnmenucita);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            mostrar(pnmenupagos);
        }

        private void personalizar()
        {

            pnmenucita.Visible = false;
            pnmenuclientes.Visible = false;
            pnmenupagos.Visible = false;
            pnmenuusuarios.Visible = false;
        }
        private void ocultar()
        {

            if (pnmenucita.Visible == true)
            {
                pnmenucita.Visible = false;
            }
            if (pnmenuclientes.Visible == true)
            {
                pnmenuclientes.Visible = false;
            }
            if (pnmenupagos.Visible == true)
            {
                pnmenupagos.Visible = false;

            }
            if (pnmenuusuarios.Visible == true)
            { pnmenuusuarios.Visible = false; }
        }

        private void mostrar(Panel pnmenu)
        {

            if (pnmenu.Visible == false)
            {
                ocultar();
                pnmenu.Visible = true;
            }
            else
            {

                pnmenu.Visible = false;
            }
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            mostrar(pnmenuclientes);
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            mostrar(pnmenuusuarios);
        }
        private Form activo = null;

        private void hijos(Form fhijo)
        {
            if (activo != null)
            {
                activo.Close(); // Cierra el formulario activo actual
            }

            // Establece el nuevo formulario como el formulario activo
            activo = fhijo;
            fhijo.TopLevel = false;
            fhijo.FormBorderStyle = FormBorderStyle.None;
            fhijo.Dock = DockStyle.Fill;


            pnhijo.Controls.Add(fhijo);
            pnhijo.Tag = fhijo;
            fhijo.BringToFront();
            fhijo.Show();
        }

        private void btnagregarcita_Click(object sender, EventArgs e)
        {

        }

        private void btnvercitas_Click(object sender, EventArgs e)
        {
            hijos(new Cita());
        }
    }


}
