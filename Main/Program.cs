using DiaSemana;
string ObtenerDia = DiaSemana.Semana.(ObtenerDia(int numero));
Console.WriteLine("Por favor escriba un numero del 1 al 7");
int numero = Convert.ToInt32(Console.ReadLine());
string dia = ObtenerDia(numero);

if (dia != null)
    {
        Console.WriteLine($"El día correspondiente al número {numero} es: {dia}");
    }
Console.WriteLine("Numero invalido, debe estar entre 1 y 7");
    

