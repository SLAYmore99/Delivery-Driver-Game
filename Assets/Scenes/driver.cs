using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 10000000000000.0f;
    [SerializeField] float movespeed = 7f;
    [SerializeField] float slowspeed = 5f;
    [SerializeField] float boostspeed =11f;

    
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerspeed*Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * movespeed*Time.deltaTime;
        transform.Rotate(0,0,-steeramount);
        transform.Translate(0,moveamount,0);

        
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Booster")
        {
            movespeed = boostspeed;
        }
        
        if (other.tag == "Bump")
        {
            movespeed = slowspeed;
        }
    }
}
