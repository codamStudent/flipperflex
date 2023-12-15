using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youSpinMeRound : MonoBehaviour
{
	[SerializeField] float speed = 0.1f;
    [SerializeField] float distanceFromCenter = 2;
    [SerializeField] Vector3 center = new Vector3(0,1,0);
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(distanceFromCenter, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero,center,speed);
        transform.LookAt(Vector3.zero);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0, -90, 0));
    }	
}
