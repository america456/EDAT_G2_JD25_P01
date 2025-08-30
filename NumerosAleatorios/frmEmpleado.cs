namespace NumerosAleatorios
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
          
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            
            List<string> nombresMasculinos = new List<string>();
            nombresMasculinos.Add("Juan");
            nombresMasculinos.Add("Carlos");
            nombresMasculinos.Add("Luis");
            nombresMasculinos.Add("Miguel");

            List<string> nombresFemeninos = new List<string>();
            nombresFemeninos.Add("María");
            nombresFemeninos.Add("Ana");
            nombresFemeninos.Add("Laura");
            nombresFemeninos.Add("Carmen");

            List<string> apellidos = new List<string>();
            apellidos.Add("García");
            apellidos.Add("Rodríguez");
            apellidos.Add("Hernández");
            apellidos.Add("Fernández");

            int numero = random.Next(1000, 10000);
            bool esMasculino = (random.Next(2) == 0);
            string sexo = esMasculino ? "Masculino" : "Femenino";

            string nombreCompleto = "";
            if (esMasculino)
            {
                int indiceNombre = random.Next(0, nombresMasculinos.Count);
                int indiceApellido1 = random.Next(0, apellidos.Count);
                int indiceApellido2;
                do
                {
                    indiceApellido2 = random.Next(0, apellidos.Count);
                } while (indiceApellido2 == indiceApellido1);
                nombreCompleto = nombresMasculinos[indiceNombre] + " " + apellidos[indiceApellido1] + " " + apellidos[indiceApellido2];
            }
            else
            {
                int indiceNombre = random.Next(0, nombresFemeninos.Count);
                int indiceApellido1 = random.Next(0, apellidos.Count);
                int indiceApellido2;
                do
                {
                    indiceApellido2 = random.Next(0, apellidos.Count);
                } while (indiceApellido2 == indiceApellido1);
                nombreCompleto = nombresFemeninos[indiceNombre] + " " + apellidos[indiceApellido1] + " " + apellidos[indiceApellido2];
            }

            DateTime fechaMinima = DateTime.Today.AddYears(-40);
            DateTime fechaMaxima = DateTime.Today.AddYears(-18);
            int rangoDias = (fechaMaxima - fechaMinima).Days;
            DateTime fechaNacimiento = fechaMinima.AddDays(random.Next(rangoDias));

            char[] grupos = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            char grupo = grupos[random.Next(0, grupos.Length)];

            double sueldo = Math.Round(random.Next(1000, 10001) + random.NextDouble(), 2);
            bool seguroMedico = (random.Next(2) == 0);

           
            textnum.Text = numero.ToString();
            textname.Text = nombreCompleto;
            datefec.Value = fechaNacimiento;
            chkMasculino.Checked = (sexo == "Masculino");
            chkFemenino.Checked = (sexo == "Femenino");
            comgrup.Text = grupo.ToString();
            texsueld.Text = sueldo.ToString();
            checkmedi.Checked = seguroMedico;

        }



    }
    }


