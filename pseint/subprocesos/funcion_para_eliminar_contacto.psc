SubProceso eliminar_contacto(nombres Por Referencia, telefonos Por Referencia, correos Por Referencia, n Por Referencia)
	Definir i, j Como Entero
	Definir buscar Como Cadena
	Definir encontrado Como Logico
	encontrado <- Falso
	Escribir "Ingrese el nombre del contacto a eliminar:"
	Leer buscar
	Para i <- 1 Hasta n Hacer
		Si nombres[i] = buscar Entonces
			Para j <- i Hasta n-1 Hacer
				nombres[j] <- nombres[j+1]
				telefonos[j] <- telefonos[j+1]
				correos[j] <- correos[j+1]
			FinPara
			n <- n - 1
			encontrado <- Verdadero
			Escribir "Contacto eliminado correctamente"
		FinSi
	FinPara
	Si encontrado = Falso Entonces
		Escribir "Contacto no encontrado"
	FinSi
FinSubProceso
Algoritmo funcion_para_eliminar_contacto	
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
	eliminar_contacto(nombres, telefonos, correos, n)
	Escribir "===== AGENDA ACTUALIZADA ====="
	Para i <- 1 Hasta n Hacer
		Escribir nombres[i], " - ", telefonos[i], " - ", correos[i]
	FinPara
FinAlgoritmo