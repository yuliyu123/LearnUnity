using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)  
    {
        Debug.Log("OnTriggerEnter");
    }
    void OnCollisionEnter(Collision collision)   
    {  
        //进入碰撞器执行的代码
        Debug.Log("OnCollisionEnter");
    }
}
