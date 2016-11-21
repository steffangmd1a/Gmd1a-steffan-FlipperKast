using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

    // deze void word opgeroept als je de Try Again button indrukt.
    public void Restarting()
    {

        // Dit zorgt er voor dat het spel de scene met de flipperkast weer laad.
        Application.LoadLevel("FlipperKast");

    }

    // Deze void word opgeroepen als je de quit button indrukt.
    public void Stop()
    {

        // Dit zorgt er voor dat het spel afsluit.
        Application.Quit();

    }

}
