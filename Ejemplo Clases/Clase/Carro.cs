using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Clases.Clase
{
    internal class Carro
    {
    }
}
public class Carro
{
    public string Marca { get; }
    public int Modelo { get; set; }
    public string Color { get; set; }
    public string owner { get; set; }

    private int Encendidio = 0;
    private int Velocidad_actual = 0;
    public int MAXIMAVELOCIDAD { get; set; }

    public Carro(string m,int model,string col)
    {
        Marca = m;
        Modelo = model;
        Color = col;
    }
    public int Acelerar()
    {
        if  (Encendidio==0)
            {
            return 0;
        }
        else
            Velocidad_actual += 10;
        return Velocidad_actual;    
    }
}



