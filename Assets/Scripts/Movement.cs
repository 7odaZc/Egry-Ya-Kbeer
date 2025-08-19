using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5f;
    public float HorizontalSpeed = 5f;
    public float jumpForce = 400f;
    [SerializeField] Rigidbody rb;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float jumpHeight = 2f;
    [SerializeField] float gravity = -9.81f;
    [SerializeField] float maxJumpHeight = 2.46f; // Maximum height for the player
    [SerializeField] Animator animator; // Use Animator instead of Animation




    // Update is called once per frame
    void Update()

    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        Keyboard keyboard = Keyboard.current;

        if (keyboard.aKey.isPressed || keyboard.leftArrowKey.isPressed)
        {

            transform.Translate(Vector3.left * Time.deltaTime * HorizontalSpeed);

        }
        if (keyboard.dKey.isPressed || keyboard.rightArrowKey.isPressed)
        {

            transform.Translate(Vector3.right * Time.deltaTime * HorizontalSpeed);

        }
        if (Input.GetKeyDown(KeyCode.Space) || keyboard.upArrowKey.isPressed || keyboard.spaceKey.isPressed)
        {
            jump();
        }
    }
    void jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, height / 2 + 0.1f);
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            if (animator != null)
                animator.Play("Cat_Jump"); // Play the jump animation
        }
        Debug.Log($"isGrounded: {isGrounded}, rb assigned: {rb != null}, jumpForce: {jumpForce}");
    }
}
