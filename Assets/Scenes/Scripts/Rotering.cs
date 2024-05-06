using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotering : MonoBehaviour
{
   
    public GameObject nulpunkt;

    
    public float speed=0.5f;

    bool roter = false;
    bool midt = false;
    bool stop = false;


    int tryk=0;

    
    public StartGame SG;
    

    


    void Start(){
        
    }


    
    void Update()
    {


        float distance =Vector3.Distance(this.transform.position,nulpunkt.transform.position);
        Vector3 retning = nulpunkt.transform.position - transform.position;




        if(SG.startet==true){
            roter=true;
        
        }


        if (roter==true){
            
            transform.RotateAround(nulpunkt.transform.position, Vector3.up, 40 * Time.deltaTime);
        

        }

        if (Input.GetKeyDown("space")){
            SG.startet=false;

            roter=false;

            tryk +=1;
            


        }


        if (roter==false){


            if (stop==false&& tryk==1){
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
                stop=true;

            }

           

            
        }
           
        

        

        

    
        
    }
}
