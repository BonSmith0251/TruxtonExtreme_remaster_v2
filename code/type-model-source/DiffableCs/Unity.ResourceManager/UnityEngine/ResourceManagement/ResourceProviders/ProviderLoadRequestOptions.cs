namespace UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x2000066")]
public class ProviderLoadRequestOptions
{
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x400010E")]
	private bool m_IgnoreFailures; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x400010F")]
	private int m_WebRequestTimeout; //Field offset: 0x14

	[Token(Token = "0x1700005C")]
	public bool IgnoreFailures
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[Token(Token = "0x600023D")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[Token(Token = "0x600023E")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700005D")]
	public int WebRequestTimeout
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[Token(Token = "0x600023F")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[Token(Token = "0x6000240")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000241")]
	public ProviderLoadRequestOptions() { }

	[Address(RVA = "0x2E468D0", Offset = "0x2E45CD0", Length = "0x71")]
	[Token(Token = "0x600023C")]
	public ProviderLoadRequestOptions Copy() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[Token(Token = "0x600023D")]
	public bool get_IgnoreFailures() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[Token(Token = "0x600023F")]
	public int get_WebRequestTimeout() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[Token(Token = "0x600023E")]
	public void set_IgnoreFailures(bool value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[Token(Token = "0x6000240")]
	public void set_WebRequestTimeout(int value) { }

}

