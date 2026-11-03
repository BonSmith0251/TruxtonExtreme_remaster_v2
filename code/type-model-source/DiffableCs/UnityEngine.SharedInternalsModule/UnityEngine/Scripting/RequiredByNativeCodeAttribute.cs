namespace UnityEngine.Scripting;

[AttributeUsage(1532, Inherited = False)]
[Token(Token = "0x200001D")]
[VisibleToOtherModules]
internal class RequiredByNativeCodeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000028")]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000029")]
	private bool <Optional>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x400002A")]
	private bool <GenerateProxy>k__BackingField; //Field offset: 0x19

	[Token(Token = "0x17000018")]
	public bool GenerateProxy
	{
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000042")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000016")]
	public string Name
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000040")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000017")]
	public bool Optional
	{
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000041")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600003D")]
	public RequiredByNativeCodeAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x600003E")]
	public RequiredByNativeCodeAttribute(string name) { }

	[Address(RVA = "0x3166480", Offset = "0x3165880", Length = "0x26")]
	[Token(Token = "0x600003F")]
	public RequiredByNativeCodeAttribute(bool optional) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000042")]
	public void set_GenerateProxy(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000040")]
	public void set_Name(string value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000041")]
	public void set_Optional(bool value) { }

}

