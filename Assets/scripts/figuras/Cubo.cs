using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
   
    public float velocidad;

    
    private string _nombre;

   
    public string Nombre
    {
        get { return _nombre; }
        set
        {
            
            if (value != null)
            {
                _nombre = value;
            }
            else
            {
               
                Debug.LogWarning("Nombre ingresado null");
            }
        }
    }

   
    private void FixedUpdate()
    {
       
        Movimiento();
    }

    
    private void Movimiento()
    {
       
        float speed_x = Input.GetAxis("Horizontal");

       
        transform.Translate(Vector3.right * speed_x * velocidad * Time.fixedDeltaTime);
    }
}
