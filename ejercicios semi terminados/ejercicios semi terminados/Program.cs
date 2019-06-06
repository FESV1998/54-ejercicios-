using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios_semi_terminados
{
    class Program
    {
        static void Main(string[] args)
        {
            //hacer un algoritmo que imprima los numeros del 0 al 100
            Console.WriteLine("algoritmo num.1");
            int n;
            for (n = 0; n <= 100; n = n + 1)
            {
                Console.WriteLine(n);
            }
            //algoritmo que imprima los numeros del 100 al 0 en forma decresiente
            Console.ReadKey();
            Console.WriteLine("algoritmo num.2");
            int m;
            for (m = 100; m >= 0; m = m - 1)
            {
                Console.WriteLine(m);
            }
            //algortimo que imprima la suma de los primeros 100 numeros enteros 
            Console.ReadKey();
            Console.WriteLine("algoritmo num.3");
            double c, primeros;
            c = 100;
            primeros = (c * (c + 1)) / 2;
            Console.WriteLine("la suma de los primeros 100 numeros es:" + primeros);
            // algoritmo que imprima los numeros pares entre 0 al 100
            Console.ReadKey();
            Console.WriteLine("algoritmo num.4");
            for (int j = 0; j <= 100; j = j + 2)
            {
                Console.WriteLine(j);
            }

            Console.ReadKey();
            //algoritmo que imprima los numeros impares hasta el 100 y que imprima cuantos hay
            Console.WriteLine("algoritmo num.5");
            int i, f;
            f = 50;
            for (i = 1; i <= 99; i = i + 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("los numeros impares que hay son:" + f);
            Console.ReadKey();
            //algoritmo que imprima los numeros impares del 100 al hasta la unidad y que cslcule su suma
            Console.WriteLine("algoritmo num.6");
            int s = 0;
            for (int e = 99; e >= 1; e = e - 2)
            {
                s = s + e;
                Console.WriteLine("los numeros pares son:" + e);
                Console.WriteLine("la suma es" + s);

            }
            Console.ReadKey();
            Console.WriteLine("algoritmo num.7");
            int p;
            Console.WriteLine("ingrese numero final");
            p = int.Parse(Console.ReadLine());
            for (int r = 1; r <= p; r = r + 1)
            {
                Console.WriteLine(r);
            }
            Console.ReadKey();
            //algoritmo que imprima y cuente los multiplos de 3 que hay entre 0 y 100
            Console.WriteLine("ejercicio8");
            for (int k = 0; k <= 100; k++)
            {
                if (k % 3 == 0)
                {
                    Console.WriteLine(k);
                }

            }
            Console.ReadKey();
            //algoritmo calcule la suma de los numeros impares comprendidos entre el 0 y el 100
            Console.WriteLine("ejercicio 9");
            int SUM = 0, impar2 = 0;
            for (int l = 0; l <= 100; l++)
            {
                if (l % 2 != 0)
                {
                    Console.WriteLine(l);
                    impar2++;
                    Console.WriteLine();
                    SUM = SUM + impar2;
                    Console.WriteLine("suma " + SUM);
                }

            }
            Console.ReadKey();
            //algoritmo que imprima los multiplos de 5 que hay entre el 1 y el 500
            Console.WriteLine("ejercicio10 ");
            for (int z = 0; z <= 500; z = z + 5)
            {
                Console.WriteLine(z);
            }
            Console.ReadKey();
            //algoritmo, imprimir y sumar los multiplos de 2 hasta un numero que introducimos por teclado
            Console.WriteLine("ejercicio 11");
            int suma1 = 0, nlimite;
            Console.WriteLine("ingrese un numero final");
            nlimite = int.Parse(Console.ReadLine());
            for (int se = 0; se <= nlimite; se = se + 2)
            {
                Console.WriteLine(se);
                suma1 = suma1 + se;
                Console.WriteLine("suma " + suma1);
            }
            Console.ReadKey();
            //algoritmo, imprimir y sumar los multiplos de 10 hasta un numero que introducimos por teclado
            Console.WriteLine("ejercicio 12");
            int suma2 = 0, numlimite;
            Console.WriteLine("ingrese un numero final");
            numlimite = int.Parse(Console.ReadLine());
            for (int n1 = 0; n1 <= numlimite; n1 = n1 + 10)
            {
                Console.WriteLine(n1);
                Console.WriteLine();
                suma2 = suma2 + n1;
                Console.WriteLine("suma " + suma2);
            }
            Console.ReadKey();
            //algoritmo, introducir un numero por teclado menor que 500.
            //imprimir y sumar los numeros que estan separados entre si 8 posiciones, desde es numero al 500
            Console.WriteLine("ejercicio 13");
            int nom, sum3 = 0;
            Console.WriteLine("introdusca un numero menor que 500");
            nom = Convert.ToInt16(Console.ReadLine());
            for (int q = nom; q <= 500; q = q + 8)
            {
                Console.WriteLine(q);
                Console.WriteLine();
                sum3 = sum3 + q;
                Console.WriteLine("suma " + sum3);
            }
            Console.ReadKey();
            //algoritmo, introducir un numero por teclado y que nos diga si es positivo o negativo
            Console.WriteLine("ejercicio 16");
            int nmr;
            Console.WriteLine("ingrese un numero");
            nmr = int.Parse(Console.ReadLine());
            if (nmr > 0)
            {
                Console.WriteLine("+positivo");
            }
            else
            {
                Console.WriteLine("-negativo");

            }
            Console.ReadKey();
            //algoritmo, introducir un numero por teclado que nos diga si es par o impar
            Console.WriteLine("ejercicio 17");
            int b;
            Console.WriteLine("ingrese un numero");
            b = int.Parse(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine("es par");
            }
            else
            {
                Console.WriteLine("es impar");
            }
            Console.ReadKey();
            //algoritmo, imprimir los multiplos de 3 desde la unidad hasta un numero que introducimos por teclado
            Console.WriteLine("ejercicio 18");
            int Nu;
            Console.WriteLine("ingrese un numero");
            Nu = int.Parse(Console.ReadLine());
            for (int L = 0; L <= Nu; L = L + 3)
            {
                Console.WriteLine(L);
            }
            Console.ReadKey();
            //algoritmo, imprima los numeros del 1  al 100
            //calcule la suma de todos los numeros pares por un lado y por otro la de todos los impares 
            Console.WriteLine("ejercicio 19");
            Console.WriteLine("numeros pares");
            for (int y = 0; y <= 100; y++)
            {
                if (y % 2 == 0)
                {
                    Console.WriteLine(y);
                }
                else if (y % 2 != 0)
                {
                    Console.WriteLine("numero impares");
                    Console.WriteLine(y);
                }
            }
            Console.ReadKey();
            //algoritmo, imprimir los numeros que son multiplos de 2 o 3 que hay del 1 al 100
            Console.WriteLine("ejercicio 20");
            Console.WriteLine("los multiplos de 2");
            for (int v = 0; v <= 100; v = v + 2)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("los multiplos de 3");
            for (int ñ = 0; ñ <= 100; ñ = ñ + 3)
            {
                Console.WriteLine(ñ);
            }
            Console.ReadKey();
            //algoritmo, imprima el mayor y el menor de una serie de 5 numeros que vamos introduciendo por teclado
            Console.WriteLine("ejercicio 22");
            int numm, max = 0, min = 0;
            for (int coun = 0; coun <= 5; coun++)
            {
                Console.WriteLine("escriba un numero");
                numm = Convert.ToInt16(Console.ReadLine());
                if (coun == 0)
                {
                    max = numm;
                    min = numm;
                }
                else if (coun != 0)
                {
                    if (numm < min)
                    {
                        min = numm;
                    }
                    if (numm > max)
                    {
                        max = numm;
                    }

                }

            }
            Console.WriteLine("el mayo es " + max);
            Console.WriteLine("el menor es " + min);
            Console.ReadKey();
            Console.WriteLine("algoritmo # 23");
            //Introducir dos números por teclado.Imprimir los números naturales que hay entre ambos números empezando
            //por el más pequeño, contar cuantos hay y cuantos de ellos son pares. Calcular la suma de los impares.
            int num1, num2, cantNurales, cantpares, sumImpares;
            cantNurales = 0;
            cantpares = 0;
            sumImpares = 0;
            Console.Write("Ingrese un de Inicio: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un de Inicio: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            for (int x = num1; x <= num2; x++)
            {
                Console.WriteLine(i);
                cantNurales = cantNurales + 1;
                if (x % 2 == 0)
                {
                    cantpares = cantpares + 1;
                }
                else
                {
                    sumImpares = sumImpares + i;
                }
            }
            Console.WriteLine("Cantidad de numeros Naturales" + cantNurales);
            Console.WriteLine("Cantidad Numero Pares:" + cantpares);
            Console.WriteLine("Suma de Numeros Impares:" + sumImpares);
            Console.ReadKey();
            Console.WriteLine("ejercicio # 24");
            // Introducir una serie de números. Decir si esos números son mayores o menores de 10.
            int numero = 0;
            string mayores, menores;
            mayores = "";
            menores = "";
            for (int qw = 1; qw < 10; qw++)
            {
                Console.Write("Ingrese un Numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero > 10)
                {
                    mayores = mayores + "" + numero + ",";
                }
                else
                {
                    menores = menores + "" + numero + ",";
                }
            }
            Console.WriteLine("Los numeros: " + mayores + " " + "Son mayores que 10");
            Console.WriteLine("Los numeros: " + menores + " " + "Son Menores que 10");
            Console.ReadKey();
            Console.WriteLine("algoritmo # 25");
            //Introducir tantos números que hay entre el 1 al 100.excepto los múltiplos de 2.
            int nume = 0;
            for (int we = 1; we < 15; we++)
            {
                Console.Write("Ingrese un numero entre el 1 al 100, excepto los Multiplos de 2:");
                nume = Convert.ToInt32(Console.ReadLine());
                if (nume < 0 || nume > 100)
                {
                    Console.WriteLine("El numero ingresado no esta entre el rango de 1 - 100");
                    Console.ReadKey();
                    return;
                }
                if (nume % 2 == 0)
                {
                    Console.WriteLine("El numero ingresado es multiplo de dos");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine("algoritmo # 26");
                //Imprimir y sumar los números desde el cero hasta un numero determinado, excepto los múltiplos
                //de 5 imprimir el valor de la suma de los múltiplos de 5.
                int numer, sumaNumeros, sumaMultiplos;
                sumaMultiplos = 0;
                sumaNumeros = 0;
                Console.Write("Ingrese un numero donde desea finalizar: ");
                numer = Convert.ToInt32(Console.ReadLine());
                for (int er = 0; er <= numer; er++)
                {
                    if (er % 5 == 0)
                    {
                        sumaMultiplos = sumaMultiplos + er;
                    }
                    else
                    {
                        Console.WriteLine(er);
                        sumaNumeros = sumaNumeros + er;
                    }
                }
                Console.WriteLine("Suma de numeros Excepto los multiplos de 5: {0}", sumaNumeros);
                Console.WriteLine("Valor de la suma de los multiplos de 5: {0}", sumaMultiplos);
                Console.ReadKey();
                Console.WriteLine("algortimo # 27");
                //Imprimir y contar los números, que son a la vez múltiplos de 2 y 3, que
                //hay entre la unidad y el determinado número.
                int nmero, cantNumeros;
                nmero = 0;
                cantNumeros = 0;
                Console.Write("Ingrese un Numero donde desea finalizar el conteo: ");
                nmero = Convert.ToInt32(Console.ReadLine());
                for (int rt = 1; rt <= nmero; rt++)
                {
                    if (rt % 2 == 0 && rt % 3 == 0)
                    {
                        Console.WriteLine(rt);
                        cantNumeros = cantNumeros + 1;
                    }
                }
                Console.WriteLine("Cantidad de numeros Multiplos de 2 y 3:" + cantNumeros);
                Console.ReadKey();
                Console.WriteLine("algortimo # 28");
                //Introducir una serie de números. Sumar los múltiplos de 5. Cual es el mayor y cuantos números
                //se han introducido. SEPARADO EN 7 UNIDADES, SUMAR LOS IMPARES
                int numeo, sumaMultiplo, mayor, canteparados, sumaImpares;
                sumaMultiplo = 0;
                mayor = 0;
                canteparados = 0;
                sumaImpares = 0;
                for (int ty = 1; ty <= 10; ty++)
                {
                    Console.Write("Ingrese un numero: ");
                    numeo = int.Parse(Console.ReadLine());
                    if (numeo % 5 == 0)
                    {
                        sumaMultiplo = sumaMultiplo + numeo;
                    }
                    if (numeo > mayor)
                    {
                        mayor = numeo;
                    }
                    if (numero % 2 == 0)
                    {
                        sumaImpares = sumaImpares + numero;
                    }
                }
                Console.WriteLine("Suma de los Multiplos de 5: {0}", sumaMultiplo);
                Console.WriteLine("El mayor de los Numeros Ingresado: {0}", mayor);
                Console.WriteLine("Suma de los numeros impares: {0}", sumaImpares);
                Console.ReadKey();
                Console.WriteLine("algoritmo # 29");
                // Introducir dos números por teclado de tal forma que el segundo sea mayor que el primero.
                //A partir del primero. Imprimir los números separados. Entre si 7 unidades, contarlos.
                //Cuantos de estos son pares y cuanto vale la suma de los impares.
                int numero1, numero2, cantPares, sumImpres;
                cantPares = 0;
                sumImpres = 0;
                Console.Write("Ingrese un Numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.Write("Ingrese otro numero Mayor que el anterior: ");
                numero2 = int.Parse(Console.ReadLine());
                if (numero2 > numero1)
                {
                    for (int yu = numero1; yu < numero2; yu = yu + 7)
                    {
                        Console.WriteLine(i);
                        if (yu % 2 == 0)
                        {
                            cantPares = cantPares + 1;
                        }
                        else
                        {
                            sumImpres = sumImpres + i;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("El segundo numero no es mayor al primero.....");

                }
                Console.WriteLine("Numeros pares encontrados:" + cantPares);
                Console.WriteLine("Suma de Numeros Impares:" + sumImpares);
                Console.ReadKey();
                Console.WriteLine("algoritmo # 30");
                //Introducir una cantidad por teclado.Si es menor que 500, sumarle el 50 por ciento;
                //si es mayor o igual a 500 pero menor que 1000, sumarle el 7 por ciento;
                //si es mayor que 1000 y menor o igual a 5000, restarle el 5 por ciento.
                int cantidad;
                Console.Write("Ingrese una Cantidad: ");
                cantidad = int.Parse(Console.ReadLine());
                if (cantidad < 500)
                {
                    Console.WriteLine("\n ========================");
                    Console.WriteLine("El numero que ingreso es:" + cantidad);
                    cantidad = cantidad + (cantidad * 50 / 100);
                    Console.WriteLine("Total mas 50%:" + cantidad);

                }
                else if (cantidad >= 500 && cantidad < 1000)
                {
                    Console.WriteLine("\n ========================");
                    Console.WriteLine("El numero que ingreso es:" + cantidad);
                    cantidad = cantidad + (cantidad * 7 / 100);
                    Console.WriteLine("Total mas 7%:" + cantidad);
                }
                else if (cantidad > 1000 && cantidad <= 5000)
                {
                    Console.WriteLine("\n ========================");
                    Console.WriteLine("El numero que ingreso es: {0}", cantidad);
                    cantidad = cantidad - (cantidad * 5 / 100);
                    Console.WriteLine("Total menos 5%: {0}", cantidad);
                }
                Console.ReadKey();
                Console.WriteLine("algortimo # 31");
                //Imprimir diez veces la serie de números del 1 al 10
                for (int ui = 1; ui <= 10; ui++)
                {
                    Console.WriteLine("==========Serie {0}==========", ui);
                    for (int io = 1; io <= 10; io++)
                    {
                        Console.WriteLine(io);
                    }

                }
                Console.ReadKey();
                Console.WriteLine("algoritmo # 32");
                //Imprimir, contar y sumar los múltiplos de 2 que hay entre una serie de número,
                //tal que el segundo sea mayor o igual que el primero
                int n1 = 1, n2 = 0, op = 0, cp = 0, sp = 0;
                while (n1 > n2)
                {
                    Console.Write("Ingrese un valor entero positivo: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el otro valor mayor al anterior: ");
                    n2 = int.Parse(Console.ReadLine());
                    if (n1 > n2)
                    {
                        Console.Write("Error debe ingresar el Segundo valor mayor o igual al primero");
                    }
                }
                op = n1;
                while (op <= n2)
                {
                    if (op % 2 == 0)
                    {
                        Console.WriteLine(c);
                        cp++;
                        sp = sp + op;
                    }
                    c++;
                }
                Console.WriteLine("Multiplos de 2 encontrados: " + cp);
                Console.WriteLine("La suma de los multiplos de 2: " + sp);
                Console.ReadKey();
                Console.WriteLine("algortimo # 33");
                //Calcular e imprimar la factorial de un número ingresado vía teclado.
                int nuro = 0, fact = 1;
                Console.Write("Ingrese un numero a calcular el Factorial: ");
                nuro = Convert.ToInt32(Console.ReadLine());
                for (int sa = 1; sa <= nuro; sa++)
                {
                    fact = fact * sa;
                }
                Console.WriteLine("El Factorial del numero ingresado es:" + fact);
                Console.ReadKey();
                Console.WriteLine("algortimo # 34");
                //Hacer un programa que obtenga el producto de dos números enteros positivos mediante restas sucesivas
                int n3 = 0, n4 = 0, sd = 0, multi = 0;
                Console.Write("Ingrese el primer número entero: ");
                n3 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número entero: ");
                n4 = Convert.ToInt32(Console.ReadLine());
                while (sd < n4)
                {
                    multi = multi - n3;
                    sd++;
                }
                Console.WriteLine("La multiplicación por sumas sucesivas es: " + multi * -1);
                Console.ReadKey();
                Console.WriteLine("algoritmo # 35");
                //Obtener el cociente y el resto de dos números enteros positivos mediante restas sucesivas
                int m1 = 0, m2 = 1, fg = 0, gh = 0;
                while (n2 > n1)
                {
                    Console.Write("Ingrese un valor entero positivo: ");
                    m1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el otro valor menor al anterior: ");
                    m2 = Convert.ToInt32(Console.ReadLine());
                }
                fg = n1;
                while (fg >= m2)
                {
                    fg = fg - m2;
                    gh++;
                }
                Console.WriteLine("El cociente por restas sucesivas es: " + gh);
                Console.WriteLine("El resto de la divisón por restas sucesivas es: " + fg);
                Console.ReadKey();
                Console.WriteLine("algortimo # 36");
                //Hacer un algoritmo que calcule las raíces de una ecuación de segundo grado
                //Repetir el proceso tantas veces como se desee.
                Console.ReadKey();
                Console.WriteLine("algortimo # 37");
                //Hacer un programa que determine cuantas cifras posee un número
                //entero positivo introducido por teclado.repetir el proceso
                int nu = 0, cant = 0;
                Console.Write("Ingrese un numero entero positivo: ");
                nu = Convert.ToInt32(Console.ReadLine());

                while (nu >= 10)
                {
                    cant++;
                    nu = nu / 10;
                }
                Console.WriteLine("El número tiene: " + (cant + 1) + " dígitos");
                Console.ReadKey();

                Console.WriteLine("algoritmo # 40");
                //Calcular el menor numero primo de un numero que introducimos vía teclado.

                int cv = 0, aux = 0, cc = 0, numro = 0;
                Console.Write("Ingrese un valor: ");
                numro = Convert.ToInt32(Console.ReadLine());
                while (cv < numro)
                {
                    cv++;
                    while (aux < cv)
                    {
                        aux++;
                        if (cv % aux == 0)
                        {
                            cc++;
                        }
                    }
                    if (cc == 2)
                    {
                        Console.WriteLine(" " + c);

                    }
                    cc = 0;
                    aux = 0;
                }
                Console.WriteLine("El menor numero primos es: 2");
                Console.ReadKey();
                Console.WriteLine("algoritmo # 41");
                // Introducir un número entero, imprimir el valor equivalente en binario
                int nuo = 0, x = 0;
                Console.Write("Ingrese un numero ENTERO para Convertir a BINARIO: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n===============");
                Console.Write("BINARIO: ");
                while ((nuo) != 0)
                {
                    x = nuo % 2;
                    Console.Write("" + x);
                    nuo = nuo / 2;
                }
                Console.ReadKey();
                Console.WriteLine("algoritmo # 42");
                //Implementar un método en java que reciba como parámetro un vector de 20 elementos
                int[] Vector1 = new int[19];
                int conteo = 0;

                for (int nn = 0; nn < Vector1.Length; nn++)
                {
                    conteo = nn;
                }
                if (conteo == 20)
                {
                    Vector(Vector1);
                }

            }
        }
        public static void Vector(int[] intArray)
        {
            Console.WriteLine("continuaraa.....");
        }
    }
}
