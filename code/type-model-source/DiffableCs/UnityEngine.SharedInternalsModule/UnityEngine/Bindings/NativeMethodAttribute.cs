namespace UnityEngine.Bindings;

[AttributeUsage(192)]
[Token(Token = "0x200000C")]
[VisibleToOtherModules]
internal class NativeMethodAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000A")]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000B")]
	private bool <IsThreadSafe>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x19")]
	[Token(Token = "0x400000C")]
	private bool <IsFreeFunction>k__BackingField; //Field offset: 0x19
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1A")]
	[Token(Token = "0x400000D")]
	private bool <ThrowsException>k__BackingField; //Field offset: 0x1A
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1B")]
	[Token(Token = "0x400000E")]
	private bool <HasExplicitThis>k__BackingField; //Field offset: 0x1B

	[Token(Token = "0x1700000C")]
	public override bool HasExplicitThis
	{
		[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600001A")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000A")]
	public override bool IsFreeFunction
	{
		[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000018")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000009")]
	public override bool IsThreadSafe
	{
		[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000017")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000008")]
	public override string Name
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000016")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000B")]
	public override bool ThrowsException
	{
		[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000019")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x600001B")]
	public NativeMethodAttribute() { }

	[Address(RVA = "0x3166010", Offset = "0x3165410", Length = "0x10E")]
	[Token(Token = "0x600001C")]
	public NativeMethodAttribute(string name) { }

	[Address(RVA = "0x3166120", Offset = "0x3165520", Length = "0x28")]
	[Token(Token = "0x600001D")]
	public NativeMethodAttribute(string name, bool isFreeFunction) { }

	[Address(RVA = "0x3165FD0", Offset = "0x31653D0", Length = "0x3A")]
	[Token(Token = "0x600001E")]
	public NativeMethodAttribute(string name, bool isFreeFunction, bool isThreadSafe) { }

	[Address(RVA = "0x29EA840", Offset = "0x29E9C40", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600001A")]
	public override void set_HasExplicitThis(bool value) { }

	[Address(RVA = "0x21BAC10", Offset = "0x21BA010", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000018")]
	public override void set_IsFreeFunction(bool value) { }

	[Address(RVA = "0x14125C0", Offset = "0x14119C0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000017")]
	public override void set_IsThreadSafe(bool value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000016")]
	public override void set_Name(string value) { }

	[Address(RVA = "0x21BAC00", Offset = "0x21BA000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000019")]
	public override void set_ThrowsException(bool value) { }

}

