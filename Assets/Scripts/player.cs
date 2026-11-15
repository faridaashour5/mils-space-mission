
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    public Rigidbody2D rb;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            rb.linearVelocity = Vector2.up * 5f;
        }
    }

   void OnCollisionEnter2D(Collision2D other){
        
        if (other.gameObject.CompareTag("Rock"))
        { 
            SceneManager.LoadScene("Game");
        }
    }       
}