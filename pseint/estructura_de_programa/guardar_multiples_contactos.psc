Algoritmo guardar_multiples_contactos
	Definir nombres, telefonos, correos Como Cadena
	Definir i, n Como Entero
	n <- 3
	Dimension nombres[n]
	Dimension telefonos[n]
	Dimension correos[n]
	MostrarTitulo
	Para i <- 0 Hasta n-1 Hacer
		Escribir "Contacto ", i+1
		PedirNombre(nombres[i])
		PedirTelefono(telefonos[i])
		PedirCorreo(correos[i])
		LineaSeparadora
	FinPara
	Escribir "LISTA DE CONTACTOS REGISTRADOS ?"
	LineaSeparadora
	Para i <- 0 Hasta n-1 Hacer
		Escribir "Contacto ", i+1
		Escribir "Nombre: ", nombres[i]
		Escribir "Teléfono: ", telefonos[i]
		Escribir "Correo: ", correos[i]
		LineaSeparadora
	FinPara
	Pausa
FinAlgoritmo
SubProceso PedirNombre(nombre Por Referencia)
	Repetir
		Escribir "Ingrese nombre:"
		Leer nombre
	Hasta Que nombre <> ""
FinSubProceso
SubProceso PedirTelefono(telefono Por Referencia)
	Definir i, contador Como Entero
	Definir caracter Como Cadena
	Definir valido Como Logico
	Repetir
		Escribir "Ingrese teléfono (10 dígitos):"
		Leer telefono
		valido <- Verdadero
		contador <- 0
		i <- 0
		Mientras Subcadena(telefono, i, i) <> "" Hacer
			caracter <- Subcadena(telefono, i, i)
			Si caracter < "0" O caracter > "9" Entonces
				valido <- Falso
			FinSi
			contador <- contador + 1
			i <- i + 1
		FinMientras
		Si contador <> 10 Entonces
			valido <- Falso
		FinSi
		Si valido = Falso Entonces
			Escribir "Error: Teléfono inválido"
		FinSi
	Hasta Que valido = Verdadero
FinSubProceso
SubProceso PedirCorreo(correo Por Referencia)
	Definir i Como Entero
	Definir caracter Como Cadena
	Definir tieneArroba Como Logico
	Repetir
		Escribir "Ingrese correo:"
		Leer correo
		tieneArroba <- Falso
		i <- 0
		Mientras Subcadena(correo, i, i) <> "" Hacer
			caracter <- Subcadena(correo, i, i)
			Si caracter = "@" Entonces
				tieneArroba <- Verdadero
			FinSi
			i <- i + 1
		FinMientras
		Si tieneArroba = Falso Entonces
			Escribir "Error: Correo inválido"
		FinSi
	Hasta Que tieneArroba = Verdadero
FinSubProceso
SubProceso MostrarTitulo
	Escribir "=============================="
	Escribir "   REGISTRO DE CONTACTOS"
	Escribir "=============================="
FinSubProceso
SubProceso LineaSeparadora
	Escribir "------------------------------"
FinSubProceso
SubProceso Pausa
	Definir tecla Como Cadena
	Escribir "Presione ENTER para continuar..."
	Leer tecla
FinSubProceso