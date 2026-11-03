namespace UnityEngine.UIElements;

[Token(Token = "0x200051D")]
public class UxmlEnumeration : UxmlTypeRestriction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010C6")]
	private List<String> m_Values; //Field offset: 0x10

	[Token(Token = "0x170009E2")]
	public IEnumerable<String> values
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x60025D4")]
		 get { } //Length: 7
		[Address(RVA = "0x32C3F50", Offset = "0x32C3350", Length = "0x55")]
		[Token(Token = "0x60025D5")]
		 set { } //Length: 85
	}

	[Address(RVA = "0x32C3ED0", Offset = "0x32C32D0", Length = "0x77")]
	[Token(Token = "0x60025D7")]
	public UxmlEnumeration() { }

	[Address(RVA = "0x32C3D70", Offset = "0x32C3170", Length = "0x153")]
	[Token(Token = "0x60025D6")]
	public virtual bool Equals(UxmlTypeRestriction other) { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x60025D4")]
	public IEnumerable<String> get_values() { }

	[Address(RVA = "0x32C3F50", Offset = "0x32C3350", Length = "0x55")]
	[Token(Token = "0x60025D5")]
	public void set_values(IEnumerable<String> value) { }

}

