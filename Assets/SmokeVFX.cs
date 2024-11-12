using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeVFX : MonoBehaviour
{
    public float reduce = 0.1f;

    public bool increase;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);

        if (increase)
        {
            reduce *= -570.0f;
            Renderer r = GetComponent<Renderer>();
            r.material.color = Color.red;
            Destroy(gameObject, 0.2f);
        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale -= new Vector3(reduce * Time.deltaTime, reduce * Time.deltaTime, reduce * Time.deltaTime);


    }
}
