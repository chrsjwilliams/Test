using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //  Controls if we can move or not
    public bool canMove;

    //  Controls how fast we can move
    float moveSpeed = 5f;

    //  Reference to the BoxCollider Component on the Player.
    //  It is null until we assign it. This was assigned in the
    //  Inspector.
    public BoxCollider2D playerCollider;

    //  Reference to the Rigidbody2D Component on the Player.
    //  It is null until we assign it. We assigned this in 
    //  Start()
    Rigidbody2D rb2D;

	// Use this for initialization
	void Start ()
    {
        //  At that start of the game we can move
        canMove = true;
        //  We assign rb2D to the Rigidbody2D Component on
        //  the gameobject we are on
        rb2D = GetComponent<Rigidbody2D>();
	}

    /// <summary>
    ///     Moves the player based on horizontal and vertical inputs
    /// </summary>
    /// <param name="dx">Force applied in the horizontal direction.</param>
    /// <param name="dy">Force applied in the vertical direction.</param>
    private void Move(float dx, float dy)
    {
        //  Applies the new vector to our velocity
        rb2D.velocity = new Vector2(dx * moveSpeed, dy * moveSpeed);
    }

    // Update is called once per frame
    void Update ()
    {
        //-------- Movement with physics --------//

        //  assigns input from horizontal and vertical axes defined
        //  in Unity to our floats x and y
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        //  If we press '0' on the keyboard we toggle movement
        if(Input.GetKeyDown(KeyCode.Alpha0))
        {
            canMove = !canMove;
        }

        //  If we can move, move
        if (canMove)
        {
            Move(x, y);
        }
        else
        {
            Move(0,0);
        }


        //-------- Movement with transforms --------//

        /*
	    if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0.0f, 1.0f) * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0.0f, -1.0f) * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-1.0f, 0.0f) * Time.deltaTime * moveSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1.0f, 0.0f) * Time.deltaTime * moveSpeed;
        }
        */

        if (Input.GetKey(KeyCode.Space))
        {
            // Open Mouth
            GetComponent<SpriteRenderer>().color = Color.red;
            playerCollider.enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white;
            playerCollider.enabled = false;
        }
	}
}
