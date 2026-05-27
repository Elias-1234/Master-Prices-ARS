using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace POS_PROYECT
{
    // Clase principal del formulario heredada de la clase Form de Windows Forms

    public partial class Form1 : Form
    {
        // Instancia de la clase personalizada que maneja las operaciones de la Base de Datos
        GestorDeProductos gestor = new GestorDeProductos();
        FormMetodoPago formMetodoPago = new FormMetodoPago();
        private decimal total = 0;
        int CantidadProducto = 0;
        decimal Subtotal = 0; // CORREGIDO: cambiado de int a decimal para manejar importes correctamente
        int unidades = 0;
        // Variables globales del formulario
        string rutaArchivo;    // Guarda la ruta del archivo de imagen seleccionado en el disco (C:\...)
        DataTable ruta;        // Estructura de tabla en memoria para almacenar respuestas de consultas SQL
        int contador = 0;      // Controla el orden secuencial del foco (los pasos del "Enter")


        // Constructor del formulario: Se ejecuta inmediatamente al abrir la ventana
        public Form1()
        {
            InitializeComponent(); // Inicializa todos los componentes visuales del diseñador (botones, textos, etc.)
            txtVCodigoBarra.Focus();// Pone el cursor automáticamente en el TextBox de código de barra para ventas al iniciar la aplicación
            this.KeyPreview = true;// Permite al formulario capturar las teclas presionadas ANTES que los controles individuales
                                   // Pone el cursor automáticamente en el TextBox de código de barra para ventas al iniciar la aplicación
                                   // ACÁ DETECTAMOS EL ESPACIO PARA INICIAR EL PAGO



        } // Aquí el objeto formMetodoPago se libera completamente de la memoria de forma segura
        public decimal Total { get { return total; } }


        // Evento que se dispara cada vez que el usuario cambia de pestaña (pestaña Ventas, Productos, etc.)
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // switch evalúa cuál es el índice numérico de la pestaña activa actualmente
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    // Índice 0: El usuario está viendo la pestaña de "Ventas"
                    txtVCodigoBarra.Focus(); // Pone el cursor automáticamente en el TextBox de código de barra para ventas
                    break;

                case 1:
                    // Índice 1: El usuario entró a la pestaña de "Productos"
                    // Cargamos automáticamente la lista completa de productos desde la base de datos hacia el DataGridView
                    gestor.CargarDatosEnDataGridView(dgvTablaProductos);
                    txtReferencia.Focus();
                    break;

                case 2:
                    // Índice 2: El usuario está en "Método de Pago"
                    break;

                case 3:
                    // Índice 3: El usuario está en "Consultar Ventas"
                    break;
            }
        }

        // Evento del botón "Agregar Producto"
        private void button22_Click(object sender, EventArgs e)
        {
            // Validación de seguridad: Verifica que el campo código de barra no esté vacío o con puros espacios
            if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
            {
                MessageBox.Show("Por favor, agregue un producto.");
                return; // Detiene por completo la ejecución del método para evitar registrar datos corruptos
            }

            // Construcción de la cadena SQL para insertar un nuevo registro
            // Nota: Los datos numéricos se mandan directos, los datos de texto se envían entre comillas simples ''
            string consulta = $"INSERT INTO productos(referencia, codigo_barra, nombre, costo, precio, stock) " +
                              $"Values ({txtReferencia.Text}, '{txtCodigoBarra.Text}', '{txtNombre.Text}', {Convert.ToDecimal(txtCosto.Text)}, {Convert.ToDecimal(txtPrecio.Text)}, {Convert.ToInt32(txtStock.Text)})";

            // El objeto gestor ejecuta la instrucción SQL en la base de datos
            gestor.GestionarDatos(consulta);

            MessageBox.Show("Producto agregado correctamente");

            // Actualiza visualmente el DataGridView con el nuevo producto e invoca la limpieza de los campos de texto
            gestor.CargarDatosEnDataGridView(dgvTablaProductos);
            LimpiarCampos();
        }

        // Evento del botón "Actualizar/Modificar Producto"
        private void button23_Click(object sender, EventArgs e)
        {
            // Validación de seguridad: Asegura que haya un producto seleccionado mediante su código de barra
            if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
            {
                MessageBox.Show("Por favor, seleccione un producto.");
                return; // Detiene el código
            }
            string consulta = "";
            // Construcción de la cadena SQL de actualización (UPDATE)
            // IMPORTANTE: Convierte los textos de los TextBox a sus tipos de datos reales (Decimal, Int32) para la Base de Datos
            // Revisamos si Costo O Precio O Stock están vacíos
            // 1. Validamos que las cajas vacías no rompan los convertidores (les asignamos "0")
            if (string.IsNullOrWhiteSpace(txtCosto.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                if (string.IsNullOrWhiteSpace(txtCosto.Text)) txtCosto.Text = "0";
                if (string.IsNullOrWhiteSpace(txtPrecio.Text)) txtPrecio.Text = "0";
                if (string.IsNullOrWhiteSpace(txtStock.Text)) txtStock.Text = "0";
            }

            // 2. Armamos la consulta unificada para SQLite
            consulta = $"UPDATE productos SET " +
                              $"codigo_barra = '{txtCodigoBarra.Text}', " +
                              $"nombre = '{txtNombre.Text}', " +
                              $"costo = {Convert.ToDecimal(txtCosto.Text)}, " +
                              $"precio = {Convert.ToDecimal(txtPrecio.Text)}, " +
                              $"stock = {Convert.ToInt32(txtStock.Text)}, " +

                              // Lógica del CASE WHEN: conserva la imagen vieja si no se seleccionó una nueva
                              $"ruta_imagen = CASE WHEN '{rutaArchivo}' = '' OR '{rutaArchivo}' IS NULL THEN ruta_imagen ELSE '{rutaArchivo}' END " +

                              $"WHERE codigo_barra = '{txtCodigoBarra.Text}'";

            // 3. Ejecutamos la consulta en la base de datos
            gestor.Consulta(consulta);

            // 4. Avisamos al usuario que todo salió joya
            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Ejecuta los cambios en la base de datos
            gestor.GestionarDatos(consulta);

            MessageBox.Show("Producto actualizado correctamente");
            rutaArchivo = "";
            // Recarga los datos en la tabla visual y limpia los controles
            gestor.CargarDatosEnDataGridView(dgvTablaProductos);
            LimpiarCampos();
        }

        // Evento que se dispara al hacer clic sobre cualquier celda/fila de la tabla de productos (DataGridView)
        private void dgvTablaProductos_Click(object sender, DataGridViewCellEventArgs e)
        {
            // e.RowIndex asegura que el clic fue en una fila con datos real y no en los encabezados de las columnas (que valen -1)
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila completa donde el usuario hizo clic
                DataGridViewRow fila = dgvTablaProductos.Rows[e.RowIndex];

                // Pasa los valores de cada celda de la fila [0, 1, 2...] de regreso a sus respectivos TextBox
                // El operador ?.ToString() evita que el programa se rompa si alguna celda está vacía (null)
                txtReferencia.Text = fila.Cells[0].Value?.ToString();
                txtCodigoBarra.Text = fila.Cells[1].Value?.ToString();
                txtNombre.Text = fila.Cells[2].Value?.ToString();
                txtCosto.Text = fila.Cells[3].Value?.ToString();
                txtPrecio.Text = fila.Cells[4].Value?.ToString();
                txtStock.Text = fila.Cells[5].Value?.ToString();
            }

            // Consulta para verificar si el producto seleccionado tiene alguna imagen registrada
            ruta = gestor.GestionarDatos($"SELECT ruta_imagen from productos where codigo_barra = '{txtCodigoBarra.Text}'");
            if (string.IsNullOrWhiteSpace(ruta.ToString()))
            {
                return; // Si no hay registros de respuesta válidos, finaliza el método
            }

            // Trae la tabla con la columna ruta_imagen filtrada por el código de barras
            DataTable rutaImagenBackground = gestor.GestionarDatos($"SELECT ruta_imagen FROM productos WHERE codigo_barra = '{txtCodigoBarra.Text}'");

            // Verifica que el contenedor traiga información y tenga al menos 1 fila
            if (rutaImagenBackground != null && rutaImagenBackground.Rows.Count > 0)
            {
                // Extrae la ruta de texto pura de la Fila 0, Columna "ruta_imagen"
                string rutaReal = rutaImagenBackground.Rows[0]["ruta_imagen"].ToString();

                // Si la ruta contiene texto (es decir, el producto sí tiene una imagen guardada)...
                if (!string.IsNullOrWhiteSpace(rutaReal))
                {
                    // Carga y dibuja la imagen en el fondo del PictureBox leyendo el archivo desde el disco duro
                    pcbImagenProducto.BackgroundImage = Image.FromFile(rutaReal);
                }
                else
                {
                    pcbImagenProducto.BackgroundImage = null; // Si la celda estaba vacía en la base de datos, limpia el PictureBox
                }
            }
            else
            {
                pcbImagenProducto.BackgroundImage = null; // Si la consulta falló o no encontró nada, limpia el PictureBox
            }
        }

        // Evento del botón "Eliminar Producto"
        private void button26_Click(object sender, EventArgs e)
        {
            // Control de seguridad básica
            if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
            {
                MessageBox.Show("Por favor, selecciona el producto que deseas eliminar.");
                return;
            }

            // Cuadro de diálogo de confirmación para evitar que el usuario borre algo por accidente
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                     "Confirmar Eliminación",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

            // Si el usuario presionó el botón "SÍ" en la alerta...
            if (resultado == DialogResult.Yes)
            {
                // Sentencia SQL destructiva filtrada estrictamente por código de barra string ('')
                string consulta = $"DELETE FROM productos WHERE codigo_barra = '{txtCodigoBarra.Text}'";

                // Ejecuta la eliminación
                gestor.GestionarDatos(consulta);

                MessageBox.Show("Producto eliminado correctamente");

                // Actualiza el control visual de la tabla y limpia los cuadros de texto
                gestor.CargarDatosEnDataGridView(dgvTablaProductos);
                LimpiarCampos();
            }
        }

        // Evento al hacer clic en el PictureBox de la foto del producto para elegir una nueva imagen
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Ventana nativa de Windows para explorar carpetas y seleccionar archivos
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Todos los archivos|*.*"; // Filtro de visualización de archivos
            openFileDialog.Title = "Selecciona un archivo";

            // Si el usuario seleccionó un archivo y le dio al botón "Aceptar"...
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Guarda la ruta completa del archivo (Ejemplo: C:\Imagenes\producto1.jpg) en nuestra variable global
                rutaArchivo = openFileDialog.FileName;

                // Validación: Si el cuadro de texto del código está vacío, no asigna la previsualización
                if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
                {
                    return;
                }

                // Muestra de forma inmediata el archivo seleccionado en el PictureBox
                pcbImagenProducto.BackgroundImage = Image.FromFile(rutaArchivo);

                MessageBox.Show("Archivo seleccionado: " + rutaArchivo);
            }
        }

        // Administrador de teclado global del formulario (Gracia a KeyPreview = true)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Atajo: Si el usuario presiona la tecla Escape (ESC), se limpian inmediatamente todas las cajas
            if (e.KeyCode == Keys.Escape)
            {
                LimpiarCampos();
            }

            // Flujo secuencial: Si presionan Enter
            if (e.KeyCode == Keys.Enter)
            {
                total += Subtotal;
                // Cancela la acción nativa de la tecla para silenciar el sonido de alerta "beep" de Windows
                e.SuppressKeyPress = true;
                SePresionaEnter();

                // Utiliza la variable global "contador" para decidir a qué TextBox enviará el cursor (foco)
                switch (contador)
                {
                    case 0:
                        txtReferencia.Focus(); // Pone el cursor en Referencia
                        contador++;            // Suma 1 para que el siguiente Enter salte al case 1
                        break;
                    case 1:
                        txtCodigoBarra.Focus(); // Pone el cursor en Código de Barra
                        contador++;
                        break;
                    case 2:
                        txtNombre.Focus();     // Pone el cursor en Nombre
                        contador++;
                        break;
                    case 3:
                        txtCosto.Focus();      // Pone el cursor en Costo
                        contador++;
                        break;
                    case 4:
                        txtPrecio.Focus();     // Pone el cursor en Precio
                        contador++;
                        break;
                    case 5:
                        txtStock.Focus();      // Pone el cursor en Stock
                        contador = 0;          // Resetea el contador a 0 para volver a empezar la secuencia desde el inicio
                        break;

                }





                // Abre la ventana de selección de método de pago como un diálogo modal (bloquea la ventana principal hasta cerrarla)

            }
            if (e.KeyCode == Keys.Space && dgvVentas.Rows.Count > 0)
            {

                formMetodoPago.ShowDialog();

                // Abre la ventana de selección de método de pago como un diálogo modal (bloquea la ventana principal hasta cerrarla)
            }



        }

        // Método personalizado reutilizable para limpiar el texto de los 6 controles principales
        private void LimpiarCampos()
        {
            txtReferencia.Clear();
            txtCodigoBarra.Clear();
            txtNombre.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void BotonNumerico_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            txtVCodigoBarra.Text += botonPresionado.Text;
        }

        private void CEClick(object sender, EventArgs e)
        {
            txtVCodigoBarra.Clear();
        }

        private void MultiplicarClick(object sender, EventArgs e)
        {
            txtMultiplicador.Text = txtVCodigoBarra.Text;
            txtVCodigoBarra.Clear();
            txtVCodigoBarra.Focus();
        }

        private void btnIgualOTraerProducto(object sender, EventArgs e)
        {

            // 1. Validación: Si la caja de texto está vacía, detenemos el proceso
            if (string.IsNullOrWhiteSpace(txtVCodigoBarra.Text)) return;

            // 2. Traemos los datos del producto desde la base de datos
            DataTable datos = gestor.GestionarDatos($"SELECT productos_id, nombre, precio FROM productos WHERE codigo_barra = '{txtVCodigoBarra.Text}'");


            if (string.IsNullOrWhiteSpace(txtMultiplicador.Text))
            {
                CantidadProducto = 1; // Si no hay multiplicador, se asume que es 1 unidad del producto
            }
            else
            {
                CantidadProducto = Convert.ToInt32(txtMultiplicador.Text); // Si hay multiplicador, lo convertimos a número entero
            }
            // 3. Verificamos si el producto realmente existe
            if (datos != null && datos.Rows.Count > 0)
            {
                // Extraemos la información de la primera fila obtenida
                string nombreProducto = datos.Rows[0]["nombre"].ToString();
                decimal precioProducto = Convert.ToDecimal(datos.Rows[0]["precio"]);
                int productoId = Convert.ToInt32(datos.Rows[0]["productos_id"]); // Si necesitas el ID para algo más adelante, ya lo tienes aquí

                // 4. Agregamos la fila al DataGridView (dgvVentas)
                // Pasamos "" en la primera posición para dejar la columna 'Cantidad' libre para ti.
                // Si tu cuarta columna es el Subtotal o código, puedes mapearla al final. Aquí puse un "" de ejemplo para la 4ta columna:
                dgvVentas.Rows.Add(CantidadProducto, nombreProducto, precioProducto, productoId);
                unidades += CantidadProducto; // Acumula el total de unidades vendidas
                Subtotal += precioProducto * CantidadProducto; // CORREGIDO: Quitado el Convert.ToInt32 para mantener decimales exactos
                lblTotal.Text = "$ " + Subtotal.ToString();
                lblUnidades.Text = unidades.ToString();
                // 5. Limpiamos la caja de texto de ventas y le regresamos el foco
                txtVCodigoBarra.Clear();
                txtMultiplicador.Clear();
                txtVCodigoBarra.Focus();
            }
            else
            {
                // Mensaje de alerta en caso de que escriban o escaneen un código que no exista
                MessageBox.Show("El producto no está registrado en el sistema.", "Código no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVCodigoBarra.Clear();
                txtVCodigoBarra.Focus();
            }
        }
        private void SePresionaEnter()
        {
            // 1. Validación: Si la caja de texto está vacía, detenemos el proceso
            if (string.IsNullOrWhiteSpace(txtVCodigoBarra.Text)) return;

            // 2. Traemos los datos del producto desde la base de datos
            DataTable datos = gestor.GestionarDatos($"SELECT productos_id, nombre, precio FROM productos WHERE codigo_barra = '{txtVCodigoBarra.Text}'");


            if (string.IsNullOrWhiteSpace(txtMultiplicador.Text))
            {
                CantidadProducto = 1; // Si no hay multiplicador, se asume que es 1 unidad del producto
            }
            else
            {
                CantidadProducto = Convert.ToInt32(txtMultiplicador.Text); // Si hay multiplicador, lo convertimos a número entero
            }
            // 3. Verificamos si el producto realmente existe
            if (datos != null && datos.Rows.Count > 0)
            {
                // Extraemos la información de la primera fila obtenida
                string nombreProducto = datos.Rows[0]["nombre"].ToString();
                decimal precioProducto = Convert.ToDecimal(datos.Rows[0]["precio"]);
                int productoId = Convert.ToInt32(datos.Rows[0]["productos_id"]); // Si necesitas el ID para algo más adelante, ya lo tienes aquí

                // 4. Agregamos la fila al DataGridView (dgvVentas)
                // Pasamos "" en la primera posición para dejar la columna 'Cantidad' libre para ti.
                // Si tu cuarta columna es el Subtotal o código, puedes mapearla al final. Aquí puse un "" de ejemplo para la 4ta columna:
                dgvVentas.Rows.Add(CantidadProducto, nombreProducto, precioProducto, productoId);
                unidades += CantidadProducto; // Acumula el total de unidades vendidas
                Subtotal += precioProducto * CantidadProducto; // CORREGIDO: Quitado el Convert.ToInt32 para mantener decimales exactos
                lblTotal.Text = "$ " + Subtotal.ToString();
                lblUnidades.Text = unidades.ToString();
                // 5. Limpiamos la caja de texto de ventas y le regresamos el foco
                txtVCodigoBarra.Clear();
                txtMultiplicador.Clear();
                txtVCodigoBarra.Focus();
            }
            else
            {
                // Mensaje de alerta en caso de que escriban o escaneen un código que no exista
                MessageBox.Show("El producto no está registrado en el sistema.", "Código no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVCodigoBarra.Clear();
                txtVCodigoBarra.Focus();
            }
        }

        private void btnEliminarProducto(object sender, EventArgs e)
        {
            // VALIDACIÓN BLINDADA: 
            // 1. Que no sea nulo.
            // 2. Que la tabla tenga al menos 1 fila de datos.
            // 3. Que la fila seleccionada no sea la fila en blanco para nuevos registros (IsNewRow).
            if (dgvVentas.CurrentRow != null && dgvVentas.Rows.Count > 0 && !dgvVentas.CurrentRow.IsNewRow)
            {
                // CORREGIDO: cambiado de int a decimal para el manejo de precios al restar
                DataGridViewRow filaSeleccionada = dgvVentas.CurrentRow;

                // Extraemos los datos para restar
                int cantidadARestar = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                decimal precioARestar = Convert.ToDecimal(filaSeleccionada.Cells[2].Value);
                decimal totalFila = cantidadARestar * precioARestar;

                // Eliminamos la fila de forma segura
                dgvVentas.Rows.Remove(filaSeleccionada);

                // AQUÍ RECALCULAS TUS TOTALES RESTANDO ESTOS VALORES
                // (Tu lógica para actualizar los recuadros de Unidades y Total)

                txtVCodigoBarra.Focus();
                if (dgvVentas.Rows.Count < 2)
                {
                    lblUnidades.Text = "0";
                    lblTotal.Text = "$ 0";
                    unidades = 0;
                    Subtotal = 0;
                }
            }
            else
            {
                // Si el dgv está vacío o no seleccionaron nada, salimos amigablemente sin romper el programa
                MessageBox.Show("No hay productos en la lista para eliminar.", "Lista vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVCodigoBarra.Focus();


            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataTable Tabla = gestor.GestionarDatos("SELECT * FROM productos WHERE codigo_barra LIKE '%" + txtBuscarProducto.Text + "%'");
            if (Tabla != null && Tabla.Rows.Count > 0)
            {
                dgvTablaProductos.Rows.Clear();
                foreach (DataRow fila in Tabla.Rows)
                {
                    dgvTablaProductos.Rows.Add(
                        fila["referencia"],
                        fila["codigo_barra"],
                        fila["nombre"],
                        fila["costo"],
                        fila["precio"],
                        fila["stock"]
                    );
                }
            }
            else
            {
                dgvTablaProductos.Rows.Clear(); // Limpia la tabla si no hay resultados para mostrar
            }
        }

        private void txtFiltrarProducto_TextChanged(object sender, EventArgs e)
        {
            dgvTablaProductos.Rows.Clear();

            string textoBusqueda = txtFiltrarProducto.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                return;
            }

            string[] palabras = textoBusqueda.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string query = "SELECT * FROM productos WHERE ";

            for (int i = 0; i < palabras.Length; i++)
            {
                if (i > 0)
                    query += " AND ";

                query += $"nombre LIKE '%{palabras[i]}%' COLLATE NOCASE";
            }

            DataTable Tabla = gestor.GestionarDatos(query);

            if (Tabla != null && Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    dgvTablaProductos.Rows.Add(
                        fila["referencia"],
                        fila["codigo_barra"],
                        fila["nombre"],
                        fila["costo"],
                        fila["precio"],
                        fila["stock"]
                    );
                }
            }
        }
        public void LimpiarTablaVentas()
        {

            dgvVentas.Rows.Clear();


            lblUnidades.Text = "0";
            lblTotal.Text = "$ 0";


        }
        //realizar la venta

        public void Vender()
        {

            try
            {
                string fechaVenta = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string subtotalFormateado = Subtotal.ToString(System.Globalization.CultureInfo.InvariantCulture);
                int idMetodoPago = formMetodoPago.CodigoMetodoPagoSeleccionado;

                long idVentaGenerado = gestor.RegistrarVentaYObtenerId(
                    fechaVenta,
                    subtotalFormateado,
                    idMetodoPago
                
                 );
                
                if (idVentaGenerado <= 0)
                {
                    MessageBox.Show(
                        "No se pudo obtener el ID de la venta.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                CargarDetallesVenta(idVentaGenerado);

                MessageBox.Show(
                    $"Venta Nº {idVentaGenerado} registrada correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                unidades = 0;
                Subtotal = 0;
                LimpiarTablaVentas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error general en la venta:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }



        public void CargarDetallesVenta(long ventasId)
        {

            try
            {
                foreach (DataGridViewRow fila in dgvVentas.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    if (fila.Cells[0].Value == null ||
                        fila.Cells[2].Value == null ||
                        fila.Cells[3].Value == null)
                    {
                        continue;
                    }

                    int cantidad = Convert.ToInt32(fila.Cells[0].Value);
                    decimal precioUnitario = Convert.ToDecimal(fila.Cells[2].Value);
                    int productoId = Convert.ToInt32(fila.Cells[3].Value);

                    if (productoId <= 0)
                        continue;

                    string precioFormateado =
                        precioUnitario.ToString(
                            System.Globalization.CultureInfo.InvariantCulture
                        );

                    string consultaDetalle =
                        $"INSERT INTO detalle_ventas " +
                        $"(cantidad, precio_unitario, venntas_id, productos_id) " +
                        $"VALUES ({cantidad}, {precioFormateado}, {ventasId}, {productoId})";

                    gestor.Consulta(consultaDetalle);
                    // 1. Guardamos el resultado en un DataTable en lugar de convertirlo directo
                    DataTable dtStock = gestor.GestionarDatos($"SELECT stock FROM productos WHERE productos_id = {productoId}");
                    int StockActual = 0;

                    // 2. Nos aseguramos de que el producto exista en la base
                    if (dtStock.Rows.Count > 0)
                    {
                        // Sacamos el valor de la fila 0, columna "stock"
                        StockActual = Convert.ToInt32(dtStock.Rows[0]["stock"]);
                    }

                    // 3. Tu lógica de control (¡Ojo acá también con las unidades!)
                    if (StockActual >= unidades) // <-- Cambié > 0 por >= unidades, abajo te explico por qué
                    {
                        string queryStock = $"UPDATE productos SET stock = stock - {unidades}  WHERE productos_id = {productoId}";
                        gestor.Consulta(queryStock);
                    }
                    else
                    {
                        string consularNombre = $"SELECT nombre FROM productos WHERE productos_id = {productoId}";
                        DataTable nombreProducto = gestor.GestionarDatos(consularNombre);

                        // Validamos primero que la tabla haya devuelto alguna fila
                        if (nombreProducto.Rows.Count > 0)
                        {
                            string nombreTexto = nombreProducto.Rows[0]["nombre"].ToString();

                            MessageBox.Show(
                                $"El producto con el Nombre {nombreTexto} está agotado o no alcanza para cubrir la venta.",
                                "Stock Insuficiente",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else
                        {
                            MessageBox.Show($"El producto con ID {productoId} no se encontró en la base de datos.");
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar los detalles:\n{ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }





        private void button27_Click(object sender, EventArgs e)
        {
            // ====================================================================================
            // PASO 1: CAPTURA DE FECHAS Y HORAS
            // ====================================================================================
            // Obtenemos los valores de los DateTimePicker y les damos el formato 'yyyy-MM-dd HH:mm:ss'
            // que es el estándar que entiende SQLite para poder hacer comparaciones precisas.
            string fechaInicio = dtpFechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string fechaFin = dtpFechaFin.Value.ToString("yyyy-MM-dd HH:mm:ss");

            // ====================================================================================
            // PASO 2: CONSTRUCCIÓN DE LA CONSULTA SQL
            // ====================================================================================
            // Realizamos un INNER JOIN entre 'ventas' y 'metodo_pago' para obtener el nombre 
            // del método de pago en lugar de su ID numérico. El filtro 'BETWEEN' asegura que 
            // traigamos solo los registros dentro del rango de tiempo especificado.
            string query = $@"
        SELECT 
            v.venntas_id, 
            v.fecha, 
            v.importe_total, 
            m.nombre AS metodo_pago_id
        FROM ventas v
        INNER JOIN metodo_pago m ON v.metodo_pago_id = m.metodo_pago_id
        WHERE v.fecha BETWEEN '{fechaInicio}' AND '{fechaFin}'";

            // ====================================================================================
            // PASO 3: EJECUCIÓN Y OBTENCIÓN DE DATOS
            // ====================================================================================
            // Invocamos a tu método gestor para ejecutar la consulta y recibir un DataTable
            // con toda la información filtrada lista para ser reportada.
            DataTable dtVentasFiltradas = gestor.GestionarDatos(query);

            // ====================================================================================
            // PASO 4: MANTENIMIENTO DEL COMPONENTE VISUAL (REPORTVIEWER)
            // ====================================================================================
            // Nos aseguramos de que el control no se haya "desenganchado" de la pestaña al refrescar.
            // Esto evita que el visor de informes desaparezca o deje de mostrarse.
            reportViewer1.Dock = DockStyle.Fill;
            if (!tabPage5.Controls.Contains(reportViewer1))
            {
                tabPage5.Controls.Add(reportViewer1);
            }

            // ====================================================================================
            // PASO 5: CONFIGURACIÓN DEL REPORTE
            // ====================================================================================
            // Asignamos la ruta al archivo .rdlc y limpiamos cualquier fuente de datos previa.
            // Esto es fundamental para que el visor cargue la estructura actualizada.
            reportViewer1.LocalReport.ReportPath = "ReporteVentas.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();

            // ====================================================================================
            // PASO 6: PASO DE DATOS O MANEJO DE RESULTADOS VACÍOS
            // ====================================================================================
            if (dtVentasFiltradas != null && dtVentasFiltradas.Rows.Count > 0)
            {
                // Si hay resultados, asignamos el DataTable como fuente de datos del reporte.
                // Las expresiones matemáticas en el .rdlc calcularán los totales automáticamente.
                ReportDataSource rds = new ReportDataSource("DataSet1", dtVentasFiltradas);
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else
            {
                // Si no se encuentran ventas en ese periodo, asignamos una tabla vacía
                // para mantener la integridad del reporte y mostramos un aviso al usuario.
                DataTable dtVacio = dtVentasFiltradas ?? new DataTable();
                ReportDataSource rds = new ReportDataSource("DataSet1", dtVacio);
                reportViewer1.LocalReport.DataSources.Add(rds);

                MessageBox.Show("No se encontraron ventas registradas en el rango de fecha y hora seleccionado.",
                                "Aviso de Búsqueda",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            // ====================================================================================
            // PASO 7: RENDERIZADO FINAL
            // ====================================================================================
            // Esta orden le indica al visor que procese el nuevo origen de datos y dibuje
            // los resultados, incluyendo las sumatorias de los métodos de pago en el pie del reporte.
            reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fechaInicio = dtpFechaInicio.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string fechaFin = dtpFechaFin.Value.ToString("yyyy-MM-dd HH:mm:ss");

                string query = $@"
                    SELECT
                        p.nombre,
                        SUM(d.cantidad) AS cantidad_vendida
                    FROM detalle_ventas d
                    INNER JOIN productos p
                        ON d.productos_id = p.productos_id
                    INNER JOIN ventas v
                        ON d.venntas_id = v.venntas_id
                    WHERE v.fecha BETWEEN '{fechaInicio}' AND '{fechaFin}'
                    GROUP BY p.nombre
                    ORDER BY cantidad_vendida DESC
                    LIMIT 10";

                DataTable tabla = gestor.GestionarDatos(query);

                dgvTablaProductosMasVendido.Rows.Clear();

                if (tabla != null)
                {
                    foreach (DataRow fila in tabla.Rows)
                    {
                        int indice = dgvTablaProductosMasVendido.Rows.Add();

                        dgvTablaProductosMasVendido.Rows[indice].Cells["Column2"].Value =
                            fila["nombre"].ToString();

                        dgvTablaProductosMasVendido.Rows[indice].Cells["Column3"].Value =
                            fila["cantidad_vendida"].ToString();
                    }

                    MessageBox.Show("Registros encontrados: " + tabla.Rows.Count);
                }
                else
                {
                    MessageBox.Show("La consulta no devolvió datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
    
}