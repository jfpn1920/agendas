import mysql.connector
def conectar():
    try:
        conexion = mysql.connector.connect(
            host="localhost",
            user="root",
            password="",
            database="buscar_contacto_por_nombre"
        )
        return conexion
    except mysql.connector.Error as e:
        print("Error al conectar:", e)
        return None