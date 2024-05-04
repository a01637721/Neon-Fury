using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para manejo de escenas

public class Cambio_EscenaMENU : MonoBehaviour
{
    // Método para cargar escena
    public void CambiarMENU(string MENU)
    {
        SceneManager.LoadScene(MENU);
    }
}
