using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);
        int moveSpeed = 10;

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y += 1 * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y -= 1 * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x -= 1 * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x += 1 * moveSpeed;
        }
        inputVector = inputVector.normalized;
        transform.position += new Vector3(inputVector.x, inputVector.y, 0) * Time.deltaTime * 5;
        Debug.Log(inputVector);
    }
}
