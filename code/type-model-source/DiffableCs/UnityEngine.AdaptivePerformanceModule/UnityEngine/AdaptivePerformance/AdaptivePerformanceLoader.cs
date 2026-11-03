namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000033")]
public abstract class AdaptivePerformanceLoader : ScriptableObject
{

	[Token(Token = "0x1700007B")]
	public abstract bool Initialized
	{
		[Token(Token = "0x600016D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700007C")]
	public abstract bool Running
	{
		[Token(Token = "0x600016E")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x6000176")]
	protected AdaptivePerformanceLoader() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6000172")]
	public override bool Deinitialize() { }

	[Token(Token = "0x600016D")]
	public abstract bool get_Initialized() { }

	[Token(Token = "0x600016E")]
	public abstract bool get_Running() { }

	[Token(Token = "0x6000174")]
	public abstract ISubsystem GetDefaultSubsystem() { }

	[Token(Token = "0x6000173")]
	public abstract T GetLoadedSubsystem() { }

	[Token(Token = "0x6000175")]
	public abstract IAdaptivePerformanceSettings GetSettings() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x600016F")]
	public override bool Initialize() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6000170")]
	public override bool Start() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6000171")]
	public override bool Stop() { }

}

