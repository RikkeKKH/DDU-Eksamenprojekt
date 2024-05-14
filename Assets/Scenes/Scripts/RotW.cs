using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotW : MonoBehaviour
{
   
    public GameObject nulpunkt;

    
    public float speed=5f;

    bool roter = false;
    bool midt = false;
    public bool stop = false;


    int tryk=0;

    
    public StartGame SG;

    public Ram rm;

    bool start=false;
    

    


    void Start(){
        
    }


    
    void Update()
    {   
        
        float distance =Vector3.Distance(this.transform.position,nulpunkt.transform.position);
        Vector3 retning = nulpunkt.transform.position - transform.position;

        if (SG.startet==true&& tryk==0){
            start=true;
        }


        if(start==true){
            roter=true;
        
        }


        if (roter==true){
            
            transform.RotateAround(nulpunkt.transform.position, Vector3.up, 40 * Time.deltaTime);
        

        }

        if (Input.GetKeyDown(KeyCode.W)){
            tryk +=1;
            start=false;

            roter=false;

            
            


        }


        if (roter==false){


            if (rm.rwStop==false&& tryk==1){
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
                rm.rwStop=true;

            }

           

            
        }
           
        

        

        

    
        
    }
}
