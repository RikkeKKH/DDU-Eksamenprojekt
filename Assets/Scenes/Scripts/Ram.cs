using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ram : MonoBehaviour
{


    GameObject GM;
    AktiveSpillere AS;
    LavFunktion LF;
    svar sv;
    SpawnVaser SP;

    public bool rwStop=false;
    public bool rArrowStop=false;
    public bool rIStop=false;
    public bool rTStop=false;

    public List <int> ramt=new List<int>();

    public List<bool> givPoint = new List<bool>() { false, false, false, false };

    public List <int> ramtVenteliste=new List<int>();
    public List <int> givPointVenteliste=new List<int>();





   
   
    void Start()
    {
        GM =GameObject.Find("GameManager");
        AS=GM.GetComponent<AktiveSpillere>();
        LF=GM.GetComponent<LavFunktion>();
        sv=GM.GetComponent<svar>();
        SP=GM.GetComponent<SpawnVaser>();

        
    }

   
    void Update()
    {   

        if (LF.rundeNr==3||LF.rundeNr==5||LF.rundeNr==7||LF.rundeNr==9){
            
            if (AS.Player_1==true){
                if (rwStop==true){
                    if (sv.P1r==true){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance1=Vector3.Distance(AS.I1.transform.position,SP.Plads[i]);
                            if (distance1<2){
                                if (!ramt.Contains(i)){
                                    ramt.Add(i);
                                    givPoint[0]=true;
                                    break;
                                }
                            }

                        }

                        
                    }
                    if (sv.P1r==false){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance1=Vector3.Distance(AS.I1.transform.position,SP.Plads[i]);
                            if (distance1<2){
                                if (!ramtVenteliste.Contains(i)||!ramt.Contains(i)){
                                    ramtVenteliste.Add(i);
                                    givPointVenteliste.Add(0);
                                    
                                    break;
                                }
                            }

                        }
                    }

                }
            }

            if (AS.Player_2==true){
                if (rArrowStop==true){
                    if (sv.P2r==true){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance2=Vector3.Distance(AS.I2.transform.position,SP.Plads[i]);
                            if (distance2<2){
                                if (!ramt.Contains(i)){
                                    ramt.Add(i);
                                    givPoint[1]=true;
                                    break;
                                }
                            }

                        }

                        
                    }
                    if (sv.P2r==false){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance2=Vector3.Distance(AS.I2.transform.position,SP.Plads[i]);
                            if (distance2<2){
                                if (!ramtVenteliste.Contains(i)||!ramt.Contains(i)){
                                    ramtVenteliste.Add(i);
                                    givPointVenteliste.Add(1);
                                    
                                    break;
                                }
                            }

                        }
                    }

                }
            }

            if (AS.Player_3==true){
                if (rIStop==true){
                    if (sv.P3r==true){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance3=Vector3.Distance(AS.I2.transform.position,SP.Plads[i]);
                            if (distance3<2){
                                if (!ramt.Contains(i)){
                                    ramt.Add(i);
                                    givPoint[2]=true;
                                    break;
                                }
                            }

                        }

                        
                    }
                    if (sv.P3r==false){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance3=Vector3.Distance(AS.I3.transform.position,SP.Plads[i]);
                            if (distance3<2){
                                if (!ramtVenteliste.Contains(i)||!ramt.Contains(i)){
                                    ramtVenteliste.Add(i);
                                    givPointVenteliste.Add(2);
                                    
                                    break;
                                }
                            }

                        }
                    }

                }
            }

            if (AS.Player_4==true){
                if (rArrowStop==true){
                    if (sv.P4r==true){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance4=Vector3.Distance(AS.I4.transform.position,SP.Plads[i]);
                            if (distance4<2){
                                if (!ramt.Contains(i)){
                                    ramt.Add(i);
                                    givPoint[3]=true;
                                    break;
                                }
                            }

                        }

                        
                    }
                    if (sv.P4r==false){
                        for (int i=0;i<SP.Plads.Count;i++){
                            float distance4=Vector3.Distance(AS.I4.transform.position,SP.Plads[i]);
                            if (distance4<2){
                                if (!ramtVenteliste.Contains(i)||!ramt.Contains(i)){
                                    ramtVenteliste.Add(i);
                                    givPointVenteliste.Add(3);
                                    
                                    break;
                                }
                            }

                        }
                    }

                }
            }
        }

        if (LF.rundeNr==4||LF.rundeNr==6||LF.rundeNr==8||LF.rundeNr==10){

            for (int i=0;i<ramtVenteliste.Count;i++){
                if (!ramt.Contains(ramtVenteliste[i])){
                    ramt.Add(ramtVenteliste[i]);
                    givPoint[givPointVenteliste[i]]=true;
                }


            }

            for (int i=0;i<4;i++){
                if (givPoint[i]==true){
                    Debug.Log(i+"ramte");
                }
            }
        }

       

        
        
        
        
        
        
        
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
