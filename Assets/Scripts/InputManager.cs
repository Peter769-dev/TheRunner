using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerControl playerControl;

    public InputAction horizontalMovement;

    private void Awake()
    {
        playerControl = new PlayerControl();

        horizontalMovement = playerControl.InGame.HorizontalMovement;
        horizontalMovement.Enable();  
    }

    private void OnDisable()
    {
        horizontalMovement.Disable();
    }
}
