using UnityEngine;
using System.Collections;

public class FlipperClassRight : MonoBehaviour {

    // deze script is hetzelfde als FlipperClassLeft het enige verschil is dat de flipper de andere kant op draait.

    public bool activateFlipper;
    public bool deActivateFlipper;
    public float activateTimer = 0f;
    public float deActivateTimer = 0f;
    public GameObject flipperPivot;
    public static bool ismovingright = false;
    public Quaternion originalRotation;
    public Vector3 direction;
    public Rigidbody ball;
    public float force = -60;

    void Start()
    {
        originalRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetButtonDown("Right"))
        {
            activateFlipper = true;
            ismovingright = true;
        }

        if (activateTimer > 0.06f)
        {
            activateFlipper = false;
            activateTimer = 0f;

        }

        if (activateFlipper == true)
        {
            transform.RotateAround(transform.position, flipperPivot.transform.forward, -800 * Time.deltaTime);
            activateTimer = activateTimer + Time.deltaTime;
        }

        if (Input.GetButtonUp("Right"))
        {
            deActivateFlipper = true;
            ismovingright = false;
        }

        if (deActivateTimer > 0.06f)
        {
            deActivateFlipper = false;
            deActivateTimer = 0f;

        }

        if (deActivateFlipper == true)
        {
            transform.rotation = originalRotation;
            deActivateTimer = deActivateTimer + Time.deltaTime;
        }
    }
}