using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    //hier word de cordinate van het begin punt van de ball bepaald
    public Vector3 respawn = new Vector3(5.81f, -10.02f, 10.4f);

    // deze void word geactiveerd als de bal de collider aanraakt.
    public void OnTriggerEnter(Collider Respawn)
    {

        // hier word de bal terug naar hte beginpunt gestuurd.
        transform.position = respawn;

    }


}
