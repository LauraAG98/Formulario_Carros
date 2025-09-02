using Datos;
using Logica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Principal
{
    public partial class Form1 : Form
    {
        CarroController controller;

        public Form1()
        {
            controller = new CarroController();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string color = txtColor.Text;

            string resultado = controller.GuardarDatos(placa, modelo, marca, color);

            MessageBox.Show(resultado);
            txtPlaca.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtColor.Text = "";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            var listaCarros = controller.VerCarros();

            string resultado = "";

            foreach (var carro in listaCarros)
            {
                resultado += "Placa: " + carro.placa + " Modelo: " + carro.modelo + " Marca: " + carro.marca + " Color: " + carro.color+Environment.NewLine;
                ;
            }

            MessageBox.Show(resultado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var carro = controller.buscarDatos(txtPlaca.Text);

            if (carro != null)
            {
                MessageBox.Show("Carro encontrado");
                txtPlaca.Text = carro.placa;
                txtModelo.Text = carro.modelo;
                txtMarca.Text = carro.marca;
                txtColor.Text = carro.color;
            }
            else {
                MessageBox.Show("Carro no encontrado");
            }
        }

        private void btnActualiz_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string modelo = txtModelo.Text;
            string marca = txtMarca.Text;
            string color = txtColor.Text;

            string resultado = controller.actualizarDatos(placa,modelo,marca,color);
            MessageBox.Show(resultado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;

            string resultado = controller.eliminarDatos(placa);
            MessageBox.Show(resultado);

                txtPlaca.Text="";
                txtModelo.Text = "";
                txtMarca.Text = "";
                txtColor.Text = "";
        }
    }
}
