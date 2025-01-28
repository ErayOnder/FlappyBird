using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpForce = 10f;
    public LogicScript logicScript;
    public bool isDead = false;

    public float topScreen;
    public float bottomScreen;
    public AudioSource jumpSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float cameraHeight = Camera.main.orthographicSize;
        topScreen = cameraHeight + 1;
        bottomScreen = -cameraHeight - 1;

        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        offScreen();

        if (Input.GetKeyDown(KeyCode.Space) && !isDead)
        {
            myRigidbody.linearVelocity = Vector2.up * jumpForce;
            jumpSound.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        isDead = true;
    }

    private void offScreen()
    {
        if (transform.position.y > topScreen || transform.position.y < bottomScreen)
        {
            logicScript.gameOver();
            isDead = true;
        }
    }
    
}