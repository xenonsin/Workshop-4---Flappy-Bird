using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //jumpForce stores the force applied to the player when we jump.
    public Vector2 jumpForce = new Vector2(0, 300);

    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
	{
        //grab the Rigidbody2D reference.
	    rb = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
            //reset all velocity, so there is no force going down.
	        rb.velocity = Vector2.zero;
            //add the jump force.
            rb.AddForce(jumpForce);
	    }
	
	}

    //The OnCollisionEnter2D method is called whenever there is a collision detected between two GameObjects that have Collider 2D components.
    void OnCollisionEnter2D(Collision2D col)
    {
        Die();
    }

    //Cause the level to reset
    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
