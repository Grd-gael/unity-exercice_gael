using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float m_vitesse = 20f;
    [SerializeField] private float m_dureeDeVie = 5f;

    [SerializeField] private GameObject platformPrefab;

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
        if (collision.gameObject.CompareTag("Cible") == true)
        {
            Vector3 spawnPosition = new Vector3(-2.54f, 0f, 2.48f);
            Quaternion spawnRotation = Quaternion.identity;

            Instantiate(platformPrefab, spawnPosition, spawnRotation);

        }
        Destroy(gameObject);
    }
}
