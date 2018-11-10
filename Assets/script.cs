using UnityEngine;

public class script : MonoBehaviour
{

    public int forceConst = 5;
    public Rigidbody rb;
    private bool canJump;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Input.GetKey("d"))
        {
            rb.AddForce(300 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-300 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 300 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, 0 - 300 * Time.deltaTime);
        }
        if (canJump)
        {
            canJump = false;
            rb.AddForce(0, forceConst, 0, ForceMode.Impulse);
        }

    }
    void Update()
    {
        if (Input.GetKeyUp("v"))
        {
            canJump = true;
        }
    }
}
