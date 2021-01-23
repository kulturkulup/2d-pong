using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tophareketleri : MonoBehaviour
{
    public Rigidbody2D top;
    public float xHizi, yHizi;


    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Player1")
        {
            top.velocity = new Vector2(-xHizi, Random.Range(-3f,3f));

    }
    else if (temas.gameObject.tag == "Player2")
        {
            top.velocity = new Vector2(xHizi, Random.Range(-3f, 3f));
        }

        if(temas.gameObject.tag == "UstDuvar") {
            top.velocity = new Vector2(top.velocity.x, -yHizi); 
        } else if (temas.gameObject.tag == "AltDuvar")
        {
            top.velocity = new Vector2(top.velocity.x, yHizi);
        }
    }
}

