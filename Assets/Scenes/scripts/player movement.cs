using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    void Start()
    {
        Debug.Log("maybe the script works now please god");
    }
    public float playerSpeed = 10f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0f, v);
        transform.Translate(move * playerSpeed * Time.deltaTime);
    }
}
