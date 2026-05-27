import sqlite3

conexion = sqlite3.connect(
    r"C:\Users\User\Documents\POS\POS PROYECT\DB\proyectoBD.db"
)

cursor = conexion.cursor()

cursor.execute("SELECT * FROM productos")

datos = cursor.fetchall()

print(datos)

conexion.close()