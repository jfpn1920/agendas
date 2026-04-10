Algoritmo actualizar_contacto
	Definir nombres, telefonos, correos Como Cadena
	Definir i, n Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
	n <- 3
	nombres[0] <- "Ana"
	nombres[1] <- "Luis"
	nombres[2] <- "Carlos"
	telefonos[0] <- "111"
	telefonos[1] <- "222"
	telefonos[2] <- "333"
	correos[0] <- "ana@mail.com"
	correos[1] <- "luis@mail.com"
	correos[2] <- "carlos@mail.com"
	encontrado <- Falso
	Escribir "Ingrese el nombre del contacto a actualizar:"
	Leer buscar
	Para i <- 0 Hasta n-1 Hacer
		Si nombres[i] = buscar Entonces
			Escribir "Contacto encontrado. Ingrese nuevos datos:"
			Escribir "Nuevo nombre:"
			Leer nombres[i]
			Escribir "Nuevo telefono:"
			Leer telefonos[i]
			Escribir "Nuevo correo:"
			Leer correos[i]
			encontrado <- Verdadero
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "Contacto no encontrado"
	SiNo
		Escribir "Contacto actualizado correctamente"
	FinSi
FinAlgoritmo