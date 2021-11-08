using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collission : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Color32 withPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 withoutPackageColor = new Color32(1, 1, 1, 1);

    bool ifIHavePackage = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            if (ifIHavePackage == false) { 
                ifIHavePackage=true;
                Destroy(collision.gameObject, 0.5f);
            }
        }

        if (collision.tag == "Player")
        {
            ifIHavePackage = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
