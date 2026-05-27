import sqlite3

productos = {
    "barra":["1003","1004","1005","1006","1007"],
    "nombre":[
        "coca cola 1L",
        "papas fritas 300g",
        "leche 1L",
        "aceite 1L",
        "harina 1kg"
    ],
    "precio":[100,200,300,400,500],
    "stock":[1,2,3,4,5],
    "categoria_id":[1,1,1,1,1]
}

conexion = sqlite3.connect(
    r"C:\Users\User\Documents\POS\POS PROYECT\DB\proyectoBD.db"
)

cursor = conexion.cursor()

for i in range(len(productos["barra"])):

    cursor.execute("""
    INSERT INTO productos (
        codigo_barra,
        nombre,
        precio,
        stock,
        categoria_id
    )
    VALUES (?, ?, ?, ?, ?)
    """, (
        productos["barra"][i],
        productos["nombre"][i],
        productos["precio"][i],
        productos["stock"][i],
        productos["categoria_id"][i]
    ))

conexion.commit()

print("Productos cargados correctamente")

conexion.close()