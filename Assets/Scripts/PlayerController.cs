using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float x;
    public float speed;
    private float max = 6f;
    bool left, right;
    
     private void Start()
    {
       
    }

    public void LeftDown()
    {
        left=true;       
    }

    public void RightDown()
    {
        right = true;
    }

    public void OnUp()
    {
        left = right = false;
    }


    // Update is called once per frame
    void Update()
    {
       if(left)
        {
            x = -1;
        }
        else if(right)
        {
            x = 1;
        }
        else
        {
            x = Input.GetAxis("Horizontal");
        }

       Move(x);
      
    }

   
    void Move(float x)
    {
        
        x=x * speed * Time.deltaTime;
        
        transform.position += new Vector3(x, 0, 0);
        x = Mathf.Clamp(transform.position.x, -max, max);
        transform.position = new Vector3(x, transform.position.y, transform.position.z);


    }

    
}
