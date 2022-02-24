using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame 
    // LateUpdate is called after Update (makes sure the camera is positioned after the player is)
    void LateUpdate()
    {
        // Offset the camera behind the player
        transform.position = player.transform.position + offset;
    }
}
