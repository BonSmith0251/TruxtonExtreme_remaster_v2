namespace UnityEngine.Timeline;

[Flags]
[Token(Token = "0x2000059")]
public enum NotificationFlags : short
{
	TriggerInEditMode = 1,
	Retroactive = 2,
	TriggerOnce = 4,
}

