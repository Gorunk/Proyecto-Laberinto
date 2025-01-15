using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiaEscena : MonoBehaviour
{
	public void CambiaEscena(string nombreEscena){
		SceneManager.LoadScene(nombreEscena);
	}
}


/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiaEscena : MonoBehaviour {

	public void cambiarEscena(string nombreEscena){
		SceneManager.LoadScene(nombreEscena);
	}
}
*/
