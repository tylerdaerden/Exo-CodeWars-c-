#region 1.2

//EXO 1.2 CODE WARS KATA C # Fundamentals
// Soluces par meilleurs pratiques

using System.Text;

string repeatStr(int n, string s)
{
    return String.Concat(Enumerable.Repeat(s, n));
}

Console.WriteLine(repeatStr(3, "yo"));
Console.WriteLine("__________________________");
Console.WriteLine();
Console.WriteLine();

string repeatStr2(int n, string s)
{
    var res = "";
    for (int i = 0; i < n; i++)
    {
        res += s;
    }
    return res;

}

Console.WriteLine(repeatStr2(5, "cho"));
Console.WriteLine("__________________________");
Console.WriteLine();
Console.WriteLine();

string repeatStr3 (int n , string s)
{
    return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
}

Console.WriteLine(repeatStr3(10, "pi"));
Console.WriteLine("__________________________");
Console.WriteLine();
Console.WriteLine();



#endregion



#region 1.3

//EXO 1.3 CODE WARS KATA C # Fundamentals
// Exo avec ma soluce 👇👇👇

//Create a function with two arguments that will return an array of the first n multiples of x.
//Assume both the given number and the number of times to count will be positive numbers greater than 0.
//Return the results as an array or list ( depending on language ).
//Examples
//countBy(1, 10)  should return  {1,2,3,4,5,6,7,8,9,10}
//countBy(2, 5)  should return {2,4,6,8,10}

int[] premiersmultiplesde (int a , int b )
{
    int[] tablede = new int[b];
    for (int i = 1;i <= b;i++)
    {
        tablede[i-1] = (a)*i;
    }
    //ici je fais le choix de l'affichage dans la méthode
    Console.WriteLine(string.Join(",", tablede));
    return tablede;
    
}

//si méthode d'affichage pas dans la fonction
//int[] tab1to10 = premiersmultiplesde(1, 10);
//Console.WriteLine(string.Join("," , tab1to10));
premiersmultiplesde(1, 10);

// Soluces par meilleurs pratiques , affichage pas implémenté

 int[] CountBy(int x, int n)
{
    return Enumerable.Range(1, n).Select(i => i * x).ToArray();
}

CountBy(1, 5);
Console.WriteLine("__________________________");
Console.WriteLine();
Console.WriteLine();

int[] CountBy2(int x, int n)
{
    int[] z = new int[n];
    for (int k = 0; k < n; k++)
    {
        z[k] = (k + 1) * x;
    }
    return z;
}
CountBy2(2, 10);

Console.WriteLine("__________________________");
Console.WriteLine();
Console.WriteLine();


Console.ReadLine();























#endregion