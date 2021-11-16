using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour{
    public GameObject rocks;
    void Start(){
        InvokeRepeating("CreateObstacle",1f,1.5f);
    }
    void CreateObstacle(){
        Instantiate(rocks);
    }
}