namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000170")]
public class XblMultiplayerMatchmakingServer
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002CF")]
	private readonly XblMatchmakingStatus <Status>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002D0")]
	private readonly string <StatusDetails>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002D1")]
	private readonly uint <TypicalWaitInSeconds>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002D2")]
	private readonly XblMultiplayerSessionReference <TargetSessionRef>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40002D3")]
	private readonly XblMultiplayerMatchmakingServer <InteropHandle>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x170000D8")]
	internal XblMultiplayerMatchmakingServer InteropHandle
	{
		[Address(RVA = "0x2B87950", Offset = "0x2B86D50", Length = "0x75")]
		[CompilerGenerated]
		[Token(Token = "0x6000822")]
		internal get { } //Length: 117
	}

	[Token(Token = "0x170000D4")]
	public XblMatchmakingStatus Status
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600081E")]
		 get { } //Length: 85
	}

	[Token(Token = "0x170000D5")]
	public string StatusDetails
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600081F")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D7")]
	public XblMultiplayerSessionReference TargetSessionRef
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000821")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000D6")]
	public uint TypicalWaitInSeconds
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000820")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x2B87600", Offset = "0x2B86A00", Length = "0x343")]
	[Token(Token = "0x600081D")]
	internal XblMultiplayerMatchmakingServer(XblMultiplayerMatchmakingServer interopHandle) { }

	[Address(RVA = "0x2B87950", Offset = "0x2B86D50", Length = "0x75")]
	[CompilerGenerated]
	[Token(Token = "0x6000822")]
	internal XblMultiplayerMatchmakingServer get_InteropHandle() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600081E")]
	public XblMatchmakingStatus get_Status() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600081F")]
	public string get_StatusDetails() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000821")]
	public XblMultiplayerSessionReference get_TargetSessionRef() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000820")]
	public uint get_TypicalWaitInSeconds() { }

}

