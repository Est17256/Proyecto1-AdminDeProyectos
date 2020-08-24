using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoInfo : MonoBehaviour
{
    // [SerializeField]
    // private Text Info_PMBOK;
    // [SerializeField]
    // private TriggerDialogo objetoDialogo;
    private bool agarrar;
    public TriggerDialogo objetoTrigger;
    // Start is called before the first frame update
    // void Start()
    // {
    //      //  Info_PMBOK.gameObject.SetActive(false);
    // }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            AgarrarObjeto();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.name.Equals("Player")){
          //  Info_PMBOK.gameObject.SetActive(true);
            agarrar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision){
        if(collision.gameObject.name.Equals("Player")){
           // Info_PMBOK.gameObject.SetActive(false);
            agarrar = false;
        }
    }

    private void AgarrarObjeto(){
       // DialogoManager.IniciarDialogo();
       objetoTrigger.ActivarDialogo();
       Debug.Log("Prueba");
    }
}
