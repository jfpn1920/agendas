SubProceso filtrar_contactos(nombres, telefonos, correos, categoria, n)
	Definir i Como Entero
	Definir filtro Como Cadena
	Escribir "Ingrese la categoria a filtrar (Familia, Trabajo, Amigos):"
	Leer filtro
	Escribir "===== CONTACTOS FILTRADOS: ", filtro, " ====="
	Para i <- 1 Hasta n Hacer
		Si categoria[i] = filtro Entonces
			Escribir "Nombre: ", nombres[i]
			Escribir "Telefono: ", telefonos[i]
			Escribir "Correo: ", correos[i]
			Escribir "----------------------"
		FinSi
	FinPara
FinSubProceso
Algoritmo funcion_para_filtrar_contactos	
	Definir nombres, telefonos, correos, categoria Como Cadena
	Definir n Como Entero
	Dimension nombres[100]
	Dimension telefonos[100]
	Dimension correos[100]
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
	filtrar_contactos(nombres, telefonos, correos, categoria, n)
FinAlgoritmo