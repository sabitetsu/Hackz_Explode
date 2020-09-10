using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detonation : MonoBehaviour
{
    float countDown;
    GameObject Gmng;
    StageMng Smng;
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        Gmng = GameObject.Find("GameMng");
        Smng = Gmng.GetComponent<StageMng>();
        countDown = Random.Range(5,10);
    }

    // Update is called once per frame
    void Update()
    {
        if (Smng.allReady == true && done == false)
        {
            if (Input.GetKey(KeyCode.H))
            {
                Invoke("Explosion", countDown);
                done = true;
            }
        }
    }
    public void ReadyOK()
    {
        Invoke("Explosion", countDown);
    }
    void Explosion()
    {
        this.SendMessage("Explode");
    }
}
