Algoritmo validar_correo_con_formato
	Definir correo, caracter, arroba, punto Como Cadena
	Definir i, posArroba, posPunto Como Entero
	Definir esValido Como Logico
	arroba <- "@"
	punto <- "."
	Repetir
		Escribir "Ingrese un correo electrónico:"
		Leer correo
		esValido <- Verdadero
		posArroba <- -1
		posPunto <- -1
		Si correo = "" Entonces
			Escribir "Error: No puede estar vacío"
			esValido <- Falso
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
				Escribir "Error: Falta arroba (@)"
				esValido <- Falso
			FinSi
			Si posPunto = -1 Entonces
				Escribir "Error: Falta punto (.)"
				esValido <- Falso
			FinSi
			Si posArroba = 0 Entonces
				Escribir "Error: Arroba no puede ir al inicio"
				esValido <- Falso
			FinSi
			Si posPunto < posArroba Entonces
				Escribir "Error: El punto debe ir después del arroba"
				esValido <- Falso
			FinSi
		FinSi
	Hasta Que esValido = Verdadero
	Escribir "Correo válido ?"
FinAlgoritmo