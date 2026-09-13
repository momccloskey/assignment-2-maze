using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        public float playerSpeed = 5f;
    }

    // Update is called once per frame
    public void Update()
    {
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");

    Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

    transform.Translate(direction * speed * Time.deltaTime);
    }
}
