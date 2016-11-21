using UnityEngine;
using System.Collections;

public class FlipperBounce : MonoBehaviour {

    // deze vector3 word gebruitk om de richting van de bal mee te bekijken.
    public Vector3 direction;
    // hiermee word het script met de rigidbody van de bal verbonde zodat de bal kan stuiteren.
    public Rigidbody ball;
    // deze float bepaalt de kracht van de bounce van de flipper.
    public float force = -60;


    // deze void word geactiveerd als de bal tegen de flipper aan komt.
    public void OnCollisionEnter(Collision collision)
    {
        // deze if zorgt er voor dat de bal alleen weg word geschoten als je een van de twee flipper knoppen in drukt.
        if (Input.GetButton("Left") || Input.GetButton("Right"))
        {
            // hier word de richting van de bal bapaald
            direction = collision.contacts[0].point;

            // hier word de bal weg geschoten door de flipper.
            ball.AddForce(direction * force);
        }

    }
}