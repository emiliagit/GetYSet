using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    public CanvasManager canvasManager;

    private Animator anim;

   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

   
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.TryGetComponent(out Cubo cubo)) return;

            if (collision.gameObject.name == "Cubito")
            {
                collision.gameObject.name = "Circulo";

                Debug.Log("¡Hola, Circulo!");

                anim.Play("NombreNuevo");
            }
            else
            {
                Debug.Log("¡Hola, no eres Cubito!");

                anim.Play("SaludoNuevo");
            }
        
    }

    
    void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Cubo"))
            canvasManager.HideMessage();
    }
}
