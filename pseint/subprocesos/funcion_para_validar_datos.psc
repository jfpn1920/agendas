Funcion valido <- validar_datos(dato)
	Definir i Como Entero
	Definir valido Como Logico
	valido <- Verdadero
	Si Longitud(dato) = 0 Entonces
		valido <- Falso
	SiNo
		Si Longitud(dato) < 3 Entonces
			valido <- Falso
		FinSi
	FinSi
FinFuncion
Algoritmo funcion_para_validar_datos	
	Definir telefono Como Cadena
	Definir resultado Como Logico
	Escribir "Ingrese el telefono:"
	Leer telefono
	resultado <- validar_datos(telefono)
	Si resultado = Verdadero Entonces
		Escribir "Dato valido"
	SiNo
		Escribir "Dato invalido"
	FinSi
FinAlgoritmo