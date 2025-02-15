using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Barier"))
        {
            movement.enabled = false;
            // GetComponent<PlayerMovement>().enabled = false;
            FindAnyObjectByType<GameManager>().EndGame();
        }
        
    }
}
