using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastBomb : MonoBehaviour
{
    bool bombed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bombed == false)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                this.SendMessage("Explode");
                bombed = true;
            }
        }
    }
}
