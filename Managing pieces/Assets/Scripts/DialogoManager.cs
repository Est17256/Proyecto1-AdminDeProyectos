using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogoManager : MonoBehaviour
{
    public Text texto;
    public Text textoDialogo;
    public GameObject cuadro;

    private Queue<string> informacion;
    // Start is called before the first frame update
    void Start()
    {
        informacion = new Queue<string>();
    }

    public void IniciarDialogo(Dialogo dialogo){
        texto.text = dialogo.titulo;
        informacion.Clear();
        foreach (string info in dialogo.oraciones)
        {
            informacion.Enqueue(info);
        }

        MostrarSiguienteInfo();
    }

    public void MostrarSiguienteInfo(){
        if(informacion.Count == 0){
            FinDialogo();
            return;
        }
        string oracion = informacion.Dequeue();
        textoDialogo.text = oracion;
    }

    void FinDialogo(){
        cuadro.SetActive(false);
        Debug.Log("Fin del dialogo");
    }
}
