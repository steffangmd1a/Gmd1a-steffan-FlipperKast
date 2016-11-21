using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
    //deze float bepaalt de kracht van de bal als hij weg geschoten word.
    public float powerUp;
    // deze float bepaalt hoe hoog powerupmax maximaal kan worden
    public float powerUpMax = 1.5f;
    // deze bool bepaalt of de spacebar knop in word gedrukt of niet
    public bool pressed = false;
    // deze int is een multiplier voor de kracht van de bal.
    public int maxForce = 1000;
    // deze vector 3 bepaalde de richting waar de bal naar word geschoten.
    public Vector3 force = new Vector3(-1, 0, 0);
    // hiermee vind het script de rigigbody van het script.
    public Rigidbody ball;
    // hiermee checkt het script of de bal de luacher (mentos rol) aanraakt.
    public bool aanraking = false;

    // deze void word elke frame opgeroepen
    void Update()
    {
        // deze if checkt of je de spacebar in hebt gedrukt
        if(Input.GetButtonDown("Jump"))
            {
            // hier word powerup gereset.
            powerUp = 0;
            // hier word aa gegeven de de knop is ingedrukt.
            pressed = true;

            }

        // hier word gecheckt of de spacebar knop word losgelaten en of de bal de laucher (mentos rol) aanraakt.
        if(Input.GetButtonUp("Jump") && aanraking == true)
        {
            // hier word pressed weer uitgezet omdat je de spacebar niet meer indrukt.
            pressed = false;
            // hiermee word de ball afgeschoten.
            ball.AddForce(force * powerUp * maxForce);

        }
        // hier word gecheckt of de spacebar inword gedrukt en of de power nog niet zijn max heeft berijkt.
        if(pressed == true && powerUp < powerUpMax)
        {
            
            // hier word de powerup verhoogt
            powerUp += Time.deltaTime;

        }

    }

    // deze void word opgeroepen als de ball de mentos rol aanraakt
    void OnTriggerExit(Collider Player)
    {

        // hier word de aanrakings bool aan gezet.
        aanraking = false;

    }

    // deze void word opgeroepen als de bal de launcher (mentos rol) aanraakt.
    void OnTriggerEnter(Collider Player)
    {

        // hier word de aanrakings bool uit gezet.
        aanraking = true;

    }

}