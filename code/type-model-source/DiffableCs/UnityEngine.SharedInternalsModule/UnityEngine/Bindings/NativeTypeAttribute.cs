namespace UnityEngine.Bindings;

[AttributeUsage(28)]
[Token(Token = "0x2000011")]
[VisibleToOtherModules]
internal class NativeTypeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000017")]
	private string <Header>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000018")]
	private string <IntermediateScriptingStructName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000019")]
	private CodegenOptions <CodegenOptions>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000010")]
	public override CodegenOptions CodegenOptions
	{
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000026")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public override string Header
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000024")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000F")]
	public string IntermediateScriptingStructName
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000025")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3166460", Offset = "0x3165860", Length = "0x1D")]
	[Token(Token = "0x6000027")]
	public NativeTypeAttribute() { }

	[Address(RVA = "0x31663F0", Offset = "0x31657F0", Length = "0x24")]
	[Token(Token = "0x6000028")]
	public NativeTypeAttribute(CodegenOptions codegenOptions) { }

	[Address(RVA = "0x31662D0", Offset = "0x31656D0", Length = "0x115")]
	[Token(Token = "0x6000029")]
	public NativeTypeAttribute(string header) { }

	[Address(RVA = "0x3166420", Offset = "0x3165820", Length = "0x40")]
	[Token(Token = "0x600002A")]
	public NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000026")]
	public override void set_CodegenOptions(CodegenOptions value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000024")]
	public override void set_Header(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000025")]
	public void set_IntermediateScriptingStructName(string value) { }

}

