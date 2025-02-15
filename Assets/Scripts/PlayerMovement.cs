using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    public float forwardForce = 1000f;
    public float rightForce = 500f;
    public float leftForce = 500f;
    public float upForce = 1500f;

    void FixedUpdate()
    {
        //добавляет толкание вперед
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(rightForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-leftForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindFirstObjectByType<GameManager>().EndGame();
            // FindObjectOfType<GameManager>().EndGame();
            //то более быстрый запрос
            // GetComponent<GameManager>().EndGame();
        }
    }
}
