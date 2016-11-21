using UnityEngine;
using System.Collections;

public class GUIScore : MonoBehaviour {

    // hier word de score mee onthouden
    public int huidigeScore;
    // hier worden de levens van de speler onthouden
    public int levens;
    // deze bool bepaalt of de speler zijn eerste leven nog heeft.
    public bool bool1 = true;
    // deze bool bepaalt of de speler zijn tweede leven nog heeft.
    public bool bool2 = true;
    // deze bool bepaalt of de speler zijn derde leven nog heeft.
    public bool bool3 = true;

    // hiermee word het plaatje die de levens aan geeft gevonden
    public Texture2D plaatje;
	
	// Update is called once per frame
	void Update () {

        // deze if word geactiveerd als je drie levens hebt
        if(levens == 3)
        {
            // zet bool 1 op true.
            bool1 = true;
            // zet bool 2 op true.
            bool2 = true;
            // zet bool 3 op true.
            bool3 = true;

        }

        // deze if word geactiveerd als je twee levens hebt
        if (levens == 2)
        {

            // zet bool 1 op true.
            bool1 = true;
            // zet bool 2 op true.
            bool2 = true;
            // zet bool 3 op false.
            bool3 = false;

        }

        // deze if word geactiveerd als je één leven hebt
        if (levens == 1)
        {

            // zet bool 1 op true.
            bool1 = true;
            // zet bool 2 op false.
            bool2 = false;
            // zet bool 3 op false.
            bool3 = false;

        }

       // deze if word geactiveerd als je geen levens (minder dan 1) hebt
        if(levens < 1)
        {

            // hiermee word je naar de gameoverscreen scene gebracht.
            Application.LoadLevel("GameOverScreen");

        }
	
	}

    // deze void word gebruit voor het maken van GUI.
    void OnGUI ()
    {

        // deze if word geactiveerd als je je eerste leven hebt.
        if(bool1 == true)
        {

            // hiermee word het eerste levens tekentje getekend
            GUI.DrawTexture(new Rect(0, 0, 50, 50), plaatje);

        }

        // deze if word geactiveerd als je je derde leven hebt.
        if (bool2 == true)
        {

            // hiermee word het tweede levens tekentje getekend
            GUI.DrawTexture(new Rect(60, 0, 50, 50), plaatje);

        }

        // deze if word geactiveerd als je je derde leven hebt.
        if (bool3 == true)
        {

            // hiermee word het derde levens tekentje getekend
            GUI.DrawTexture(new Rect(120, 0, 50, 50), plaatje);

        }

        // hiermee word de score aangegeven.
        GUI.Box(new Rect(10, 50, 100, 25), "Score: " + huidigeScore);

    }

    // deze void word geactiveerd via het colliderscript.
    public void Damage(int damage)
    {

        // hier raak je een leven kwijt
        levens += damage;

    }

    // deze void word geactiveerd via het bumper script.
    public void PlusScore(int score)
    {

        // hier krijg je 10 extra punten
        huidigeScore += score;

    }
}
