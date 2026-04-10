Algoritmo crear_modulo_de_utilidades
	Definir nombre Como Cadena
	LimpiarPantalla
	MostrarTitulo
	Escribir "Ingrese su nombre:"
	Leer nombre
	LineaSeparadora
	Escribir "Hola ", nombre
	LineaSeparadora
	Pausa
FinAlgoritmo
SubProceso LimpiarPantalla
	Definir i Como Entero
	Para i <- 1 Hasta 10 Hacer
		Escribir ""
	FinPara
FinSubProceso
SubProceso MostrarTitulo
	Escribir "=============================="
	Escribir "     SISTEMA DE AGENDA"
	Escribir "=============================="
FinSubProceso
SubProceso LineaSeparadora
	Escribir "------------------------------"
FinSubProceso
SubProceso Pausa
	Definir tecla Como Cadena
	Escribir "Presione ENTER para continuar..."
	Leer tecla
FinSubProceso