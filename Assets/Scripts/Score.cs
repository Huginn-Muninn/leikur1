using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Transform player;//spilari
    public Text scoreText;//texti
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");//bætir við score þegar spilari færir sig áfram
    }
}
