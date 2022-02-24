using UnityEngine;

public class PropellorControllerX : MonoBehaviour
{
    private float speed = 1000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move the plane forward at a constant rate
        transform.Rotate(Vector3.forward * Time.deltaTime * speed);
    }
}
