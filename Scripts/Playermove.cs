using UnityEngine;

public class Playermove : MonoBehaviour
{
    public Rigidbody rb;
    public float speed=1000f;
    public float leftrigth = 100f;
    void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(leftrigth * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-leftrigth * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (rb.position.y <= -1f)
        {
            FindObjectOfType<ManageGame>().EndGame();
        }
    }
}
