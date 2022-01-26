using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5.0f;
    private Rigidbody playerRb;
    private GameObject focalpoint;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalpoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(focalpoint.transform.forward * forwardInput * speed);
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.gameObject.tag == "Enemy")
    //    {
    //        hit.rigidbody.AddForce(transform.forward * speed);
    //        hit.transform.localScale += new Vector3(1, 1, 1);
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerRb.velocity = playerRb.velocity + Vector3.forward * 3;
            playerRb.AddForce(transform.forward * 4,ForceMode.Impulse);
            playerRb.transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            playerRb.mass++;

            
        }
    }

}
