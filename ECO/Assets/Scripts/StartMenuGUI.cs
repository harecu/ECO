using UnityEngine;
using System.Collections;

public class StartMenuGUI : MonoBehaviour {
	LanguageManager langManager;
	public GUISkin mainGUIskin = null;

	void Start () {
		langManager = LanguageManager.Instance;

		string systemLang = langManager.GetSystemLanguage();
		if(langManager.IsLanguageSupported(systemLang))
			langManager.SetDefaultLanguage(systemLang);
	}

	void OnGUI () {
		if(mainGUIskin != null)
			GUI.skin = mainGUIskin;

		GUI.Label(new Rect(((Screen.width-100) / 2),10,100,75), langManager.GetTextValue("StartMenu.Title"));
		GUI.Label(new Rect(((Screen.width-100) / 2),10,100,175), langManager.GetTextValue("StartMenu.Description"));
	}
}
