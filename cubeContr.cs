using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeContr : MonoBehaviour
{
    // Start is called before the first frame update
    float z;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        z=Random.Range(-9.38f, 9.29f);
        if(Input.GetKeyDown("space")){
            Instantiate(gameObject,new Vector3(1,1.8f,z),transform.rotation);
            Destroy(gameObject);
        }
    }
}
