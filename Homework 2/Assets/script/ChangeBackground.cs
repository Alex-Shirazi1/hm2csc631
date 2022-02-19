using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject day;
    public GameObject night;
    public GameObject light;
    public bool isNight=false;
    

    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {

    }
    public void BackGroundChanger(){
        if(isNight==false){
        day.SetActive(false);
        night.SetActive(true);
        isNight=true;
        Debug.Log("Night Time!");
        light.SetActive(false);
    }else{
        day.SetActive(true);
        night.SetActive(false);
        isNight=false;
        Debug.Log("Day Time!");
        light.SetActive(true);
    }
    }
}
