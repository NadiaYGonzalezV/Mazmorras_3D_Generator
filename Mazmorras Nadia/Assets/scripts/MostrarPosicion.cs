using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MostrarPosicion : MonoBehaviour
{
    public Transform personaje;
    public TextMeshProUGUI textoPosicion;

    void Update()
    {
        textoPosicion.text = "T� Posici�n: " + personaje.position.ToString();
    }
}
