using UnityEngine;

public class EnsTrigger : MonoBehaviour
{

    public GameManager gameManager;//gerir þetta opinbert

    void OnTriggerEnter()//Þegar þú hittir trigger
    {
        gameManager.CompleteLevel();//Notar skriptuna Completelevel
    }
}
