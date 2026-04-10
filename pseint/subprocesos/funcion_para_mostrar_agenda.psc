SubProceso mostrar_agenda(nombres, telefonos, correos, n)
	Definir i Como Entero
	Escribir "===== AGENDA COMPLETA ====="
	Para i <- 1 Hasta n Hacer
		Escribir "Contacto ", i
		Escribir "Nombre: ", nombres[i]
		Escribir "Telefono: ", telefonos[i]
		Escribir "Correo: ", correos[i]
		Escribir "----------------------"
	FinPara
FinSubProceso
Algoritmo funcion_para_mostrar_agenda	
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
	mostrar_agenda(nombres, telefonos, correos, n)
FinAlgoritmo