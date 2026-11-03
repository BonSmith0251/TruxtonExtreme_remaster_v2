namespace System.Xml.Schema;

[DefaultMember("Item")]
[Token(Token = "0x200015C")]
internal class KeySequence
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400074C")]
	private TypedObject[] ks; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400074D")]
	private int dim; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400074E")]
	private int hashcode; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400074F")]
	private int posline; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000750")]
	private int poscol; //Field offset: 0x24

	[Token(Token = "0x170003E1")]
	public object Item
	{
		[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
		[Token(Token = "0x6000EEB")]
		 get { } //Length: 43
		[Address(RVA = "0x2583D80", Offset = "0x2583180", Length = "0x10E")]
		[Token(Token = "0x6000EEC")]
		 set { } //Length: 270
	}

	[Token(Token = "0x170003E0")]
	public int PosCol
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000EEA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170003DF")]
	public int PosLine
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000EE9")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2583CC0", Offset = "0x25830C0", Length = "0x88")]
	[Token(Token = "0x6000EE8")]
	internal KeySequence(int dim, int line, int col) { }

	[Address(RVA = "0x25835D0", Offset = "0x25829D0", Length = "0x105")]
	[Token(Token = "0x6000EEF")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x2583D50", Offset = "0x2583150", Length = "0x2B")]
	[Token(Token = "0x6000EEB")]
	public object get_Item(int index) { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000EEA")]
	public int get_PosCol() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000EE9")]
	public int get_PosLine() { }

	[Address(RVA = "0x25836E0", Offset = "0x2582AE0", Length = "0x408")]
	[Token(Token = "0x6000EEE")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2583AF0", Offset = "0x2582EF0", Length = "0x60")]
	[Token(Token = "0x6000EED")]
	internal bool IsQualified() { }

	[Address(RVA = "0x2583D80", Offset = "0x2583180", Length = "0x10E")]
	[Token(Token = "0x6000EEC")]
	public void set_Item(int index, object value) { }

	[Address(RVA = "0x2583B60", Offset = "0x2582F60", Length = "0x155")]
	[Token(Token = "0x6000EF0")]
	public virtual string ToString() { }

}

