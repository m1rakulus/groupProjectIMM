using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenGithub()
	{
#if !UNITY_EDITOR
		openWindow("https://github.com/m1rakulus/groupProjectIMM");
#endif
    }

    [DllImport("__Internal")]
	private static extern void openWindow(string url);

}