def sumar(num1,num2):
    return num1 + num2

def restar(num1,num2):
    return num1 - num2

def multiplicar(num1,num2):
    return num1 * num2

def dividir(num1,num2):
    return num1 / num2

num1 = int(input("Ingrese el primer numero: "))
num2 = int(input("Ingrese el primer numero: "))

print ("La suma es: ",sumar(num1,num2))
print ("La resta es: ",restar(num1,num2))
print ("La multiplicacion es: ",multiplicar(num1,num2))
if num2==0:
    print("No se puede dividir entre cero")
else:
    print ("La division es: ",dividir(num1,num2))