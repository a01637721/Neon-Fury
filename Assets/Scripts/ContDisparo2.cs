using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoJugador2 : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject bala;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Disparar();
        }
    }
    private void Disparar()
    {
        Instantiate(bala, controladorDisparo.position, controladorDisparo.rotation);
    }
}