using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktiveSpillere : MonoBehaviour
{

    GameObject GM;
    Ram rm;
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
        
    }

    void Update()
    {   
        if (SG.startet==false){

            if (Input.GetKeyDown(KeyCode.W)){
                Player_1 = !Player_1;

                if (Player_1==true){
                    I1 = Instantiate(P1,new Vector3(0,1,8),Quaternion.identity);
                    I1.GetComponent<RotW>().SG = SG;
                    I1.GetComponent<RotW>().rm = rm;
                    Aktiv.Add("P1");
                
                }
                if (Player_1==false){
                    Destroy(I1);               
                    Aktiv.Remove("P1"); 
                }



            }



            if (Input.GetKeyDown(KeyCode.UpArrow)){
                Player_2 = !Player_2;

                if (Player_2==true){
                    I2 = Instantiate(P2,new Vector3(8,1,0),Quaternion.identity);
                    I2.GetComponent<RotArrow>().SG = SG;
                    I2.GetComponent<RotArrow>().rm = rm;
                    Aktiv.Add("P2");
                
                }
                if (Player_2==false){
                    Destroy(I2);               
                    Aktiv.Remove("P2"); 
                }



            }

            if (Input.GetKeyDown(KeyCode.I)){
                Player_3 = !Player_3;

                if (Player_3==true){
                    I3 = Instantiate(P3,new Vector3(0,1,-8),Quaternion.identity);
                    I3.GetComponent<RotI>().SG = SG;
                    I3.GetComponent<RotI>().rm = rm;
                    Aktiv.Add("P3");
                
                }
                if (Player_3==false){
                    Destroy(I3);
                    Aktiv.Remove("P3");                
                    
                }

            }

            if (Input.GetKeyDown(KeyCode.T)){
                Player_4 = !Player_4;

                if (Player_4==true){
                    I4 = Instantiate(P4,new Vector3(-8,1,0),Quaternion.identity);
                    I4.GetComponent<RotT>().SG = SG;
                    I4.GetComponent<RotT>().rm = rm;
                    Aktiv.Add("P4");
                
                }
                if (Player_4==false){
                    Destroy(I4);  
                    Aktiv.Remove("P4");             
                    
                }

            }
        }
        
        
    }
}
