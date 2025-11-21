using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    private InputManager inputManager;
    private Vector3 targetPosition;
    private bool isMoving;

    public float lanesDistance = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inputManager = GetComponent<InputManager>();
        targetPosition = transform.position;
        isMoving = false;
    }
    private void SelectTargetPosition()
    {
        if (isMoving) { return; }
        float horizontalMovement = inputManager.horizontalMovement.ReadValue<float>();
        float x = transform.position.x;
        if (horizontalMovement == 1 && x <= 0)
        {
            targetPosition = transform.position + Vector3.right * lanesDistance;
            isMoving = true;
        }
        else if (horizontalMovement == -1 && x >= 0)
        {
            targetPosition = transform.position + Vector3.left * lanesDistance;

            isMoving = true;
        }
    }
    private void MoveToTargetPosition()
    {
        if (!isMoving) { return; } 
        
        transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);
        float distance = (targetPosition - transform.position).magnitude;
        
        if (distance < 0.001f)
        {
            transform.position = targetPosition;
            isMoving = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        SelectTargetPosition();
        MoveToTargetPosition();
    }
}
