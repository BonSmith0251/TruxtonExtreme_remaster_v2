namespace UnityEngine;

[AttributeUsage(12, Inherited = False)]
[Token(Token = "0x2000007")]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000003")]
	private string <QualifiedNativeName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000004")]
	private string <Declaration>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000002")]
	private string Declaration
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000007")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000001")]
	private string QualifiedNativeName
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000006")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x3165DA0", Offset = "0x31651A0", Length = "0x72")]
	[Token(Token = "0x6000008")]
	public NativeClassAttribute(string qualifiedCppName) { }

	[Address(RVA = "0x1F319D0", Offset = "0x1F30DD0", Length = "0x4E")]
	[Token(Token = "0x6000009")]
	public NativeClassAttribute(string qualifiedCppName, string declaration) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000007")]
	private void set_Declaration(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000006")]
	private void set_QualifiedNativeName(string value) { }

}

