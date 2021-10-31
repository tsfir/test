using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Hayiii");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
