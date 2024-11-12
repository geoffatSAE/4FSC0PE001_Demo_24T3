using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBill : MonoBehaviour
{

    public float speed;
    public GameObject smokeVFXPrefab;
    public Transform spawnPoint;
    float smokeTimer;
    public GameObject explosionVFXPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        smokeTimer += Time.deltaTime;
        if(smokeTimer > 0.1)
        {
            Instantiate(smokeVFXPrefab, spawnPoint.position, Quaternion.identity);
            smokeTimer = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //collision, hurt the other guy

        //boom vfx
        Instantiate(explosionVFXPrefab, transform.position, Quaternion.identity);

        //destroy
        Destroy(gameObject);
    }
}
