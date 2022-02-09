using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
   
    public float maxTime;
    public float minSwipeDist;

    float startTime;
    float endTime;
    
    Vector3 startPos;
    Vector3 endPos;

    float swipeDistance;
    float swipeTime;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.touchCount > 0)
        {
            
            Touch touch = Input.GetTouch(0);
        
            if(touch.phase==TouchPhase.Began)
            {
                startTime = Time.time;
                startPos = touch.position;
            }
            else if(touch.phase == TouchPhase.Ended)
            {

                endTime = Time.time;
                endPos = touch.position;
                swipeDistance = (endPos - startPos).magnitude;
                swipeTime = endTime - startTime;

                if(swipeTime<maxTime && swipeDistance>minSwipeDist)
                {
                    Swipe();
                }

            }
        }

            // Debug.Log("Touch Count :"+Input.touchCount);
            //Debug.log("Get Particular Touch by index :" + Input.GetTouch(0).position;

            //if (Input.touchCount > 0)
            //{
            //    if (Input.GetTouch(0).phase == TouchPhase.Began)
            //        Debug.Log("Touch phase begun");
            //    if (Input.GetTouch(0).phase == TouchPhase.Moved)
            //        Debug.Log("Touch phase Moved");
            //    if (Input.GetTouch(0).phase == TouchPhase.Stationary)
            //        Debug.Log("Touch phase Stationary");
            //    if (Input.GetTouch(0).phase == TouchPhase.Ended)
            //        Debug.Log("Touch phase Ended");
            //    if (Input.GetTouch(0).phase == TouchPhase.Canceled)
            //        Debug.Log("Touch phase Canceled");

            //}
    }



    public void Swipe()
    {
        Vector2 distance = endPos - startPos;

        if (Mathf.Abs(distance.x) > Mathf.Abs(distance.y))
        {
            if (distance.x > 0)
            {
                
               Debug.Log("Right swipe");
               
            }

            if (distance.x < 0)
            {
                
                Debug.Log("Left swipe");
                

            }
        }
        else if (Mathf.Abs(distance.x) < Mathf.Abs(distance.y))
        {

            if (distance.y > 0)
            {
               
                Debug.Log("Up swipe");
            }

            if (distance.y < 0)
            {
                
                Debug.Log("Down swipe");
            }
        }
    }
}
