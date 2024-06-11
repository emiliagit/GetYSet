using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    void Start()
    {
       
        Tienda espadaDeHierro = new Tienda("Espada de Hierro", 1.5f);
        Tienda escudoDeMadera = new Tienda("Escudo de Madera", 0.5f);
        Tienda pistolaPewPew = new Tienda("Pistola:Pew-Pew", 9999f);

       
        Debug.Log($"Producto: {espadaDeHierro.Nombre}, Precio: {espadaDeHierro.Precio} unidades monetarias");
        Debug.Log($"Producto: {escudoDeMadera.Nombre}, Precio: {escudoDeMadera.Precio} unidades monetarias");
        Debug.Log($"Producto: {pistolaPewPew.Nombre}, Precio: {pistolaPewPew.Precio} unidades monetarias");
    }
}
