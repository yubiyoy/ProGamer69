// Description : w_Version
#if (UNITY_EDITOR)
using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Linq;
using UnityEngine.SceneManagement;


public class w_Version : EditorWindow
{
	private Vector2 				scrollPosAll;
    private Vector2                 scrollPosSection;


    [MenuItem("Tools/AP/Other/Version")]
	public static void ShowWindow()
	{
		//Show existing window instance. If one doesn't exist, make one.
        EditorWindow.GetWindow(typeof(w_Version));
	}

	private Texture2D MakeTex(int width, int height, Color col) {						// use to change the GUIStyle
		Color[] pix = new Color[width * height];
		for (int i = 0; i < pix.Length; ++i) {
			pix[i] = col;
		}
		Texture2D result = new Texture2D(width, height);
		result.SetPixels(pix);
		result.Apply();
		return result;
	}


	public string[] 			listItemType = new string[]{};

	public List<string> 		_test = new List<string>(); 
	public int 					page = 0;
	public int 					numberOfIndexInAPage = 50;
	public int 					seachSpecificID = 0;


	public Texture2D eye;
    public Texture2D currentItemDisplay;
    public int intcurrentItemDisplay = 0;
    public bool b_UpdateProcessDone = false;
    public bool b_AllowUpdateScene = false;

    public windowMethods _windowMethods;

	void OnEnable () {
        _windowMethods = new windowMethods();

        if (!EditorPrefs.HasKey("AP_DarkIntensity"))
            EditorPrefs.SetFloat("AP_DarkIntensity", .4f);
	}


	void OnGUI()
	{
		//--> Scrollview
		scrollPosAll = EditorGUILayout.BeginScrollView(scrollPosAll);

		EditorGUILayout.HelpBox("First Person Narrative Adventures + Complete Puzzle Engine:" +
			    "\nversion 2020.1.0f1 (update 1)" +
				"\nImprove gamepad integration", MessageType.Info);

		EditorGUILayout.HelpBox("First Person Narrative Adventures + Complete Puzzle Engine:" +
				"\nversion 2020.1.0f1", MessageType.Info);


		EditorGUILayout.HelpBox("First Person Narrative Adventures + Complete Puzzle Engine:" +
            "\nversion 2019.3.0 (Pro Skin Update)",MessageType.Info);


      

		
        EditorGUILayout.EndScrollView ();
	}

  

}
#endif
