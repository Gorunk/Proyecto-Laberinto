using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorPuntos : MonoBehaviour
{
    public static ContadorPuntos Instance;
    [SerializeField] private float cantidadPuntos;
    private void Awake()
    {
        if (ContadorPuntos.Instance == null)
        {
            ContadorPuntos.Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SumarPuntos(float puntos)
    {
        cantidadPuntos += puntos;
    }

    public float MostrarPuntos()
    {
        return cantidadPuntos;
    }
}
