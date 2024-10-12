using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

//anim perso
Animation animations;

//vitesse
public float walkSpeed;
public float runSpeed;
public float turnSpeed;

//inputs
public string inputFront;
public string inputBack;
public string inputLeft;
public string inputRight;

public Vector3 jumpSpeed;
CapsuleCollider playerCollider;

    // Use for init
    void Start()
    animations = gameObjet.GetComponent<Animation>();
    playerCollider = gameObjet.GetComponent<CapsuleCollider>();
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
