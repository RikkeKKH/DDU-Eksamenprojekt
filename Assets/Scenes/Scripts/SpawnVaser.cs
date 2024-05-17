using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnVaser : MonoBehaviour
{

    GameObject GM;
    svar sv;
    AktiveSpillere AS;
    LavFunktion LF;
    
    public GameObject vase1;
    public GameObject vase2;

    public GameObject vasen;

    public GameObject vI;

    public List<Vector3> Plads = new List<Vector3>();
    public List<GameObject> Inst = new List<GameObject>();

    public List<GameObject> vaseType = new List<GameObject>();

    float minDistance =2.5f;




  
    void Start()
    {
        GM =GameObject.Find("GameManager");
        sv=GM.GetComponent<svar>();
        AS=GM.GetComponent<AktiveSpillere>();
        LF=GM.GetComponent<LavFunktion>();
        
    }


    void Update()
    {   

        if (LF.rundeNr==3||LF.rundeNr==5||LF.rundeNr==7||LF.rundeNr==9){

            while (Plads.Count<AS.Aktiv.Count){
                Vector3 tilfældigPlads =new Vector3(Random.Range(-7f,7f),1.2f,Random.Range(-7f,7f));
                if (Plads.Count==0){
                    Plads.Add(tilfældigPlads);
                }
                else if (Plads.Count==1) {
                    while (Vector3.Distance(Plads[0],tilfældigPlads)<minDistance){
                        tilfældigPlads =new Vector3(Random.Range(-7f,7f),1.2f,Random.Range(-7f,7f));
                    }
                    Plads.Add(tilfældigPlads);
                }
                else if (Plads.Count==2){
                    while (Vector3.Distance(Plads[0],tilfældigPlads)<minDistance||Vector3.Distance(Plads[1],tilfældigPlads)<minDistance){
                        tilfældigPlads =new Vector3(Random.Range(-7f,7f),1.2f,Random.Range(-7f,7f));
                    }
                    Plads.Add(tilfældigPlads);
                }
                else if (Plads.Count==3){
                    while (Vector3.Distance(Plads[0],tilfældigPlads)<minDistance||Vector3.Distance(Plads[1],tilfældigPlads)<minDistance||Vector3.Distance(Plads[2],tilfældigPlads)<minDistance){
                        tilfældigPlads =new Vector3(Random.Range(-7f,7f),1.2f,Random.Range(-7f,7f));
                    }
                    Plads.Add(tilfældigPlads);
                }

                
            }

            while (vaseType.Count<AS.Aktiv.Count){
                int TilfVase =Random.Range(1,5);
                if (TilfVase==4){
                    vasen=vase2;
                }
                else{
                    vasen=vase1;
                }
                vaseType.Add(vasen);
            }

            for (int i=0;i<AS.Aktiv.Count;i++){
                
                vI=Instantiate(vaseType[i],Plads[i],Quaternion.identity);
                Inst.Add(vI);

            }

        }
        
        if(LF.rundeNr==4||LF.rundeNr==6||LF.rundeNr==8){
            
            foreach (GameObject vase in Inst){
                Destroy(vase);
            }

            Inst.Clear();
            vaseType.Clear();


        }


        
    }
}