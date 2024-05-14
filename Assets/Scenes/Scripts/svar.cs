using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class svar : MonoBehaviour
{   
    public StartGame SG;
    GameObject GM;
    AktiveSpillere AS;
    LavFunktion LF;
   
    public int P1s=5;
    public int P2s=5;
    public int P3s=5;
    public int P4s=5;

    public bool P1r =false;
    public bool P2r=false;
    public bool P3r =false;
    public bool P4r =false;

    public bool P1t=false;
    public bool P2t=false;
    public bool P3t=false;
    public bool P4t=false;



    // Start is called before the first frame update
    void Start()
    {

        GM =GameObject.Find("GameManager");
        AS=GM.GetComponent<AktiveSpillere>();
        LF=GM.GetComponent<LavFunktion>();
        
    }

    // Update is called once per frame
    void Update()
    {   

        if(SG.startet==true){


            if(LF.rundeNr==2||LF.rundeNr==4||LF.rundeNr==6||LF.rundeNr==8){

                if (AS.Player_1==true&&P1t==false){
                    if (Input.GetKeyDown(KeyCode.A)){
                        P1s=0;
                        P1t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.S)){
                        P1s=1;
                        P1t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.D)){
                        P1s=2;
                        P1t=true;
                    }
                    if(Input.GetKeyDown(KeyCode.W)){
                        P1s=3;
                        P1t=true;
                    }



                    if (LF.PladsOptaget.Count != 0 && P1s==LF.PladsOptaget[0]){
                        P1r=true;
                    }
                    else {
                        P1r=false;
                    }

                    


                }

                if (AS.Player_2==true&&P2t==false){
                    if (Input.GetKeyDown(KeyCode.LeftArrow)){
                        P2s=0;
                        P2t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.DownArrow)){
                        P2s=1;
                        P2t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.RightArrow)){
                        P2s=2;
                        P2t=true;
                    }
                    if(Input.GetKeyDown(KeyCode.UpArrow)){
                        P2s=3;
                        P2t=true;
                    }


                    if (LF.PladsOptaget.Count != 0 && P2s==LF.PladsOptaget[0]){
                        P2r=true;
                    }
                    else {
                        P2r=false;
                    }

                

                }
                

                if (AS.Player_3==true&&P3t==false){
                    if (Input.GetKeyDown(KeyCode.J)){
                        P3s=0;
                        P3t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.K)){
                        P3s=1;
                        P3t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.L)){
                        P3s=2;
                        P3t=true;
                    }
                    if(Input.GetKeyDown(KeyCode.I)){
                        P3s=3;
                        P3t=true;
                    }



                    if (LF.PladsOptaget.Count != 0 && P3s==LF.PladsOptaget[0]){
                        P3r=true;
                    }
                    else {
                        P3r=false;
                    }

                }

                if (AS.Player_4==true&&P4t==false){
                    if (Input.GetKeyDown(KeyCode.F)){
                        P4s=0;
                        P4t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.G)){
                        P4s=1;
                        P4t=true;
                    }
                    if (Input.GetKeyDown(KeyCode.H)){
                        P4s=2;
                        P4t=true;
                    }
                    if(Input.GetKeyDown(KeyCode.T)){
                        P4s=3;
                        P4t=true;
                    }



                    if (LF.PladsOptaget.Count != 0 && P4s==LF.PladsOptaget[0]){
                        P4r=true;
                    }
                    else {
                        P4r=false;
                    }
                }


            }

            




        }
        
      
    }
}
