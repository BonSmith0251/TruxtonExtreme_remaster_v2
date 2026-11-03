namespace UnityEngine.Categorization;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False, AllowMultiple = False)]
[Token(Token = "0x200024D")]
public sealed class CategoryInfoAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007B4")]
	private int <Order>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007B5")]
	private string <Name>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000390")]
	public string Name
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001831")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700038F")]
	public int Order
	{
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001830")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x30782C0", Offset = "0x30776C0", Length = "0x32")]
	[Token(Token = "0x6001832")]
	public CategoryInfoAttribute() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001831")]
	public void set_Name(string value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001830")]
	public void set_Order(int value) { }

}

