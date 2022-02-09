using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            // Increase score
            GameManager.instance.IncreaseScore();
            Destroy(gameObject);
        }

        if(collision.gameObject.tag=="Boundary")
        {
            GameManager.instance.DecreaseLives();
            Destroy(gameObject);
                
        }

    }

    
}
