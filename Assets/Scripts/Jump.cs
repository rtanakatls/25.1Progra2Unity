using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float jumpForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this);
        GameManager.Instance.GameOver();
    }
}
