using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 35;
    private float rotationSpeed = 50;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane depending on the user inputs 
        transform.Rotate(Vector3.left * Time.deltaTime * verticalInput * rotationSpeed);
        transform.Rotate(Vector3.back * Time.deltaTime * horizontalInput * rotationSpeed);
    }
}
