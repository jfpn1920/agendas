Algoritmo buscar_por_campo_nombre
	Definir nombres, telefonos, correos Como Cadena
	Definir i, n Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
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
	encontrado <- Falso
	Escribir "Ingrese el nombre a buscar:"
	Leer buscar
	Para i <- 1 Hasta n Hacer
		Si nombres[i] = buscar Entonces
			Escribir "===== CONTACTO ENCONTRADO ====="
			Escribir "Nombre: ", nombres[i]
			Escribir "Telefono: ", telefonos[i]
			Escribir "Correo: ", correos[i]
			encontrado <- Verdadero
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "Contacto no encontrado"
	FinSi
FinAlgoritmo