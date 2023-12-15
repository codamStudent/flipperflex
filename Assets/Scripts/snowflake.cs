using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowflake : MonoBehaviour
{
    public float startYValue = 20;
    public float endYValue = -20;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 StartPos = transform.position;
            StartPos.x = Random.Range(-10, 10);
            StartPos.z = 9;
            StartPos.y = startYValue + Random.Range(0, 30);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < endYValue)
        {
            Vector3 StartPos = transform.position;
            StartPos.x = Random.Range(-10, 10);
            StartPos.z = 9;
            StartPos.y = startYValue + Random.Range(0, 30);
            transform.position = StartPos;
            rb.velocity = Vector3.zero;
        }
    }
}
