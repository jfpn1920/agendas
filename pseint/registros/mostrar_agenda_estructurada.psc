Algoritmo mostrar_agenda_estructurada
	Definir nombres, telefonos, correos Como Cadena
	Definir i, n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
	n <- 4
	nombres[1] <- "Ana"
	nombres[2] <- "Luis"
	nombres[3] <- "Carlos"
	nombres[4] <- "Maria"
	telefonos[1] <- "111"
	telefonos[2] <- "222"
	telefonos[3] <- "333"
	telefonos[4] <- "444"
	correos[1] <- "ana@mail.com"
	correos[2] <- "luis@mail.com"
	correos[3] <- "carlos@mail.com"
	correos[4] <- "maria@mail.com"
	Escribir "====================================="
	Escribir "        AGENDA ESTRUCTURADA"
	Escribir "====================================="
	Escribir "No  | Nombre   | Telefono | Correo"
	Escribir "-------------------------------------"
	Para i <- 1 Hasta n Hacer
		Escribir i, "   | ", nombres[i], "   | ", telefonos[i], "   | ", correos[i]
	FinPara
	Escribir "====================================="
FinAlgoritmo