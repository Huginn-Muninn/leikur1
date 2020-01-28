using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("Quit");//Skrifar quit í console
        Application.Quit();//Lokar forritinu
    }
}
