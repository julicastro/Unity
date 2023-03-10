using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

/*
 * Integer - for counting, indexing, id
 * float - for forces, speed, acceleration, time
 * booleans - true or false
 * string - store information
 * Vector2 - to represent XY position, anything 2D related
 * Vector3 - in order to make use of formulas
 * GameObjects - Prefabs, anything that carries a component
 * 
 */
public class MyFiirstScript : MonoBehaviour {

    // public to see on unity screen
    /*
    public int myInt = 1; 
    public float myFloat = 0.0f;
    public string mySting = "Hola";
    public bool myBoolean = true;

    public Vector2 myDesiredCord2;
    public Vector3 myDesiredCord3;
    public GameObject myGameObject;
    */

    /*
    public float myTime = 0;
    public float myTestFloat;
    public float mySpeed;

    public int myIntMin, myIntMax;
    */

    public int intMin, intMax;
    public float myFloat;
    public float speed;
    public bool limitReached = true;
    public GameObject myQuad;
    public Vector2 position;

    void Start() {
        myQuad.transform.position = new Vector2(intMin, myQuad.transform.position.y);
    }


    void Update() {
        // myTime = myTime + Time.deltaTime;
        // print(Random.Range(1f, 10f)); // inclusive & exclusive
        // myTestFloat = Mathf.MoveTowards(myTestFloat, myIntMax, mySpeed * Time.deltaTime); // contador: arranca del min, va a la velocidad de mySpeed y llega hasta el max
        // si pongo speed 2 va a ir al doble
        myFunction();



    }

    public void myFunction() {
        if (limitReached) {
            myFloat = Mathf.MoveTowards(myFloat, intMax, speed * Time.deltaTime);

            if (myFloat >= intMax-0.001f) {
                limitReached = false;
            }
        } else if (!limitReached) {
            myFloat = Mathf.MoveTowards(myFloat, intMin, intMax * Time.deltaTime);

            if (myFloat <= intMin+0.001f) {
                limitReached = true;
            }
        }
        position = new Vector2(myFloat, myQuad.transform.position.y);
        myQuad.transform.position = position;
    }

}