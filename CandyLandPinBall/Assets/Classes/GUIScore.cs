using UnityEngine;
using System.Collections;

public class GUIScore : MonoBehaviour {

    public int huidigeScore;
    public int highscore;
    public int levens;
    public bool bool1 = true;
    public bool bool2 = true;
    public bool bool3 = true;

    public Texture2D plaatje;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if(levens == 3)
        {

            bool1 = true;
            bool2 = true;
            bool3 = true;

        }

        if(levens == 2)
        {

            bool1 = true;
            bool2 = true;
            bool3 = false;

        }

        if(levens == 1)
        {

            bool1 = true;
            bool2 = false;
            bool3 = false;

        }
	
	}

    void OnGUI ()
    {

        if(bool1 == true)
        {

            GUI.DrawTexture(new Rect(0, 0, 50, 50), plaatje);

        }

        if(bool2 == true)
        {

            GUI.DrawTexture(new Rect(60, 0, 50, 50), plaatje);

        }

        if (bool3 == true)
        {

            GUI.DrawTexture(new Rect(120, 0, 50, 50), plaatje);

        }

    }

    public void Damage(int damage)
    {

        levens += damage;

    }
}
