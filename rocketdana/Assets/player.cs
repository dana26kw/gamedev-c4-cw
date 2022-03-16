using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource rocketAudioSource;
    [SerializeField] AudioClip mainEngine;

    Rigidbody rocketRB;

    void Start()
    {
        rocketRB = GetComponent<Rigidbody>();
        rocketRB = GetComponent<Rigidbody>();
        rocketAudioSource = GetComponent<AudioSource>();
    }

   
    
   
    void Rotate()
    {
        rocketRB.freezeRotation = true; //this says that we will take manual control of the rotation
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward);
        }

        else if (Input.GetKey(KeyCode.D))

        {
            transform.Rotate(-Vector3.forward);
        }
        rocketRB.freezeRotation = false;


    }



    

    void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            print("Thrusting!");
            rocketRB.AddRelativeForce(Vector3.up * 60);
            if (!rocketAudioSource.isPlaying)
            {
                rocketAudioSource.PlayOneShot(mainEngine);
            }
        }
        else
        {
            rocketAudioSource.Stop();
        }
    }


    // Update is called once per frame
    void Update()
    {

        Thrust();
        Rotate();

    }
}