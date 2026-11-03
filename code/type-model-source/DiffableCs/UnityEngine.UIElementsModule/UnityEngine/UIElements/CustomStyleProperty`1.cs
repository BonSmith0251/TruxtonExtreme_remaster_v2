namespace UnityEngine.UIElements;

[Token(Token = "0x20002FC")]
public struct CustomStyleProperty : IEquatable<CustomStyleProperty`1<T>>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C29")]
	private string <name>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000466")]
	public private string name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001561")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001562")]
		private set { } //Length: 8
	}

	[Address(RVA = "0x17C9510", Offset = "0x17C8910", Length = "0xF5")]
	[Token(Token = "0x6001563")]
	public CustomStyleProperty`1(string propertyName) { }

	[Address(RVA = "0x17C9230", Offset = "0x17C8630", Length = "0x128")]
	[Token(Token = "0x6001564")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x17C90A0", Offset = "0x17C84A0", Length = "0x5C")]
	[Token(Token = "0x6001565")]
	public override bool Equals(CustomStyleProperty<T> other) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x6001561")]
	public string get_name() { }

	[Address(RVA = "0x17C9430", Offset = "0x17C8830", Length = "0x41")]
	[Token(Token = "0x6001566")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001562")]
	private void set_name(string value) { }

}

