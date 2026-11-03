namespace UnityEngine.SubsystemsImplementation;

[Token(Token = "0x2000014")]
public abstract class SubsystemWithProvider : SubsystemWithProvider
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000015")]
	private TSubsystemDescriptor <subsystemDescriptor>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000016")]
	private TProvider <provider>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700000B")]
	protected private TProvider provider
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600003F")]
		private get { } //Length: 5
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000042")]
	protected SubsystemWithProvider`3() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600003F")]
	protected private TProvider get_provider() { }

	[Address(RVA = "0xFD9310", Offset = "0xFD8710", Length = "0x2A")]
	[Token(Token = "0x6000041")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0xFD9340", Offset = "0xFD8740", Length = "0x2A")]
	[Token(Token = "0x6000040")]
	protected virtual void OnStop() { }

}

