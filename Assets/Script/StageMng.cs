using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMng : MonoBehaviour
{
    public int stage = 0;
    [SerializeField]Detonation[] Dtn;
    [SerializeField] GameObject[] Hides;
    public bool allReady = false;
    
    void Start()
    {

    }

    
    void Update()
    {

    }
    public void ClearStage()
    {
        switch (stage)
        {
            case 0: //init
                break;
            case 1: //1Clear
                //左の壁を消す
                Hides[0].SetActive(false);
                break;
            case 2: //2Clear
                //正面の壁を消す
                Hides[1].SetActive(false);
                break;
            case 3: //3Clear
                //奥の壁を消す
                Hides[2].SetActive(false);
                break;
            case 4: //ALL Clear
                //bomb
                allReady = true;
                /*for(int i = 0; i < Dtn.Length - 1; i++)
                {
                    Dtn[i].ReadyOK();
                }*/
                break;
        }
    }
}
