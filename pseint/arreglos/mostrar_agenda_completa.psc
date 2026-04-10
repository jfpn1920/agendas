Algoritmo mostrar_agenda_completa
	Definir nombres Como Cadena
	Definir telefonos Como Cadena
	Definir categoria Como Cadena
	Definir i, n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension categoria[100]
	n <- 4
	nombres[0] <- "Ana"
	nombres[1] <- "Luis"
	nombres[2] <- "Carlos"
	nombres[3] <- "Maria"
	telefonos[0] <- "111"
	telefonos[1] <- "222"
	telefonos[2] <- "333"
	telefonos[3] <- "444"
	categoria[0] <- "Familia"
	categoria[1] <- "Trabajo"
	categoria[2] <- "Amigos"
	categoria[3] <- "Familia"
	Escribir "===== AGENDA COMPLETA ====="
	Para i <- 0 Hasta n-1 Hacer
		Escribir "Contacto ", i+1
		Escribir "Nombre: ", nombres[i]
		Escribir "Teléfono: ", telefonos[i]
		Escribir "Categoría: ", categoria[i]
		Escribir "------------------------"
	FinPara
FinAlgoritmo