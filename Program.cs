
/*
Define una función que calcule el valor promedio de un vector numérico. La cantidad de elementos seran 5
*/


    // Display title as the C# console calculator app.
    Console.WriteLine("------------------------------------------------------------------------\n");
    Console.WriteLine("Capturar de N números para determinar el promedio de los capturados \r");
    Console.WriteLine("------------------------------------------------------------------------\n");

    Console.WriteLine("Tamaño del arreglo \r");
    int longitud = Convert.ToInt32(Console.ReadLine());

    //Declaración de un variable de tipo arreglo con 5 posiciones
    int[] numeros = new int[longitud];

    //Con un for estoy leyendo cada posición para llenar el arreglo con datos.
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine("Escribe el numero de la posición : [" + i + "]");
        numeros[i] = Convert.ToInt32(Console.ReadLine());
    }

    //Declarar una variables para obtener la sumatoria de los elementos del arreglo.
    int suma = 0;

    //Variable que me ayudará a recorrer todos los elementos del arreglo.
    int j = 0;

    do
    {
        suma = suma + numeros[j];
        j++;
    } while (j < numeros.Length);


    //Variable que es el resultado
    double resultado = suma / numeros.Length;
    
    Console.WriteLine("El promedio de los numeros registrados es:" + resultado);
    Console.Write("Fin del PRograma...");

    Console.ReadKey();



// // Declare variables and then initialize to zero.
//     int num1 = 0; int num2 = 0;

//     // Display title as the C# console calculator app.
//     Console.WriteLine("Console Calculator in C#\r");
//     Console.WriteLine("------------------------\n");

//     // Ask the user to type the first number.
//     Console.WriteLine("Type a number, and then press Enter");
//     num1 = Convert.ToInt32(Console.ReadLine());

//     // Ask the user to type the second number.
//     Console.WriteLine("Type another number, and then press Enter");
//     num2 = Convert.ToInt32(Console.ReadLine());

//     // Ask the user to choose an option.
//     Console.WriteLine("Choose an option from the following list:");
//     Console.WriteLine("\ta - Add");
//     Console.WriteLine("\ts - Subtract");
//     Console.WriteLine("\tm - Multiply");
//     Console.WriteLine("\td - Divide");
//     Console.Write("Your option? ");

//     // Use a switch statement to do the math.
//     switch (Console.ReadLine())
//     {
//         case "a":
//             Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
//             break;
//         case "s":
//             Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
//             break;
//         case "m":
//             Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
//             break;
//         case "d":
//             Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
//             break;
//     }
    // Wait for the user to respond before closing.
