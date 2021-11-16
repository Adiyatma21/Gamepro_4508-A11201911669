using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCoin : MonoBehaviour{
    public GameObject Coin;
    void Start(){
        InvokeRepeating("CreateObstacle",1f,1.5f);
    }
    void CreateObstacle(){
        Instantiate(Coin);
    }
}