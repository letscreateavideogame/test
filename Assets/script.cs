using UnityEngine;

public class script : MonoBehaviour {

    public Rigidbody rb;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        rb.AddForce(0, 0, 300 * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

    }
}
