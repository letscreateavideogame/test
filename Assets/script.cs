using UnityEngine;

public class script : MonoBehaviour
{
    public float SpeedFoward = 300f;
    public float Lateral = 300f;
    public int forceConst = 5;
    public Rigidbody rb;
    private bool canJump;
    // Use this for initialization


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, SpeedFoward * Time.deltaTime, ForceMode.Force);

        if (Input.GetKey("d"))
        {
            rb.AddForce(Lateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Lateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
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
