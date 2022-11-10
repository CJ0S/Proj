using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CubeControl : MonoBehaviour
{
    float speed = 10f;
    float rotationSpeed = 90f;


    Rigidbody ourRidgidbody;
    // Start is called before the first frame update
    void Start()
    {
        ourRidgidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= speed * transform.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += speed * transform.right * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(transform.right, rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= speed * transform.forward * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            print("Hello");
            ourRidgidbody.AddExplosionForce(40, transform.position + Vector3.down, 3);
        }
    }
}