﻿// valida  numero entero si es ingresdo en  el input debe ser mayor de 3 cifras con tryparse
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);
int numericValue = 0;
bool validNumber = false;


validNumber = int.TryParse(readResult, out numericValue);
Console.WriteLine(numericValue);
Console.WriteLine(validNumber);