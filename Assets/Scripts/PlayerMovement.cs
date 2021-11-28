using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool moove = false;
    public float backforce = 50f;
    public float forwardforce = 50f;
    public float jumpforce = 50f;
    public float sideforce = 50f;
    public float speed = 0;
    public Rigidbody rb;

    // Use this for initialization
    private void Start()
    {
        Debug.Log("Alo Maci.");
        Debug.Log("Sta ima.");
    }

    // Update is called once per frame
    private void FixedUpdate() // FixedUpdate se koristi kod psyhisc zakona
    {
        speed = rb.velocity.magnitude;
        speed = Mathf.Round(speed);

        if (Input.GetKey("w") || Input.GetKey("up"))
        {
            moove = true;
            if (moove == true)
            {
                rb.AddForce(0, 0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);
            }
        }
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            moove = true;
            if (moove == true)
            {
                rb.AddForce(0, 0, -backforce * Time.deltaTime, ForceMode.VelocityChange);
            }
        }
        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            moove = true;
            if (moove == true)
            {
                rb.AddForce(sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            moove = true;
            if (moove == true)
            {
                rb.AddForce(-sideforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
        if (Input.GetKey("space"))
        {
            moove = true;
            if (moove == true)
            {
                rb.AddForce(0, jumpforce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }
        if (rb.position.y < -1f || rb.position.y > 4f) // Player is out of allowed boundryes
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 10, 100, 90), "Measurements");

        GUI.Label(new Rect(20, 40, 80, 20), speed + " m/s");
    }
}