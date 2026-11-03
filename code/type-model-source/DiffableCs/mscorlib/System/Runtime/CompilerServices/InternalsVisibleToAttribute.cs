namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Assembly (1), AllowMultiple = True, Inherited = False)]
[Token(Token = "0x20004AC")]
public sealed class InternalsVisibleToAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001290")]
	private string _assemblyName; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001291")]
	private bool _allInternalsVisible; //Field offset: 0x18

	[Token(Token = "0x17000412")]
	public bool AllInternalsVisible
	{
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[Token(Token = "0x6002166")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x1F36770", Offset = "0x1F35B70", Length = "0x35")]
	[Token(Token = "0x6002165")]
	public InternalsVisibleToAttribute(string assemblyName) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[Token(Token = "0x6002166")]
	public void set_AllInternalsVisible(bool value) { }

}

