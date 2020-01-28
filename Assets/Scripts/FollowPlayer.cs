using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;//Leifir þér að breyta þessu í Unity
    public Vector3 offset;//Leifir þér að breyta í Unity 

   
    void Update()
    {
        transform.position = Player.position + offset;//Færir spilarann áfram
    }
}
