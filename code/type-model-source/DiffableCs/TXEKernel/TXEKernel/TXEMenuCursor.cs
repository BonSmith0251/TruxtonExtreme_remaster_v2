namespace TXEKernel;

[Token(Token = "0x20000E2")]
public class TXEMenuCursor : MonoBehaviour
{
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000498")]
	private UIImage _cursorImage; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000499")]
	private UIBlinker uIBlinker; //Field offset: 0x28

	[Address(RVA = "0x2715A20", Offset = "0x2714E20", Length = "0x8C")]
	[Token(Token = "0x60006B9")]
	public TXEMenuCursor() { }

	[Address(RVA = "0x27158B0", Offset = "0x2714CB0", Length = "0x41")]
	[Token(Token = "0x60006B7")]
	public void SetPosition(Vector3 pos) { }

	[Address(RVA = "0x2715900", Offset = "0x2714D00", Length = "0x115")]
	[Token(Token = "0x60006B8")]
	private void Update() { }

}

