using UnityEngine;

/// <summary>
/// 
/// </summary>
public class Ball : MonoBehaviour
{
    public float Force;
    public Rigidbody rb;

    private Vector2 vel;

    private void Start()
    {
        rb.AddForce(new Vector3(1, 1, 0) * Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.attachedRigidbody != null)
        {
            vel.x = rb.velocity.x;
            vel.y = rb.velocity.y;
            Debug.Log(rb.velocity);
            rb.velocity = -vel;
            Debug.Log(rb.velocity);
            //rb.AddForce(-vel);
        }
    }
}
