using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class objectforce : MonoBehaviour
{
    public Rigidbody rb;
    public Transform t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            rb.AddForce(-100, 0, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            rb.AddForce(100, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.AddForce(0, 0, -50);
        if (Input.GetKey(KeyCode.RightArrow))
            rb.AddForce(0, 0, 50);
        if (t.position.y < -1f)
        {
            FindObjectOfType<gamerestart>().Endgame();
        }
    }
}
