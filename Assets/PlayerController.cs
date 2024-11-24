using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //needed for navmesh agent

public class PlayerController : MonoBehaviour
{



    public float moveSpeed;
    Rigidbody rb;
    AudioSource audioS;

    float accellerating;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioS = GetComponent<AudioSource>();
        accellerating = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(h, 0, v) * moveSpeed * Time.deltaTime);

        //Debug.Log(rb.velocity.magnitude);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            accellerating += 1 * Time.deltaTime;

           accellerating = Mathf.Clamp(accellerating, 1, 3);
        } else
        {
            //accellerating = 1.0f;
            accellerating -= 1.5f * Time.deltaTime;

            accellerating = Mathf.Clamp(accellerating, 1, 3);
        }

        Debug.Log(accellerating);
        audioS.pitch = accellerating;
    }


}
