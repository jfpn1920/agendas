SubProceso registrar_contacto(nombre Por Referencia, telefono Por Referencia, correo Por Referencia)
	Escribir "Ingrese el nombre del contacto:"
	Leer nombre
	Escribir "Ingrese el telefono:"
	Leer telefono
	Escribir "Ingrese el correo:"
	Leer correo
FinSubProceso
Algoritmo funcion_para_registrar_contacto
	Definir nombre, telefono, correo Como Cadena
	registrar_contacto(nombre, telefono, correo)
	Escribir "===== CONTACTO REGISTRADO ====="
	Escribir "Nombre: ", nombre
	Escribir "Telefono: ", telefono
	Escribir "Correo: ", correo
FinAlgoritmo