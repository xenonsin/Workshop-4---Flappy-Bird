using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    public Vector2 velocity = new Vector2(-3,0);
    public float range = 5;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start ()
	{
	    rb = GetComponent<Rigidbody2D>();
	    rb.velocity = velocity;

        //Note: Random.value produces a value between 0.0 and 1.0 inclusive
        //When the object is first created, we move its position down a random amount.
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, 0);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
