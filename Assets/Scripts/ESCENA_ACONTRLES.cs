using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para manejo de escenas

public class Cambio_EscenaCONTROLES : MonoBehaviour
{
    // Método para cargar escena
    public void CambiarEscena(string CONTROLES)
    {
        SceneManager.LoadScene(CONTROLES);
    }
}