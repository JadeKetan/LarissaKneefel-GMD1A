using UnityEngine;
using System.Collections;

public class BumperCollideer : MonoBehaviour {
    public Vector3 direction;
    public Rigidbody ball;
    public float force = -10;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnCollisionEnter(Collision collision)
    {
        direction = collision.contacts[0].point;
        ball.AddForce(direction * force);
    }
}
