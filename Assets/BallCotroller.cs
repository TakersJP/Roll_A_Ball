using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
public Rigidbody sphereRigidbody;
public float ballSpeed = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Calling the Start Method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; //initialize the input vector

        if (Input.GetKey(KeyCode.W)) {
            inputVector += Vector2.up; //iv = iv+up
        }

        if (Input.GetKey(KeyCode.S)) {
           inputVector += Vector2.down; //iv = iv+down
        }

        if (Input.GetKey(KeyCode.D)) {
            inputVector += Vector2.right; //iv = iv+right
        }

        if (Input.GetKey(KeyCode.A)) {
            inputVector += Vector2.left; //iv = iv+left
        }
        Debug.Log("Resultant Vector: " + inputVector);

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y); //assignining the input’s X, Y, Z to each axis of the new vector
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed); //adds force to the ball
    }
}

