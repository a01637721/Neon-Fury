using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para manejo de escenas

public class Cambio_EscenaHISTORIA : MonoBehaviour
{
    // Método para cargar escena
    public void CambiarEscena(string HISTORIA)
    {
        SceneManager.LoadScene(HISTORIA);
    }
}