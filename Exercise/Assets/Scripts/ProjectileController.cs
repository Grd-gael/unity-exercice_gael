using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float vitesse = 20f;
    [SerializeField] private float dureeDeVie = 5f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * vitesse;
        }

        Destroy(gameObject, dureeDeVie);
    }

    private void OnCollisionEnter(Collision collision)
    {

        Destroy(gameObject);
    }
}
