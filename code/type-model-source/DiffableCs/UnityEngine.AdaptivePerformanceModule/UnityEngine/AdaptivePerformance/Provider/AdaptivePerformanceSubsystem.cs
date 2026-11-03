namespace UnityEngine.AdaptivePerformance.Provider;

[Token(Token = "0x2000055")]
public class AdaptivePerformanceSubsystem : AdaptivePerformanceSubsystemBase<AdaptivePerformanceSubsystem, AdaptivePerformanceSubsystemDescriptor, APProvider>
{
	[Token(Token = "0x2000056")]
	internal abstract class APProvider : SubsystemProvider<AdaptivePerformanceSubsystem>
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400014B")]
		protected bool m_Running; //Field offset: 0x18

		[Token(Token = "0x170000CB")]
		public abstract IApplicationLifecycle ApplicationLifecycle
		{
			[Token(Token = "0x6000279")]
			 get { } //Length: 0
		}

		[Token(Token = "0x170000CA")]
		public abstract Feature Capabilities
		{
			[Token(Token = "0x6000276")]
			 get { } //Length: 0
			[Token(Token = "0x6000277")]
			 set { } //Length: 0
		}

		[Token(Token = "0x170000CF")]
		public abstract bool Initialized
		{
			[Token(Token = "0x600027D")]
			 get { } //Length: 0
			[Token(Token = "0x600027E")]
			 set { } //Length: 0
		}

		[Token(Token = "0x170000CC")]
		public abstract IDevicePerformanceLevelControl PerformanceLevelControl
		{
			[Token(Token = "0x600027A")]
			 get { } //Length: 0
		}

		[Token(Token = "0x170000CE")]
		public override string Stats
		{
			[Address(RVA = "0x2F9A080", Offset = "0x2F99480", Length = "0x2C")]
			[Token(Token = "0x600027C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000CD")]
		public abstract Version Version
		{
			[Token(Token = "0x600027B")]
			 get { } //Length: 0
		}

		[Address(RVA = "0x2F9A040", Offset = "0x2F99440", Length = "0x39")]
		[Token(Token = "0x600027F")]
		protected APProvider() { }

		[Token(Token = "0x6000279")]
		public abstract IApplicationLifecycle get_ApplicationLifecycle() { }

		[Token(Token = "0x6000276")]
		public abstract Feature get_Capabilities() { }

		[Token(Token = "0x600027D")]
		public abstract bool get_Initialized() { }

		[Token(Token = "0x600027A")]
		public abstract IDevicePerformanceLevelControl get_PerformanceLevelControl() { }

		[Address(RVA = "0x2F9A080", Offset = "0x2F99480", Length = "0x2C")]
		[Token(Token = "0x600027C")]
		public override string get_Stats() { }

		[Token(Token = "0x600027B")]
		public abstract Version get_Version() { }

		[Token(Token = "0x6000277")]
		public abstract void set_Capabilities(Feature value) { }

		[Token(Token = "0x600027E")]
		public abstract void set_Initialized(bool value) { }

		[Token(Token = "0x6000278")]
		public abstract PerformanceDataRecord Update() { }

	}


	[Token(Token = "0x170000C4")]
	public virtual IApplicationLifecycle ApplicationLifecycle
	{
		[Address(RVA = "0x2F9A610", Offset = "0x2F99A10", Length = "0x4C")]
		[Token(Token = "0x600026F")]
		 get { } //Length: 76
	}

	[Token(Token = "0x170000C7")]
	public virtual Feature Capabilities
	{
		[Address(RVA = "0x2F9A660", Offset = "0x2F99A60", Length = "0x4C")]
		[Token(Token = "0x6000272")]
		 get { } //Length: 76
	}

	[Token(Token = "0x170000C9")]
	public virtual bool Initialized
	{
		[Address(RVA = "0x2F9A6B0", Offset = "0x2F99AB0", Length = "0x4C")]
		[Token(Token = "0x6000274")]
		 get { } //Length: 76
	}

	[Token(Token = "0x170000C5")]
	public virtual IDevicePerformanceLevelControl PerformanceLevelControl
	{
		[Address(RVA = "0x2F9A700", Offset = "0x2F99B00", Length = "0x4C")]
		[Token(Token = "0x6000270")]
		 get { } //Length: 76
	}

	[Token(Token = "0x170000C8")]
	public virtual string Stats
	{
		[Address(RVA = "0x2F9A750", Offset = "0x2F99B50", Length = "0x4C")]
		[Token(Token = "0x6000273")]
		 get { } //Length: 76
	}

	[Token(Token = "0x170000C6")]
	public virtual Version Version
	{
		[Address(RVA = "0x2F9A7A0", Offset = "0x2F99BA0", Length = "0x4C")]
		[Token(Token = "0x6000271")]
		 get { } //Length: 76
	}

	[Address(RVA = "0x2F9A5D0", Offset = "0x2F999D0", Length = "0x39")]
	[Token(Token = "0x600026E")]
	public AdaptivePerformanceSubsystem() { }

	[Address(RVA = "0x2F9A610", Offset = "0x2F99A10", Length = "0x4C")]
	[Token(Token = "0x600026F")]
	public virtual IApplicationLifecycle get_ApplicationLifecycle() { }

	[Address(RVA = "0x2F9A660", Offset = "0x2F99A60", Length = "0x4C")]
	[Token(Token = "0x6000272")]
	public virtual Feature get_Capabilities() { }

	[Address(RVA = "0x2F9A6B0", Offset = "0x2F99AB0", Length = "0x4C")]
	[Token(Token = "0x6000274")]
	public virtual bool get_Initialized() { }

	[Address(RVA = "0x2F9A700", Offset = "0x2F99B00", Length = "0x4C")]
	[Token(Token = "0x6000270")]
	public virtual IDevicePerformanceLevelControl get_PerformanceLevelControl() { }

	[Address(RVA = "0x2F9A750", Offset = "0x2F99B50", Length = "0x4C")]
	[Token(Token = "0x6000273")]
	public virtual string get_Stats() { }

	[Address(RVA = "0x2F9A7A0", Offset = "0x2F99BA0", Length = "0x4C")]
	[Token(Token = "0x6000271")]
	public virtual Version get_Version() { }

	[Address(RVA = "0x2F9A530", Offset = "0x2F99930", Length = "0x9D")]
	[Token(Token = "0x6000275")]
	public virtual PerformanceDataRecord Update() { }

}

