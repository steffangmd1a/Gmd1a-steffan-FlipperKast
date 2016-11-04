using UnityEngine;
using System.Collections;

public class LeftFlipper : MonoBehaviour {

    public bool activateFlipper;
    public float timer = 0;
    public GameObject flipperPivot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Left"))
        {

            activateFlipper = true;

        }

        if(timer > 0.04f)
        {

            activateFlipper = false;


        }

        if(activateFlipper)
        {

            transform.RotateAround(transform.position, flipperPivot.transform.up, -800 * Time.deltaTime);
            timer = timer + Time.deltaTime;

        }
	
	}
}
