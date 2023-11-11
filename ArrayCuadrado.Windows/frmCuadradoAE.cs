using ArrayCuadrados.Entidades;

namespace ArrayCuadrado.Windows
{
    public partial class frmCuadradoAE : Form
    {
        public frmCuadradoAE()
        {
            InitializeComponent();
        }
        private Cuadrado cuadrado;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosComboColorRelleno();
            CrearBotonesOpcionBordes();
            if (cuadrado != null)
            {
                txtLado.Text = cuadrado.GetLado().ToString();
            }
        }

        private void CrearBotonesOpcionBordes()
        {
            var listaBordes = Enum.GetValues(typeof(TipoDeBorde)).Cast<TipoDeBorde>().ToList();
            int x = 6;
            int y = 31;
            bool check = true;
            foreach (var itemBorde in listaBordes)
            {
                RadioButton rb = new RadioButton
                {
                    Text = itemBorde.ToString(),
                    Location = new Point(x, y),
                    Checked = check
                };
                gbxBordes.Controls.Add(rb);
                y += 30;
                check = false;
            }

        }

        private void CargarDatosComboColorRelleno()
        {
            var listaColores = Enum.GetValues(typeof(ColorRelleno)).Cast<ColorRelleno>().ToList();
            cboColores.DataSource = listaColores;
            cboColores.SelectedIndex = 0;
        }

        public Cuadrado GetCuadrado()
        {
            return cuadrado;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (cuadrado == null)
                {
                    cuadrado = new Cuadrado();
                }
                cuadrado.SetLado(int.Parse(txtLado.Text));
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLado.Text, out int lado))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Numero mal ingresado");
            }
            else if (lado <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Valor del lado no valido");
            }
            return valido;
        }

        public void SetCuadrado(Cuadrado? cuadrado)
        {
            this.cuadrado = cuadrado;
        }
    }
}
