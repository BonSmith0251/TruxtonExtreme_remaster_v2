namespace UnityEngine.Bindings;

[AttributeUsage(204)]
[Token(Token = "0x2000016")]
[VisibleToOtherModules]
internal class StaticAccessorAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400001F")]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000020")]
	private StaticAccessorType <Type>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000011")]
	public string Name
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000030")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000012")]
	public StaticAccessorType Type
	{
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000031")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5D27B0", Offset = "0x5D1BB0", Length = "0x31")]
	[Token(Token = "0x6000032")]
	[VisibleToOtherModules]
	internal StaticAccessorAttribute(string name) { }

	[Address(RVA = "0x5D2830", Offset = "0x5D1C30", Length = "0x42")]
	[Token(Token = "0x6000033")]
	public StaticAccessorAttribute(string name, StaticAccessorType type) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000030")]
	public void set_Name(string value) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000031")]
	public void set_Type(StaticAccessorType value) { }

}

