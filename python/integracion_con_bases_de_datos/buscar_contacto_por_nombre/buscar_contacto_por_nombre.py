from conexion import conectar
def guardar_contacto(nombre, telefono, email):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        sql = "INSERT INTO contactos (nombre, telefono, email) VALUES (%s, %s, %s)"
        valores = (nombre, telefono, email)
        cursor.execute(sql, valores)
        conexion.commit()
        cursor.close()
        conexion.close()
        print("✅ Contacto guardado")
def buscar_contacto(nombre_buscar):
    conexion = conectar()
    if conexion:
        cursor = conexion.cursor()
        sql = "SELECT * FROM contactos WHERE nombre LIKE %s"
        valor = (f"%{nombre_buscar}%",)
        cursor.execute(sql, valor)
        resultados = cursor.fetchall()
        if resultados:
            print("\n🔍 Resultados encontrados:\n")
            for contacto in resultados:
                print(f"ID: {contacto[0]}")
                print(f"Nombre: {contacto[1]}")
                print(f"Teléfono: {contacto[2]}")
                print(f"Email: {contacto[3]}")
                print("-" * 30)
        else:
            print("⚠️ No se encontraron coincidencias")
        cursor.close()
        conexion.close()
def main():
    print("=== Buscar Contacto ===")
    while True:
        print("\n1. Agregar contacto")
        print("2. Buscar por nombre")
        print("3. Salir")
        opcion = input("Elige una opción: ")
        if opcion == "1":
            nombre = input("Nombre: ")
            telefono = input("Teléfono: ")
            email = input("Email: ")
            guardar_contacto(nombre, telefono, email)
        elif opcion == "2":
            nombre_buscar = input("Ingrese el nombre a buscar: ")
            buscar_contacto(nombre_buscar)
        elif opcion == "3":
            print("👋 Saliendo")
            break
        else:
            print("❌ Opción inválida")
if __name__ == "__main__":
    main()