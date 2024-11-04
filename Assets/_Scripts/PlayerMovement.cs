using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;
    public LayerMask interactableLayer ;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    public void HandleUpdate()
    {
        rb.velocity = moveInput * moveSpeed;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Interact();
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        animator.SetBool("isWalking", true);

        if (context.canceled)
        {
            animator.SetBool("isWalking", false);
            animator.SetFloat("LastInputX", moveInput.x);
            animator.SetFloat("LastInputY", moveInput.y);

        }

        moveInput = context.ReadValue<Vector2>();
        animator.SetFloat("InputX", moveInput.x);
        animator.SetFloat("InputY", moveInput.y);

    }

    // Checks whether an object is infront of the players current pos is interactable, and executes
    void Interact()
    {
        var facingDir = new Vector3(animator.GetFloat("LastInputX"), animator.GetFloat("LastInputY"));
        var interactPos = transform.position + facingDir;

        /* For testing interact function
         * Debug.DrawLine(transform.position, interactPos, Color.red, 1f); 
         */

        var collider = Physics2D.OverlapCircle(interactPos, 0.2f, interactableLayer);

        if (collider != null)
        {
            collider.GetComponent<Interactable>()?.Interact();
        }
    }
}
