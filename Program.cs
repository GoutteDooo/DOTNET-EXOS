// See https://aka.ms/new-console-template for more information

using DOTNET_DAY2.Exercices.Alex;
using DOTNET_DAY2.Exercices.Complexe;
using System;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace DOTNET_DAY2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculatrice calculatrice = new Calculatrice();
            calculatrice.DisplayCalc();
        }
    }
}