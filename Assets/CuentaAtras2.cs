using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CuentaAtras2 : MonoBehaviour {
    public float tiempo;
    public Text gOText;

	// Use this for initialization
	void Start () {
        StartCoroutine(cuentaAtras2(tiempo));
        gOText.text = tiempo.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        tiempo -= Time.deltaTime;
        gOText.text = tiempo.ToString("f0");
    }

    IEnumerator cuentaAtras2(float tiempo) {
        yield return new WaitForSeconds(tiempo);
        SceneManager.LoadScene("GameOver2");
    }
}
