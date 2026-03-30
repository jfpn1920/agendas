import mysql.connector
def conectar():
    try:
        conexion = mysql.connector.connect(
            host="localhost",
            user="root",
            password="",
            database="validar_datos_antes_de_insertar"
        )
        return conexion
    except mysql.connector.Error as e:
        print("Error al conectar:", e)
        return None