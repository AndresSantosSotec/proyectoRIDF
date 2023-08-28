using System;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Windows.Forms;

namespace ProyectoRIFD_final
{
    public partial class frm_usuario : Form
    {
        private SerialPort arduinoSerialPort;
        private string connectionString = "Server=DESKTOP-368AM7B\\SQLEXPRESS;Database=db_RIFD_Proyect;Trusted_Connection=True;";

        public frm_usuario()
        {
            InitializeComponent();
            arduinoSerialPort = new SerialPort();
            arduinoSerialPort.PortName = "COM3";
            arduinoSerialPort.BaudRate = 9600;
            arduinoSerialPort.DataReceived += arduinoSerialPort_DataReceived;
            arduinoSerialPort.Open();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void arduinoSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string codigo = arduinoSerialPort.ReadLine();
                Invoke(new Action(() => txtcodigo.Text = codigo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frm_usuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduinoSerialPort.IsOpen)
            {
                arduinoSerialPort.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Consultar si el código ya está asignado a otro usuario
                    string checkQuery = "SELECT usuario FROM tb_usuarios WHERE codigo = @codigo";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@codigo", txtcodigo.Text);

                        object existingUser = checkCommand.ExecuteScalar();
                        if (existingUser != null)
                        {
                            MessageBox.Show("La tarjeta ya está asignada a otro usuario.");
                            txtcodigo.Text = "";
                            txtnombre.Text = "";
                            txtcontraseña.Text = "";
                            return;  // Salir del método sin realizar la inserción
                        }
                    }

                    string insertQuery = "INSERT INTO tb_usuarios (usuario, contraseña, codigo) VALUES (@usuario, @contraseña, @codigo)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@usuario", txtnombre.Text);
                        command.Parameters.AddWithValue("@contraseña", txtcontraseña.Text);
                        command.Parameters.AddWithValue("@codigo", txtcodigo.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos guardados correctamente.");
                            txtcodigo.Text = "";
                            txtnombre.Text = "";
                            txtcontraseña.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No se pudieron guardar los datos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            this.tb_usuariosTableAdapter.Fill(this.db_RIFD_ProyectDataSet.tb_usuarios);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM tb_usuarios";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }
    }
}
