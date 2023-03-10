using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float stearSpeed = 200;
    [SerializeField] float moveSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float stearAmount = Input.GetAxis("Horizontal")*stearSpeed*Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;
        transform.Rotate(0,0, -stearAmount);
        transform.Translate(0,moveAmount,0);
    }
}
