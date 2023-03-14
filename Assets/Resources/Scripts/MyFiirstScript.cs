using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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

    /*
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
    */

    /* for loop */
    /*
    public GameObject myParentObject;
    public int searchingID;
    public string myString;
    public Text myText;
    */

    public GameObject myQuad;
    public int Origin, Limit;
    public GameObject instanceParentQuad;
    public float blinkTime, speed;

    void Start() {
        /*
        myQuad.transform.position = new Vector2(intMin, myQuad.transform.position.y);
        phineas.transform.position = new Vector2(intMin, phineas.transform.position.y);
        */
    }


    void Update() {
        // myTime = myTime + Time.deltaTime;
        // print(Random.Range(1f, 10f)); // inclusive & exclusive
        // myTestFloat = Mathf.MoveTowards(myTestFloat, myIntMax, mySpeed * Time.deltaTime); // contador: arranca del min, va a la velocidad de mySpeed y llega hasta el max
        // si pongo speed 2 va a ir al doble
        // myFunction();
        // myFunctionPhineas();
        // print(myParentObject.transform.childCount);
        // myForLoop1();
        // myForLoop2();
        intantiateMyQuadNow();
        blink();
    }

    /*
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
    */
    /*
    public void myForLoop2() {
        for (int i = 0; i < myParentObject.transform.childCount; i++) {
            if (searchingID == myParentObject.transform.GetChild(i).transform.GetComponent<ObjectInfo>().myID) {
                myString = "Child ID Found " + myParentObject.transform.GetChild(i).transform.GetComponent<ObjectInfo>().myID +
                    " and the name is " + myParentObject.transform.GetChild(i).transform.GetComponent<ObjectInfo>().myName;
                myText.text = myString;
            } else {
                myText.text = "not found";
            }
        }
    }
    */

    public void blink() {

        blinkTime = Mathf.MoveTowards(blinkTime, instanceParentQuad.transform.childCount, speed * Time.deltaTime);
        for (int i = 0; i < instanceParentQuad.transform.childCount; i++) {
            if (i == (int) blinkTime) {
                instanceParentQuad.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(true);
            } else if (i != (int) blinkTime) {
                instanceParentQuad.transform.GetChild(i).transform.GetChild(1).gameObject.SetActive(false);
            }
        }
        if (blinkTime >= instanceParentQuad.transform.childCount) {
            blinkTime = 0;
        }
    
    }

    public void intantiateMyQuadNow() {
        for (int i = Origin; i <= Limit; i++) {
            // distancia de 2 
            if (i % 2 == 0) {
                GameObject newQuad = Instantiate(myQuad);
                newQuad.transform.position = new Vector2(i, 0);
                newQuad.transform.SetParent(instanceParentQuad.transform);
                newQuad.transform.GetChild(1).gameObject.SetActive(false);
            }
        }
    }









}