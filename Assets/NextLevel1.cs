using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel1 : MonoBehaviour
{
    public string scene;
    public ContadorPuntos contadorPuntos;
    public CuentaAtras cuentaAtras;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            contadorPuntos.SumarPuntos(cuentaAtras.tiempo);
            StartCoroutine("TiempoCambio");
            
        }
    }

    public IEnumerator TiempoCambio()
    {
        yield return new WaitForSeconds(0.05f);
        SceneManager.LoadScene(scene);
    }

}