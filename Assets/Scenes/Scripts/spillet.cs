using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spillet : MonoBehaviour
{


    public GameObject vase;
    GameObject P2va;
    GameObject GM;

    svar sv;

    public bool koerigennem=true;

    public Vector3 P2ve;


    // Start is called before the first frame update
    void Start()
    {

        GM =GameObject.Find("GameManager");
        sv=GM.GetComponent<svar>();
    
        
    }

    // Update is called once per frame
    void Update()
    {

        if (koerigennem==true){

            if (sv.P2r==true){
                P2ve =new Vector3(Random.Range(-7f,7f),1.5f,Random.Range(-7f,7f));
                P2va=Instantiate(vase,P2ve,Quaternion.identity);
            }
            

        }

        



    }
}
