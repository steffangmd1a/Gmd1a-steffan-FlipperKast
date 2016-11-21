using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

    // Deze vector3 bepaalt de richting die de bal opgaat.
    public Vector3 direction;
    // deze rigedbody is verbonden met de rigedbody van de bal zodat het script de bal kan laten stuiteren.
    public Rigidbody ball;
    // de force bepaalt de kracht van de bounce.
    public float force = -60;
    // gameobject score gebruik ik om te verbinden met de script van het object die ik hiermee verbind.
    public GameObject Score;
    // deze int geeft aan hoeveel score je krijg als je bal tegen de bumper komt.
    public int score = 10;


    // deze void word opgeroepen als de bal tegen de bumper stuitert
    public void OnCollisionEnter(Collision collision)
    {
            
        // hier word de vector3 direction aangepast zodat de bal de goede kant op stuiterd.
        direction = collision.contacts[0].point;

        // hier word de bal de richting op geschoten.
        ball.AddForce(direction * force);

        //hier verbind ik via het gameobject de scripts van de bumper en de score aan elkaar.
        GUIScore gc = (GUIScore)Score.GetComponent("GUIScore");
        // Hiermee pas ik de score aan.
        gc.PlusScore(+10);
    }
}