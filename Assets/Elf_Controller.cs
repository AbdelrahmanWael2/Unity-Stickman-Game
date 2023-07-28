using System.Collections;
using UnityEngine;

public class Elf_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator animator;
    public float speed = 4f; // Public variable to adjust speed in the Inspector
    public float walkTime = 2f;
    public bool isWalking = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator.SetBool("isWalking", isWalking);
        
        // Set the velocity to move the rigidbody in the forward direction (assuming you want it to move forward)
        rb.velocity = -transform.right * speed;

        Debug.Log("Start method called.");
        Debug.Log("Rigidbody velocity: " + rb.velocity);
    }

    // Update is not needed for this movement
    public void Update()
    {
        
        walkTime = walkTime - Time.deltaTime;
        if(walkTime > 0)
        {
            rb.velocity = -transform.right * speed;
        }
        else
        {
            isWalking= false;
            animator.SetBool("isWalking", isWalking) ;
        }
        
        
    }
}
