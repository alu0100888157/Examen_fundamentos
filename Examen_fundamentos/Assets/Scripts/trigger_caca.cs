using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_caca : MonoBehaviour
{
    public Animator animacion;
    public Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Vector3.Distance(this.transform.position, rb.transform.position) < 1)
        {
            Debug.Log("TRIGGER caca dentro");
            animacion.SetBool("caca", true);
            animacion.SetBool("hueso", false);
        }
        else
        {
            Debug.Log("TRIGGER caca dentro");
            animacion.SetBool("caca", false);
        }
         */
        
    }
    //void OnCollisionEnter2D(Collider2D col)
    //{
        
        //Debug.Log("TRIGGER");
        //animacion.SetBool("caca", true);
        //animacion.SetBool("hueso", false);
    //}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "jugador")
        {
            animacion.SetBool("caca", true);
            animacion.SetBool("hueso", false);
        }
    }
}
