Algoritmo validar_contacto_activo_y_valido
	Definir nombre, telefono, estado Como Cadena
	Definir i, contador Como Entero
	Definir nombreValido, telefonoValido, activo, contactoValido Como Logico
	Definir caracter Como Cadena
	Repetir
		Escribir "Ingrese nombre:"
		Leer nombre
		Escribir "Ingrese telefono:"
		Leer telefono
		Escribir "¿El contacto está activo? (SI/NO):"
		Leer estado
		nombreValido <- Verdadero
		contador <- 0
		Si nombre = "" Entonces
			nombreValido <- Falso
		SiNo
			i <- 0
			Mientras Subcadena(nombre, i, i) <> "" Hacer
				contador <- contador + 1
				i <- i + 1
			FinMientras
			Si contador < 3 Entonces
				nombreValido <- Falso
			FinSi
		FinSi
		telefonoValido <- Verdadero
		contador <- 0
		Si telefono = "" Entonces
			telefonoValido <- Falso
		SiNo
			i <- 0
			Mientras Subcadena(telefono, i, i) <> "" Hacer
				caracter <- Subcadena(telefono, i, i)
				Si caracter < "0" O caracter > "9" Entonces
					telefonoValido <- Falso
				FinSi
				contador <- contador + 1
				i <- i + 1
			FinMientras
			Si contador <> 10 Entonces
				telefonoValido <- Falso
			FinSi
		FinSi
		Si estado = "SI" Entonces
			activo <- Verdadero
		SiNo
			activo <- Falso
		FinSi
		contactoValido <- nombreValido Y telefonoValido Y activo
		Si contactoValido Entonces
			Escribir "Contacto ACTIVO y válido ?"
		SiNo
			Escribir "El contacto NO cumple las condiciones"
		FinSi
	Hasta Que contactoValido = Verdadero
FinAlgoritmo