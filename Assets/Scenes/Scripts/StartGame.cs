using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{

    public bool startet =false;

    public AktiveSpillere AS;
    public LavFunktion LF;

    bool erStartet;


    // Start is called before the first frame update
    void Start()
    {
        erStartet =false;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space")&&AS.Aktiv.Count>1&&erStartet==false){
            startet =true;
            LF.rundeNr=1;
            LF.tidenGået=true;
            erStartet=true;
        
        }

        
    }

    //Rasmus er den bedste
}
