using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;//Leikurinn er í gangi á meðan þetta er false

    public float restartDelay = 0.2f;// Hversu langur tími mun líða frá því að þú tapaðir þangað til að leikurinn endurræsir sig

    public GameObject completeLevelUI;

    public GameObject failedLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);//Setur  texta yfir skjáinn þegar þú vinnur
    }

    public void FailedLevel()
    {
        failedLevelUI.SetActive(true);// sama og fyrir ofan nema þegar þú tapar
    }

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;//Leikinum hefur verið kláraður
            Debug.Log("GAME OVER");//Skrifar GAME OVER í console
            FailedLevel();
            Invoke("Restart", restartDelay);//Endurræsir leikinn
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//endurræsir sceneið
    }
}
