    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LavFunktion : MonoBehaviour
{

    string[] Speciel ={"sin(x)","cos(x)","e<sup>x</sup>","ln(x)"};

    
    
    public TextMeshProUGUI HovedFunktion;
    
    public TextMeshProUGUI VenstreSvarmulighed;
    public TextMeshProUGUI MidtSvarmulighed;
    public TextMeshProUGUI HøjreSvarmulighed;
    public TextMeshProUGUI TopSvarmulighed;

    //int rundeNr=0;

    //public TextMeshProUGUI[] TextListe;
    List <string> svarmuligheder=new List<string>{"","","",""};
    List <string> svarmuligheder1;
    List <string> svarmuligheder2;
    List <string> svarmuligheder3;
    List <string> svarmuligheder4;
    public List<TextMeshProUGUI> TextListe;
    List<int> PladsOptaget = new List<int>();

    int test =0;
    

    


    // Start is called before the first frame update
    void Start()
    {   
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

        HovedFunktion.text=Funktion.ToString();
        
       

        
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetKeyDown(KeyCode.J)){
            test=test+1;
            svarmuligheder.Clear();

            if(test==1){
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder1[i]);
                }
            }
            if(test==2){
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder2[i]);
                }
            }
            if(test==3){
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder3[i]);
                }
            }
            if(test==4){
                for (int i=0;i<4;i++){
                    svarmuligheder.Add(svarmuligheder4[i]);
                }
            }


        }
        
     

        while (PladsOptaget.Count<4){
            int r =Random.Range(0,4);
            if (!PladsOptaget.Contains(r)){
                PladsOptaget.Add(r);
            }
        }

        for (int i=0;i<4;i++){
            TextListe[i].text=svarmuligheder[PladsOptaget[i]];
        }
       




        



    }
}
