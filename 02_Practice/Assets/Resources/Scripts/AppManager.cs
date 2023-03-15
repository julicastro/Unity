using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{

    // variables used for functionality
    public int[] givenArray = new int[100];
    public int giverNumber;
    public bool funtion1Var;
    public bool funtion2Var;
    public List<int> repassingNumbers = new List<int>();
    public bool passedNumbers;

    // variables needed to draw the array
    public string drawingHelper;
    public int columns;
    public int rows;

    public bool startDrawing;

    // variables needer for UI
    public Text arrayText;


    void Start()
    {
        for (int i = 0; i < 100; i++) {
            givenArray[i] = i + 1;
        }
    }

    void Update()
    {
        if (startDrawing == true) {
            startDrawingMyArray();
            startDrawing = false;
        }
        if (funtion1Var == true) {
            function1();
            funtion1Var = false;
        }
        if (funtion2Var == true) {
            function2();
            funtion2Var = false;
        }
    }

    public void startDrawingMyArray() {
        for (int i = 0; i < columns; i++) {
            for (int j = 0; j < rows; j++) {
                if (givenArray[i * columns + j] > 10) {
                    drawingHelper = drawingHelper + givenArray[i + columns + j] + " ";
                } else if (givenArray[i * columns + j] < 10) {
                    drawingHelper = drawingHelper + givenArray[i + columns + j] + "     ";
                }
            }
            drawingHelper = drawingHelper + "\n";
        }
        arrayText.text = arrayText.text + "\n" + drawingHelper;
    }

    public void function1() {
        arrayText.text = "";
        for (int i = 0; i < givenArray.Length; i++) {
            for (int j = 0; j < givenArray.Length; j++) {
                for (int p = 0; p < repassingNumbers.Count; p++) {
                    if (repassingNumbers[p] == givenArray[i] || repassingNumbers[p] == givenArray[j]) {
                        passedNumbers = true;
                    }
                }
                if (giverNumber == givenArray[i] + givenArray[j] && passedNumbers == false && givenArray[i] != givenArray[j]) {
                    arrayText.text = arrayText.text + "\n" + "Given number found by adding " 
                        + givenArray[i] + " and " + givenArray[j] + ".";

                    repassingNumbers.Add(givenArray[i]);
                    repassingNumbers.Add(givenArray[j]);
                }
                passedNumbers = false;
            }
        }
        repassingNumbers.Clear();
    }

    public void function2() {
        arrayText.text = "";
        for (int i = 0; i < givenArray.Length; i++) {
            for (int j = 0; j < givenArray.Length; j++) {
                for (int k = 0; k < givenArray.Length; k++) {


                    for (int p = 0; p < repassingNumbers.Count; p++) {
                        if (repassingNumbers[p] == givenArray[i] 
                            || repassingNumbers[p] == givenArray[j] 
                            || repassingNumbers[k] == givenArray[i] 
                            || repassingNumbers[k] == givenArray[j]) {
                            passedNumbers = true;
                        }
                    }
                    if (giverNumber == givenArray[i] + givenArray[j] + givenArray[k] 
                        && passedNumbers == false 
                        && givenArray[i] != givenArray[j] 
                        && givenArray[i] != givenArray[k] 
                        && givenArray[k] != givenArray[j]) {
                        arrayText.text = arrayText.text + "\n" + "Given number found by adding "
                            + givenArray[i] + " and " + givenArray[j] + " and " + givenArray[k] + ".";

                        repassingNumbers.Add(givenArray[i]);
                        repassingNumbers.Add(givenArray[j]);
                    }
                    passedNumbers = false;
                }
            }
        }
        repassingNumbers.Clear();
    }



}
