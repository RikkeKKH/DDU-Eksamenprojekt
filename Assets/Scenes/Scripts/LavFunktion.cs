    
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
    string[] svarmuligheder;
    public List<TextMeshProUGUI> TextListe;
    List<int> PladsOptaget = new List<int>();
    

    


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

    
       
        var rigtigt1 =(n*a)+"x<sup>"+nsup;
    


        var forkert1 =(n*a)+"x<sup>"+(nsup);
        string forkert1s=forkert1.ToString();

        var forkert2 =((n-1)*a)+"x<sup>"+(nsup);
        string forkert2s=forkert2.ToString();


        int w=Random.Range(2,10);
        if (a==n&&w==n-1){
            w=w+1;
            
        }
        var forkert3 =(a*w+n)+"x<sup>"+(nsup);
        string forkert3s=forkert3.ToString();


        string rigtig1s=rigtigt1.ToString();

        svarmuligheder = new string[]{rigtig1s,forkert1s,forkert2s,forkert3s};
    
    
        
      

        int b=Random.Range(2,31);

        int rigtigt2 =b;


        int s=Random.Range(0,4);

        string rigtigt3="";

        if (s==0){
            rigtigt3="cos(x)";
        }
        else if (s==1){
            rigtigt3="-sin(x)";
        }
        else if (s==2){
            rigtigt3="e<sup>x</sup>";
        }
        else if (s==3){
            rigtigt3="1/x";
        }

        int k=Random.Range(2,31);

        int rigtigt4=0;
        
        


        var Funktion=a+"x<sup>"+n+"</sup>+"+b+"x+"+Speciel[s]+"+"+k;

        HovedFunktion.text=Funktion.ToString();
        
       

        
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetKeyDown("J")){

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
