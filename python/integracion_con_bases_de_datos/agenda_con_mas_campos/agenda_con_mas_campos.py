from conexion import conectar
def guardar_contacto(nombre, telefono, email, direccion, fecha_nacimiento, notas):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        try:
            sql = """
            INSERT INTO contactos 
            (nombre, telefono, email, direccion, fecha_nacimiento, notas) 
            VALUES (%s, %s, %s, %s, %s, %s)
            """
            valores = (nombre, telefono, email, direccion, fecha_nacimiento, notas)
            cursor.execute(sql, valores)
            conexion.commit()
            print("✅ Contacto guardado correctamente")
        except Exception as e:
            print("⚠️ Error:", e)
        finally:
            cursor.close()
            conexion.close()
def mostrar_contactos():
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        cursor.execute("SELECT * FROM contactos")
        resultados = cursor.fetchall()
        if resultados:
            print("\n📋 Contactos:\n")
            for c in resultados:
                print(f"""
ID: {c[0]}
Nombre: {c[1]}
Teléfono: {c[2]}
Email: {c[3]}
Dirección: {c[4]}
Fecha Nacimiento: {c[5]}
Notas: {c[6]}
------------------------------""")
        else:
            print("⚠️ No hay contactos")
        cursor.close()
        conexion.close()
def main():
    print("=== Agenda con Más Campos ===")
    while True:
        print("\n1. Agregar contacto")
        print("2. Mostrar contactos")
        print("3. Salir")
        opcion = input("Elige una opción: ")
        if opcion == "1":
            nombre = input("Nombre: ")
            telefono = input("Teléfono: ")
            email = input("Email: ")
            direccion = input("Dirección: ")
            fecha_nacimiento = input("Fecha de nacimiento (YYYY-MM-DD): ")
            notas = input("Notas: ")
            guardar_contacto(nombre, telefono, email, direccion, fecha_nacimiento, notas)
        elif opcion == "2":
            mostrar_contactos()
        elif opcion == "3":
            print("👋 Saliendo")
            break
        else:
            print("❌ Opción inválida")
if __name__ == "__main__":
    main()