namespace UnityEngine.AdaptivePerformance.Provider;

[Token(Token = "0x2000058")]
public sealed class AdaptivePerformanceSubsystemDescriptor : SubsystemDescriptorWithProvider<AdaptivePerformanceSubsystem, APProvider>
{
	[Token(Token = "0x2000059")]
	internal struct Cinfo
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400014C")]
		private string <id>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400014D")]
		private Type <providerType>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400014E")]
		private Type <subsystemTypeOverride>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400014F")]
		private Type <subsystemImplementationType>k__BackingField; //Field offset: 0x18

		[Token(Token = "0x170000D0")]
		public string id
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000284")]
			 get { } //Length: 4
			[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000285")]
			 set { } //Length: 8
		}

		[Token(Token = "0x170000D1")]
		public Type providerType
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000286")]
			 get { } //Length: 5
			[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000287")]
			 set { } //Length: 13
		}

		[Token(Token = "0x170000D2")]
		public Type subsystemTypeOverride
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6000288")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000289")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000284")]
		public string get_id() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000286")]
		public Type get_providerType() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6000288")]
		public Type get_subsystemTypeOverride() { }

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000285")]
		public void set_id(string value) { }

		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000287")]
		public void set_providerType(Type value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000289")]
		public void set_subsystemTypeOverride(Type value) { }

	}


	[Address(RVA = "0x2F9A340", Offset = "0x2F99740", Length = "0x77")]
	[Token(Token = "0x6000282")]
	public AdaptivePerformanceSubsystemDescriptor(Cinfo cinfo) { }

	[Address(RVA = "0x2F9A0B0", Offset = "0x2F994B0", Length = "0x289")]
	[Token(Token = "0x6000283")]
	public static AdaptivePerformanceSubsystemDescriptor RegisterDescriptor(Cinfo cinfo) { }

}

