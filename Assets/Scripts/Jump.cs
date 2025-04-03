using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour
{
    Rigidbody rb;

    float jumpForce = 5.7f;
    public bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, .15f);
        Debug.DrawRay(transform.position, Vector3.down * .15f,Color.red);

        if(Input.GetButtonDown("Jump")){
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
