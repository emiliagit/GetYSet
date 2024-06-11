using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
   
    public string Nombre { get; set; }
    public float Precio { get; set; }

   
    public Tienda(string nombre, float precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}

