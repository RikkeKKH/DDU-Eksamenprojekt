using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotI : MonoBehaviour
{
   
    public GameObject nulpunkt;
    public LavFunktion LF;

    
    public float speed=5f;

    bool roter = false;
    bool midt = false;


    int tryk=0;

    
    public StartGame SG;

    public Ram rm;

    bool start=false;

    void resetVar(){
        midt=false;
        tryk=0;
        rm.rIStop=false;
    }
    

    


    void Start(){
        
    }


    
    void Update()
    {   

        if(LF.tidenGåetRotI){
            resetVar();
            LF.tidenGåetRotI=false;
        }



        if (SG.startet==true&& tryk==0){
            start=true;
        }


        float distance =Vector3.Distance(this.transform.position,nulpunkt.transform.position);
        Vector3 retning = nulpunkt.transform.position - transform.position;




        if(start==true){
            roter=true;
        
        }


        if (roter==true){
            
            transform.RotateAround(nulpunkt.transform.position, Vector3.up, 40 * Time.deltaTime);
        

        }

        if (Input.GetKeyDown(KeyCode.I)){
            tryk +=1;
            start=false;

            roter=false;

            
            


        }


        if (roter==false){


            if (rm.rIStop==false&& tryk==1){
                if (midt==false){
                    transform.position = transform.position+retning*speed*Time.deltaTime;

                }

                if (midt==true){
                    transform.position = transform.position-retning*speed*Time.deltaTime;

                }

            }

            if (distance<=1){
                midt=true;
            }

            if (distance>=8.1){
                midt=false;
            }   

            if (tryk==2){
                rm.rIStop=true;
                rm.trykket[2]=true;

            }

           

            
        }
           
        

        

        

    
        
    }
}
