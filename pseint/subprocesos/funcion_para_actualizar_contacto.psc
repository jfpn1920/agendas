SubProceso actualizar_contacto(nombres, telefonos, correos, n)
	Definir i Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	encontrado <- Falso
	Escribir "Ingrese el nombre del contacto a actualizar:"
	Leer buscar
	Para i <- 1 Hasta n Hacer
		Si nombres[i] = buscar Entonces
			Escribir "===== CONTACTO ENCONTRADO ====="
			Escribir "Ingrese el nuevo nombre:"
			Leer nombres[i]
			Escribir "Ingrese el nuevo telefono:"
			Leer telefonos[i]
			Escribir "Ingrese el nuevo correo:"
			Leer correos[i]
			encontrado <- Verdadero
			Escribir "Contacto actualizado correctamente"
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "Contacto no encontrado"
	FinSi
FinSubProceso
Algoritmo funcion_para_actualizar_contacto
	Definir nombres, telefonos, correos Como Cadena
	Definir n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
	n <- 3
	nombres[1] <- "Ana"
	nombres[2] <- "Luis"
	nombres[3] <- "Carlos"
	telefonos[1] <- "111"
	telefonos[2] <- "222"
	telefonos[3] <- "333"
	correos[1] <- "ana@mail.com"
	correos[2] <- "luis@mail.com"
	correos[3] <- "carlos@mail.com"
	actualizar_contacto(nombres, telefonos, correos, n)
FinAlgoritmo