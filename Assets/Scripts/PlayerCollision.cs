using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)//kíkir hvort að þú sért að snerta eitthvað
    {
        if (collisionInfo.collider.tag == "Obstacle")//ef þú klessir á hindrun
        {
            movement.enabled = false;//stoppar þig frá því að hreyfa þig
            FindObjectOfType<GameManager>().EndGame();//kallar á Endgame
        }
    }

}