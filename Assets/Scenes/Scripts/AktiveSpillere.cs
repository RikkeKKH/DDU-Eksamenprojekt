using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AktiveSpillere : MonoBehaviour
{

    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;


    public bool Player_1 = false;
    public bool Player_2 = false;
    public bool Player_3 = false;
    public bool Player_4 = false;

    private GameObject I1;
    private GameObject I2;
    private GameObject I3;
    private GameObject I4;

    public StartGame SG;


    void Start()
    {
        
    }

    void Update()
    {   
        if (SG.startet==false){

            if (Input.GetKeyDown(KeyCode.W)){
                Player_1 = !Player_1;

                if (Player_1==true){
                    I1 = Instantiate(P1,new Vector3(0,1,8),Quaternion.identity);
                    I1.GetComponent<RotW>().SG = SG;
                
                }
                if (Player_1==false){
                    Destroy(I1);               
                    
                }



            }



            if (Input.GetKeyDown(KeyCode.UpArrow)){
                Player_2 = !Player_2;

                if (Player_2==true){
                    I2 = Instantiate(P2,new Vector3(8,1,0),Quaternion.identity);
                    I2.GetComponent<Rotering>().SG = SG;
                
                }
                if (Player_2==false){
                    Destroy(I2);               
                    
                }



            }

            if (Input.GetKeyDown(KeyCode.I)){
                Player_3 = !Player_3;

                if (Player_3==true){
                    I3 = Instantiate(P3,new Vector3(0,1,-8),Quaternion.identity);
                    I3.GetComponent<Rotering>().SG = SG;
                
                }
                if (Player_3==false){
                    Destroy(I3);               
                    
                }

            }

            if (Input.GetKeyDown(KeyCode.T)){
                Player_4 = !Player_4;

                if (Player_4==true){
                    I4 = Instantiate(P4,new Vector3(-8,1,0),Quaternion.identity);
                    I4.GetComponent<Rotering>().SG = SG;
                
                }
                if (Player_4==false){
                    Destroy(I4);               
                    
                }

            }
        }
        
        
    }
}
