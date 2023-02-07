using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float jumpForce = 300.0f;

    Rigidbody rb;

    int lane = 0;

    float laneStep = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsGrounded() && Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0.0f, jumpForce, 0.0f));
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && lane >= 0)
        {
            transform.Translate(new Vector3(-laneStep, 0.0f, 0.0f));
            --lane;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && lane <= 0)
        {
            transform.Translate(new Vector3(laneStep, 0.0f, 0.0f));
            ++lane;
        }
    }

    private bool IsGrounded()
    {
        return (transform.position.y == 1.0f);
    }
}
