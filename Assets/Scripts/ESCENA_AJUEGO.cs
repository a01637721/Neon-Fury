using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para manejo de escenas

public class Cambio_EscenaJUEGO : MonoBehaviour
{
    // Método para cargar escena
    public void CambiarEscena(string LEVEL1)
    {
        SceneManager.LoadScene(LEVEL1);
    }
}
