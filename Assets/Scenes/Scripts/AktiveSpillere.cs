using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AktiveSpillere : MonoBehaviour
{

    GameObject GM;
    Ram rm;
    LavFunktion LF;

    public Image P1billede;
    public Image P2billede;
    public Image P3billede;
    public Image P4billede;

    public Sprite P1nej;
    public Sprite P2nej;
    public Sprite P3nej;
    public Sprite P4nej;

    public Sprite P1lys;
    public Sprite P2lys;
    public Sprite P3lys;
    public Sprite P4lys;

    public Sprite gennemsigtig;

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;


    public bool Player_1 = false;
    public bool Player_2 = false;
    public bool Player_3 = false;
    public bool Player_4 = false;

    public GameObject I1;
    public GameObject I2;
    public GameObject I3;
    public GameObject I4;

    public StartGame SG;

    public List <string> Aktiv=new List<string>();


    void Start()
    {
        GM =GameObject.Find("GameManager");
        rm=GM.GetComponent<Ram>();
        LF=GM.GetComponent<LavFunktion>();

        Player_1 = false;
        Player_2 = false;
        Player_3 = false;
        Player_4 = false;

        P1billede.sprite = P1nej;
        P2billede.sprite= P2nej;
        P3billede.sprite=P3nej;
        P4billede.sprite=P4nej;
        
    }

    void Update()
    {   
        if (SG.startet==false){

            if (Input.GetKeyDown(KeyCode.W)){
                Player_1 = !Player_1;

                if (Player_1==true){
                    I1 = Instantiate(P1,new Vector3(0,1.5f,9),Quaternion.identity);
                    I1.GetComponent<RotW>().SG = SG;
                    I1.GetComponent<RotW>().rm = rm;
                    I1.GetComponent<RotW>().LF = LF;
                    Aktiv.Add("P1");
                    P1billede.sprite=P1lys;
                
                }
                if (Player_1==false){
                    Destroy(I1);               
                    Aktiv.Remove("P1");
                    P1billede.sprite=P1nej;
                }



            }



            if (Input.GetKeyDown(KeyCode.UpArrow)){
                Player_2 = !Player_2;

                if (Player_2==true){
                    I2 = Instantiate(P2,new Vector3(9,1.5f,0),Quaternion.identity);
                    I2.GetComponent<RotArrow>().SG = SG;
                    I2.GetComponent<RotArrow>().rm = rm;
                    I2.GetComponent<RotArrow>().LF = LF;
                    Aktiv.Add("P2");
                    P2billede.sprite=P2lys;
                
                }
                if (Player_2==false){
                    Destroy(I2);               
                    Aktiv.Remove("P2"); 
                    P2billede.sprite =P2nej;
                }



            }

            if (Input.GetKeyDown(KeyCode.I)){
                Player_3 = !Player_3;

                if (Player_3==true){
                    I3 = Instantiate(P3,new Vector3(0,1.5f,-9),Quaternion.identity);
                    I3.GetComponent<RotI>().SG = SG;
                    I3.GetComponent<RotI>().rm = rm;
                    I3.GetComponent<RotI>().LF = LF;
                    Aktiv.Add("P3");
                    P3billede.sprite=P3lys;
                
                }
                if (Player_3==false){
                    Destroy(I3);
                    Aktiv.Remove("P3");   
                    P3billede.sprite=P3nej;           
                }

            }

            if (Input.GetKeyDown(KeyCode.T)){
                Player_4 = !Player_4;

                if (Player_4==true){
                    I4 = Instantiate(P4,new Vector3(-9,1.5f,0),Quaternion.identity);
                    I4.GetComponent<RotT>().SG = SG;
                    I4.GetComponent<RotT>().rm = rm;
                    I4.GetComponent<RotT>().LF = LF;
                    Aktiv.Add("P4");
                    P4billede.sprite=P4lys;
                
                }
                if (Player_4==false){
                    Destroy(I4);  
                    Aktiv.Remove("P4"); 
                    P4billede.sprite=P4nej;          
                }

            }
        }

        if (SG.startet==true){
            P1billede.sprite=gennemsigtig;
            P2billede.sprite=gennemsigtig;
            P3billede.sprite=gennemsigtig;
            P4billede.sprite=gennemsigtig;

        }
        
        
    }
}
