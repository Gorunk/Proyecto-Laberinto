using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{

  public ScoreG scoreG;
  public ContadorPuntos contadorPuntos;
  //DateTime dt = DateTime.Now;
  string date = System.DateTime.UtcNow.ToLocalTime().ToString("MMM d - H:mm");
  private void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      float puntos = contadorPuntos.MostrarPuntos();
      scoreG.AddScoreEntry((int)puntos*7, date);
    }
  }

}