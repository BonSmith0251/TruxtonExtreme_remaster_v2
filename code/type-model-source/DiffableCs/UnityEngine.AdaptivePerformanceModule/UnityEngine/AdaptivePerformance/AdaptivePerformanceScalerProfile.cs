namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000037")]
public class AdaptivePerformanceScalerProfile : AdaptivePerformanceScalerSettings
{
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[Token(Token = "0x40000D8")]
	private List<AdaptivePerformanceScaler> m_AddedScalers; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[Token(Token = "0x40000D9")]
	[Tooltip("Name of the scaler profile.")]
	private string m_Name; //Field offset: 0xA0

	[Token(Token = "0x17000088")]
	public List<AdaptivePerformanceScaler> AddedScalers
	{
		[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
		[Token(Token = "0x6000196")]
		 get { } //Length: 10
	}

	[Token(Token = "0x17000087")]
	public string Name
	{
		[Address(RVA = "0x2F92D10", Offset = "0x2F92110", Length = "0xA")]
		[Token(Token = "0x6000194")]
		 get { } //Length: 10
		[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
		[Token(Token = "0x6000195")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x2F92C30", Offset = "0x2F92030", Length = "0xCB")]
	[Token(Token = "0x6000199")]
	public AdaptivePerformanceScalerProfile() { }

	[Address(RVA = "0x2F929A0", Offset = "0x2F91DA0", Length = "0x132")]
	[Token(Token = "0x6000197")]
	internal void EnableAddedScalers() { }

	[Address(RVA = "0x2F92D00", Offset = "0x2F92100", Length = "0xA")]
	[Token(Token = "0x6000196")]
	public List<AdaptivePerformanceScaler> get_AddedScalers() { }

	[Address(RVA = "0x2F92D10", Offset = "0x2F92110", Length = "0xA")]
	[Token(Token = "0x6000194")]
	public string get_Name() { }

	[Address(RVA = "0x2F92AE0", Offset = "0x2F91EE0", Length = "0x148")]
	[Token(Token = "0x6000198")]
	internal void RemoveAllAddedScalersFromIndexer() { }

	[Address(RVA = "0xE7CF20", Offset = "0xE7C320", Length = "0x13")]
	[Token(Token = "0x6000195")]
	public void set_Name(string value) { }

}

