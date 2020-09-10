using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddRigidbody : MonoBehaviour
{
    //Detonation Deton;
    Rigidbody rb;
    bool addRigid = false;
    GameObject Gmng;
    StageMng Smng;
    // Start is called before the first frame update
    void Start()
    {
        Gmng = GameObject.Find("GameMng");
        Smng = Gmng.GetComponent<StageMng>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Smng.allReady == true)
        {
            if (addRigid == false)
            {
                //if (Deton.exp == true)
                if (Input.GetKey(KeyCode.H))
                {
                    //Invoke("AddRigid", 5);
                    rb = gameObject.AddComponent<Rigidbody>();
                    rb.mass = 5;
                    rb.useGravity = true;
                    addRigid = true;
                }
            }
        }
    }

    /*void AddRigid()
    {
        rb = gameObject.AddComponent<Rigidbody>();
        rb.mass = 5;
        rb.useGravity = true;
    }*/
}
