using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Camera cam;
    public float range = 100f;
    public ParticleSystem partic;
    float x;
    float z;
    GameObject clone;
    void Start()
    {
        
    }

    void Update()
    {
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.green);
        RaycastHit hit;

        if(Input.GetButtonDown("Fire1")){
            x=Random.Range(-8.75f,8.76f);
            z=Random.Range(-9.38f,9.29f);
            partic.Play();
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
                if(hit.transform.gameObject.tag=="target"){
                    Destroy(hit.transform.gameObject);
                    clone=Instantiate(hit.transform.gameObject,new Vector3(x,1.8f,z),Quaternion.identity);
                    clone.GetComponent<UnityEngine.AI.NavMeshAgent>().enabled=true;
                    clone.GetComponent<enemyContr>().enabled=true;
                }
               
            }     

        }
    }


}
