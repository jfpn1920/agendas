Algoritmo validar_numero_telefonico_completo
	Definir telefono, caracter Como Cadena
	Definir i, contador Como Entero
	Definir esValido Como Logico
	Repetir
		Escribir "Ingrese un número telefónico (10 dígitos):"
		Leer telefono
		esValido <- Verdadero
		contador <- 0
		Si telefono = "" Entonces
			Escribir "Error: No puede estar vacío"
			esValido <- Falso
		SiNo
			i <- 0
			Mientras Subcadena(telefono, i, i) <> "" Hacer
				contador <- contador + 1
				caracter <- Subcadena(telefono, i, i)
				Si caracter < "0" O caracter > "9" Entonces
					Escribir "Error: Solo se permiten números"
					esValido <- Falso
				FinSi
				i <- i + 1
			FinMientras
			Si contador <> 10 Entonces
				Escribir "Error: Debe tener 10 dígitos"
				esValido <- Falso
			FinSi
		FinSi
	Hasta Que esValido = Verdadero
	Escribir "Número telefónico válido ?"
FinAlgoritmo