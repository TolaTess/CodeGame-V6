using UnityEngine;

public class CharacterSwitching : MonoBehaviour {

    //index 0 will be selected first
    public int selectCharacter = 0;
	

	void Start () {
        SelectPlayer();
		
	}

	/// <summary>
    /// use keycode to change characters
    /// </summary>
	void Update () {

        int prevSeletedDT = selectCharacter;


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectCharacter = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            selectCharacter = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && transform.childCount >= 3)
        {
            selectCharacter = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && transform.childCount >= 4)
        {
            selectCharacter = 3;
        }

        if (prevSeletedDT != selectCharacter)
        {
            SelectPlayer();
        }
		
	}

    /// <summary>
    /// Selects the player method set iterates through characters and set true if selected.
    /// </summary>
    void SelectPlayer()
    {
        int i = 0;
        foreach (Transform datatype in transform)
        {
            if (i == selectCharacter)

                datatype.gameObject.SetActive(true);
            
            else 

                datatype.gameObject.SetActive(false);
            
            i++;

        }
    }
}
