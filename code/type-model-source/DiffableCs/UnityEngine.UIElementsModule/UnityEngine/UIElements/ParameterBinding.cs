namespace UnityEngine.UIElements;

[Token(Token = "0x2000251")]
public struct ParameterBinding
{
	[DontCreateProperty]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000903")]
	private int m_Index; //Field offset: 0x0
	[DontCreateProperty]
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000904")]
	private string m_Name; //Field offset: 0x8

	[CreateProperty]
	[Token(Token = "0x170002E7")]
	public int index
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000FEB")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000FEC")]
		 set { } //Length: 3
	}

	[CreateProperty]
	[Token(Token = "0x170002E8")]
	public string name
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000FED")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x6000FEE")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000FEB")]
	public int get_index() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000FED")]
	public string get_name() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000FEC")]
	public void set_index(int value) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[Token(Token = "0x6000FEE")]
	public void set_name(string value) { }

}

