namespace UnityEngine.Categorization;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x200024C")]
public sealed class ElementInfoAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B2")]
	private int <Order>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007B3")]
	private string <Name>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700038E")]
	public int Order
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600182E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x30782C0", Offset = "0x30776C0", Length = "0x32")]
	[Token(Token = "0x600182F")]
	public ElementInfoAttribute() { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600182E")]
	public void set_Order(int value) { }

}

