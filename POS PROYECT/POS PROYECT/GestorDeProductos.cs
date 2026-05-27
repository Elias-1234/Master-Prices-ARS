using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite; // Asegúrate de tener esta referencia para trabajar con SQL Server

namespace POS_PROYECT
{
    internal class GestorDeProductos
    {
        string connectionString = @"Data Source=C:\Users\User\Documents\POS\POS PROYECT\DB\master_prices_ars.db";
        public DataTable GestionarDatos(string query)
    {
        // 1. Corregimos el espacio en "Data Source" y agregamos la extensión .db (o la que uses)
        

        try
        {
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    DataTable dataTable = new DataTable();

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }

                    return dataTable;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al gestionar los datos: " + ex.Message);
            return null;
        }
    }

        public void CargarDatosEnDataGridView(DataGridView dgvProductos)
        {
            // Seleccionamos los campos en el orden exacto que requiere tu DataGridView
            string query = "SELECT referencia, codigo_barra, nombre, costo, precio, stock FROM productos";

            GestorDeProductos gestor = new GestorDeProductos();
            DataTable dtProductos = gestor.GestionarDatos(query);

            if (dtProductos != null)
            {
                dgvProductos.Rows.Clear();

                foreach (DataRow fila in dtProductos.Rows)
                {
                    // Ahora sí, cada campo va directo a su columna correspondiente
                    dgvProductos.Rows.Add(
                        fila["referencia"],    // Columna 1: Referencia
                        fila["codigo_barra"],  // Columna 2: Codigo Barra
                        fila["nombre"],        // Columna 3: Nombre
                        fila["costo"],         // Columna 4: Costo
                        fila["precio"],        // Columna 5: Precio
                        fila["stock"]          // Columna 6: Stock

                    );
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los datos en la tabla.", "Error POS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Consulta(string query) {
            
            //entendes lo que quiero hacer? es para hacer solo una consulta o consulta personalizada, por ejemplo para agregar un dato por separado
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    
                }
                connection.Close();
            }
        }
        public long RegistrarVentaYObtenerId(string fecha, string total, int metodoPagoId)
        {
            

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                // 1. Insertamos la cabecera de la venta
                string qInsert = $"INSERT INTO ventas (fecha, importe_total, metodo_pago_id) VALUES ('{fecha}', {total}, {metodoPagoId});";
                using (SqliteCommand cmdInsert = new SqliteCommand(qInsert, connection))
                {
                    cmdInsert.ExecuteNonQuery();
                }

                // 2. Al estar en la misma conexión abierta, last_insert_rowid() funciona al 100%
                string qId = "SELECT last_insert_rowid();";
                using (SqliteCommand cmdId = new SqliteCommand(qId, connection))
                {
                    // ExecuteScalar es el método ideal en C# para traer un único valor numérico suelto
                    return Convert.ToInt64(cmdId.ExecuteScalar());
                }
            }
        }
    }
    }


    

