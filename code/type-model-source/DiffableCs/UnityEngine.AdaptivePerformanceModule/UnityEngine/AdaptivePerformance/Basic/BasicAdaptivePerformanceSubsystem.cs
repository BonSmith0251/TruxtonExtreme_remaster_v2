namespace UnityEngine.AdaptivePerformance.Basic;

[Token(Token = "0x200005B")]
internal class BasicAdaptivePerformanceSubsystem : AdaptivePerformanceSubsystem
{
	[Token(Token = "0x200005C")]
	public class BasicProvider : APProvider, IApplicationLifecycle, IDevicePerformanceLevelControl
	{
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000150")]
		private PerformanceDataRecord m_UpdatedPerfRecord; //Field offset: 0x20
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000151")]
		private bool <Initialized>k__BackingField; //Field offset: 0x5C
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000152")]
		private Feature <Capabilities>k__BackingField; //Field offset: 0x60

		[Token(Token = "0x170000D3")]
		public virtual IApplicationLifecycle ApplicationLifecycle
		{
			[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
			[Token(Token = "0x600028D")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170000D7")]
		public virtual Feature Capabilities
		{
			[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000292")]
			 get { } //Length: 4
			[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000293")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170000D6")]
		public virtual bool Initialized
		{
			[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000290")]
			 get { } //Length: 5
			[Address(RVA = "0x2C9FC50", Offset = "0x2C9F050", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000291")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170000D9")]
		public override int MaxCpuPerformanceLevel
		{
			[Address(RVA = "0x2F9BA30", Offset = "0x2F9AE30", Length = "0x8")]
			[Token(Token = "0x600029D")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170000DA")]
		public override int MaxGpuPerformanceLevel
		{
			[Address(RVA = "0x2F9BA30", Offset = "0x2F9AE30", Length = "0x8")]
			[Token(Token = "0x600029E")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170000D4")]
		public virtual IDevicePerformanceLevelControl PerformanceLevelControl
		{
			[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
			[Token(Token = "0x600028E")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170000D5")]
		public virtual string Stats
		{
			[Address(RVA = "0x2F9BA40", Offset = "0x2F9AE40", Length = "0x2C")]
			[Token(Token = "0x600028F")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000D8")]
		public virtual Version Version
		{
			[Address(RVA = "0x2F9BA70", Offset = "0x2F9AE70", Length = "0x56")]
			[Token(Token = "0x600029C")]
			 get { } //Length: 86
		}

		[Address(RVA = "0x2F9B9C0", Offset = "0x2F9ADC0", Length = "0x6A")]
		[Token(Token = "0x600028C")]
		public BasicProvider() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000297")]
		public override void ApplicationPause() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6000298")]
		public override void ApplicationResume() { }

		[Address(RVA = "0x268F650", Offset = "0x268EA50", Length = "0x16")]
		[Token(Token = "0x6000295")]
		public virtual void Destroy() { }

		[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
		[Token(Token = "0x600029A")]
		public override bool EnableCpuBoost() { }

		[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
		[Token(Token = "0x600029B")]
		public override bool EnableGpuBoost() { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x600028D")]
		public virtual IApplicationLifecycle get_ApplicationLifecycle() { }

		[Address(RVA = "0x2069B10", Offset = "0x2068F10", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000292")]
		public virtual Feature get_Capabilities() { }

		[Address(RVA = "0x1FEC950", Offset = "0x1FEBD50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000290")]
		public virtual bool get_Initialized() { }

		[Address(RVA = "0x2F9BA30", Offset = "0x2F9AE30", Length = "0x8")]
		[Token(Token = "0x600029D")]
		public override int get_MaxCpuPerformanceLevel() { }

		[Address(RVA = "0x2F9BA30", Offset = "0x2F9AE30", Length = "0x8")]
		[Token(Token = "0x600029E")]
		public override int get_MaxGpuPerformanceLevel() { }

		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x600028E")]
		public virtual IDevicePerformanceLevelControl get_PerformanceLevelControl() { }

		[Address(RVA = "0x2F9BA40", Offset = "0x2F9AE40", Length = "0x2C")]
		[Token(Token = "0x600028F")]
		public virtual string get_Stats() { }

		[Address(RVA = "0x2F9BA70", Offset = "0x2F9AE70", Length = "0x56")]
		[Token(Token = "0x600029C")]
		public virtual Version get_Version() { }

		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000293")]
		public virtual void set_Capabilities(Feature value) { }

		[Address(RVA = "0x2C9FC50", Offset = "0x2C9F050", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000291")]
		public virtual void set_Initialized(bool value) { }

		[Address(RVA = "0x2F9B910", Offset = "0x2F9AD10", Length = "0x19")]
		[Token(Token = "0x6000299")]
		public override bool SetPerformanceLevel(ref int cpuLevel, ref int gpuLevel) { }

		[Address(RVA = "0x291E930", Offset = "0x291DD30", Length = "0x5")]
		[Token(Token = "0x6000294")]
		public virtual void Stop() { }

		[Address(RVA = "0x2F9B930", Offset = "0x2F9AD30", Length = "0x8B")]
		[Token(Token = "0x6000296")]
		public virtual PerformanceDataRecord Update() { }

	}


	[Address(RVA = "0x2F9A5D0", Offset = "0x2F999D0", Length = "0x39")]
	[Token(Token = "0x600028B")]
	public BasicAdaptivePerformanceSubsystem() { }

}

