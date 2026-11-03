namespace Unity.XGamingRuntime.Interop;

[MovedFrom("Unity.GameCore.Interop")]
[Token(Token = "0x20002B9")]
public struct TimeT
{
	[Token(Token = "0x4000744")]
	private static DateTime UnixEpoch; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000745")]
	internal readonly long SecondsSinceUnixEpoch; //Field offset: 0x0

	[Token(Token = "0x17000308")]
	public DateTime DateTime
	{
		[Address(RVA = "0x2B9F230", Offset = "0x2B9E630", Length = "0xEB")]
		[Token(Token = "0x6000E2A")]
		 get { } //Length: 235
	}

	[Address(RVA = "0x2B9F060", Offset = "0x2B9E460", Length = "0x73")]
	[Token(Token = "0x6000E2B")]
	private static TimeT() { }

	[Address(RVA = "0x604A00", Offset = "0x603E00", Length = "0x4")]
	[Token(Token = "0x6000E28")]
	internal TimeT(long secondsSinceUnixEpoch) { }

	[Address(RVA = "0x2B9F0E0", Offset = "0x2B9E4E0", Length = "0x148")]
	[Token(Token = "0x6000E29")]
	public TimeT(DateTime dateTime) { }

	[Address(RVA = "0x2B9F230", Offset = "0x2B9E630", Length = "0xEB")]
	[Token(Token = "0x6000E2A")]
	public DateTime get_DateTime() { }

}

