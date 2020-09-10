using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMng : MonoBehaviour
{
    bool opened = false;
    Animator anim;
    [SerializeField]StageMng Smng;
    AudioClip sound1;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        //Smng = GetComponent<StageMng>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay(Collider other)
    {
        if (opened == false)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                anim.SetBool("openReady", true);
                audio.PlayOneShot(sound1);
                Smng.stage += 1;
                Smng.ClearStage();
                opened = true;
            }
        }
    }
}
