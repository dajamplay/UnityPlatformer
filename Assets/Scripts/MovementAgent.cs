using UnityEngine;

public class MovementAgent : MonoBehaviour
{
    private float m_Speed;
    private Vector3 m_Target;
    void Start()
    {
        m_Speed = 5f;
        m_Target = new Vector3(10f, 10f, 0);
    }

    void Update()
    {
        Vector3 direction = (m_Target - transform.position).normalized;
        Vector3 delta = direction * m_Speed;
        transform.Translate(delta);
    }
}
