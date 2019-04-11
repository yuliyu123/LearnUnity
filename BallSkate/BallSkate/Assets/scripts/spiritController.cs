using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiritController : MonoBehaviour
{

    void Start()
    {
        Debug.Log("enter start");
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
