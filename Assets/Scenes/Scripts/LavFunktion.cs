    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LavFunktion : MonoBehaviour
{


    GameObject GM;
    svar sv;
    AktiveSpillere AS;
    SpawnVaser SpV;
    Ram rm;


    public Image baggrund;

    public Sprite sort;
    public Sprite gennemsigtig;

    public bool tidenGåetRotW=false;
    public bool tidenGåetRotArrow=false;
    public bool tidenGåetRotI=false;
    public bool tidenGåetRotT=false;



    string[] Speciel ={"sin(x)","cos(x)","e<sup>x</sup>","ln(x)"};

    
    
    public TextMeshProUGUI HovedFunktion;
    
    public TextMeshProUGUI VenstreSvarmulighed;
    public TextMeshProUGUI MidtSvarmulighed;
    public TextMeshProUGUI HøjreSvarmulighed;
    public TextMeshProUGUI TopSvarmulighed;

    public TextMeshProUGUI tiimer;



    List <string> svarmuligheder=new List<string>{"","","",""};
    List <string> svarmuligheder1;
    List <string> svarmuligheder2;
    List <string> svarmuligheder3;
    List <string> svarmuligheder4;
    List <string> svarmulighederBlank =new List<string>{"","","","",};
    public List<TextMeshProUGUI> TextListe;
    public List<int> PladsOptaget = new List<int>();

    public int rundeNr =0;
    
    public float timer =15;

    public bool timerBool=true;

    public bool tidenGået =false;

    public bool PointTid=false;

    string FunktionString;



    void resetSvar(){
        sv.P1t=false;
        sv.P2t=false;
        sv.P3t=false;
        sv.P4t=false;
        sv.P1s=5;
        sv.P2s=5;
        sv.P3s=5;
        sv.P4s=5;
    }

    void justerPlayers(){
        if (AS.Player_1==true){
            AS.I1.transform.position = new Vector3(0,1.5f,9);
        }
        if (AS.Player_2==true){
            AS.I2.transform.position = new Vector3(9,1.5f,0);
        }
        if (AS.Player_3==true){
            AS.I3.transform.position = new Vector3(0,1.5f,-9);
        }
        if (AS.Player_4==true){
            AS.I4.transform.position = new Vector3(-9,1.5f,0);
        }

        baggrund.sprite=gennemsigtig;

        HovedFunktion.text="";

    }

    void clearLister(){
        SpV.Plads.Clear();
        //sv.listeRigtige.Clear();
        PladsOptaget.Clear();
        if (rundeNr!=10){
            HovedFunktion.text=FunktionString;
        }
        

    }

    void resetRot(){
        tidenGåetRotW=true;
        tidenGåetRotArrow=true;
        tidenGåetRotI=true;
        tidenGåetRotT=true;

        if (AS.Player_1==true){
            rm.trykket[0]=false;
        }
        if (AS.Player_2==true){
            rm.trykket[1]=false;
        }
        if (AS.Player_3==true){
            rm.trykket[2]=false;
        }
        if (AS.Player_4==true){
            rm.trykket[3]=false;
        }

        sv.listeTrykket.Clear();

    }

    


    void Start()
    {   
        GM =GameObject.Find("GameManager");
        sv=GM.GetComponent<svar>();
        SpV=GM.GetComponent<SpawnVaser>();
        AS=GM.GetComponent<AktiveSpillere>();
        rm=GM.GetComponent<Ram>();



        TextListe = new List<TextMeshProUGUI> { VenstreSvarmulighed, MidtSvarmulighed, HøjreSvarmulighed, TopSvarmulighed };


        int a=Random.Range(2,16);


        int n =Random.Range(2,7);

        string nsup=(n-1).ToString();

        if(n==2){
            nsup="";
        }

    
       
        var r1 =(n*a)+"x<sup>"+nsup;
    


        var f12 =((n-1)*a)+"x<sup>"+(nsup);


        int w=Random.Range(2,10);
        if (a==n&&w==n-1){
            w=w+2;
            
        }
        var f13 =(a*w+n)+"x<sup>"+(nsup);

        var f11 =(a*w-n)+"x<sup>"+(nsup);



        svarmuligheder1 = new List<string>{r1.ToString(),f11.ToString(),f12.ToString(),f13.ToString()};
    
    
        
      

        int b=Random.Range(2,31);

        int r2 =b;

        int f21 =Random.Range(2,31);
        if (f21==b){
            f21=f21+1;
        }
        int f22=f21+b;

        string f23="x";

        svarmuligheder2 = new List<string>{r2.ToString(),f21.ToString(),f22.ToString(),f23.ToString()};



        int s=Random.Range(0,4);

        string r3="";
        string f31="";
        string f32="";
        string f33="";

        if (s==0){
            r3="cos(x)";
            f31="-sin(x)";
            f32="-cos(x)";
            f33="sin(x)";
        }
        else if (s==1){
            r3="-sin(x)";
            f31="-cos(x)";
            f32="sin(x)";
            f33="cos(x)";
        }
        else if (s==2){
            r3="e<sup>x</sup>";
            f31="ln(x)";
            f32="x<sup>e</sup>";
            f33="tan(x)";
        }
        else if (s==3){
            r3="1/x";
            f31="ln(x)";
            f32="e<sup>x</sup>";
            f33="x(ln)";
        }

        svarmuligheder3 = new List<string>{r3.ToString(),f31.ToString(),f32.ToString(),f33.ToString()};

        int k=Random.Range(2,31);

        int r4=0;

        int f41=k;

        int f42=Random.Range(2,31);
        if (f42==k){
            f42=f42*2;
        }
        string f43="x";

        svarmuligheder4 = new List<string>{r4.ToString(),f41.ToString(),f42.ToString(),f43.ToString()};
        
        


        var Funktion=a+"x<sup>"+n+"</sup>+"+b+"x+"+Speciel[s]+"+"+k;

        FunktionString=Funktion.ToString();

        //HovedFunktion.text=Funktion.ToString();
        
       

        
    }

    // Update is called once per frame
    void Update()
    {   

        while (PladsOptaget.Count<4){
            int r =Random.Range(0,4);
            if (!PladsOptaget.Contains(r)){
                PladsOptaget.Add(r);
            }
        }

        for (int i=0;i<4;i++){
            TextListe[PladsOptaget[i]].text=svarmuligheder[i];
        }



        if (tidenGået==true){
            rundeNr=rundeNr+1;
           
            timer=15;

            resetRot();



            if(rundeNr==2){
                baggrund.sprite=sort;
                svarmuligheder.Clear();
                clearLister();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder1[i]);
                }
            }
            if (rundeNr==3){
                justerPlayers();
                svarmuligheder.Clear();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmulighederBlank[i]);
                }
                resetSvar();
                timerBool=true;
            }
            if(rundeNr==4){
                baggrund.sprite=sort;
                PointTid=true;
                clearLister();
                svarmuligheder.Clear();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder2[i]);
                }
                timerBool=true;
            }
            if (rundeNr==5){
                justerPlayers();
                svarmuligheder.Clear();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmulighederBlank[i]);
                }
                resetSvar();
                timerBool=true;
            }
            if(rundeNr==6){
                baggrund.sprite=sort;
                PointTid=true;
                clearLister();
                svarmuligheder.Clear();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder3[i]);
                }
                timerBool=true;
            }
            if (rundeNr==7){
                justerPlayers();
                svarmuligheder.Clear();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmulighederBlank[i]);
                }
                resetSvar();
                timerBool=true;
            }
            if(rundeNr==8){
                baggrund.sprite=sort;
                PointTid=true;
                clearLister();
                svarmuligheder.Clear();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder4[i]);
                }
                timerBool=true;
            }
            if (rundeNr==9){
                justerPlayers();
                svarmuligheder.Clear();
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmulighederBlank[i]);
                }
                timerBool=true;
            }
            if (rundeNr==10){
                PointTid=true;
            }
            tidenGået=false;


        }

       

        timer-=Time.deltaTime;

        

        if (timer<0){
            tidenGået=true;
        }

        if (rundeNr==0||rundeNr==10){
            timer=100;
            tiimer.text="Tryk på mellemrum for at starte";
        }
        else{
            tiimer.text=Mathf.Round(timer).ToString();
        }


        
     

        



    }
}
