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
    private Vector3 bottomLeftLimit;
    private Vector3 topRightLimit;
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

        if (horizontalInput == 1 || horizontalInput == -1 || verticalInput == 1 || verticalInput == -1)
        {
            myAnim.SetFloat("lastMoveX", horizontalInput);
            myAnim.SetFloat("lastMoveY", verticalInput);
        }

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z);
    }

    public void SetBounds(Vector3 botLeft, Vector3 topRight)
    {
        bottomLeftLimit = botLeft + new Vector3(0.5f, 1f, 0f);
        topRightLimit = topRight + new Vector3(-0.5f, -1f, 0f);
    }

    // Method to update animation
    void UpdateAnimation()
    {
        myAnim.SetFloat("moveX", theRB.linearVelocity.x);
        myAnim.SetFloat("moveY", theRB.linearVelocity.y);
    }
}
