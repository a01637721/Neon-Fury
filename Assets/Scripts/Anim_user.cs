using UnityEngine;
using System.Collections;

public class AnimationAndDisappear : MonoBehaviour
{
    public Animator animator; // Animator para la animación
    public float disappearDelay = 1f; // Retraso antes de desaparecer
    public float disappearTime = 1f; // Tiempo que tarda en desaparecer
    private bool collided = false; // Bandera para controlar si ha ocurrido una colisión

    void Update()
    {
        // Verificar si la colisión ya ha ocurrido y si el objeto aún está activo
        if (collided && gameObject.activeSelf)
        {
            // Desvanecer el objeto después de un retraso
            Invoke("Disappear", disappearDelay);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Verificar si el objeto ha colisionado con otro
        if (!collided)
        {
            collided = true; // Marcar como colisionado para evitar múltiples colisiones
            animator.SetTrigger("PlayAnimation"); // Activar la animación
        }
    }

    void Disappear()
    {
        // Desvanecer el objeto
        StartCoroutine(FadeOut(disappearTime));
    }

    IEnumerator FadeOut(float time)
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Color originalColor = spriteRenderer.color;
        Color transparentColor = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
        float elapsedTime = 0f;

        while (elapsedTime < time)
        {
            // Interpolar el color entre el color original y transparente
            spriteRenderer.color = Color.Lerp(originalColor, transparentColor, elapsedTime / time);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Asegurarse de que el color sea completamente transparente al final
        spriteRenderer.color = transparentColor;

        // Desactivar el objeto o destruirlo después de desaparecer
        gameObject.SetActive(false);
        // O puedes usar Destroy(gameObject); para destruirlo permanentemente
    }
}
