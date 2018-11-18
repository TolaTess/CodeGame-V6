using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManagerf : MonoBehaviour {
    
    public List<string> objList = new List<string>();
    private static string start = "public class ClassNameHolder{";
    private static string M1 = "public String deleteString(String string){";
    private static string B1 = "int take = 7;\nif(deleteStr.length() < take)\n return deleteStr;\n String n = deleteStr.subString(2,7);\nif(n.equals(string)){return deleteStr.charAt(0) + deleteStr.subbstring(7);}\n return deleteStr;}\n";
    private static string M2 = "public String reverse(String string){";
    private static string B2 = "for(int i = reverseString.length()-1>=0; i--)\n reverseString= reverseString + reverseString.charAt(i);}";
    private static string M3 = "public String notString(String string){";
    private static string B3 = "if(notString.length()>=3 && notString.substring(0,3).equals(java)){\n return notString;} return java + notString;}";
 
    private static string BM1 = "public boolean 3or5 (int n) {";
    private static string BB1 = "if(n. > 0 && (n % 3 == 0) || (n % 5 ==0))\n{return true;\n} return faslse;\n}";
    private static string BM2 = "public boolean boolIsValid(String color, int size) {";
    private static string BB2 = "if(color.equals(“Red”) && size >= 10 && size <= 100)\n { return true; \n} return false;}";

    private static string IM1 = "public int sumInteger(int a, int b){";
    private static string IB1 = "if(a == b){return(a + b)*2;}\n return a + b;\n";
    private static string IM2 = "public int intMax(int a, int b, int c){";
    private static string IB2 = "if(a > b) {\n max = a; } max = a;\n} else {\n max = b;} if(c > max){\n max = c;}\n return max;}";
    private static string end = "}";

    public static string[] obj = { start, M1, B1, M2, B2, M3, B3, BM1, BB1, BM2, BB2, IM1, IB1, IM2, IB2, end};

	// Use this for initialization
	void Start () {
        objList.AddRange(obj);
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
