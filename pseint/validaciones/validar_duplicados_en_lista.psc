Algoritmo validar_duplicados_en_lista
	Definir contactos, nuevoNombre Como Cadena
	Definir i, n Como Entero
	Definir existe Como Logico
	n <- 3
	Dimension contactos[n]
	contactos[0] <- "Juan"
	contactos[1] <- "Maria"
	contactos[2] <- "Carlos"
	Repetir
		Escribir "Ingrese un nombre de contacto:"
		Leer nuevoNombre
		existe <- Falso
		Si nuevoNombre = "" Entonces
			Escribir "Error: No puede estar vacío"
		SiNo
			Para i <- 0 Hasta n-1 Hacer
				Si contactos[i] = nuevoNombre Entonces
					existe <- Verdadero
				FinSi
			FinPara
			Si existe Entonces
				Escribir "Error: El contacto ya existe"
			FinSi
		FinSi
	Hasta Que nuevoNombre <> "" Y existe = Falso
	Escribir "Contacto agregado correctamente ?"
FinAlgoritmo