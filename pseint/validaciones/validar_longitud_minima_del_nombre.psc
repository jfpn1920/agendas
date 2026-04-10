Algoritmo validar_longitud_minima_del_nombre
	Definir nombre, caracter Como Cadena
	Definir i, contador Como Entero
	Definir esValido Como Logico
	Repetir
		Escribir "Ingrese su nombre (mínimo 3 letras):"
		Leer nombre
		esValido <- Verdadero
		contador <- 0
		Si nombre = "" Entonces
			Escribir "Error: El nombre no puede estar vacío"
			esValido <- Falso
		SiNo
			i <- 0
			Mientras Subcadena(nombre, i, i) <> "" Hacer
				contador <- contador + 1
				i <- i + 1
			FinMientras
			Si contador < 3 Entonces
				Escribir "Error: El nombre debe tener al menos 3 caracteres"
				esValido <- Falso
			FinSi
		FinSi
	Hasta Que esValido = Verdadero
	Escribir "Nombre válido ?"
FinAlgoritmo