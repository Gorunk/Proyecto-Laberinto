using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CuentaAtras : MonoBehaviour {
    public float tiempo;
    public Text gOText;
    public string escena;

	// Use this for initialization
	void Start () {
        StartCoroutine(cuentaAtras(tiempo));
        gOText.text = tiempo.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        tiempo -= Time.deltaTime;
        gOText.text = tiempo.ToString("f0");
    }

    IEnumerator cuentaAtras(float tiempo) {
        yield return new WaitForSeconds(tiempo);
        SceneManager.LoadScene(escena);
    }
}
