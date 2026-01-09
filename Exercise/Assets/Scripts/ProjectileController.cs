using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float m_vitesse = 20f;
    [SerializeField] private float m_dureeDeVie = 5f;

    [SerializeField] private GameObject m_player;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        if (rb != null)
        {
            rb.linearVelocity = transform.forward * m_vitesse;
        }

        Destroy(gameObject, m_dureeDeVie);
    }

    private void OnCollisionEnter(Collision collision)
    {
        m_player.transform.position = transform.position;
        Destroy(gameObject);
    }
}
