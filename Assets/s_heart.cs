using UnityEngine;

public class s_heart : MonoBehaviour
{

    public float speed = 10f;
    public bool MControlling;

    public float Rtimer = 3.0f;

    private SpriteRenderer playerSprite;
    private Rigidbody2D rb;

    public int deathCounter = 0;
    public int deathRestart = 0;
    public int explosionCounter = 0;
    // Use this for initialization
    void Start()
    {
        playerSprite = GetComponent<SpriteRenderer>();
        MControlling = false;
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!MControlling)//is active
        {

            //float moveHorizontal = Input.GetAxis("Horizontal");
            //float moveVertical = Input.GetAxis("Vertical");

            //Vector2 movement = new Vector2(moveHorizontal, moveVertical);

            //rb.AddForce(movement * speed);
            //Forward movement

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector2.up * Time.deltaTime * speed);
                //playerSprite.flipX = true;
            }//endofW
            
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector2.down * Time.deltaTime * speed);
            }//endofS
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * Time.deltaTime * speed);
                //playerSprite.flipX = true;
            }//endofA
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * Time.deltaTime * speed);
                //playerSprite.flipX = true;
            }//endofD


            if (Input.GetKeyDown(KeyCode.E)) //&&doesnotexist
            {
                //shootbullet
            }//endofMC

            if (Input.GetKeyDown(KeyCode.R))
            {
                Rtimer -= Time.deltaTime;
                if (Rtimer < 0)
                {
                    //autodestruct
                    Death();
                    deathRestart++;
                }

            }//endofRestart
            else
            {
                Rtimer = 3.0f;
            }
        }//endofHeartControl
    }//endofUpdate

    public void Death()
    {
        //pause and screen stuff
        Destroy(this);
        deathCounter++;
    }
}