namespace Steamworks;

[Token(Token = "0x20001DD")]
public struct SteamNetworkingConfigValue_t
{
	[Token(Token = "0x20001DE")]
	internal struct OptionValue
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B13")]
		public int m_int32; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B14")]
		public long m_int64; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B15")]
		public float m_float; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B16")]
		public IntPtr m_string; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B17")]
		public IntPtr m_functionPtr; //Field offset: 0x0

	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B10")]
	public ESteamNetworkingConfigValue m_eValue; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000B11")]
	public ESteamNetworkingConfigDataType m_eDataType; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000B12")]
	public OptionValue m_val; //Field offset: 0x8

}

