using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Libreria para manejo de escenas

public class SCENE_NEXT : MonoBehaviour

//Crea un metodo para cargar la siguiente escena

    
{
   //Un botón para cargar la siguiente escena al presionar la tecla "Espacio"
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Cargar la siguiente escena
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
