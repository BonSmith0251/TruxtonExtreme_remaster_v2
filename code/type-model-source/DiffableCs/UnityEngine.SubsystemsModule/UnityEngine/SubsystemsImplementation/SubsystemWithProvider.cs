namespace UnityEngine.SubsystemsImplementation;

[Token(Token = "0x2000013")]
public abstract class SubsystemWithProvider : ISubsystem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000013")]
	private bool <running>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000014")]
	private SubsystemProvider <providerBase>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x1700000A")]
	internal SubsystemProvider providerBase
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600003D")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public private override bool running
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600003B")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600003C")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600003E")]
	protected SubsystemWithProvider() { }

	[Address(RVA = "0x3167830", Offset = "0x3166C30", Length = "0xF9")]
	[Token(Token = "0x6000039")]
	public override void Destroy() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600003D")]
	internal SubsystemProvider get_providerBase() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600003B")]
	public override bool get_running() { }

	[Token(Token = "0x600003A")]
	protected abstract void OnDestroy() { }

	[Token(Token = "0x6000038")]
	protected abstract void OnStop() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600003C")]
	private void set_running(bool value) { }

	[Address(RVA = "0x3167930", Offset = "0x3166D30", Length = "0x88")]
	[Token(Token = "0x6000037")]
	public override void Stop() { }

}

