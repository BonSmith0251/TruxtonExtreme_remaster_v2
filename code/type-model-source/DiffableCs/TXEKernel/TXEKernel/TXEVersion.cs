namespace TXEKernel;

[CreateAssetMenu(menuName = "KANAI/TXEVersion")]
[Token(Token = "0x20000F9")]
public class TXEVersion : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[Readonly]
	[SerializeField]
	[Token(Token = "0x4000507")]
	public string dateString; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000508")]
	public int majorVersion; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000509")]
	public int minorVersion; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x400050A")]
	public int tinyVersion; //Field offset: 0x28

	[Address(RVA = "0x2718BB0", Offset = "0x2717FB0", Length = "0x9E")]
	[Token(Token = "0x6000731")]
	public TXEVersion() { }

	[Address(RVA = "0x2718B70", Offset = "0x2717F70", Length = "0x3D")]
	[Token(Token = "0x600072F")]
	public string GetVersionText() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000730")]
	public void UpdateCreateDate() { }

}

