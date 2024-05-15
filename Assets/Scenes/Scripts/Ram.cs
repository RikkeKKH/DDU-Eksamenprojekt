using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram : MonoBehaviour
{


    GameObject GM;
    AktiveSpillere AS;
    LavFunktion LF;
    svar sv;

    public bool rwStop=false;
    public bool rArrowStop=false;
    public bool rIStop=false;
    public bool rTStop=false;


   
   
    void Start()
    {
        GM =GameObject.Find("GameManager");
        AS=GM.GetComponent<AktiveSpillere>();
        LF=GM.GetComponent<LavFunktion>();
        sv=GM.GetComponent<svar>();

        
    }

   
    void Update()
    {

        /*if(LF.rundeNr==3&&sv.P1r==true){
            float DisMellem =Vector3.Distance(AS.I1.transform.position,sp.P1va.transform.position);

    
        
            Debug.Log(DisMellem);

        }

        if (sv.listeRigtige.Count==AS.Aktiv.Count){
            
            if (rwStop==true){
                Debug.Log("test");
            }


        }*/
        

        



        
    }
}
