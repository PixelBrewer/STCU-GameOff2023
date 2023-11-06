using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static PlayerMovement Instance { get; private set; }
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameInput gameInput;

    private bool isWalking;

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("There is more than one player movement instance.");
        }
        Instance = this;
    }

    private void Update()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {

        if (gameInput == null)
        {
            Debug.LogError("GameInput is null");
            return;
        }

        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);

        float moveDistance = moveSpeed * Time.deltaTime;
        transform.position += moveDirection * moveDistance;




        // Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        // Vector3 moveDirection = new Vector3(inputVector.x, 0f, inputVector.y);

        // float playerRadius = 0.7f;
        // float playerHeight = 2f;
        // float moveDistance = moveSpeed * Time.deltaTime;
        // bool canMove = !Physics.CapsuleCast(
        //     transform.position,
        //     transform.position + Vector3.up * playerHeight,
        //     playerRadius,
        //     moveDirection,
        //     moveDistance);

        // if (!canMove)
        // {
        //     Vector3 moveDirectionX = new Vector3(moveDirection.x, 0, 0).normalized;
        //     canMove = moveDirection.x != 0 && !Physics.CapsuleCast(
        //     transform.position,
        //     transform.position + Vector3.up * playerHeight,
        //     playerRadius,
        //     moveDirectionX,
        //     moveDistance);

        //     if (canMove)
        //     {
        //         moveDirection = moveDirectionX;
        //     }
        //     else
        //     {
        //         Vector3 moveDirectionZ = new Vector3(0, 0, moveDirection.z).normalized;
        //         canMove = !Physics.CapsuleCast(
        //         transform.position,
        //         transform.position + Vector3.up * playerHeight,
        //         playerRadius,
        //         moveDirectionZ,
        //         moveDistance);
        //         if (canMove)
        //         {
        //             moveDirection = moveDirectionZ;
        //         }
        //     }
        // }

        // if (canMove)
        // {
        //     transform.position += moveDirection * moveDistance;
        // }


        // isWalking = moveDirection != new Vector3(0, 0, 0);
        // float rotateSpeed = 12f;
        // transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);
    }
}
