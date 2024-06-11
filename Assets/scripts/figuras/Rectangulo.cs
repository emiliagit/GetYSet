using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo : MonoBehaviour
{
    public CanvasManager canvasManager;
    private Animator anim; 

    void Start()
    {
      
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.TryGetComponent(out Cubo cubo))
        {
            
            Debug.Log("Hola " + collision.name);

            anim.Play("Saludo");
           
           
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Cubo")) 
        {
            canvasManager.HideMessage();
        }
    }
}
