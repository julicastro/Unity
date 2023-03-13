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

    public int myInt = 1; 
    public float myFirstFloat = 0.0f;
    public string mySting = "Hola";
    public bool myBoolean = true;

    public Vector2 myDesiredCord2;
    public Vector3 myDesiredCord3;
    public GameObject myGameObject;
    
    public float myTime = 0;
    public float myTestFloat;
    public float mySpeed;

    public int myIntMin, myIntMax;

    public int intMin, intMax;
    public float myFloat;
    public float speed;
    public bool limitReached = true;
    public GameObject myQuad;
    public GameObject phineas;
    public Vector2 position;

    public GameObject myParentObject;

    void Start() {
        myQuad.transform.position = new Vector2(intMin, myQuad.transform.position.y);
        phineas.transform.position = new Vector2(intMin, phineas.transform.position.y);
        
    }


    void Update() {
        // myTime = myTime + Time.deltaTime;
        // print(Random.Range(1f, 10f)); // inclusive & exclusive
        // myTestFloat = Mathf.MoveTowards(myTestFloat, myIntMax, mySpeed * Time.deltaTime); // contador: arranca del min, va a la velocidad de mySpeed y llega hasta el max
        // si pongo speed 2 va a ir al doble
        // myFunction();
        // myFunctionPhineas();
        // print(myParentObject.transform.childCount);
        myForLoop1();
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
    public void myFunctionPhineas() {
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
        position = new Vector2(myFloat, phineas.transform.position.y);
        phineas.transform.position = position;
    }
    public void myForLoop1() {
        for (int i = 0; i < myParentObject.transform.childCount; i++) {
            int id = myParentObject.transform.GetChild(i).transform.GetComponent<ObjectInfo>().myID;
            myParentObject.transform.GetChild(i).transform.GetComponent<ObjectInfo>().myID = i * 3;
            myParentObject.transform.GetChild(i).transform.GetComponent<ObjectInfo>().myName = ("Child + " + id).ToString();
            myParentObject.transform.GetChild(i).transform.GetComponent<ObjectInfo>().attack = i + 100;


        }
    }







}