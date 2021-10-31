using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 160f;
    [SerializeField] float moveSpeed = 25f;
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
}
