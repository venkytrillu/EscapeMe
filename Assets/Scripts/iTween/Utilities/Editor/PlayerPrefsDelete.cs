using UnityEngine;
using UnityEditor;

public class PlayerPrefsDelete : EditorWindow
{

	[MenuItem ("EditorTool/PlayerPrefs/Delete %q")]
	public static void DeletePrefs ()
	{
        if (EditorUtility.DisplayDialog("EditorTool", "Are you sure? Do you wanna delete playerprefs", "Yes","No"))
        {
            PlayerPrefs.DeleteAll();
            EditorUtility.DisplayDialog("EditorTool", "PlayerPrefs deleted successfully", "Ok");
        }
	}

}
