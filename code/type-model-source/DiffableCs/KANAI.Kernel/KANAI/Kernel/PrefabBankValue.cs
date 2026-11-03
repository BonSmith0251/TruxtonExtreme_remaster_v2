namespace KANAI.Kernel;

[Token(Token = "0x2000022")]
public struct PrefabBankValue
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000095")]
	public int createCount; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000096")]
	public GameObject baseObject; //Field offset: 0x8

	[Token(Token = "0x1700001D")]
	public string name
	{
		[Address(RVA = "0x1DED9C0", Offset = "0x1DECDC0", Length = "0x1D")]
		[Token(Token = "0x600012B")]
		 get { } //Length: 29
	}

	[Address(RVA = "0x1DED9C0", Offset = "0x1DECDC0", Length = "0x1D")]
	[Token(Token = "0x600012B")]
	public string get_name() { }

}

