namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200001A")]
public struct PropertyPathPart : IEquatable<PropertyPathPart>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000028")]
	private readonly PropertyPathPartKind m_Kind; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000029")]
	private readonly string m_Name; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400002A")]
	private readonly int m_Index; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400002B")]
	private readonly object m_Key; //Field offset: 0x18

	[Token(Token = "0x17000010")]
	public int Index
	{
		[Address(RVA = "0x315B840", Offset = "0x315AC40", Length = "0x53")]
		[Token(Token = "0x6000045")]
		 get { } //Length: 83
	}

	[Token(Token = "0x1700000D")]
	public bool IsIndex
	{
		[Address(RVA = "0x29415A0", Offset = "0x29409A0", Length = "0x7")]
		[Token(Token = "0x6000042")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700000C")]
	public bool IsName
	{
		[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
		[Token(Token = "0x6000041")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000011")]
	public object Key
	{
		[Address(RVA = "0x315B8A0", Offset = "0x315ACA0", Length = "0x54")]
		[Token(Token = "0x6000046")]
		 get { } //Length: 84
	}

	[Token(Token = "0x1700000E")]
	public PropertyPathPartKind Kind
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x6000043")]
		 get { } //Length: 3
	}

	[Token(Token = "0x1700000F")]
	public string Name
	{
		[Address(RVA = "0x315B900", Offset = "0x315AD00", Length = "0x54")]
		[Token(Token = "0x6000044")]
		 get { } //Length: 84
	}

	[Address(RVA = "0x315B800", Offset = "0x315AC00", Length = "0x3B")]
	[Token(Token = "0x6000047")]
	public PropertyPathPart(string name) { }

	[Address(RVA = "0x315B7A0", Offset = "0x315ABA0", Length = "0x53")]
	[Token(Token = "0x6000048")]
	public PropertyPathPart(int index) { }

	[Address(RVA = "0x315B740", Offset = "0x315AB40", Length = "0x55")]
	[Token(Token = "0x6000049")]
	public PropertyPathPart(object key) { }

	[Address(RVA = "0x315B400", Offset = "0x315A800", Length = "0x4F")]
	[Token(Token = "0x600004A")]
	private void CheckKind(PropertyPathPartKind type) { }

	[Address(RVA = "0x315B520", Offset = "0x315A920", Length = "0x5A")]
	[Token(Token = "0x600004C")]
	public override bool Equals(PropertyPathPart other) { }

	[Address(RVA = "0x315B450", Offset = "0x315A850", Length = "0xCB")]
	[Token(Token = "0x600004D")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x315B840", Offset = "0x315AC40", Length = "0x53")]
	[Token(Token = "0x6000045")]
	public int get_Index() { }

	[Address(RVA = "0x29415A0", Offset = "0x29409A0", Length = "0x7")]
	[Token(Token = "0x6000042")]
	public bool get_IsIndex() { }

	[Address(RVA = "0x23E3B10", Offset = "0x23E2F10", Length = "0x7")]
	[Token(Token = "0x6000041")]
	public bool get_IsName() { }

	[Address(RVA = "0x315B8A0", Offset = "0x315ACA0", Length = "0x54")]
	[Token(Token = "0x6000046")]
	public object get_Key() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x6000043")]
	public PropertyPathPartKind get_Kind() { }

	[Address(RVA = "0x315B900", Offset = "0x315AD00", Length = "0x54")]
	[Token(Token = "0x6000044")]
	public string get_Name() { }

	[Address(RVA = "0x315B580", Offset = "0x315A980", Length = "0xAA")]
	[Token(Token = "0x600004E")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x315B630", Offset = "0x315AA30", Length = "0x107")]
	[Token(Token = "0x600004B")]
	public virtual string ToString() { }

}

