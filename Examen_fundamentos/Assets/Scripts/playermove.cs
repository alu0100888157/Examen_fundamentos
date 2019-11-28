using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public int puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            Vector2 position = this.transform.position;
            position.x = position.x - 1 ;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.K))
        {
            Vector2 position = this.transform.position;
            //Vector3 position = this.transform.position;
            position.x = 1 + position.x;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.I))
        {
            Vector2 position = this.transform.position;
            //Vector3 position = this.transform.position;
            position.y = 1 + position.y;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.M))
        {
            Vector2 position = this.transform.position;
            //Vector3 position = this.transform.position;
            position.y = position.y - 1;
            this.transform.position = position;
        }
    }
}
