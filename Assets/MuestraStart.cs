using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MuestraStart : MonoBehaviour {
    public float tiempo;
    public GameObject botonStart = null;

	// Use this for initialization
	void Start () {
        StartCoroutine(muestraStart(tiempo));
	}
	
	// Update is called once per frame
	void Update () {
        tiempo -= Time.deltaTime;
    }

    IEnumerator muestraStart(float tiempo) {
        yield return new WaitForSeconds(tiempo);
        botonStart.SetActive(true);
    }
}
