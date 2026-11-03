namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000183")]
public sealed class ListBindableAttribute : Attribute
{
	[Token(Token = "0x4000631")]
	public static readonly ListBindableAttribute Yes; //Field offset: 0x0
	[Token(Token = "0x4000632")]
	public static readonly ListBindableAttribute No; //Field offset: 0x8
	[Token(Token = "0x4000633")]
	public static readonly ListBindableAttribute Default; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000634")]
	private bool _isDefault; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000635")]
	private readonly bool <ListBindable>k__BackingField; //Field offset: 0x11

	[Token(Token = "0x170001CA")]
	public bool ListBindable
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000961")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2663FF0", Offset = "0x26633F0", Length = "0xE0")]
	[Token(Token = "0x6000965")]
	private static ListBindableAttribute() { }

	[Address(RVA = "0x26640D0", Offset = "0x26634D0", Length = "0x26")]
	[Token(Token = "0x6000960")]
	public ListBindableAttribute(bool listBindable) { }

	[Address(RVA = "0x2663EF0", Offset = "0x26632F0", Length = "0x7A")]
	[Token(Token = "0x6000962")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000961")]
	public bool get_ListBindable() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x6000963")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2663F70", Offset = "0x2663370", Length = "0x75")]
	[Token(Token = "0x6000964")]
	public virtual bool IsDefaultAttribute() { }

}

