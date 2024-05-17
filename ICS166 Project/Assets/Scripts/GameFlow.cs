using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    //example orders with amount of an ingred.

    public static int[] orderValue = { 11441111, 11800000, 10443000 }; 
    public static int[] plateValue = { 0, 0, 0 }; //empty plate that needs to match with orderValue
    public static float[] orderTimer = { 30, 30, 30 };


    public static int plateNum = 0;
    public static float plateXpos = -200;

    public Transform plateSelector;

    private Vector3 initialPosition;

    void Start()
    {
        // Store the initial position of plateSelector
        initialPosition = plateSelector.transform.position;
        // Set the initial position of plateXpos based on the initial position of plateSelector
        plateXpos = initialPosition.x;
    }

    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            plateNum += 1;
            plateXpos += 200;

            if (plateNum > 2)
            {
                plateNum = 0;
                plateXpos = -200;
            }

            plateSelector.transform.position = new Vector3(plateXpos, initialPosition.y, initialPosition.z);
        }

        orderTimer[0] -= Time.deltaTime;
        orderTimer[1] -= Time.deltaTime;
        orderTimer[2] -= Time.deltaTime;

        //plateSelector.transform.position = new Vector3(plateXpos, 0, 0);
    }
}
