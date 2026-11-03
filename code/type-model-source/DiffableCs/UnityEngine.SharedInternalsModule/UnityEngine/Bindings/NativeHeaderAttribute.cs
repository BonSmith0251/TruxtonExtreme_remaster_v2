namespace UnityEngine.Bindings;

[AttributeUsage(10716, AllowMultiple = True)]
[Token(Token = "0x200000A")]
[VisibleToOtherModules]
internal class NativeHeaderAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000008")]
	private string <Header>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000006")]
	public override string Header
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000011")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000012")]
	public NativeHeaderAttribute() { }

	[Address(RVA = "0x3165EC0", Offset = "0x31652C0", Length = "0x10E")]
	[Token(Token = "0x6000013")]
	public NativeHeaderAttribute(string header) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000011")]
	public override void set_Header(string value) { }

}

