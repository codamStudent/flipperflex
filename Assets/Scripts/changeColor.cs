using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    [SerializeField] MeshRenderer naaaam;
    // Start is called before the first frame update
    void Start()
    {
        naaaam = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    public void colorchange()
    {
        naaaam.material.color = Color.yellow;
    }
}
