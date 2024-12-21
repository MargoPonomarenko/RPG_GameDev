using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;
    public Animator myAnim;
    public static PlayerController instance;
    public string areaTransitionName;

    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        

        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        // Get input data
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        // Update linear velocity
        theRB.linearVelocity = new Vector2(horizontalInput, verticalInput) * moveSpeed;


        // Update animation
        UpdateAnimation();

        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnim.SetFloat("lastMoveX", horizontalInput);
            myAnim.SetFloat("lastMoveY", verticalInput);
        }
    }

    // Method to update animation
    void UpdateAnimation()
    {
        myAnim.SetFloat("moveX", theRB.linearVelocity.x);
        myAnim.SetFloat("moveY", theRB.linearVelocity.y);
    }
}
