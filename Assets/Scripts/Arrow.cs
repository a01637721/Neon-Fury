using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARROWS : MonoBehaviour
{
    //public float speed;

    // Lifes counter
    public GameObject[] hearts;
    private int life = 3; // Iniciar con 3 vidas

    [SerializeField] private AudioClip crashSound;

    private Vector2 _direction = Vector2.zero;
    private Vector3 checkpointPosition; // Posición del checkpoint

    private AudioSource _audioSource;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        // Establecer la posición del checkpoint como la posición inicial
        checkpointPosition = transform.position;
    }

    private void Update()
    {
        //Flecha de arriba
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _direction = Vector2.up;
        }
           else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + _direction.x,
            Mathf.Round(this.transform.position.y) + _direction.y,
            0.0f
        );

        // Calcula el ángulo de rotación en radianes.
        float angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
        //float angle = Mathf.Atan2(MovementY, MovementX) * Mathf.Rad2Deg;
        // Aplica la rotación al objeto.
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        //myTransform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "box")
        {
            //Play sound effect
            _audioSource.clip = crashSound;
            _audioSource.Play();

            // Lifes counter
            life--;
            LifesUpDate();
        }
    }

    private void PlayCrashSound()
    {
        _audioSource.clip = crashSound;
        _audioSource.Play();
    }

    public void LifesUpDate()
    {
        if (life < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        else
        {
            // Repetir el efecto de sonido mientras haya vidas
            PlayCrashSound();

            // Actualizar las representaciones visuales de las vidas
            if (life == 0)
            {
                Destroy(hearts[0].gameObject);
            }
            else if (life == 1)
            {
                Destroy(hearts[1].gameObject);
            }
            else if (life == 2)
            {
                Destroy(hearts[2].gameObject);
            }

            // Reiniciar la posición del jugador al checkpoint
            transform.position = checkpointPosition;
        }
    }
}


