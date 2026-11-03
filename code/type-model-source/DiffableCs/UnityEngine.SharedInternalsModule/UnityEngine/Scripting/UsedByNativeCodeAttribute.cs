namespace UnityEngine.Scripting;

[AttributeUsage(1532, Inherited = False)]
[Token(Token = "0x200001C")]
[VisibleToOtherModules]
internal class UsedByNativeCodeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000027")]
	private string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000015")]
	public string Name
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600003C")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600003A")]
	public UsedByNativeCodeAttribute() { }

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x600003B")]
	public UsedByNativeCodeAttribute(string name) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600003C")]
	public void set_Name(string value) { }

}

