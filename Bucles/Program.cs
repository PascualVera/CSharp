using static System.Console;
/////Ejercicio 1

void multiply() {
    WriteLine("Introduce un numero");
    string input = ReadLine();
    int number = Convert.ToInt32(input);
    int i = 1;
    while (i <= 10)
    {
        WriteLine($"{number} x {i} = {number * i}");
        i++;
    }
}


/////Ejercicio 2

string Counter()
{
    WriteLine("Numeros a valorar:");
    string x = ReadLine();
    int[] numberArr = new int[x.Length];
    for(int i = 0; i < numberArr.Length; i++)
    {   
        numberArr[i] = Convert.ToInt32(x[i]);
    }
    int Positive = 0;
    int Negative = 0;
    int Zero = 0;

    int j = 0;
    do
    {
        if (numberArr[j] < 0)
        {
            Negative++;
        }
        else if (numberArr[j]>0) 
        {
            Positive++; 
        }
        else { Zero++; }
        j++;
    }
    while(j < numberArr.Length);

    return $"Postive:{Positive}\n" +
        $"Negative:{Negative}\n" +
        $"Zero: {Zero}";
}

//Ejercicio 3
string Square(int x, int y, bool fill)
{
    string square = new string('*', x) + "\n";
    for(int i = 0; i < y-2; i++)
    {
        if (fill)
        {
            square = square + new string('*', x) + "\n";
        }
        else
        {
            square = square + "*" + new string(' ', x-2) + "*" + "\n";
        }
    }
    square = square + new string('*', x);
    return square;
}

//Llamadas a las funciones
multiply();
WriteLine(Counter());
WriteLine(Square(5, 5, false));