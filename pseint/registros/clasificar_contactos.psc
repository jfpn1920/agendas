Algoritmo clasificar_contactos
	Definir nombres, telefonos, categoria Como Cadena
	Definir i, n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension categoria[100]
	n <- 6
	nombres[1] <- "Ana"
	nombres[2] <- "Luis"
	nombres[3] <- "Carlos"
	nombres[4] <- "Maria"
	nombres[5] <- "Pedro"
	nombres[6] <- "Sofia"
	telefonos[1] <- "111"
	telefonos[2] <- "222"
	telefonos[3] <- "333"
	telefonos[4] <- "444"
	telefonos[5] <- "555"
	telefonos[6] <- "666"
	categoria[1] <- "Familia"
	categoria[2] <- "Trabajo"
	categoria[3] <- "Amigos"
	categoria[4] <- "Familia"
	categoria[5] <- "Trabajo"
	categoria[6] <- "Amigos"
	Escribir "===== CONTACTOS CLASIFICADOS ====="
	Escribir "----- FAMILIA -----"
	Para i <- 1 Hasta n Hacer
		Si categoria[i] = "Familia" Entonces
			Escribir nombres[i], " - ", telefonos[i]
		FinSi
	FinPara
	Escribir "----- TRABAJO -----"
	Para i <- 1 Hasta n Hacer
		Si categoria[i] = "Trabajo" Entonces
			Escribir nombres[i], " - ", telefonos[i]
		FinSi
	FinPara
	Escribir "----- AMIGOS -----"
	Para i <- 1 Hasta n Hacer
		Si categoria[i] = "Amigos" Entonces
			Escribir nombres[i], " - ", telefonos[i]
		FinSi
	FinPara
FinAlgoritmo