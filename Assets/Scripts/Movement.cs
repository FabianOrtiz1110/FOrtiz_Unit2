using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float HorizontalInput;
    public float speed = 10.0f;
    private float xRange = 20.0f;

    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);

        if (transform.position.x > xRange)
            {
                transform.position = new Vector3 (xRange, transform.position.y, transform.position.z);
            }

        if (transform.position.x < -xRange)
            {
                transform.position = new Vector3 (-xRange, transform.position.y, transform.position.z);
            }

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bulletPrefab, transform.position, bulletPrefab.transform.rotation);
            }
    }
}
