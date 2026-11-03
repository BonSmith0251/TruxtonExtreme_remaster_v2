namespace UnityEngine.Bindings;

[AttributeUsage(448)]
[Token(Token = "0x200000B")]
[VisibleToOtherModules]
internal class NativeNameAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000009")]
	private string <Name>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000007")]
	public override string Name
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000014")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x3166150", Offset = "0x3165550", Length = "0x10E")]
	[Token(Token = "0x6000015")]
	public NativeNameAttribute(string name) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000014")]
	public override void set_Name(string value) { }

}

