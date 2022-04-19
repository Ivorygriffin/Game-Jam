using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject ball;
    public float force;
    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }



    void Shoot()
    {
        GameObject ballClone = Instantiate(ball, transform.position, transform.rotation);
        ballClone.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
    }
































    //public float force;
    //public GameObject ball;




    //void Start()
    //{

    //}


    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Mouse0))
    //    {
    //        Shoot();
    //    }
    //}
    //public void Shoot()
    //{
    //    GameObject BallIns = Instantiate(ball, transform.position, transform.rotation);

    //    BallIns.GetComponent<Rigidbody2D>().velocity = transform.right * force;
    //}
}
