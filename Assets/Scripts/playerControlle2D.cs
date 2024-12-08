using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class playerControlle2D : MonoBehaviour
{

    //referencias a las antiguas imputs
    float hornInput;
    float verInput;

    //referencias generales 
    [SerializeField] Rigidbody2D playerRb; //Ref al rigidbody del player

    [Header("movement Parameters")]
    public float speed;

    [Header("jump Parameters")]
    public float jumpforce;
    [SerializeField] bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
