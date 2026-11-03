namespace UnityEngine;

[Token(Token = "0x2000003")]
public enum AudioDataLoadState : int
{
	Unloaded = 0,
	Loading = 1,
	Loaded = 2,
	Failed = 3,
}

