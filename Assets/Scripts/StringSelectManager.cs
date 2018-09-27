using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StringSelectManager : MonoBehaviour {


    public GameObject selectedGameObject;
    private GameObject hitObject;

    public Text dtext;

   
    /// <summary>
    /// mouse position stored in ray
    /// if this information exist, info is stored in hitobbject and check is made for object
    /// to be selectable of not.
    /// different messages is displayed for different objects
    /// </summary>
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {

            hitObject = hitInfo.transform.parent.gameObject;

            if(hitObject != null){

            if (hitObject != hitObject.CompareTag("NotSelectable"))
            {
                SelectObject(hitObject);

                switch (hitObject.name)
                {
                    case "Method1":
                        if (hitObject.CompareTag("Fragment"))
                        {
                            dtext.text = "Try again";
                        }
                        break;
                    case "Method1(Clone)":
                            dtext.text = JavaObjects.M1;

                        break;
                    case "Field1":
                            dtext.text = JavaObjects.F1;
                        break;
                    case "Body1":
                        if (hitObject.CompareTag("Fragment"))
                        {
                            dtext.text = "Look for\nDataType String";
                        }
                        break;
                    case "Body1(Clone)":
                            dtext.text = JavaObjects.B1;
                        break;
                    case "Method2":
                        if (hitObject.CompareTag("Fragment2"))
                        {
                            dtext.text = "It not me";
                        }
                        break;
                    case "Method2(Clone)":
                            dtext.text = JavaObjects.M2;
                        break;
                    case "Field2":
                        if (hitObject.CompareTag("Fragment2"))
                        {
                            dtext.text = "Hint,\nI am Colour of String";
                        }
                        break;
                    case "Field2(Clone)":
                            dtext.text = JavaObjects.F2;
                        break;
                    case "Body2":
                        if (hitObject.CompareTag("Fragment2"))
                        {
                            dtext.text = "Try again";
                        }
                        break;
                    case "Body2(Clone)":
                            dtext.text = JavaObjects.B2;
                        break;
                    case "Method3":
                        if (hitObject.CompareTag("Fragment3"))
                        {
                            dtext.text = "Try again,\nKeeping searching";
                        }
                        break;
                    case "Method3(Clone)":
                            dtext.text = JavaObjects.M3;
                        break;
                    case "Field3":
                        if (hitObject.CompareTag("Fragment3"))
                        {
                            dtext.text = "You are nearly there";
                        }
                        break;
                    case "Field3(Clone)":
                            dtext.text = JavaObjects.F3;
                        break;
                    case "Body3":
                        if (hitObject.CompareTag("Fragment3"))
                        {
                            dtext.text = "Look for keyword\nModify";
                        }
                        break;
                    case "Body3(Clone)":
                            dtext.text = JavaObjects.B3;
                        break;
                    default:
                        dtext.text = "Name: " + hitObject.name;
                        break;
                }

            }
        }
        else
        {
            ClearSelection();
        }
    }
    else
    {
            Debug.Log("Not hitObject");
        }

    }

    /// <summary>
    /// check if object is selected, if not called clearselection method.
    /// if selected, turn the material into different colours
    /// </summary>
    /// <param name="obj">Object.</param>
    void SelectObject(GameObject obj)
    {
        if (selectedGameObject != null)
        {
            if (obj == selectedGameObject)
                return;

            ClearSelection();
        }

        selectedGameObject = obj;

        Renderer[] rs = selectedGameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            if (selectedGameObject == selectedGameObject.CompareTag("Fragment"))
            {
                Material m = r.material;
                m.color = Color.yellow;
                r.material = m;
            }
            else
            {
                if (selectedGameObject == selectedGameObject.CompareTag("Fragment2"))
                {
                    Material m = r.material;
                    m.color = Color.cyan;
                    r.material = m;
                }
                else
                {
                    Material m = r.material;
                    m.color = Color.red;
                    r.material = m;
                }
            }

        }
    }
    /// <summary>
    /// if object is not selected, change colour to white.
    /// </summary>
    void ClearSelection()
    {
        if (selectedGameObject == null)
            return;

        Renderer[] rs = selectedGameObject.GetComponentsInChildren<Renderer>();
        foreach (Renderer r in rs)
        {
            Material m = r.material;
            m.color = Color.white;
            r.material = m;
        }


        selectedGameObject = null;
    }
}
