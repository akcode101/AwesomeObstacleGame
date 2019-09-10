
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 8000f;
    public float sidewaysForce = 120f;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Hello, World!");
        //rb.AddForce(0,200, 500);
    }

    /*
    // Update is called once per frame
    void Update()
    {
        rb.AddForece
    }
    */

    //fixed keyword used for physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
        
}
