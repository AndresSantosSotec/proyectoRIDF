using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoRIFD_final
{
    public partial class Form1 : Form
    {
        private SerialPort arduinoSerialPort;
        private string connectionString = "Server=DESKTOP-368AM7B\\SQLEXPRESS;Database=db_RIFD_Proyect;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            arduinoSerialPort = new SerialPort();
            arduinoSerialPort.PortName = "COM3";
            arduinoSerialPort.BaudRate = 9600;
            arduinoSerialPort.DataReceived += arduinoSerialPort_DataReceived;
            arduinoSerialPort.Open();
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void arduinoSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string codigo = arduinoSerialPort.ReadLine();  // Lee una línea del monitor serial
                Invoke(new Action(() => txtcodigo.Text = codigo));

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT usuario FROM tb_usuarios WHERE codigo = @codigo";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@codigo", codigo);

                        object result = command.ExecuteScalar();
                        if (result != null)  // Si el resultado no es nulo, se encontró el usuario
                        {
                            Invoke(new Action(() => txtusuario.Text = result.ToString()));
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (arduinoSerialPort.IsOpen)
            {
                arduinoSerialPort.Close();
            }

            frm_usuario formularioUsuario = new frm_usuario();

            // Mostrar el formulario frm_usuario
            formularioUsuario.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_RIFD_ProyectDataSet1.registros' Puede moverla o quitarla según sea necesario.
            this.registrosTableAdapter.Fill(this.db_RIFD_ProyectDataSet1.registros);
            // TODO: esta línea de código carga datos en la tabla 'db_RIFD_ProyectDataSet1.tb_codigos' Puede moverla o quitarla según sea necesario.
            this.tb_codigosTableAdapter.Fill(this.db_RIFD_ProyectDataSet1.tb_codigos);

        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (arduinoSerialPort.IsOpen)
            {
                arduinoSerialPort.Close();
            }
        }

        
        private int contador = 0;
        private void btnentrada_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Obtener la fecha y hora actual
                    DateTime fechaActual = DateTime.Now;

                    string query = "INSERT INTO registros (estado, usuario, fecha) VALUES (@estado, @usuario, @fecha)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (contador == 0)
                        {
                            command.Parameters.AddWithValue("@estado", "entrada");
                        }
                        else if (contador == 1)
                        {
                            command.Parameters.AddWithValue("@estado", "salida");
                        }

                        command.Parameters.AddWithValue("@usuario", txtusuario.Text);
                        command.Parameters.AddWithValue("@fecha", fechaActual);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registro insertado correctamente.");
                            txtcodigo.Text = "";
                            txtusuario.Text = "";
                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo insertar el registro.");
                            txtcodigo.Text = "";
                            txtusuario.Text = "";
                        }
                    }

                    // Incrementar el contador y reiniciarlo si llega a 2
                    contador++;
                    if (contador > 1)
                    {
                        contador = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM registros";
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

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
