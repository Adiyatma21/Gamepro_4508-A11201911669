using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestroy : MonoBehaviour{
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "playerTag"){
            Destroy(gameObject);
        }
    }
}
