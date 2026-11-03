namespace UnityEngine;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False, Inherited = False)]
[Token(Token = "0x2000188")]
public sealed class CreateAssetMenuAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000629")]
	private string <menuName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400062A")]
	private string <fileName>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400062B")]
	private int <order>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170002CB")]
	public string fileName
	{
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001286")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002CA")]
	public string menuName
	{
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001285")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170002CC")]
	public int order
	{
		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001287")]
		 set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6001288")]
	public CreateAssetMenuAttribute() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001286")]
	public void set_fileName(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001285")]
	public void set_menuName(string value) { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001287")]
	public void set_order(int value) { }

}

