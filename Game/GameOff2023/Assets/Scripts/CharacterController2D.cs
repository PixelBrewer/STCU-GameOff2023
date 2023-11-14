using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    private const float MOVE_SPEED = 6f;
    private const float DASH_AMOUNT = 3f;
    private Rigidbody2D rigidBody2D;
    private Vector3 moveDirection;
    private bool isDashButtonDown;

    private void Awake()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveX = 0f;
        float moveY = 0f;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
        }

        moveDirection = new Vector3(moveX, moveY).normalized;

        // Maybe we can use this dash code somehow.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isDashButtonDown = true;
        }
    }
    private void FixedUpdate()
    {
        rigidBody2D.velocity = moveDirection * MOVE_SPEED;

        if (isDashButtonDown)
        {
            rigidBody2D.MovePosition(transform.position + moveDirection * DASH_AMOUNT);
            isDashButtonDown = false;
        }
    }

    private void printLastPressed()
    {
        Debug.Log("Last pressed: " + Input.inputString);
    }
}
