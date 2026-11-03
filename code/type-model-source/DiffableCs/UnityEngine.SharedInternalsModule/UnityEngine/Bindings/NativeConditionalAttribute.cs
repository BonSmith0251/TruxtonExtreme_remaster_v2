namespace UnityEngine.Bindings;

[AttributeUsage(204)]
[Token(Token = "0x2000009")]
[VisibleToOtherModules]
internal class NativeConditionalAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000005")]
	private string <Condition>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000006")]
	private string <StubReturnStatement>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000007")]
	private bool <Enabled>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000003")]
	public string Condition
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600000C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000005")]
	public bool Enabled
	{
		[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600000E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000004")]
	public string StubReturnStatement
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600000D")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3165E80", Offset = "0x3165280", Length = "0x36")]
	[Token(Token = "0x600000F")]
	public NativeConditionalAttribute(string condition) { }

	[Address(RVA = "0x3165E20", Offset = "0x3165220", Length = "0x52")]
	[Token(Token = "0x6000010")]
	public NativeConditionalAttribute(string condition, string stubReturnStatement) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600000C")]
	public void set_Condition(string value) { }

	[Address(RVA = "0xA9A660", Offset = "0xA99A60", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600000E")]
	public void set_Enabled(bool value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600000D")]
	public void set_StubReturnStatement(string value) { }

}

