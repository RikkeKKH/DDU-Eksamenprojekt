using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spillet : MonoBehaviour
{

    public GameObject vase1;
    public GameObject vase2;
    public GameObject vase3;
    public GameObject vase4;

    public GameObject P1va;
    public GameObject P2va;
    public GameObject P3va;
    public GameObject P4va;
    GameObject GM;
    svar sv;
    LavFunktion LF;

    public bool koerigennem=true;

    public Vector3 P1ve;
    public Vector3 P2ve;
    public Vector3 P3ve;
    public Vector3 P4ve;


  
    void Start()
    {

        GM =GameObject.Find("GameManager");
        sv=GM.GetComponent<svar>();
        LF=GM.GetComponent<LavFunktion>();
    
        
    }

    void Update()
    {

        if (LF.rundeNr==3||LF.rundeNr==5||LF.rundeNr==7||LF.rundeNr==9){


            if (koerigennem==true){


                if (sv.P1r==true){
                    P1ve =new Vector3(Random.Range(-7f,7f),1.5f,Random.Range(-7f,7f));
                    P1va=Instantiate(vase1,P1ve,Quaternion.identity);
                }
                  if (sv.P2r==true){
                    P2ve =new Vector3(Random.Range(-7f,7f),1.5f,Random.Range(-7f,7f));
                    P2va=Instantiate(vase2,P2ve,Quaternion.identity);
                }
                  if (sv.P3r==true){
                    P3ve =new Vector3(Random.Range(-7f,7f),1.5f,Random.Range(-7f,7f));
                    P3va=Instantiate(vase3,P3ve,Quaternion.identity);
                }
                  if (sv.P4r==true){
                    P4ve =new Vector3(Random.Range(-7f,7f),1.5f,Random.Range(-7f,7f));
                    P4va=Instantiate(vase4,P4ve,Quaternion.identity);
                }
                koerigennem=false;
            
            }

        }
        if (LF.rundeNr==4||LF.rundeNr==6||LF.rundeNr==8){
            
            Destroy(P1va);
            Destroy(P2va);
            Destroy(P3va);
            Destroy(P4va);
        }
        



    }
}
