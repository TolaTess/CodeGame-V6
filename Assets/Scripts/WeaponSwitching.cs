using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour {
    //index 0 will be selected first
    public int selectWeapon = 0;
    // Use this for initialization
    void Start()
    {
        SelectDataType();

    }

    // Update is called once per frame
    void Update()
    {

        int prevSelectedWeapon = selectWeapon;
        //using Mouse Scrollwheel
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (selectWeapon >= transform.childCount - 1)
                selectWeapon = 0;
            else
                selectWeapon++;
        }
        //reverse
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (selectWeapon <= 0)
                selectWeapon = transform.childCount - 1;
            else
                selectWeapon--;
        }

        if (prevSelectedWeapon != selectWeapon)
        {
            SelectDataType();
        }

    }

    void SelectDataType()
    {
        int i = 0;
        foreach (Transform datatype in transform)
        {
            if (i == selectWeapon)

                datatype.gameObject.SetActive(true);

            else

                datatype.gameObject.SetActive(false);

            i++;

        }
    }
}
