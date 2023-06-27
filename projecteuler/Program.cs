using System;
using System.Reflection;

public partial class Program
{
	public static void Main()
	{
        string number = "0023";

        Type tipo = typeof(Program);
        MethodInfo metodo = tipo.GetMethod("Exercise" + number);
        if (metodo != null)
        {
            object instancia = Activator.CreateInstance(tipo);
            metodo.Invoke(instancia, null);
        }
        else
        {
            Console.WriteLine("No se encontró el procedimiento especificado.");
        }
    
    }

}