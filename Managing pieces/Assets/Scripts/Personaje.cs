using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("Plataforma")){
            player.transform.parent = other.gameObject.transform;
        }
    }

    public void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.CompareTag("Plataforma")){
            player.transform.parent = null;
        }
    }
}
