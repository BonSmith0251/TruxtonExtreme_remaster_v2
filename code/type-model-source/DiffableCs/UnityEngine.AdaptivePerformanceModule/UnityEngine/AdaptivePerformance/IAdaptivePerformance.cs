namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000010")]
public interface IAdaptivePerformance
{

	[Token(Token = "0x17000031")]
	public AdaptivePerformanceIndexer Indexer
	{
		[Token(Token = "0x60000A0")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000030")]
	public IPerformanceStatus PerformanceStatus
	{
		[Token(Token = "0x600009F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000032")]
	public IAdaptivePerformanceSettings Settings
	{
		[Token(Token = "0x60000A1")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700002F")]
	public IThermalStatus ThermalStatus
	{
		[Token(Token = "0x600009E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60000A0")]
	public AdaptivePerformanceIndexer get_Indexer() { }

	[Token(Token = "0x600009F")]
	public IPerformanceStatus get_PerformanceStatus() { }

	[Token(Token = "0x60000A1")]
	public IAdaptivePerformanceSettings get_Settings() { }

	[Token(Token = "0x600009E")]
	public IThermalStatus get_ThermalStatus() { }

	[Token(Token = "0x60000A2")]
	public bool SupportedFeature(Feature feature) { }

}

