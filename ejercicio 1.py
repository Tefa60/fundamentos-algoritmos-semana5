         print("=== SISTEMA DE DESCUENTOS ===")

# Solicitar precio del producto
precio = float(input("Ingrese el precio del producto: $"))

# Solicitar código de descuento
print("\nCódigos de descuento:")
print("1 = Estudiante (10%)")
print("2 = Empleado (15%)")
print("3 = Cliente frecuente (20%)")
codigo = int(input("Ingrese su código de descuento (1, 2 o 3): "))

# Variables para cálculos
porcentaje_descuento = 0
tipo_cliente = ""

# Estructura condicional para seleccionar descuento
if codigo == 1:
    porcentaje_descuento = 0.10  # 10%
    tipo_cliente = "Estudiante"
elif codigo == 2:
    porcentaje_descuento = 0.15  # 15%
    tipo_cliente = "Empleado"
elif codigo == 3:
    porcentaje_descuento = 0.20  # 20%
    tipo_cliente = "Cliente frecuente"
else:
    print("Código inválido. No se aplicará descuento.")
    porcentaje_descuento = 0
    tipo_cliente = "Sin descuento"

# Calcular descuento base
descuento_base = precio * porcentaje_descuento
precio_con_descuento_base = precio - descuento_base

# Validación con operadores lógicos: descuento adicional si precio > 500
descuento_adicional = 0
if precio > 500 and codigo >= 1 and codigo <= 3:
    descuento_adicional = precio_con_descuento_base * 0.05  # 5% adicional
    print("¡Descuento adicional del 5% aplicado por compra mayor a $500!")

# Calcular precio final
precio_final = precio_con_descuento_base - descuento_adicional
descuento_total = descuento_base + descuento_adicional

# Mostrar resultados
print("\n=== RESUMEN DE COMPRA ===")
print(f"Tipo de cliente: {tipo_cliente}")
print(f"Precio original: ${precio:.2f}")
print(f"Descuento base ({porcentaje_descuento * 100:.0f}%): -${descuento_base:.2f}")

if descuento_adicional > 0:
    print(f"Descuento adicional (5%): -${descuento_adicional:.2f}")

print(f"Descuento total: -${descuento_total:.2f}")
print(f"PRECIO FINAL: ${precio_final:.2f}")

print("\nPresione Enter para salir...")
input()
