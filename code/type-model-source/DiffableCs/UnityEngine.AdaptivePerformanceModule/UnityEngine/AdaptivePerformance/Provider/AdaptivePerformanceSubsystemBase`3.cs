namespace UnityEngine.AdaptivePerformance.Provider;

[Token(Token = "0x2000054")]
public abstract class AdaptivePerformanceSubsystemBase : SubsystemWithProvider<TSubsystem, TSubsystemDescriptor, TProvider>
{

	[Token(Token = "0x170000BF")]
	public abstract IApplicationLifecycle ApplicationLifecycle
	{
		[Token(Token = "0x6000268")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000BE")]
	public abstract Feature Capabilities
	{
		[Token(Token = "0x6000266")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C3")]
	public abstract bool Initialized
	{
		[Token(Token = "0x600026C")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C0")]
	public abstract IDevicePerformanceLevelControl PerformanceLevelControl
	{
		[Token(Token = "0x6000269")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C2")]
	public abstract string Stats
	{
		[Token(Token = "0x600026B")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000C1")]
	public abstract Version Version
	{
		[Token(Token = "0x600026A")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x1C4DF90", Offset = "0x1C4D390", Length = "0x13")]
	[Token(Token = "0x600026D")]
	protected AdaptivePerformanceSubsystemBase`3() { }

	[Token(Token = "0x6000268")]
	public abstract IApplicationLifecycle get_ApplicationLifecycle() { }

	[Token(Token = "0x6000266")]
	public abstract Feature get_Capabilities() { }

	[Token(Token = "0x600026C")]
	public abstract bool get_Initialized() { }

	[Token(Token = "0x6000269")]
	public abstract IDevicePerformanceLevelControl get_PerformanceLevelControl() { }

	[Token(Token = "0x600026B")]
	public abstract string get_Stats() { }

	[Token(Token = "0x600026A")]
	public abstract Version get_Version() { }

	[Token(Token = "0x6000267")]
	public abstract PerformanceDataRecord Update() { }

}

