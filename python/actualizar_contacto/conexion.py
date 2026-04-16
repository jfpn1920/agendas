import mysql.connector
def conectar():
    try:
        conexion = mysql.connector.connect(
            host="localhost",
            user="root",
            password="",
            database="actualizar_contacto"
        )
        return conexion
    except mysql.connector.Error as e:
        print("Error al conectar:", e)
        return None