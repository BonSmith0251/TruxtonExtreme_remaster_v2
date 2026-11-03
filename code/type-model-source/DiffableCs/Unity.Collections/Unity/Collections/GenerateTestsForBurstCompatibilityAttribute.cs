namespace Unity.Collections;

[AttributeUsage(236, AllowMultiple = True)]
[Token(Token = "0x200007F")]
public class GenerateTestsForBurstCompatibilityAttribute : Attribute
{
	[Token(Token = "0x2000080")]
	internal enum BurstCompatibleCompileTarget : int
	{
		Player = 0,
		Editor = 1,
		PlayerAndEditor = 2,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40003A2")]
	private Type[] <GenericTypeArguments>k__BackingField; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40003A3")]
	public string RequiredUnityDefine; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40003A4")]
	public BurstCompatibleCompileTarget CompileTarget; //Field offset: 0x20

	[Token(Token = "0x170000A8")]
	public Type[] GenericTypeArguments
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006C9")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006CA")]
		 set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60006CB")]
	public GenerateTestsForBurstCompatibilityAttribute() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60006C9")]
	public Type[] get_GenericTypeArguments() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60006CA")]
	public void set_GenericTypeArguments(Type[] value) { }

}

