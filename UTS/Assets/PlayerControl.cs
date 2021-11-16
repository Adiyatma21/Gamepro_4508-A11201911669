using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour{
    public Vector2 jumpForce = new Vector2(0,100);
    int score = 0;
    GUIStyle guiStyle = new GUIStyle();
    private AudioSource audioSource;
    public AudioClip Scored;
    void Start(){
    }
    void Update(){
        // float touchclicked = Input.GetAxis("Fire1");
        if(Input.GetKeyDown("space")){
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.y > Screen.height || screenPosition.y < 0){
            Die();
        }
    }
    void Die(){
        Debug.Log("Game Over");
        SceneManager.LoadScene("Menu");
    }
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "enemyTag"){
            Die();
        }
        if(coll.gameObject.tag == "coinTag"){
            score++;
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = Scored;
            audioSource.Play();
        }
    }
    void OnGUI(){
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(0,0,300,50), "Score: "+score.ToString(), guiStyle);
    }
}
