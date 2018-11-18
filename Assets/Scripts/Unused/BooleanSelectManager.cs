using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BooleanSelectManager : MonoBehaviour {
    public GameObject selectedGameObject;
    public Text dtext;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {

            GameObject hitObject = hitInfo.transform.parent.gameObject;

            if (hitObject != null)
            {

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
                            dtext.text = JavaObjects.BM1;

                            break;
                        case "Field1":
                            dtext.text = JavaObjects.BF1;
                            break;
                        case "Body1":
                            if (hitObject.CompareTag("Fragment"))
                            {
                                dtext.text = "Look for\nDataType String";
                            }
                            break;
                        case "Body1(Clone)":
                            dtext.text = JavaObjects.BB1;
                            break;
                        case "Method2":
                            if (hitObject.CompareTag("Fragment2"))
                            {
                                dtext.text = "It not me";
                            }
                            break;
                        case "Method2(Clone)":
                            dtext.text = JavaObjects.BM2;
                            break;
                        case "Field2":
                            if (hitObject.CompareTag("Fragment2"))
                            {
                                dtext.text = "Hint,\nI am Colour of String";
                            }
                            break;
                        case "Field2(Clone)":
                            dtext.text = JavaObjects.BF2;
                            break;
                        case "Body2":
                            if (hitObject.CompareTag("Fragment2"))
                            {
                                dtext.text = "Try again";
                            }
                            break;
                        case "Body2(Clone)":
                            dtext.text = JavaObjects.BF3;
                            break;
                        case "Method3":
                            if (hitObject.CompareTag("Fragment3"))
                            {
                                dtext.text = "Try again,\nKeeping searching";
                            }
                            break;
                        case "Method3(Clone)":
                            dtext.text = JavaObjects.BB2;
                            break;
                        case "Field3":
                            if (hitObject.CompareTag("Fragment3"))
                            {
                                dtext.text = "You are nearly there";
                            }
                            break;
                        case "Field3(Clone)":
                            dtext.text = JavaObjects.BF3;
                            break;
                        case "Body3":
                            if (hitObject.CompareTag("Fragment3"))
                            {
                                dtext.text = "Look for keyword\nModify";
                            }
                            break;
                        case "Body3(Clone)":
                            dtext.text = JavaObjects.BB2;
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
                    m.color = Color.green;
                    r.material = m;
                }
            }
        }
    }

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
