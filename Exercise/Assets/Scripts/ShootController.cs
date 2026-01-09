using UnityEngine;
using UnityEngine.InputSystem;


public class ShootController : MonoBehaviour
{
    [SerializeField] private GameObject m_projectile;
    [SerializeField] private GameObject m_player;
    private InputAction m_InteractAction;

    private void Start()
    {
        m_InteractAction = InputSystem.actions.FindAction("Shoot");
    }

    private void Update()
    {
        if (m_InteractAction.triggered)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (m_projectile != null)
        {
            Vector3 position = m_player.transform.position + m_player.transform.forward * 1.5f + Vector3.up * 1.0f;
            GameObject projectileInstance = Instantiate(m_projectile, position, m_player.transform.rotation);
        }
    }



}