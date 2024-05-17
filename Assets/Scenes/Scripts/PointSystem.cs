using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;

public class PointSystem : MonoBehaviour
{

    GameObject GM;
    AktiveSpillere AS;
    Ram rm;
    LavFunktion LF;
    svar sv;

    public TextMeshProUGUI HovedFunktion;

    public TextMeshProUGUI Player1Score;
    public TextMeshProUGUI Player2Score;
    public TextMeshProUGUI Player3Score;
    public TextMeshProUGUI Player4Score;

    public List <int> PointListe;

    int vinderScore;

    bool slut=false;

    string Vinder;
    string[] PlayerNavn ={"<color=red>Player1</color>","<color=blue>Player2</color>","<color=green>Player3</color>","<color=yellow>Player4</color>"};


    void resetgivPoint (){
        for (int i = 0;i<4;i++){
            rm.givPoint[i]=false;
        }
    }


    void Start()
    {
        PointListe =new List<int>(){0,0,0,0};
        GM =GameObject.Find("GameManager");
        AS=GM.GetComponent<AktiveSpillere>();
        rm=GM.GetComponent<Ram>();
        LF=GM.GetComponent<LavFunktion>();
        sv=GM.GetComponent<svar>();

        Vinder="Vinder:";
        
    }


    
    void Update()
    {

        if (AS.Player_1==true){
            Player1Score.text=PointListe[0].ToString();
        }
        else {
            Player1Score.text="";
        }
        if (AS.Player_2==true){
            Player2Score.text=PointListe[1].ToString();
        }
        else {
            Player2Score.text="";
        }
        if (AS.Player_3==true){
            Player3Score.text=PointListe[2].ToString();
        }
        else {
            Player3Score.text="";
        }
        if (AS.Player_4==true){
            Player4Score.text=PointListe[3].ToString();
        }
        else {
            Player4Score.text="";
        }


        if (rm.givScore==true){
            for (int i=0;i<4;i++){
                if (rm.givPoint[i]==true){
                    PointListe[i]+=50;
                }
            }

            resetgivPoint();
            rm.ramt.Clear();
            rm.ramtVenteliste.Clear();
            rm.givPointVenteliste.Clear();
            

            rm.givScore=false;
        }

        if(LF.rundeNr==3||LF.rundeNr==5||LF.rundeNr==7||LF.rundeNr==9){
            
            
            if (sv.listeRigtige.Count>0){
                PointListe[sv.listeRigtige[0]]+=75;
                
                if (sv.listeRigtige.Count>1){
                    PointListe[sv.listeRigtige[1]]+=50;
                    
                    if (sv.listeRigtige.Count>2){
                        PointListe[sv.listeRigtige[2]]+=25;

                        if (sv.listeRigtige.Count>3){
                            PointListe[sv.listeRigtige[3]]+=25;
                        }
                    }
                }

            }

            sv.listeRigtige.Clear();

        }

        
        if (LF.rundeNr==10){
            if (slut==false){
                vinderScore=PointListe.Max();

                for (int i=0;i<4;i++){
                    if (PointListe[i]==vinderScore){
                        Vinder +=PlayerNavn[i];
                    }
                }
            
                HovedFunktion.text=Vinder;
                slut=true;
            }
            
            if (Input.GetKeyDown("space")){
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }


        }



        
    }
}
