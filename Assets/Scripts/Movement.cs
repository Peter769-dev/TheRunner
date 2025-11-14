using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{

    public float playerSpeed = 2f;
    public float horizontalSpeed = 3f;
    public float leftLimit = 5.5f;


    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * playerSpeed, Space.World);
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.left * Time.deltaTime * horizontalSpeed * -1);
        }
    }
}
