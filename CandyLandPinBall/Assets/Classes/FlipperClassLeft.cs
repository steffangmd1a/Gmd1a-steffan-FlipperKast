using UnityEngine;
using System.Collections;

public class FlipperClassLeft : MonoBehaviour {

    public bool activateFlipper;
    public bool deActivateFlipper;
    public float activateTimer = 0f;
    public float deActivateTimer = 0f;
    public GameObject flipperPivot;
    public static bool ismovingright = false;
    public Quaternion originalRotation;
    public Vector3 direction;
    public Rigidbody ball;
    public float force = -60;

    void Start()
    {
        // hier word de orginele rotatie bepaald.
        originalRotation = transform.rotation;
    }

    void Update()
    {
        // deze if word geactiveerd als je de left button indrukt (left control).
        if (Input.GetButtonDown("Left"))
        {
            // hiermee word de activate flipper bool aangezet
            activateFlipper = true;
            ismovingright = true;
        }

        // hier word gecheckt of de draai tijd van de flipper al voorbij is.
        if (activateTimer > 0.06f)
        {
            // hier word de flipper weer uit gezet
            activateFlipper = false;
            // hier word de flipper draai tijd weer op nul gezet
            activateTimer = 0f;

        }

        //deze if word geactiveerd als de activate flipper bool aanstaat
        if (activateFlipper == true)
        {
            //hier word de flipper gedraaid
            transform.RotateAround(transform.position, flipperPivot.transform.forward, -800 * Time.deltaTime);
            // hier word de draaitijd bepaald
            activateTimer = activateTimer + Time.deltaTime;
        }

        // deze if word geactiveerd als je de left button loslaat (left control)
        if (Input.GetButtonUp("Left"))
        {
            // hier word de deactivate bool op true gezet.
            deActivateFlipper = true;
            // hier word de ismovingright bool uitgezet
            ismovingright = false;
        }

        // deze if word geactiveerd als de deactivate timer klaar is.
        if (deActivateTimer > 0.06f)
        {
            // hier word de deactivate bool uit gezet.
            deActivateFlipper = false;
            // hier word de timer op nul gezet
            deActivateTimer = 0f;

        }

        // deze if word geactiveerd als de deactivate bool op true staat
        if (deActivateFlipper == true)
        {
            // hier word de flipper terug gezet op de orginele plaats
            transform.rotation = originalRotation;
            // hier word een timer gezet zodat de flipper op de juiste plek stopt.
            deActivateTimer = deActivateTimer + Time.deltaTime;
        }
    }
}
