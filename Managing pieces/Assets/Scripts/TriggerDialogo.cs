using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogo : MonoBehaviour
{
    public Dialogo dialogo;
    public GameObject cuadro;

    public void ActivarDialogo(){
        FindObjectOfType<DialogoManager>().IniciarDialogo(dialogo);
        cuadro.SetActive(true);
    }
}
