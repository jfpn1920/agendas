import mysql.connector
def conectar():
    try:
        conexion = mysql.connector.connect(
            host="localhost",
            user="root",
            password="",
            database="mini_sistema_completo"
        )
        return conexion
    except mysql.connector.Error as e:
        print("Error al conectar:", e)
        return None