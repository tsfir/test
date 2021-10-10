using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;

    [SerializeField] Color32 hascolor = new Color32(0, 0, 0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerInputAmount = -1 * Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float speedInputAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, steerInputAmount);
        transform.Translate(0, speedInputAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package")
        {
            Debug.Log("Package");
            Destroy(collision.gameObject, 0.5f);
            GetComponent<SpriteRenderer>().color = hascolor;
        }

        
    }
}
