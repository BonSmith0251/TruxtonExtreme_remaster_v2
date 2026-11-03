namespace UnityEngine.Rendering.UI;

[ExecuteAlways]
[Token(Token = "0x20002F8")]
public class UIFoldout : Toggle
{
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x4000DB0")]
	public GameObject content; //Field offset: 0x128
	[FieldOffset(Offset = "0x130")]
	[Token(Token = "0x4000DB1")]
	public GameObject arrowOpened; //Field offset: 0x130
	[FieldOffset(Offset = "0x138")]
	[Token(Token = "0x4000DB2")]
	public GameObject arrowClosed; //Field offset: 0x138

	[Address(RVA = "0x2CBFE20", Offset = "0x2CBF220", Length = "0x636")]
	[Token(Token = "0x6001511")]
	public UIFoldout() { }

	[Address(RVA = "0x2CBFB30", Offset = "0x2CBEF30", Length = "0x12")]
	[Token(Token = "0x600150E")]
	private void OnValidate() { }

	[Address(RVA = "0x2CBFB50", Offset = "0x2CBEF50", Length = "0xB")]
	[Token(Token = "0x600150F")]
	public void SetState(bool state) { }

	[Address(RVA = "0x2CBFB60", Offset = "0x2CBEF60", Length = "0x1F8")]
	[Token(Token = "0x6001510")]
	public void SetState(bool state, bool rebuildLayout) { }

	[Address(RVA = "0x2CBFD60", Offset = "0x2CBF160", Length = "0xBB")]
	[Token(Token = "0x600150D")]
	protected virtual void Start() { }

}

