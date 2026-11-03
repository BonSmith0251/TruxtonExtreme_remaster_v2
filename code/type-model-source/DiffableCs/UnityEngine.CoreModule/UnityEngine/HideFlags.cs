namespace UnityEngine;

[Flags]
[Token(Token = "0x20001CB")]
public enum HideFlags : int
{
	None = 0,
	HideInHierarchy = 1,
	HideInInspector = 2,
	DontSaveInEditor = 4,
	NotEditable = 8,
	DontSaveInBuild = 16,
	DontUnloadUnusedAsset = 32,
	DontSave = 52,
	HideAndDontSave = 61,
}

