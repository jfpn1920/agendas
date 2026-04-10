Algoritmo limpiar_agenda
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir categoria Como Cadena
	Definir i Como Entero
	Definir n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension categoria[100]
	n <- 3
	nombres[0] <- "Ana"
	nombres[1] <- "Luis"
	nombres[2] <- "Carlos"
	telefonos[0] <- "111"
	telefonos[1] <- "222"
	telefonos[2] <- "333"
	categoria[0] <- "Familia"
	categoria[1] <- "Trabajo"
	categoria[2] <- "Amigos"
	Escribir "Limpiando agenda..."
	Para i <- 0 Hasta 99 Hacer
		nombres[i] <- ""
		telefonos[i] <- ""
		categoria[i] <- ""
	FinPara
	n <- 0
	Escribir "Agenda limpiada correctamente"
FinAlgoritmo