from conexion import conectar
import re
def validar_nombre(nombre):
    return len(nombre.strip()) > 0
def validar_telefono(telefono):
    return telefono.isdigit() and len(telefono) >= 7
def validar_email(email):
    patron = r'^[\w\.-]+@[\w\.-]+\.\w+$'
    return re.match(patron, email)
def guardar_contacto(nombre, telefono, email):
    if not validar_nombre(nombre):
        print("❌ Nombre inválido")
        return
    if not validar_telefono(telefono):
        print("❌ Teléfono inválido")
        return
    if not validar_email(email):
        print("❌ Email inválido")
        return
    conexion = conectar()
    cursor = conexion.cursor()
    try:
        sql = "INSERT INTO contactos (nombre, telefono, email) VALUES (%s, %s, %s)"
        cursor.execute(sql, (nombre, telefono, email))
        conexion.commit()
        print("✅ Contacto guardado")
    except Exception as e:
        print("⚠️ Error:", e)
    finally:
        cursor.close()
        conexion.close()
def mostrar_contactos():
    conexion = conectar()
    cursor = conexion.cursor()
    cursor.execute("SELECT * FROM contactos")
    resultados = cursor.fetchall()
    if resultados:
        print("\n📋 Contactos:\n")
        for c in resultados:
            print(f"ID: {c[0]} | Nombre: {c[1]} | Tel: {c[2]} | Email: {c[3]}")
    else:
        print("⚠️ No hay contactos")
    cursor.close()
    conexion.close()
def buscar_contacto(nombre):
    conexion = conectar()
    cursor = conexion.cursor()
    sql = "SELECT * FROM contactos WHERE nombre LIKE %s"
    cursor.execute(sql, (f"%{nombre}%",))
    resultados = cursor.fetchall()
    if resultados:
        print("\n🔍 Resultados:\n")
        for c in resultados:
            print(f"ID: {c[0]} | Nombre: {c[1]} | Tel: {c[2]} | Email: {c[3]}")
    else:
        print("⚠️ No se encontraron coincidencias")
    cursor.close()
    conexion.close()
def eliminar_contacto(id_contacto):
    conexion = conectar()
    cursor = conexion.cursor()
    cursor.execute("DELETE FROM contactos WHERE id = %s", (id_contacto,))
    conexion.commit()
    if cursor.rowcount > 0:
        print("🗑️ Contacto eliminado")
    else:
        print("⚠️ No encontrado")
    cursor.close()
    conexion.close()
def actualizar_contacto(id_contacto, nombre, telefono, email):
    conexion = conectar()
    cursor = conexion.cursor()
    sql = """
    UPDATE contactos 
    SET nombre=%s, telefono=%s, email=%s 
    WHERE id=%s
    """
    cursor.execute(sql, (nombre, telefono, email, id_contacto))
    conexion.commit()
    if cursor.rowcount > 0:
        print("✏️ Contacto actualizado")
    else:
        print("⚠️ No encontrado")
    cursor.close()
    conexion.close()
def ordenar_contactos(tipo):
    conexion = conectar()
    cursor = conexion.cursor()
    if tipo == "1":
        sql = "SELECT * FROM contactos ORDER BY nombre ASC"
    else:
        sql = "SELECT * FROM contactos ORDER BY nombre DESC"
    cursor.execute(sql)
    resultados = cursor.fetchall()
    for c in resultados:
        print(f"ID: {c[0]} | Nombre: {c[1]} | Tel: {c[2]} | Email: {c[3]}")
    cursor.close()
    conexion.close()
def main():
    while True:
        print("\n=== MINI SISTEMA DE AGENDA ===")
        print("1. Agregar contacto")
        print("2. Mostrar contactos")
        print("3. Buscar contacto")
        print("4. Actualizar contacto")
        print("5. Eliminar contacto")
        print("6. Ordenar A-Z")
        print("7. Ordenar Z-A")
        print("8. Salir")
        opcion = input("Seleccione: ")
        if opcion == "1":
            nombre = input("Nombre: ")
            telefono = input("Teléfono: ")
            email = input("Email: ")
            guardar_contacto(nombre, telefono, email)
        elif opcion == "2":
            mostrar_contactos()
        elif opcion == "3":
            nombre = input("Buscar nombre: ")
            buscar_contacto(nombre)
        elif opcion == "4":
            mostrar_contactos()
            idc = int(input("ID a actualizar: "))
            nombre = input("Nuevo nombre: ")
            telefono = input("Nuevo teléfono: ")
            email = input("Nuevo email: ")
            actualizar_contacto(idc, nombre, telefono, email)
        elif opcion == "5":
            mostrar_contactos()
            idc = int(input("ID a eliminar: "))
            eliminar_contacto(idc)
        elif opcion == "6":
            ordenar_contactos("1")
        elif opcion == "7":
            ordenar_contactos("2")
        elif opcion == "8":
            print("👋 Hasta luego")
            break
        else:
            print("❌ Opción inválida")
if __name__ == "__main__":
    main()