namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002D0")]
public class DebugUIPrefabBundle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000D17")]
	public string type; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000D18")]
	public RectTransform prefab; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60013DB")]
	public DebugUIPrefabBundle() { }

}

