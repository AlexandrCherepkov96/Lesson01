double CalculateFormula(int a, int b, int c, int d)
{
    int numerator = a * b;
    int denomenator = c + d;
    double result = numerator / denomenator;
    return result;
}
double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);