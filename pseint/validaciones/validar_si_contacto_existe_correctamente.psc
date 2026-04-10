Algoritmo validar_si_contacto_existe_correctamente
	Definir contactos Como Cadena
	Definir i, n Como Entero
	Definir nombreBuscar Como Cadena
	Definir encontrado Como Logico
	n <- 3
	Dimension contactos[n]
	contactos[0] <- "Juan"
	contactos[1] <- "Maria"
	contactos[2] <- "Carlos"
	Repetir
		Escribir "Ingrese el nombre del contacto a buscar:"
		Leer nombreBuscar
		Si nombreBuscar = "" Entonces
			Escribir "Error: No puede estar vacío"
		FinSi
	Hasta Que nombreBuscar <> ""
	encontrado <- Falso
	Para i <- 0 Hasta n-1 Hacer
		Si contactos[i] = nombreBuscar Entonces
			encontrado <- Verdadero
		FinSi
	FinPara
	Si encontrado Entonces
		Escribir "El contacto SI existe"
	SiNo
		Escribir "El contacto NO existe"
	FinSi
FinAlgoritmo