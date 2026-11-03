namespace UnityEngine.Video;

[Obsolete("VideoTimeSource is deprecated. Use TimeUpdateMode instead. (UnityUpgradable) -> VideoTimeUpdateMode")]
[RequiredByNativeCode]
[Token(Token = "0x2000007")]
public enum VideoTimeSource : int
{
	AudioDSPTimeSource = 0,
	GameTimeSource = 1,
}

