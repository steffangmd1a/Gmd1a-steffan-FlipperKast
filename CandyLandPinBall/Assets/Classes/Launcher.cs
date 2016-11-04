using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{

    public float powerUp;
    public float powerUpMax = 1.5f;
    public bool pressed = false;
    public int maxForce = 1000;
    public Vector3 force = new Vector3(-1, 0, 0);
    public Rigidbody ball;
    public bool aanraking = false;

    void Update()
    {

        if(Input.GetButtonDown("Jump"))
            {

            powerUp = 0;
            pressed = true;

            }
        if(Input.GetButtonUp("Jump") && aanraking == true)
        {

            pressed = false;
            ball.AddForce(force * powerUp * maxForce);

        }

    }

}