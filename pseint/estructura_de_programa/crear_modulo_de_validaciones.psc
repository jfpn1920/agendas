Algoritmo crear_modulo_de_validaciones
	Definir nombre, telefono Como Cadena
	ValidarNombre(nombre)
	ValidarTelefono(telefono)
	Escribir "Datos ingresados correctamente ?"
	Escribir "Nombre: ", nombre
	Escribir "Teléfono: ", telefono
FinAlgoritmo
SubProceso ValidarNombre(nombre Por Referencia)
	Definir i, contador Como Entero
	Repetir
		Escribir "Ingrese nombre:"
		Leer nombre
		contador <- 0
		i <- 0
		Mientras Subcadena(nombre, i, i) <> "" Hacer
			contador <- contador + 1
			i <- i + 1
		FinMientras
		Si contador < 3 Entonces
			Escribir "Error: Nombre muy corto"
		FinSi
	Hasta Que contador >= 3
FinSubProceso
SubProceso ValidarTelefono(telefono Por Referencia)
	Definir i, contador Como Entero
	Definir caracter Como Cadena
	Definir esValido Como Logico
	Repetir
		Escribir "Ingrese teléfono:"
		Leer telefono
		esValido <- Verdadero
		contador <- 0
		i <- 0
		Mientras Subcadena(telefono, i, i) <> "" Hacer
			caracter <- Subcadena(telefono, i, i)
			Si caracter < "0" O caracter > "9" Entonces
				esValido <- Falso
			FinSi
			contador <- contador + 1
			i <- i + 1
		FinMientras
		Si contador <> 10 Entonces
			esValido <- Falso
		FinSi
		Si esValido = Falso Entonces
			Escribir "Error: Teléfono inválido"
		FinSi
	Hasta Que esValido = Verdadero
FinSubProceso