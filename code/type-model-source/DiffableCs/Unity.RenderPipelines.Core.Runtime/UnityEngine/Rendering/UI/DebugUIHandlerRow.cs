namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002EC")]
public class DebugUIHandlerRow : DebugUIHandlerFoldout
{
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000D7B")]
	private float m_Timer; //Field offset: 0x80

	[Address(RVA = "0x2CACF30", Offset = "0x2CAC330", Length = "0x1F")]
	[Token(Token = "0x6001495")]
	public DebugUIHandlerRow() { }

	[Address(RVA = "0x2CB4B10", Offset = "0x2CB3F10", Length = "0x12D")]
	[Token(Token = "0x6001491")]
	private GameObject GetChild(int index) { }

	[Address(RVA = "0x2CB4C40", Offset = "0x2CB4040", Length = "0x149")]
	[Token(Token = "0x6001493")]
	private bool IsActive(Table table, int index, GameObject child) { }

	[Address(RVA = "0x5ABEE0", Offset = "0x5AB2E0", Length = "0xB")]
	[Token(Token = "0x6001490")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2CB4D90", Offset = "0x2CB4190", Length = "0x82")]
	[Token(Token = "0x6001492")]
	private bool TryGetChild(int index, out GameObject child) { }

	[Address(RVA = "0x2CB4E20", Offset = "0x2CB4220", Length = "0x7FE")]
	[Token(Token = "0x6001494")]
	protected void Update() { }

}

