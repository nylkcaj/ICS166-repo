using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow : MonoBehaviour
{
    //example orders with amount of an ingred.
    public static int orderValue = 11441111; 
    public static int plateValue = 0; //empty plate that needs to match with orderValue
    public static float[] orderTimer = { 30, 30, 30 };

    //public static int plateNum = 0;
    //public static float plateXpos = 0;

    //public Transform plateSelector;

    /*void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            plateNum += 1;
            plateXpos += 2;

            if (plateNum > 2)
            {
                plateNum = 0;
                plateXpos = 0;
            }
        }

        orderTimer[0] -= Time.deltaTime;
        orderTimer[1] -= Time.deltaTime;
        orderTimer[2] -= Time.deltaTime;

        plateSelector.transform.position = new Vector3(plateXpos, 0, 0);
    }*/
}
