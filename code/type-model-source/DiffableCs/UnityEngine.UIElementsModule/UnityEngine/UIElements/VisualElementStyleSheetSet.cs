namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000557")]
public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40011AC")]
	private readonly VisualElement m_Element; //Field offset: 0x0

	[Token(Token = "0x17000A1A")]
	public int count
	{
		[Address(RVA = "0x32E8080", Offset = "0x32E7480", Length = "0x54")]
		[Token(Token = "0x60026FD")]
		 get { } //Length: 84
	}

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60026F9")]
	internal VisualElementStyleSheetSet(VisualElement element) { }

	[Address(RVA = "0x32E7C60", Offset = "0x32E7060", Length = "0x69")]
	[Token(Token = "0x60026FA")]
	public void Add(StyleSheet styleSheet) { }

	[Address(RVA = "0x32E7D60", Offset = "0x32E7160", Length = "0xD")]
	[Token(Token = "0x60026FE")]
	public override bool Equals(VisualElementStyleSheetSet other) { }

	[Address(RVA = "0x32E7CD0", Offset = "0x32E70D0", Length = "0x86")]
	[Token(Token = "0x60026FF")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x32E8080", Offset = "0x32E7480", Length = "0x54")]
	[Token(Token = "0x60026FD")]
	public int get_count() { }

	[Address(RVA = "0x326C2F0", Offset = "0x326B6F0", Length = "0x2C")]
	[Token(Token = "0x6002700")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x32E7D70", Offset = "0x32E7170", Length = "0x1AD")]
	[Token(Token = "0x60026FB")]
	public void Insert(int index, StyleSheet styleSheet) { }

	[Address(RVA = "0x32E7F20", Offset = "0x32E7320", Length = "0x156")]
	[Token(Token = "0x60026FC")]
	public bool Remove(StyleSheet styleSheet) { }

}

