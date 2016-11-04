using UnityEngine;
using System.Collections;

public class ColliderGameOver : MonoBehaviour {

    public GameObject master;

    void OnTriggerEnter(Collider Player)
    {

        GUIScore gc = (GUIScore)master.GetComponent("GUIScore");
        gc.Damage(-1);

    }

}