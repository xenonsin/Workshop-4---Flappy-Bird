using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour
{

    public GameObject obstacle;

    public float repeatRate = 3f;
    
	// Use this for initialization
	void Start () {
        InvokeRepeating("CreateObstacle", 1f, repeatRate);
	
	}

    void CreateObstacle()
    {
        Instantiate(obstacle);
    }
}
