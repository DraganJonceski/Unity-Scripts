
using UnityEngine;

public class flap : MonoBehaviour
{
    public float velocity;
    public Rigidbody2D birdRigidBody;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            birdRigidBody.velocity = Vector2.up * velocity;
        }
    }
}
