using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oncollision : MonoBehaviour
{
    public AudioSource audiosrc;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        audiosrc.Play();
    }
   
}
