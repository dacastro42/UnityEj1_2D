using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UIElements;

public class ObjectRecolected : MonoBehaviour
{
    public int scoreValue = 10; // Valor de puntuación que otorga el objeto recolectable
    public AudioSource audioSource; 
    public AudioClip audioClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        
    }
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.Stop();
            audioSource.clip = audioClip;
            audioSource.Play();
            GetComponent<SpriteRenderer>().enabled = false; // Oculta el objeto recolectable
            GetComponent<Collider2D>().enabled = false; // Desactiva el collider para evitar múltiples colisiones

            // Aquí puedes agregar la lógica para cuando el jugador recolecta el objeto
            Debug.Log("Objeto recolectado por el jugador");
            GameManager.Instance.AddScore(scoreValue);
            // Por ejemplo, puedes destruir el objeto recolectable
            Destroy(gameObject, 4f);
        }
    }


}
