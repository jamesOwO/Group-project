using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float horizontalMovement;
    public float verticalMovement;
    public float speed = 0.1f;
    private Rigidbody rb;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        verticalMovement = Input.GetAxis("Vertical");

        Vector3 movementDirection = transform.forward * verticalMovement + transform.right * horizontalMovement;
        this.transform.position += movementDirection * speed;

        if (horizontalMovement > 0)
        {
            animator.SetInteger("HSpeed", 1);
        }
        else if (horizontalMovement < 0)
        {
            animator.SetInteger("HSpeed", -1);
        }

        else if (verticalMovement > 0)
        {
            animator.SetInteger("VSpeed", 1);
        }
        else if (verticalMovement < 0)
        {
            animator.SetInteger("VSpeed", -1);
        }

        else
        {
            animator.SetInteger("HSpeed", 0);
        
            animator.SetInteger("VSpeed", 0);
        }

    }
}
