import mysql.connector
def conectar():
    try:
        conexion = mysql.connector.connect(
            host="localhost",
            user="root",
            password="",  # en XAMPP normalmente está vacío
            database="guardar_contacto_basico"
        )
        return conexion
    except mysql.connector.Error as e:
        print("Error al conectar:", e)
        return None