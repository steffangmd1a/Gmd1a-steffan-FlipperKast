using UnityEngine;
using System.Collections;

public class ColliderGameOver : MonoBehaviour {

    // hiermee verbind ik de collider en de camera aan elkaar zodat ik een leven van de totalen levens halen.
    public GameObject master;

    // deze void word opgeroepen als de bal tegen de collider aan komt.
    void OnTriggerEnter(Collider Player)
    {
        // hiermee worden de GUIScore script en de collidergameover script aan elkaar verbonden
        GUIScore gc = (GUIScore)master.GetComponent("GUIScore");
        // hiermee haal ik 1 punt van de levens van de speler er af.
        gc.Damage(-1);

    }

}