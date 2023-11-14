using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 20f;

    private Rigidbody2D rigidBody2D;
    Vector2 momentumVector2;
    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += moveSpeed;
        }
        inputVector = inputVector.normalized;
        momentumVector2 = inputVector * moveSpeed;
        transform.position += new Vector3(momentumVector2.x, momentumVector2.y, 0) * Time.deltaTime;
        Debug.Log("input vec" + inputVector);
        Debug.Log(momentumVector2);
    }
}
