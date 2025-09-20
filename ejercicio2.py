import math

print("=== SISTEMA DE CLASIFICACIÓN DE NOTAS ===")

# Solicitar nota
nota = float(input("Ingrese una nota (0-20): "))

# Validar que la nota esté en el rango correcto
if nota < 0 or nota > 20:
    print("ERROR: La nota debe estar entre 0 y 20.")
    print("Presione Enter para salir...")
    input()
    exit()

# Convertir nota a entero para facilitar la clasificación
nota_entera = int(nota)
clasificacion = ""

# Usar estructura similar a switch para clasificar la nota
if 0 <= nota_entera <= 10:
    clasificacion = "Desaprobado"
elif 11 <= nota_entera <= 13:
    clasificacion = "Regular"
elif 14 <= nota_entera <= 17:
    clasificacion = "Bueno"
elif 18 <= nota_entera <= 20:
    clasificacion = "Excelente"
else:
    clasificacion = "Fuera de rango"

# Validaciones adicionales con operadores lógicos
mensaje_adicional = ""

# Si la nota es mayor o igual a 14 y es par
if nota >= 14 and int(nota) % 2 == 0:
    mensaje_adicional = "Buen desempeño con nota par"
# Si la nota es impar o menor a 11
elif int(nota) % 2 != 0 or nota < 11:
    mensaje_adicional = "Necesita reforzar"

# Calcular raíz cuadrada y potencia al cubo
raiz_cuadrada = math.sqrt(nota)
potencia_cubo = nota ** 3

# Mostrar resultados
print("\n=== RESULTADO DE EVALUACIÓN ===")
print(f"Nota ingresada: {nota:.2f}")
print(f"Clasificación: {clasificacion}")

if mensaje_adicional:
    print(f"Observación: {mensaje_adicional}")

print("\n=== CÁLCULOS MATEMÁTICOS ===")
print(f"Raíz cuadrada: {raiz_cuadrada:.1f}")
print(f"Potencia al cubo: {potencia_cubo:.0f}")

print("\nPresione Enter para salir...")
input()
