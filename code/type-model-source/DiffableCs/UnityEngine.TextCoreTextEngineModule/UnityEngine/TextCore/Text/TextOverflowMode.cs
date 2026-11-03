namespace UnityEngine.TextCore.Text;

[Token(Token = "0x200004E")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal enum TextOverflowMode : int
{
	Overflow = 0,
	Ellipsis = 1,
	Masking = 2,
	Truncate = 3,
	ScrollRect = 4,
	Linked = 6,
}

