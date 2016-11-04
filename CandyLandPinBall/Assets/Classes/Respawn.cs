using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    public Vector3 respawn = new Vector3(5.81f, -10.02f, 10.4f);

    public void OnTriggerEnter(Collider Respawn)
    {

        transform.position = respawn;

    }


}
