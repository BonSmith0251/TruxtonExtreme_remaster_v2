namespace UnityEngine.Analytics;

[Flags]
[Token(Token = "0x2000331")]
public enum SendEventOptions : int
{
	kAppendNone = 0,
	kAppendBuildGuid = 1,
	kAppendBuildTarget = 2,
}

