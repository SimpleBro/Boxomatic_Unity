using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle!");
            Debug.Log("Motors shutting down!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
