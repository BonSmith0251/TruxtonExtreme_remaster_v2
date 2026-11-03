namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200017B")]
public class XblMultiplayerSessionNumberAttribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400030E")]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400030F")]
	private readonly double <Value>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000105")]
	public string Name
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000865")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000106")]
	public double Value
	{
		[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
		[CompilerGenerated]
		[Token(Token = "0x6000866")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x2B89B40", Offset = "0x2B88F40", Length = "0x44")]
	[Token(Token = "0x6000863")]
	public XblMultiplayerSessionNumberAttribute(string name, double value) { }

	[Address(RVA = "0x2B89B90", Offset = "0x2B88F90", Length = "0x44")]
	[Token(Token = "0x6000864")]
	internal XblMultiplayerSessionNumberAttribute(XblMultiplayerSessionNumberAttribute interopStruct) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000865")]
	public string get_Name() { }

	[Address(RVA = "0x1CC53D0", Offset = "0x1CC47D0", Length = "0x6")]
	[CompilerGenerated]
	[Token(Token = "0x6000866")]
	public double get_Value() { }

}

