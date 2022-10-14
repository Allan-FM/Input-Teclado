using UnityEngine;

public class InputTeclado : MonoBehaviour
{
    private float speed = 2.5f;
    private void Update()
    {
        /*
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        */
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal * speed * Time.deltaTime, 
                                        vertical * speed * Time.deltaTime, 0));

    }
}
