namespace Unity.XGamingRuntime.Interop;

[AttributeUsage(10640, AllowMultiple = False, Inherited = True)]
[Conditional("DEBUG")]
[Token(Token = "0x20002B7")]
internal sealed class NativeTypeNameAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000742")]
	private string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000306")]
	public private string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000E1D")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000E1E")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000E1C")]
	public NativeTypeNameAttribute(string name) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000E1D")]
	public string get_Name() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000E1E")]
	private void set_Name(string value) { }

}

