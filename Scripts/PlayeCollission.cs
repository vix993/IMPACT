
using UnityEngine;

public class PlayeCollission : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo){

        if(collisionInfo.collider.tag == "ObstacleTag")
        {
            movement.enabled = false; 
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
