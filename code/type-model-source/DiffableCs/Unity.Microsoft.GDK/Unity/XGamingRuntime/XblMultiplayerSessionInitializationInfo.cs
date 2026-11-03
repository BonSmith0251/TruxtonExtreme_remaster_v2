namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000177")]
public class XblMultiplayerSessionInitializationInfo
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002E9")]
	private readonly XblMultiplayerInitializationStage <Stage>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002EA")]
	private readonly DateTime <StageStartTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002EB")]
	private readonly uint <Episode>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170000E5")]
	public uint Episode
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600083D")]
		 get { } //Length: 4
	}

	[Token(Token = "0x170000E3")]
	public XblMultiplayerInitializationStage Stage
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600083B")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170000E4")]
	public DateTime StageStartTime
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600083C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B88E70", Offset = "0x2B88270", Length = "0x8A")]
	[Token(Token = "0x600083A")]
	internal XblMultiplayerSessionInitializationInfo(XblMultiplayerSessionInitializationInfo interopHandle) { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600083D")]
	public uint get_Episode() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600083B")]
	public XblMultiplayerInitializationStage get_Stage() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600083C")]
	public DateTime get_StageStartTime() { }

}

