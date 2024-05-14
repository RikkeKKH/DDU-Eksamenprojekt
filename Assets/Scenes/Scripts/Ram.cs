using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram : MonoBehaviour
{


    GameObject GM;
    spillet sp;
    AktiveSpillere AS;
    LavFunktion LF;
    svar sv;

   
   
    void Start()
    {
        GM =GameObject.Find("GameManager");
        sp=GM.GetComponent<spillet>();
        AS=GM.GetComponent<AktiveSpillere>();
        LF=GM.GetComponent<LavFunktion>();
        sv=GM.GetComponent<svar>();

        
    }

   
    void Update()
    {

        if(LF.rundeNr==3&&sv.P1r==true){
            float DisMellem =Vector3.Distance(AS.I1.transform.position,sp.P1va.transform.position);

    
        
            Debug.Log(DisMellem);

        }
        

        



        
    }
}
