Algoritmo validar_multiples_condiciones_combinadas
	Definir nombre, telefono, correo Como Cadena
	Definir i, contador, posArroba, posPunto Como Entero
	Definir esValido, telefonoValido, correoValido, nombreValido Como Logico
	Definir caracter, arroba, punto Como Cadena
	arroba <- "@"
	punto <- "."
	Repetir
		Escribir "Ingrese nombre:"
		Leer nombre
		Escribir "Ingrese telefono:"
		Leer telefono
		Escribir "Ingrese correo:"
		Leer correo
		esValido <- Verdadero
		nombreValido <- Verdadero
		contador <- 0
		Si nombre = "" Entonces
			Escribir "Error: Nombre vacío"
			nombreValido <- Falso
		SiNo
			i <- 0
			Mientras Subcadena(nombre, i, i) <> "" Hacer
				contador <- contador + 1
				i <- i + 1
			FinMientras
			Si contador < 3 Entonces
				Escribir "Error: Nombre muy corto"
				nombreValido <- Falso
			FinSi
		FinSi
		telefonoValido <- Verdadero
		contador <- 0
		Si telefono = "" Entonces
			Escribir "Error: Teléfono vacío"
			telefonoValido <- Falso
		SiNo
			i <- 0
			Mientras Subcadena(telefono, i, i) <> "" Hacer
				caracter <- Subcadena(telefono, i, i)
				Si caracter < "0" O caracter > "9" Entonces
					Escribir "Error: Teléfono solo números"
					telefonoValido <- Falso
				FinSi
				contador <- contador + 1
				i <- i + 1
			FinMientras
			Si contador <> 10 Entonces
				Escribir "Error: Teléfono debe tener 10 dígitos"
				telefonoValido <- Falso
			FinSi
		FinSi
		correoValido <- Verdadero
		posArroba <- -1
		posPunto <- -1
		Si correo = "" Entonces
			Escribir "Error: Correo vacío"
			correoValido <- Falso
		SiNo
			i <- 0
			Mientras Subcadena(correo, i, i) <> "" Hacer
				caracter <- Subcadena(correo, i, i)
				Si caracter = arroba Entonces
					posArroba <- i
				FinSi
				Si caracter = punto Entonces
					posPunto <- i
				FinSi
				i <- i + 1
			FinMientras
			Si posArroba = -1 Entonces
				Escribir "Error: Correo sin arroba"
				correoValido <- Falso
			FinSi
			Si posPunto = -1 Entonces
				Escribir "Error: Correo sin punto"
				correoValido <- Falso
			FinSi
			Si posPunto < posArroba Entonces
				Escribir "Error: Punto debe ir después del arroba"
				correoValido <- Falso
			FinSi
		FinSi
		Si nombreValido = Falso O telefonoValido = Falso O correoValido = Falso Entonces
			esValido <- Falso
			Escribir "-----------------------------------"
			Escribir "Corrija los errores e intente de nuevo"
			Escribir "-----------------------------------"
		FinSi
	Hasta Que esValido = Verdadero
	Escribir "Todos los datos son válidos ?"
FinAlgoritmo