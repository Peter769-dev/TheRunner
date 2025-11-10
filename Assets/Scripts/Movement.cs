using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("A"))
        {
            transform.position = new Vector3(-10, 0, 0);
        }
        if (Input.GetButtonDown("D"))
        {
            transform.position = new Vector3(10, 0, 0);
        }
    }
}
