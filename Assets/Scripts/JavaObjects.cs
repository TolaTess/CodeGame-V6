using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JavaObjects : MonoBehaviour {

    /// <summary>
    /// Datatype objects destription for UI display
    /// </summary>
    public static string M1 = "\nProblem 1: \nModify: public\nDataType: String\nName: deleteString\nParameters: 1";
    public static string F1 = "\nProblem 1:\nModify: private\nDataType: String\nName: deleteStr";
    public static string B1 = "\nProblem 1:\nint take = 7;\nif(deleteStr.length() < take)\n return deleteStr;\n String n = deleteStr.subString(2,7);\nif(n.equals(string)){return deleteStr.charAt(0) + deleteStr.subbstring(7);}\n return deleteStr;";
    public static string M2 = "\nProblem 2:\nModify: public\nDataType: String\nName: reverse\nParameters: 1";
    public static string F2 = "\nProblem 2:\nModify: private\nDataType: String\nName: reverseString";
    public static string B2 = "\nProblem 2:\nfor(int i = reverseString.length()-1>=0; i--)\n reverseString= reverseString + reverseString.charAt(i);";
    public static string M3 = "\nProblem 3:\nModify: public\nDataType: String\nName: notString\nParameters: 1";
    public static string F3 = "\nProblem 3:\nModify: private\nDataType: String\nName: notString";
    public static string B3 = "\nProblem 3:\nif(notString.length()>=3 && notString.substring(0,3).equals(java)){\n return notString;} return java + notString;";

    public static string IM1 = "\nModify: public\nDataType: Integer\nName: sumInteger\nParameters: 2";
    public static string IF1 = "\nModify: private\nDataType: int\nName: a";
    public static string IF2 = "\nModify: private\nDataType: int\nName: b";
    public static string IB1 = "\nif(a == b){return(a + b)*2;}\n return a + b;";
    public static string IM2 = "\nModify: public\nDataType: Integer\nName: reverse\nParameters: 3";
    public static string IF3 = "\nModify: private\nDataType: int\nName: a";
    public static string IF4 = "\nModify: private\nDataType: int\nName: b";
    public static string IF5 = "\nModify: private\nDataType: int\nName: c";
    public static string IB2 = "\nif(a > b) {\n max = a; } max = a;\n} else {\n max = b;} \nif(c > max){\n max = c;}\n return max;}";

    public static string BM1 = "\nModify: public\nDataType: Boolean\nName: 3or5\nParameters: 2";
    public static string BF1 = "\nModify: private\nDataType: int\nName: n";
    public static string BB1 = "\nif(n. > 0 && (n % 3 == 0) || (n % 5 ==0))\n{return true;\n} return false;";
    public static string BM2 = "\nModify: public\nDataType: Boolean\nName: boolIsValid\nParameters: 2";
    public static string BF2 = "\nModify: private\nDataType: String\nName: color";
    public static string BF3 = "\nModify: private\nDataType: int\nName: size";
    public static string BB2 = "\nif(color.equals(“Red”) && size >= 10 && size <= 100)\n { return true; \n} return false;";
}
