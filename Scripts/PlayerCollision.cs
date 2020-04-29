using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Playermove movement;
    public ManageGame controlgame;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<ManageGame>().EndGame();
        }
       
    }
}
