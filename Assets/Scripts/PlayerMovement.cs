using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 10000f;//hversu hratt þú ferð áframm
    public float sidewaysForce = 500f;//Hversu hratt þú ferð til hliðar

    // FixedUpdate er betra fyrir physics systemið og loopar við hvern ramma
    void FixedUpdate()
    {
        //Bæti forward force
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if(Input.GetKey("d"))// Þegar þú ýtir á takkan d
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);//ferðu til hægri
        }
        if (Input.GetKey("a"))// Þegar þú ýtir á takkan a
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);//ferðu til vinstri
        }

        if (rb.position.y < -1f)//ef þú ferð undir kortið
        {
            FindObjectOfType<GameManager>().EndGame();//endar leikinn
        }
    }
}
