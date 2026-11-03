namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001E8")]
public class XblTitleHistory
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000544")]
	private bool <HasUserPlayed>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000545")]
	private DateTime <LastTimeUserPlayed>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x170001D0")]
	public private bool HasUserPlayed
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A27")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000A28")]
		private set { } //Length: 4
	}

	[Token(Token = "0x170001D1")]
	public private DateTime LastTimeUserPlayed
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A29")]
		 get { } //Length: 5
		[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000A2A")]
		private set { } //Length: 5
	}

	[Address(RVA = "0x2B8C560", Offset = "0x2B8B960", Length = "0x7E")]
	[Token(Token = "0x6000A26")]
	internal XblTitleHistory(XblTitleHistory interopTitleHistory) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A27")]
	public bool get_HasUserPlayed() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A29")]
	public DateTime get_LastTimeUserPlayed() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000A28")]
	private void set_HasUserPlayed(bool value) { }

	[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000A2A")]
	private void set_LastTimeUserPlayed(DateTime value) { }

}

