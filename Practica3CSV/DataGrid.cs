using System.Windows.Forms;

namespace Practica3CSV
{
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            // Add your paint logic here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add your cell content click logic here
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Add your save button click logic here
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            // Primero, abre el archivo.
            DialogResult resultado;
            resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                string separador = ",";

                // Lee el archivo y lo guarda en un arreglo de strings.
                string[] lineas = File.ReadAllLines(filePath);

                // Crea un arreglo de arreglos de strings.
                string[][] datos = new string[lineas.Length][];

                // Separa los datos por coma.
                for (int i = 0; i < lineas.Length; i++)
                {
                    // Esto esta medio confuso, pero, lo que hace es que
                    // primero separa los datos por coma. La funcion split devuelve un arreglo de strings,
                    // entonces, al guardarlo en data[i], en cada subposicion de data[i], (osea, data[i][0], data[i][1], etc)
                    // se guardan strings diferentes, cada una perteneciendo a un dato diferente.
                    datos[i] = lineas[i].Split(separador);
                }

                // Crea el num. de columnas en base al total de datos en la primera fila.
                dataGridView.ColumnCount = datos[0].Length;

                // Crea las columnas con los nombres de la primera fila.
                for (int i = 0; i < datos[0].Length; i++)
                {
                    dataGridView.Columns[i].Name = datos[0][i];
                }

                // Agrega los datos a las filas.
                for (int i = 1; i < datos.Length; i++)
                {
                    dataGridView.Rows.Add(datos[i]);
                }
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                int total = dataGridView.RowCount;
                string[] lineas = new string[total]; // string linea = "";

                string nombreColumnas = "";
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                {
                    if (j == dataGridView.ColumnCount - 1)
                        nombreColumnas += dataGridView.Columns[j].Name;
                    else
                        nombreColumnas += dataGridView.Columns[j].Name + ",";
                }
                lineas[0] = nombreColumnas;

                for (int i = 1; i < total; i++)
                {
                    string linea = "";
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        if (j == dataGridView.ColumnCount - 1)
                            linea += dataGridView.Rows[i-1].Cells[j].Value.ToString() + "";
                        else
                            linea += dataGridView.Rows[i-1].Cells[j].Value.ToString() + ",";
                    }
                    lineas[i] = linea;


                }
                try // File.WriteAllText(filename, linea);
                {
                    File.WriteAllLines(filename, lineas);
                    MessageBox.Show("Archivo guardado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message);
                }
            }
        }
    }
}
