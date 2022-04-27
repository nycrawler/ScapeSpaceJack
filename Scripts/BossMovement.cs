using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour  
{    
    public GameObject p1;
    public GameObject p2;
    public float lifeSpan;
    float t;   


    // Start is called before the first frame update
    void Start()
    {        
        p1 = GameObject.Find("p1");
        p2 = GameObject.Find("p2");
    }

    // Update is called once per frame
    void Update()
    {
        lifeSpan = lifeSpan + Time.deltaTime;
        t = Mathf.Cos(lifeSpan)/2.0f + 0.5f;
        transform.position = Vector3.Lerp(p1.transform.position, p2.transform.position, t);
    }
}
