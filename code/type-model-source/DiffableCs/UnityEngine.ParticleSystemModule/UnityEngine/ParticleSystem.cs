namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
[RequireComponent(typeof(Transform))]
[Token(Token = "0x2000002")]
[UsedByNativeCode]
public sealed class ParticleSystem : Component
{
	[Token(Token = "0x2000006")]
	internal struct CollisionModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000004")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x1700004D")]
		public bool enabled
		{
			[Address(RVA = "0x31142F0", Offset = "0x31136F0", Length = "0x33")]
			[Token(Token = "0x60000F3")]
			 get { } //Length: 51
			[Address(RVA = "0x3114330", Offset = "0x3113730", Length = "0x42")]
			[NativeThrows]
			[Token(Token = "0x60000F4")]
			 set { } //Length: 66
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000F2")]
		internal CollisionModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x31142F0", Offset = "0x31136F0", Length = "0x33")]
		[Token(Token = "0x60000F3")]
		public bool get_enabled() { }

		[Address(RVA = "0x3114330", Offset = "0x3113730", Length = "0x42")]
		[NativeThrows]
		[Token(Token = "0x60000F4")]
		public void set_enabled(bool value) { }

	}

	[Token(Token = "0x2000022")]
	internal struct ColorBySpeedModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006E")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600011B")]
		internal ColorBySpeedModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000021")]
	internal struct ColorOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x1700005A")]
		public MinMaxGradient color
		{
			[Address(RVA = "0x3114420", Offset = "0x3113820", Length = "0xF9")]
			[Token(Token = "0x6000118")]
			 set { } //Length: 249
		}

		[NativeName("Color")]
		[Token(Token = "0x1700005B")]
		private MinMaxGradientBlittable colorBlittable
		{
			[Address(RVA = "0x31143D0", Offset = "0x31137D0", Length = "0x42")]
			[NativeThrows]
			[Token(Token = "0x6000119")]
			private set { } //Length: 66
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000117")]
		internal ColorOverLifetimeModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x3114420", Offset = "0x3113820", Length = "0xF9")]
		[Token(Token = "0x6000118")]
		public void set_color(MinMaxGradient value) { }

		[Address(RVA = "0x31143D0", Offset = "0x31137D0", Length = "0x42")]
		[NativeThrows]
		[Token(Token = "0x6000119")]
		private void set_colorBlittable(MinMaxGradientBlittable value) { }

		[Address(RVA = "0x3114380", Offset = "0x3113780", Length = "0x42")]
		[Token(Token = "0x600011A")]
		private static void set_colorBlittable_Injected(ref ColorOverLifetimeModule _unity_self, in MinMaxGradientBlittable value) { }

	}

	[Token(Token = "0x200002B")]
	internal struct CustomDataModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000077")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000124")]
		internal CustomDataModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000004")]
	internal struct EmissionModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000002")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x17000049")]
		public bool enabled
		{
			[Address(RVA = "0x3114520", Offset = "0x3113920", Length = "0x33")]
			[Token(Token = "0x60000EB")]
			 get { } //Length: 51
			[Address(RVA = "0x31145A0", Offset = "0x31139A0", Length = "0x42")]
			[NativeThrows]
			[Token(Token = "0x60000EC")]
			 set { } //Length: 66
		}

		[Token(Token = "0x1700004A")]
		public MinMaxCurve rateOverTime
		{
			[Address(RVA = "0x3114690", Offset = "0x3113A90", Length = "0x118")]
			[Token(Token = "0x60000ED")]
			 set { } //Length: 280
		}

		[NativeName("RateOverTime")]
		[Token(Token = "0x1700004B")]
		private MinMaxCurveBlittable rateOverTimeBlittable
		{
			[Address(RVA = "0x3114640", Offset = "0x3113A40", Length = "0x42")]
			[NativeThrows]
			[Token(Token = "0x60000EE")]
			private set { } //Length: 66
		}

		[Token(Token = "0x1700004C")]
		public float rateOverTimeMultiplier
		{
			[Address(RVA = "0x3114560", Offset = "0x3113960", Length = "0x33")]
			[Token(Token = "0x60000EF")]
			 get { } //Length: 51
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000EA")]
		internal EmissionModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x3114520", Offset = "0x3113920", Length = "0x33")]
		[Token(Token = "0x60000EB")]
		public bool get_enabled() { }

		[Address(RVA = "0x3114560", Offset = "0x3113960", Length = "0x33")]
		[Token(Token = "0x60000EF")]
		public float get_rateOverTimeMultiplier() { }

		[Address(RVA = "0x31145A0", Offset = "0x31139A0", Length = "0x42")]
		[NativeThrows]
		[Token(Token = "0x60000EC")]
		public void set_enabled(bool value) { }

		[Address(RVA = "0x3114690", Offset = "0x3113A90", Length = "0x118")]
		[Token(Token = "0x60000ED")]
		public void set_rateOverTime(MinMaxCurve value) { }

		[Address(RVA = "0x3114640", Offset = "0x3113A40", Length = "0x42")]
		[NativeThrows]
		[Token(Token = "0x60000EE")]
		private void set_rateOverTimeBlittable(MinMaxCurveBlittable value) { }

		[Address(RVA = "0x31145F0", Offset = "0x31139F0", Length = "0x42")]
		[Token(Token = "0x60000F0")]
		private static void set_rateOverTimeBlittable_Injected(ref EmissionModule _unity_self, in MinMaxCurveBlittable value) { }

	}

	[Token(Token = "0x200000F")]
	internal struct EmitParams
	{
		[FieldOffset(Offset = "0x0")]
		[NativeName("particle")]
		[Token(Token = "0x400002F")]
		private Particle m_Particle; //Field offset: 0x0
		[FieldOffset(Offset = "0x84")]
		[NativeName("positionSet")]
		[Token(Token = "0x4000030")]
		private bool m_PositionSet; //Field offset: 0x84
		[FieldOffset(Offset = "0x85")]
		[NativeName("velocitySet")]
		[Token(Token = "0x4000031")]
		private bool m_VelocitySet; //Field offset: 0x85
		[FieldOffset(Offset = "0x86")]
		[NativeName("axisOfRotationSet")]
		[Token(Token = "0x4000032")]
		private bool m_AxisOfRotationSet; //Field offset: 0x86
		[FieldOffset(Offset = "0x87")]
		[NativeName("rotationSet")]
		[Token(Token = "0x4000033")]
		private bool m_RotationSet; //Field offset: 0x87
		[FieldOffset(Offset = "0x88")]
		[NativeName("rotationalSpeedSet")]
		[Token(Token = "0x4000034")]
		private bool m_AngularVelocitySet; //Field offset: 0x88
		[FieldOffset(Offset = "0x89")]
		[NativeName("startSizeSet")]
		[Token(Token = "0x4000035")]
		private bool m_StartSizeSet; //Field offset: 0x89
		[FieldOffset(Offset = "0x8A")]
		[NativeName("startColorSet")]
		[Token(Token = "0x4000036")]
		private bool m_StartColorSet; //Field offset: 0x8A
		[FieldOffset(Offset = "0x8B")]
		[NativeName("randomSeedSet")]
		[Token(Token = "0x4000037")]
		private bool m_RandomSeedSet; //Field offset: 0x8B
		[FieldOffset(Offset = "0x8C")]
		[NativeName("startLifetimeSet")]
		[Token(Token = "0x4000038")]
		private bool m_StartLifetimeSet; //Field offset: 0x8C
		[FieldOffset(Offset = "0x8D")]
		[NativeName("meshIndexSet")]
		[Token(Token = "0x4000039")]
		private bool m_MeshIndexSet; //Field offset: 0x8D
		[FieldOffset(Offset = "0x8E")]
		[NativeName("applyShapeToPosition")]
		[Token(Token = "0x400003A")]
		private bool m_ApplyShapeToPosition; //Field offset: 0x8E

	}

	[Token(Token = "0x2000027")]
	internal struct ExternalForcesModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000073")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000120")]
		internal ExternalForcesModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000020")]
	internal struct ForceOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006C")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000116")]
		internal ForceOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x200001E")]
	internal struct InheritVelocityModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006A")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000114")]
		internal InheritVelocityModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x200001F")]
	internal struct LifetimeByEmitterSpeedModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006B")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000115")]
		internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000029")]
	internal struct LightsModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000075")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000122")]
		internal LightsModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x200001D")]
	internal struct LimitVelocityOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000113")]
		internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000003")]
	internal struct MainModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000001")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x17000036")]
		public float duration
		{
			[Address(RVA = "0x31147B0", Offset = "0x3113BB0", Length = "0x33")]
			[Token(Token = "0x60000C4")]
			 get { } //Length: 51
		}

		[Token(Token = "0x17000042")]
		public float gravityModifierMultiplier
		{
			[Address(RVA = "0x31147F0", Offset = "0x3113BF0", Length = "0x33")]
			[Token(Token = "0x60000DB")]
			 get { } //Length: 51
			[Address(RVA = "0x3114DB0", Offset = "0x31141B0", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000DC")]
			 set { } //Length: 67
		}

		[Token(Token = "0x17000037")]
		public bool loop
		{
			[Address(RVA = "0x3114830", Offset = "0x3113C30", Length = "0x33")]
			[Token(Token = "0x60000C5")]
			 get { } //Length: 51
			[Address(RVA = "0x3114E00", Offset = "0x3114200", Length = "0x42")]
			[NativeThrows]
			[Token(Token = "0x60000C6")]
			 set { } //Length: 66
		}

		[Token(Token = "0x17000047")]
		public int maxParticles
		{
			[Address(RVA = "0x3114870", Offset = "0x3113C70", Length = "0x33")]
			[Token(Token = "0x60000E5")]
			 get { } //Length: 51
			[Address(RVA = "0x3114E50", Offset = "0x3114250", Length = "0x40")]
			[NativeThrows]
			[Token(Token = "0x60000E6")]
			 set { } //Length: 64
		}

		[Token(Token = "0x17000046")]
		public bool playOnAwake
		{
			[Address(RVA = "0x31148B0", Offset = "0x3113CB0", Length = "0x33")]
			[Token(Token = "0x60000E3")]
			 get { } //Length: 51
			[Address(RVA = "0x3114E90", Offset = "0x3114290", Length = "0x42")]
			[NativeThrows]
			[Token(Token = "0x60000E4")]
			 set { } //Length: 66
		}

		[Token(Token = "0x17000045")]
		public ParticleSystemScalingMode scalingMode
		{
			[Address(RVA = "0x31148F0", Offset = "0x3113CF0", Length = "0x33")]
			[Token(Token = "0x60000E1")]
			 get { } //Length: 51
			[Address(RVA = "0x3114EE0", Offset = "0x31142E0", Length = "0x40")]
			[NativeThrows]
			[Token(Token = "0x60000E2")]
			 set { } //Length: 64
		}

		[Token(Token = "0x17000043")]
		public ParticleSystemSimulationSpace simulationSpace
		{
			[Address(RVA = "0x3114930", Offset = "0x3113D30", Length = "0x33")]
			[Token(Token = "0x60000DD")]
			 get { } //Length: 51
			[Address(RVA = "0x3114F20", Offset = "0x3114320", Length = "0x40")]
			[NativeThrows]
			[Token(Token = "0x60000DE")]
			 set { } //Length: 64
		}

		[Token(Token = "0x17000044")]
		public float simulationSpeed
		{
			[Address(RVA = "0x3114970", Offset = "0x3113D70", Length = "0x33")]
			[Token(Token = "0x60000DF")]
			 get { } //Length: 51
			[Address(RVA = "0x3114F60", Offset = "0x3114360", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000E0")]
			 set { } //Length: 67
		}

		[Token(Token = "0x17000040")]
		public MinMaxGradient startColor
		{
			[Address(RVA = "0x3114A60", Offset = "0x3113E60", Length = "0x143")]
			[Token(Token = "0x60000D7")]
			 get { } //Length: 323
			[Address(RVA = "0x3115050", Offset = "0x3114450", Length = "0xF9")]
			[Token(Token = "0x60000D8")]
			 set { } //Length: 249
		}

		[NativeName("StartColor")]
		[Token(Token = "0x17000041")]
		private MinMaxGradientBlittable startColorBlittable
		{
			[Address(RVA = "0x3114A00", Offset = "0x3113E00", Length = "0x59")]
			[Token(Token = "0x60000D9")]
			private get { } //Length: 89
			[Address(RVA = "0x3115000", Offset = "0x3114400", Length = "0x42")]
			[NativeThrows]
			[Token(Token = "0x60000DA")]
			private set { } //Length: 66
		}

		[Token(Token = "0x17000038")]
		public float startDelayMultiplier
		{
			[Address(RVA = "0x3114BB0", Offset = "0x3113FB0", Length = "0x33")]
			[Token(Token = "0x60000C7")]
			 get { } //Length: 51
			[Address(RVA = "0x3115150", Offset = "0x3114550", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000C8")]
			 set { } //Length: 67
		}

		[Token(Token = "0x17000039")]
		public float startLifetimeMultiplier
		{
			[Address(RVA = "0x3114BF0", Offset = "0x3113FF0", Length = "0x33")]
			[Token(Token = "0x60000C9")]
			 get { } //Length: 51
			[Address(RVA = "0x31151A0", Offset = "0x31145A0", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000CA")]
			 set { } //Length: 67
		}

		[NativeName("StartRotationZMultiplier")]
		[Token(Token = "0x1700003C")]
		public float startRotationMultiplier
		{
			[Address(RVA = "0x3114C30", Offset = "0x3114030", Length = "0x33")]
			[Token(Token = "0x60000CF")]
			 get { } //Length: 51
			[Address(RVA = "0x31151F0", Offset = "0x31145F0", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000D0")]
			 set { } //Length: 67
		}

		[Token(Token = "0x1700003D")]
		public float startRotationXMultiplier
		{
			[Address(RVA = "0x3114C70", Offset = "0x3114070", Length = "0x33")]
			[Token(Token = "0x60000D1")]
			 get { } //Length: 51
			[Address(RVA = "0x3115240", Offset = "0x3114640", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000D2")]
			 set { } //Length: 67
		}

		[Token(Token = "0x1700003E")]
		public float startRotationYMultiplier
		{
			[Address(RVA = "0x3114CB0", Offset = "0x31140B0", Length = "0x33")]
			[Token(Token = "0x60000D3")]
			 get { } //Length: 51
			[Address(RVA = "0x3115290", Offset = "0x3114690", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000D4")]
			 set { } //Length: 67
		}

		[Token(Token = "0x1700003F")]
		public float startRotationZMultiplier
		{
			[Address(RVA = "0x3114CF0", Offset = "0x31140F0", Length = "0x33")]
			[Token(Token = "0x60000D5")]
			 get { } //Length: 51
			[Address(RVA = "0x31152E0", Offset = "0x31146E0", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000D6")]
			 set { } //Length: 67
		}

		[NativeName("StartSizeXMultiplier")]
		[Token(Token = "0x1700003B")]
		public float startSizeMultiplier
		{
			[Address(RVA = "0x3114D30", Offset = "0x3114130", Length = "0x33")]
			[Token(Token = "0x60000CD")]
			 get { } //Length: 51
			[Address(RVA = "0x3115330", Offset = "0x3114730", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000CE")]
			 set { } //Length: 67
		}

		[Token(Token = "0x1700003A")]
		public float startSpeedMultiplier
		{
			[Address(RVA = "0x3114D70", Offset = "0x3114170", Length = "0x33")]
			[Token(Token = "0x60000CB")]
			 get { } //Length: 51
			[Address(RVA = "0x3115380", Offset = "0x3114780", Length = "0x43")]
			[NativeThrows]
			[Token(Token = "0x60000CC")]
			 set { } //Length: 67
		}

		[Token(Token = "0x17000048")]
		public ParticleSystemStopAction stopAction
		{
			[Address(RVA = "0x31153D0", Offset = "0x31147D0", Length = "0x40")]
			[NativeThrows]
			[Token(Token = "0x60000E7")]
			 set { } //Length: 64
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000C3")]
		internal MainModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x31147B0", Offset = "0x3113BB0", Length = "0x33")]
		[Token(Token = "0x60000C4")]
		public float get_duration() { }

		[Address(RVA = "0x31147F0", Offset = "0x3113BF0", Length = "0x33")]
		[Token(Token = "0x60000DB")]
		public float get_gravityModifierMultiplier() { }

		[Address(RVA = "0x3114830", Offset = "0x3113C30", Length = "0x33")]
		[Token(Token = "0x60000C5")]
		public bool get_loop() { }

		[Address(RVA = "0x3114870", Offset = "0x3113C70", Length = "0x33")]
		[Token(Token = "0x60000E5")]
		public int get_maxParticles() { }

		[Address(RVA = "0x31148B0", Offset = "0x3113CB0", Length = "0x33")]
		[Token(Token = "0x60000E3")]
		public bool get_playOnAwake() { }

		[Address(RVA = "0x31148F0", Offset = "0x3113CF0", Length = "0x33")]
		[Token(Token = "0x60000E1")]
		public ParticleSystemScalingMode get_scalingMode() { }

		[Address(RVA = "0x3114930", Offset = "0x3113D30", Length = "0x33")]
		[Token(Token = "0x60000DD")]
		public ParticleSystemSimulationSpace get_simulationSpace() { }

		[Address(RVA = "0x3114970", Offset = "0x3113D70", Length = "0x33")]
		[Token(Token = "0x60000DF")]
		public float get_simulationSpeed() { }

		[Address(RVA = "0x3114A60", Offset = "0x3113E60", Length = "0x143")]
		[Token(Token = "0x60000D7")]
		public MinMaxGradient get_startColor() { }

		[Address(RVA = "0x3114A00", Offset = "0x3113E00", Length = "0x59")]
		[Token(Token = "0x60000D9")]
		private MinMaxGradientBlittable get_startColorBlittable() { }

		[Address(RVA = "0x31149B0", Offset = "0x3113DB0", Length = "0x42")]
		[Token(Token = "0x60000E8")]
		private static void get_startColorBlittable_Injected(ref MainModule _unity_self, out MinMaxGradientBlittable ret) { }

		[Address(RVA = "0x3114BB0", Offset = "0x3113FB0", Length = "0x33")]
		[Token(Token = "0x60000C7")]
		public float get_startDelayMultiplier() { }

		[Address(RVA = "0x3114BF0", Offset = "0x3113FF0", Length = "0x33")]
		[Token(Token = "0x60000C9")]
		public float get_startLifetimeMultiplier() { }

		[Address(RVA = "0x3114C30", Offset = "0x3114030", Length = "0x33")]
		[Token(Token = "0x60000CF")]
		public float get_startRotationMultiplier() { }

		[Address(RVA = "0x3114C70", Offset = "0x3114070", Length = "0x33")]
		[Token(Token = "0x60000D1")]
		public float get_startRotationXMultiplier() { }

		[Address(RVA = "0x3114CB0", Offset = "0x31140B0", Length = "0x33")]
		[Token(Token = "0x60000D3")]
		public float get_startRotationYMultiplier() { }

		[Address(RVA = "0x3114CF0", Offset = "0x31140F0", Length = "0x33")]
		[Token(Token = "0x60000D5")]
		public float get_startRotationZMultiplier() { }

		[Address(RVA = "0x3114D30", Offset = "0x3114130", Length = "0x33")]
		[Token(Token = "0x60000CD")]
		public float get_startSizeMultiplier() { }

		[Address(RVA = "0x3114D70", Offset = "0x3114170", Length = "0x33")]
		[Token(Token = "0x60000CB")]
		public float get_startSpeedMultiplier() { }

		[Address(RVA = "0x3114DB0", Offset = "0x31141B0", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000DC")]
		public void set_gravityModifierMultiplier(float value) { }

		[Address(RVA = "0x3114E00", Offset = "0x3114200", Length = "0x42")]
		[NativeThrows]
		[Token(Token = "0x60000C6")]
		public void set_loop(bool value) { }

		[Address(RVA = "0x3114E50", Offset = "0x3114250", Length = "0x40")]
		[NativeThrows]
		[Token(Token = "0x60000E6")]
		public void set_maxParticles(int value) { }

		[Address(RVA = "0x3114E90", Offset = "0x3114290", Length = "0x42")]
		[NativeThrows]
		[Token(Token = "0x60000E4")]
		public void set_playOnAwake(bool value) { }

		[Address(RVA = "0x3114EE0", Offset = "0x31142E0", Length = "0x40")]
		[NativeThrows]
		[Token(Token = "0x60000E2")]
		public void set_scalingMode(ParticleSystemScalingMode value) { }

		[Address(RVA = "0x3114F20", Offset = "0x3114320", Length = "0x40")]
		[NativeThrows]
		[Token(Token = "0x60000DE")]
		public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

		[Address(RVA = "0x3114F60", Offset = "0x3114360", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000E0")]
		public void set_simulationSpeed(float value) { }

		[Address(RVA = "0x3115050", Offset = "0x3114450", Length = "0xF9")]
		[Token(Token = "0x60000D8")]
		public void set_startColor(MinMaxGradient value) { }

		[Address(RVA = "0x3115000", Offset = "0x3114400", Length = "0x42")]
		[NativeThrows]
		[Token(Token = "0x60000DA")]
		private void set_startColorBlittable(MinMaxGradientBlittable value) { }

		[Address(RVA = "0x3114FB0", Offset = "0x31143B0", Length = "0x42")]
		[Token(Token = "0x60000E9")]
		private static void set_startColorBlittable_Injected(ref MainModule _unity_self, in MinMaxGradientBlittable value) { }

		[Address(RVA = "0x3115150", Offset = "0x3114550", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000C8")]
		public void set_startDelayMultiplier(float value) { }

		[Address(RVA = "0x31151A0", Offset = "0x31145A0", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000CA")]
		public void set_startLifetimeMultiplier(float value) { }

		[Address(RVA = "0x31151F0", Offset = "0x31145F0", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000D0")]
		public void set_startRotationMultiplier(float value) { }

		[Address(RVA = "0x3115240", Offset = "0x3114640", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000D2")]
		public void set_startRotationXMultiplier(float value) { }

		[Address(RVA = "0x3115290", Offset = "0x3114690", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000D4")]
		public void set_startRotationYMultiplier(float value) { }

		[Address(RVA = "0x31152E0", Offset = "0x31146E0", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000D6")]
		public void set_startRotationZMultiplier(float value) { }

		[Address(RVA = "0x3115330", Offset = "0x3114730", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000CE")]
		public void set_startSizeMultiplier(float value) { }

		[Address(RVA = "0x3115380", Offset = "0x3114780", Length = "0x43")]
		[NativeThrows]
		[Token(Token = "0x60000CC")]
		public void set_startSpeedMultiplier(float value) { }

		[Address(RVA = "0x31153D0", Offset = "0x31147D0", Length = "0x40")]
		[NativeThrows]
		[Token(Token = "0x60000E7")]
		public void set_stopAction(ParticleSystemStopAction value) { }

	}

	[Token(Token = "0x200000B")]
	internal struct MinMaxCurve
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000019")]
		internal ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		[Token(Token = "0x400001A")]
		internal float m_CurveMultiplier; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x400001B")]
		internal AnimationCurve m_CurveMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x400001C")]
		internal AnimationCurve m_CurveMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x400001D")]
		internal float m_ConstantMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Token(Token = "0x400001E")]
		internal float m_ConstantMax; //Field offset: 0x1C

		[Address(RVA = "0x3115560", Offset = "0x3114960", Length = "0x50")]
		[Token(Token = "0x6000105")]
		public MinMaxCurve(float constant) { }

		[Address(RVA = "0x31155B0", Offset = "0x31149B0", Length = "0x87")]
		[Token(Token = "0x6000106")]
		public static MinMaxCurve op_Implicit(float constant) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	[Token(Token = "0x200000C")]
	public struct MinMaxCurveBlittable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400001F")]
		private ParticleSystemCurveMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000020")]
		private float m_CurveMultiplier; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000021")]
		private IntPtr m_CurveMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000022")]
		private IntPtr m_CurveMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000023")]
		internal float m_ConstantMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x4000024")]
		internal float m_ConstantMax; //Field offset: 0x1C

		[Address(RVA = "0x3115410", Offset = "0x3114810", Length = "0xA1")]
		[Token(Token = "0x6000108")]
		internal static MinMaxCurveBlittable FromMixMaxCurve(in MinMaxCurve minMaxCurve) { }

		[Address(RVA = "0x31154C0", Offset = "0x31148C0", Length = "0x9A")]
		[Token(Token = "0x6000107")]
		public static MinMaxCurveBlittable op_Implicit(MinMaxCurve minMaxCurve) { }

	}

	[Token(Token = "0x200000D")]
	internal struct MinMaxGradient
	{
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Token(Token = "0x4000025")]
		internal ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[Token(Token = "0x4000026")]
		internal Gradient m_GradientMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Token(Token = "0x4000027")]
		internal Gradient m_GradientMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Token(Token = "0x4000028")]
		internal Color m_ColorMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Token(Token = "0x4000029")]
		internal Color m_ColorMax; //Field offset: 0x28

		[Token(Token = "0x17000059")]
		public Color color
		{
			[Address(RVA = "0x3115A30", Offset = "0x3114E30", Length = "0xB")]
			[Token(Token = "0x600010A")]
			 get { } //Length: 11
			[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
			[Token(Token = "0x600010B")]
			 set { } //Length: 8
		}

		[Address(RVA = "0x31159D0", Offset = "0x3114DD0", Length = "0x5A")]
		[Token(Token = "0x6000109")]
		public MinMaxGradient(Color color) { }

		[Address(RVA = "0x3115A30", Offset = "0x3114E30", Length = "0xB")]
		[Token(Token = "0x600010A")]
		public Color get_color() { }

		[Address(RVA = "0x3115A40", Offset = "0x3114E40", Length = "0xB1")]
		[Token(Token = "0x600010C")]
		public static MinMaxGradient op_Implicit(Color color) { }

		[Address(RVA = "0x1FF5900", Offset = "0x1FF4D00", Length = "0x8")]
		[Token(Token = "0x600010B")]
		public void set_color(Color value) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
	[RequiredByNativeCode]
	[Token(Token = "0x200000E")]
	public struct MinMaxGradientBlittable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400002A")]
		private ParticleSystemGradientMode m_Mode; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400002B")]
		private IntPtr m_GradientMin; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400002C")]
		private IntPtr m_GradientMax; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400002D")]
		private Color m_ColorMin; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400002E")]
		private Color m_ColorMax; //Field offset: 0x28

		[Address(RVA = "0x3115640", Offset = "0x3114A40", Length = "0xAA")]
		[Token(Token = "0x600010F")]
		internal static MinMaxGradientBlittable FromMixMaxGradient(in MinMaxGradient minMaxGradient) { }

		[Address(RVA = "0x3115820", Offset = "0x3114C20", Length = "0x106")]
		[Token(Token = "0x600010D")]
		public static MinMaxGradient op_Implicit(MinMaxGradientBlittable minMaxGradientBlittable) { }

		[Address(RVA = "0x3115930", Offset = "0x3114D30", Length = "0x99")]
		[Token(Token = "0x600010E")]
		public static MinMaxGradientBlittable op_Implicit(MinMaxGradient minMaxGradient) { }

		[Address(RVA = "0x31156F0", Offset = "0x3114AF0", Length = "0x12A")]
		[Token(Token = "0x6000110")]
		internal static MinMaxGradient ToMinMaxGradient(in MinMaxGradientBlittable minMaxGradientBlittable) { }

	}

	[Token(Token = "0x2000028")]
	internal struct NoiseModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000074")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000121")]
		internal NoiseModule(ParticleSystem particleSystem) { }

	}

	[RequiredByNativeCode("particleSystemParticle", Optional = True)]
	[Token(Token = "0x200000A")]
	internal struct Particle
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000008")]
		private Vector3 m_Position; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000009")]
		private Vector3 m_Velocity; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400000A")]
		private Vector3 m_AnimatedVelocity; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400000B")]
		private Vector3 m_InitialVelocity; //Field offset: 0x24
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400000C")]
		private Vector3 m_AxisOfRotation; //Field offset: 0x30
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x400000D")]
		private Vector3 m_Rotation; //Field offset: 0x3C
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400000E")]
		private Vector3 m_AngularVelocity; //Field offset: 0x48
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x400000F")]
		private Vector3 m_StartSize; //Field offset: 0x54
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000010")]
		private Color32 m_StartColor; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4000011")]
		private uint m_RandomSeed; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000012")]
		private uint m_ParentRandomSeed; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000013")]
		private float m_Lifetime; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000014")]
		private float m_StartLifetime; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000015")]
		private int m_MeshIndex; //Field offset: 0x74
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000016")]
		private float m_EmitAccumulator0; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000017")]
		private float m_EmitAccumulator1; //Field offset: 0x7C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000018")]
		private uint m_Flags; //Field offset: 0x80

		[Token(Token = "0x17000058")]
		public Vector3 angularVelocity3D
		{
			[Address(RVA = "0x3121050", Offset = "0x3120450", Length = "0x3F")]
			[Token(Token = "0x6000104")]
			 set { } //Length: 63
		}

		[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", False)]
		[Token(Token = "0x1700004F")]
		public float lifetime
		{
			[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
			[Token(Token = "0x60000FB")]
			 set { } //Length: 6
		}

		[Token(Token = "0x17000050")]
		public Vector3 position
		{
			[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
			[Token(Token = "0x60000FC")]
			 set { } //Length: 15
		}

		[Token(Token = "0x17000055")]
		public uint randomSeed
		{
			[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
			[Token(Token = "0x6000101")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000052")]
		public float remainingLifetime
		{
			[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
			[Token(Token = "0x60000FE")]
			 set { } //Length: 6
		}

		[Token(Token = "0x17000057")]
		public Vector3 rotation3D
		{
			[Address(RVA = "0x3121090", Offset = "0x3120490", Length = "0x3F")]
			[Token(Token = "0x6000103")]
			 set { } //Length: 63
		}

		[Token(Token = "0x17000054")]
		public Color32 startColor
		{
			[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
			[Token(Token = "0x6000100")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000053")]
		public float startLifetime
		{
			[Address(RVA = "0x3098350", Offset = "0x3097750", Length = "0x6")]
			[Token(Token = "0x60000FF")]
			 set { } //Length: 6
		}

		[Token(Token = "0x17000056")]
		public float startSize
		{
			[Address(RVA = "0x31210D0", Offset = "0x31204D0", Length = "0x11")]
			[Token(Token = "0x6000102")]
			 set { } //Length: 17
		}

		[Token(Token = "0x17000051")]
		public Vector3 velocity
		{
			[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
			[Token(Token = "0x60000FD")]
			 set { } //Length: 106
		}

		[Address(RVA = "0x3121050", Offset = "0x3120450", Length = "0x3F")]
		[Token(Token = "0x6000104")]
		public void set_angularVelocity3D(Vector3 value) { }

		[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
		[Token(Token = "0x60000FB")]
		public void set_lifetime(float value) { }

		[Address(RVA = "0x28A7D50", Offset = "0x28A7150", Length = "0xF")]
		[Token(Token = "0x60000FC")]
		public void set_position(Vector3 value) { }

		[Address(RVA = "0x121E600", Offset = "0x121DA00", Length = "0x4")]
		[Token(Token = "0x6000101")]
		public void set_randomSeed(uint value) { }

		[Address(RVA = "0x16D0A90", Offset = "0x16CFE90", Length = "0x6")]
		[Token(Token = "0x60000FE")]
		public void set_remainingLifetime(float value) { }

		[Address(RVA = "0x3121090", Offset = "0x3120490", Length = "0x3F")]
		[Token(Token = "0x6000103")]
		public void set_rotation3D(Vector3 value) { }

		[Address(RVA = "0x2069190", Offset = "0x2068590", Length = "0x4")]
		[Token(Token = "0x6000100")]
		public void set_startColor(Color32 value) { }

		[Address(RVA = "0x3098350", Offset = "0x3097750", Length = "0x6")]
		[Token(Token = "0x60000FF")]
		public void set_startLifetime(float value) { }

		[Address(RVA = "0x31210D0", Offset = "0x31204D0", Length = "0x11")]
		[Token(Token = "0x6000102")]
		public void set_startSize(float value) { }

		[Address(RVA = "0x2E7FCE0", Offset = "0x2E7F0E0", Length = "0x6A")]
		[Token(Token = "0x60000FD")]
		public void set_velocity(Vector3 value) { }

	}

	[Token(Token = "0x2000010")]
	internal struct PlaybackState
	{
		[Token(Token = "0x2000017")]
		public struct Collision
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400005C")]
			public Seed4 m_Random; //Field offset: 0x0

		}

		[Token(Token = "0x2000013")]
		public struct Emission
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400004F")]
			public float m_ParticleSpacing; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000050")]
			public float m_ToEmitAccumulator; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000051")]
			public Seed m_Random; //Field offset: 0x8

		}

		[Token(Token = "0x2000016")]
		public struct Force
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400005B")]
			public Seed4 m_Random; //Field offset: 0x0

		}

		[Token(Token = "0x2000014")]
		public struct Initial
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000052")]
			public Seed4 m_Random; //Field offset: 0x0

		}

		[Token(Token = "0x2000019")]
		public struct Lights
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400005E")]
			public Seed m_Random; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400005F")]
			public float m_ParticleEmissionCounter; //Field offset: 0x10

		}

		[Token(Token = "0x2000018")]
		public struct Noise
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400005D")]
			public float m_ScrollOffset; //Field offset: 0x0

		}

		[Token(Token = "0x2000011")]
		public struct Seed
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000047")]
			public uint x; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000048")]
			public uint y; //Field offset: 0x4
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000049")]
			public uint z; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x400004A")]
			public uint w; //Field offset: 0xC

		}

		[Token(Token = "0x2000012")]
		public struct Seed4
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400004B")]
			public Seed x; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400004C")]
			public Seed y; //Field offset: 0x10
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400004D")]
			public Seed z; //Field offset: 0x20
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x400004E")]
			public Seed w; //Field offset: 0x30

		}

		[Token(Token = "0x2000015")]
		public struct Shape
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000053")]
			public Seed4 m_Random; //Field offset: 0x0
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000054")]
			public float m_RadiusTimer; //Field offset: 0x40
			[FieldOffset(Offset = "0x44")]
			[Token(Token = "0x4000055")]
			public float m_RadiusTimerPrev; //Field offset: 0x44
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x4000056")]
			public float m_ArcTimer; //Field offset: 0x48
			[FieldOffset(Offset = "0x4C")]
			[Token(Token = "0x4000057")]
			public float m_ArcTimerPrev; //Field offset: 0x4C
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x4000058")]
			public float m_MeshSpawnTimer; //Field offset: 0x50
			[FieldOffset(Offset = "0x54")]
			[Token(Token = "0x4000059")]
			public float m_MeshSpawnTimerPrev; //Field offset: 0x54
			[FieldOffset(Offset = "0x58")]
			[Token(Token = "0x400005A")]
			public int m_OrderedMeshVertexIndex; //Field offset: 0x58

		}

		[Token(Token = "0x200001A")]
		public struct Trail
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000060")]
			public float m_Timer; //Field offset: 0x0

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400003B")]
		internal float m_AccumulatedDt; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400003C")]
		internal float m_StartDelay; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400003D")]
		internal float m_PlaybackTime; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400003E")]
		internal int m_RingBufferIndex; //Field offset: 0xC
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400003F")]
		internal Emission m_Emission; //Field offset: 0x10
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000040")]
		internal Initial m_Initial; //Field offset: 0x28
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000041")]
		internal Shape m_Shape; //Field offset: 0x68
		[FieldOffset(Offset = "0xC4")]
		[Token(Token = "0x4000042")]
		internal Force m_Force; //Field offset: 0xC4
		[FieldOffset(Offset = "0x104")]
		[Token(Token = "0x4000043")]
		internal Collision m_Collision; //Field offset: 0x104
		[FieldOffset(Offset = "0x144")]
		[Token(Token = "0x4000044")]
		internal Noise m_Noise; //Field offset: 0x144
		[FieldOffset(Offset = "0x148")]
		[Token(Token = "0x4000045")]
		internal Lights m_Lights; //Field offset: 0x148
		[FieldOffset(Offset = "0x15C")]
		[Token(Token = "0x4000046")]
		internal Trail m_Trail; //Field offset: 0x15C

	}

	[Token(Token = "0x2000026")]
	internal struct RotationBySpeedModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000072")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600011F")]
		internal RotationBySpeedModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000025")]
	internal struct RotationOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000071")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600011E")]
		internal RotationOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000005")]
	internal struct ShapeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000003")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000F1")]
		internal ShapeModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000024")]
	internal struct SizeBySpeedModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000070")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600011D")]
		internal SizeBySpeedModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000023")]
	internal struct SizeOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006F")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x600011C")]
		internal SizeOverLifetimeModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x2000008")]
	internal struct SubEmittersModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000006")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Token(Token = "0x1700004E")]
		public int subEmittersCount
		{
			[Address(RVA = "0x31211A0", Offset = "0x31205A0", Length = "0x33")]
			[Token(Token = "0x60000F7")]
			 get { } //Length: 51
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000F6")]
		internal SubEmittersModule(ParticleSystem particleSystem) { }

		[Address(RVA = "0x31211A0", Offset = "0x31205A0", Length = "0x33")]
		[Token(Token = "0x60000F7")]
		public int get_subEmittersCount() { }

		[Address(RVA = "0x3121130", Offset = "0x3120530", Length = "0x6A")]
		[NativeThrows]
		[Token(Token = "0x60000F8")]
		public ParticleSystem GetSubEmitterSystem(int index) { }

		[Address(RVA = "0x31210F0", Offset = "0x31204F0", Length = "0x40")]
		[Token(Token = "0x60000F9")]
		private static IntPtr GetSubEmitterSystem_Injected(ref SubEmittersModule _unity_self, int index) { }

	}

	[Token(Token = "0x2000009")]
	internal struct TextureSheetAnimationModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000007")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000FA")]
		internal TextureSheetAnimationModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x200002A")]
	internal struct TrailModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000076")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000123")]
		internal TrailModule(ParticleSystem particleSystem) { }

	}

	[NativeType(CodegenOptions::Custom (1), "MonoParticleTrails")]
	[Token(Token = "0x200001B")]
	internal struct Trails
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000061")]
		internal List<Vector4> positions; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000062")]
		internal List<Int32> frontPositions; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000063")]
		internal List<Int32> backPositions; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000064")]
		internal List<Int32> positionCounts; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000065")]
		internal List<Single> textureOffsets; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000066")]
		internal int maxTrailCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000067")]
		internal int maxPositionsPerTrailCount; //Field offset: 0x2C

		[Address(RVA = "0x31211E0", Offset = "0x31205E0", Length = "0x248")]
		[Token(Token = "0x6000111")]
		internal void Allocate() { }

	}

	[Token(Token = "0x2000007")]
	internal struct TriggerModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000005")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60000F5")]
		internal TriggerModule(ParticleSystem particleSystem) { }

	}

	[Token(Token = "0x200001C")]
	internal struct VelocityOverLifetimeModule
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000068")]
		internal ParticleSystem m_ParticleSystem; //Field offset: 0x0

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6000112")]
		internal VelocityOverLifetimeModule(ParticleSystem particleSystem) { }

	}


	[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", True)]
	[Token(Token = "0x17000012")]
	public bool automaticCullingEnabled
	{
		[Address(RVA = "0x311F5C0", Offset = "0x311E9C0", Length = "0x76")]
		[Token(Token = "0x6000025")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700002F")]
	public CollisionModule collision
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000089")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000028")]
	public ColorBySpeedModule colorBySpeed
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000082")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000027")]
	public ColorOverLifetimeModule colorOverLifetime
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000081")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000035")]
	public CustomDataModule customData
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600008F")]
		 get { } //Length: 32
	}

	[Obsolete("duration property is deprecated. Use main.duration instead.", False)]
	[Token(Token = "0x17000004")]
	public float duration
	{
		[Address(RVA = "0x311F640", Offset = "0x311EA40", Length = "0x54")]
		[Token(Token = "0x600000A")]
		 get { } //Length: 84
	}

	[Token(Token = "0x17000020")]
	public EmissionModule emission
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600007A")]
		 get { } //Length: 32
	}

	[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", False)]
	[Token(Token = "0x17000007")]
	public float emissionRate
	{
		[Address(RVA = "0x311F6A0", Offset = "0x311EAA0", Length = "0x54")]
		[Token(Token = "0x600000F")]
		 get { } //Length: 84
		[Address(RVA = "0x3120600", Offset = "0x311FA00", Length = "0xDE")]
		[Token(Token = "0x6000010")]
		 set { } //Length: 222
	}

	[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", False)]
	[Token(Token = "0x17000006")]
	public bool enableEmission
	{
		[Address(RVA = "0x311F700", Offset = "0x311EB00", Length = "0x54")]
		[Token(Token = "0x600000D")]
		 get { } //Length: 84
		[Address(RVA = "0x31206E0", Offset = "0x311FAE0", Length = "0x5D")]
		[Token(Token = "0x600000E")]
		 set { } //Length: 93
	}

	[Token(Token = "0x1700002D")]
	public ExternalForcesModule externalForces
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000087")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000026")]
	public ForceOverLifetimeModule forceOverLifetime
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000080")]
		 get { } //Length: 32
	}

	[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", False)]
	[Token(Token = "0x1700000E")]
	public float gravityModifier
	{
		[Address(RVA = "0x311F760", Offset = "0x311EB60", Length = "0x54")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 84
		[Address(RVA = "0x3120740", Offset = "0x311FB40", Length = "0x64")]
		[Token(Token = "0x600001E")]
		 set { } //Length: 100
	}

	[Token(Token = "0x1700001D")]
	public bool has3DParticleRotations
	{
		[Address(RVA = "0x311F800", Offset = "0x311EC00", Length = "0x76")]
		[NativeName("Has3DParticleRotations")]
		[Token(Token = "0x6000071")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700001E")]
	public bool hasNonUniformParticleSizes
	{
		[Address(RVA = "0x311F8C0", Offset = "0x311ECC0", Length = "0x76")]
		[NativeName("HasNonUniformParticleSizes")]
		[Token(Token = "0x6000072")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000024")]
	public InheritVelocityModule inheritVelocity
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600007E")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000014")]
	public bool isEmitting
	{
		[Address(RVA = "0x311F980", Offset = "0x311ED80", Length = "0x76")]
		[NativeName("SyncJobs(false)->IsEmitting")]
		[Token(Token = "0x6000027")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000016")]
	public bool isPaused
	{
		[Address(RVA = "0x311FA40", Offset = "0x311EE40", Length = "0x76")]
		[NativeName("SyncJobs(false)->IsPaused")]
		[Token(Token = "0x6000029")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000013")]
	public bool isPlaying
	{
		[Address(RVA = "0x311FB00", Offset = "0x311EF00", Length = "0x76")]
		[NativeName("SyncJobs(false)->IsPlaying")]
		[Token(Token = "0x6000026")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000015")]
	public bool isStopped
	{
		[Address(RVA = "0x311FBC0", Offset = "0x311EFC0", Length = "0x76")]
		[NativeName("SyncJobs(false)->IsStopped")]
		[Token(Token = "0x6000028")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000025")]
	public LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600007F")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000033")]
	public LightsModule lights
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600008D")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000023")]
	public LimitVelocityOverLifetimeModule limitVelocityOverLifetime
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600007D")]
		 get { } //Length: 32
	}

	[Obsolete("loop property is deprecated. Use main.loop instead.", False)]
	[Token(Token = "0x17000002")]
	public bool loop
	{
		[Address(RVA = "0x311FC40", Offset = "0x311F040", Length = "0x54")]
		[Token(Token = "0x6000006")]
		 get { } //Length: 84
		[Address(RVA = "0x31207B0", Offset = "0x311FBB0", Length = "0x5D")]
		[Token(Token = "0x6000007")]
		 set { } //Length: 93
	}

	[Token(Token = "0x1700001F")]
	public MainModule main
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000079")]
		 get { } //Length: 32
	}

	[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", False)]
	[Token(Token = "0x1700000F")]
	public int maxParticles
	{
		[Address(RVA = "0x311FCA0", Offset = "0x311F0A0", Length = "0x54")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 84
		[Address(RVA = "0x3120810", Offset = "0x311FC10", Length = "0x5B")]
		[Token(Token = "0x6000020")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700002E")]
	public NoiseModule noise
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000088")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000017")]
	public int particleCount
	{
		[Address(RVA = "0x311FD40", Offset = "0x311F140", Length = "0x76")]
		[NativeName("SyncJobs(false)->GetParticleCount")]
		[Token(Token = "0x600002A")]
		 get { } //Length: 118
	}

	[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", False)]
	[Token(Token = "0x17000005")]
	public float playbackSpeed
	{
		[Address(RVA = "0x311FE20", Offset = "0x311F220", Length = "0x54")]
		[Token(Token = "0x600000B")]
		 get { } //Length: 84
		[Address(RVA = "0x31208D0", Offset = "0x311FCD0", Length = "0x64")]
		[Token(Token = "0x600000C")]
		 set { } //Length: 100
	}

	[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", False)]
	[Token(Token = "0x17000003")]
	public bool playOnAwake
	{
		[Address(RVA = "0x311FDC0", Offset = "0x311F1C0", Length = "0x54")]
		[Token(Token = "0x6000008")]
		 get { } //Length: 84
		[Address(RVA = "0x3120870", Offset = "0x311FC70", Length = "0x5D")]
		[Token(Token = "0x6000009")]
		 set { } //Length: 93
	}

	[Token(Token = "0x1700001C")]
	public bool proceduralSimulationSupported
	{
		[Address(RVA = "0x311F5C0", Offset = "0x311E9C0", Length = "0x76")]
		[Token(Token = "0x6000032")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700001A")]
	public uint randomSeed
	{
		[Address(RVA = "0x311FF00", Offset = "0x311F300", Length = "0x76")]
		[NativeName("GetRandomSeed")]
		[Token(Token = "0x600002E")]
		 get { } //Length: 118
		[Address(RVA = "0x3120980", Offset = "0x311FD80", Length = "0x83")]
		[NativeName("SyncJobs(false)->SetRandomSeed")]
		[Token(Token = "0x600002F")]
		 set { } //Length: 131
	}

	[Token(Token = "0x1700002C")]
	public RotationBySpeedModule rotationBySpeed
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000086")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700002B")]
	public RotationOverLifetimeModule rotationOverLifetime
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000085")]
		 get { } //Length: 32
	}

	[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", False)]
	[Token(Token = "0x17000011")]
	public ParticleSystemScalingMode scalingMode
	{
		[Address(RVA = "0x311FF80", Offset = "0x311F380", Length = "0x54")]
		[Token(Token = "0x6000023")]
		 get { } //Length: 84
		[Address(RVA = "0x3120A10", Offset = "0x311FE10", Length = "0x5B")]
		[Token(Token = "0x6000024")]
		 set { } //Length: 91
	}

	[Token(Token = "0x17000021")]
	public ShapeModule shape
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600007B")]
		 get { } //Length: 32
	}

	[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", False)]
	[Token(Token = "0x17000010")]
	public ParticleSystemSimulationSpace simulationSpace
	{
		[Address(RVA = "0x311FFE0", Offset = "0x311F3E0", Length = "0x54")]
		[Token(Token = "0x6000021")]
		 get { } //Length: 84
		[Address(RVA = "0x3120A70", Offset = "0x311FE70", Length = "0x5B")]
		[Token(Token = "0x6000022")]
		 set { } //Length: 91
	}

	[Token(Token = "0x1700002A")]
	public SizeBySpeedModule sizeBySpeed
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000084")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000029")]
	public SizeOverLifetimeModule sizeOverLifetime
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x6000083")]
		 get { } //Length: 32
	}

	[Obsolete("startColor property is deprecated. Use main.startColor instead.", False)]
	[Token(Token = "0x1700000A")]
	public Color startColor
	{
		[Address(RVA = "0x3120040", Offset = "0x311F440", Length = "0x74")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 116
		[Address(RVA = "0x3120AD0", Offset = "0x311FED0", Length = "0xC7")]
		[Token(Token = "0x6000016")]
		 set { } //Length: 199
	}

	[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", False)]
	[Token(Token = "0x17000001")]
	public float startDelay
	{
		[Address(RVA = "0x31200C0", Offset = "0x311F4C0", Length = "0x54")]
		[Token(Token = "0x6000004")]
		 get { } //Length: 84
		[Address(RVA = "0x3120BA0", Offset = "0x311FFA0", Length = "0x64")]
		[Token(Token = "0x6000005")]
		 set { } //Length: 100
	}

	[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", False)]
	[Token(Token = "0x1700000D")]
	public float startLifetime
	{
		[Address(RVA = "0x3120120", Offset = "0x311F520", Length = "0x54")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 84
		[Address(RVA = "0x3120C10", Offset = "0x3120010", Length = "0x64")]
		[Token(Token = "0x600001C")]
		 set { } //Length: 100
	}

	[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", False)]
	[Token(Token = "0x1700000B")]
	public float startRotation
	{
		[Address(RVA = "0x31202A0", Offset = "0x311F6A0", Length = "0x54")]
		[Token(Token = "0x6000017")]
		 get { } //Length: 84
		[Address(RVA = "0x3120D40", Offset = "0x3120140", Length = "0x64")]
		[Token(Token = "0x6000018")]
		 set { } //Length: 100
	}

	[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", False)]
	[Token(Token = "0x1700000C")]
	public Vector3 startRotation3D
	{
		[Address(RVA = "0x3120180", Offset = "0x311F580", Length = "0x118")]
		[Token(Token = "0x6000019")]
		 get { } //Length: 280
		[Address(RVA = "0x3120C80", Offset = "0x3120080", Length = "0xB4")]
		[Token(Token = "0x600001A")]
		 set { } //Length: 180
	}

	[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", False)]
	[Token(Token = "0x17000009")]
	public float startSize
	{
		[Address(RVA = "0x3120300", Offset = "0x311F700", Length = "0x54")]
		[Token(Token = "0x6000013")]
		 get { } //Length: 84
		[Address(RVA = "0x3120DB0", Offset = "0x31201B0", Length = "0x64")]
		[Token(Token = "0x6000014")]
		 set { } //Length: 100
	}

	[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", False)]
	[Token(Token = "0x17000008")]
	public float startSpeed
	{
		[Address(RVA = "0x3120360", Offset = "0x311F760", Length = "0x54")]
		[Token(Token = "0x6000011")]
		 get { } //Length: 84
		[Address(RVA = "0x3120E20", Offset = "0x3120220", Length = "0x64")]
		[Token(Token = "0x6000012")]
		 set { } //Length: 100
	}

	[Token(Token = "0x17000031")]
	public SubEmittersModule subEmitters
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600008B")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000032")]
	public TextureSheetAnimationModule textureSheetAnimation
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600008C")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000018")]
	public float time
	{
		[Address(RVA = "0x3120400", Offset = "0x311F800", Length = "0x76")]
		[NativeName("SyncJobs(false)->GetSecPosition")]
		[Token(Token = "0x600002B")]
		 get { } //Length: 118
		[Address(RVA = "0x3120EE0", Offset = "0x31202E0", Length = "0x86")]
		[NativeName("SyncJobs(false)->SetSecPosition")]
		[Token(Token = "0x600002C")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000019")]
	public float totalTime
	{
		[Address(RVA = "0x31204C0", Offset = "0x311F8C0", Length = "0x76")]
		[NativeName("SyncJobs(false)->GetTotalSecPosition")]
		[Token(Token = "0x600002D")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000034")]
	public TrailModule trails
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600008E")]
		 get { } //Length: 32
	}

	[Token(Token = "0x17000030")]
	public TriggerModule trigger
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600008A")]
		 get { } //Length: 32
	}

	[Token(Token = "0x1700001B")]
	public bool useAutoRandomSeed
	{
		[Address(RVA = "0x3120580", Offset = "0x311F980", Length = "0x76")]
		[NativeName("GetAutoRandomSeed")]
		[Token(Token = "0x6000030")]
		 get { } //Length: 118
		[Address(RVA = "0x3120FC0", Offset = "0x31203C0", Length = "0x86")]
		[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
		[Token(Token = "0x6000031")]
		 set { } //Length: 134
	}

	[Token(Token = "0x17000022")]
	public VelocityOverLifetimeModule velocityOverLifetime
	{
		[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
		[Token(Token = "0x600007C")]
		 get { } //Length: 32
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000090")]
	public ParticleSystem() { }

	[Address(RVA = "0x311B8B0", Offset = "0x311ACB0", Length = "0x76")]
	[NativeName("SetUsesAxisOfRotation")]
	[Token(Token = "0x600006E")]
	public void AllocateAxisOfRotationAttribute() { }

	[Address(RVA = "0x311B870", Offset = "0x311AC70", Length = "0x33")]
	[Token(Token = "0x60000BA")]
	private static void AllocateAxisOfRotationAttribute_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311B970", Offset = "0x311AD70", Length = "0x83")]
	[NativeName("SetUsesCustomData")]
	[Token(Token = "0x6000070")]
	public void AllocateCustomDataAttribute(ParticleSystemCustomData stream) { }

	[Address(RVA = "0x311B930", Offset = "0x311AD30", Length = "0x40")]
	[Token(Token = "0x60000BC")]
	private static void AllocateCustomDataAttribute_Injected(IntPtr _unity_self, ParticleSystemCustomData stream) { }

	[Address(RVA = "0x311BA40", Offset = "0x311AE40", Length = "0x76")]
	[NativeName("SetUsesMeshIndex")]
	[Token(Token = "0x600006F")]
	public void AllocateMeshIndexAttribute() { }

	[Address(RVA = "0x311BA00", Offset = "0x311AE00", Length = "0x33")]
	[Token(Token = "0x60000BB")]
	private static void AllocateMeshIndexAttribute_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311BBA0", Offset = "0x311AFA0", Length = "0x78")]
	[Token(Token = "0x600005F")]
	public void Clear() { }

	[Address(RVA = "0x311BB10", Offset = "0x311AF10", Length = "0x86")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = True)]
	[Token(Token = "0x600005E")]
	public void Clear(bool withChildren) { }

	[Address(RVA = "0x311BAC0", Offset = "0x311AEC0", Length = "0x42")]
	[Token(Token = "0x60000B2")]
	private static void Clear_Injected(IntPtr _unity_self, bool withChildren) { }

	[Address(RVA = "0x311BC20", Offset = "0x311B020", Length = "0x42")]
	[ThreadSafe]
	[Token(Token = "0x6000077")]
	internal static void CopyManagedJobData(Void* systemPtr, out NativeParticleData particleData) { }

	[Address(RVA = "0x311BDF0", Offset = "0x311B1F0", Length = "0x83")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000062")]
	public void Emit(int count) { }

	[Address(RVA = "0x311C070", Offset = "0x311B470", Length = "0x85")]
	[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	[Token(Token = "0x6000003")]
	public void Emit(Particle particle) { }

	[Address(RVA = "0x311BE80", Offset = "0x311B280", Length = "0x1EE")]
	[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", False)]
	[Token(Token = "0x6000002")]
	public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color) { }

	[Address(RVA = "0x311C100", Offset = "0x311B500", Length = "0x95")]
	[NativeName("SyncJobs()->EmitParticlesExternal")]
	[Token(Token = "0x6000064")]
	public void Emit(EmitParams emitParams, int count) { }

	[Address(RVA = "0x311BD50", Offset = "0x311B150", Length = "0x52")]
	[Token(Token = "0x60000B5")]
	private static void Emit_Injected(IntPtr _unity_self, in EmitParams emitParams, int count) { }

	[Address(RVA = "0x311BDF0", Offset = "0x311B1F0", Length = "0x83")]
	[NativeName("SyncJobs()->Emit")]
	[Token(Token = "0x6000063")]
	private void Emit_Internal(int count) { }

	[Address(RVA = "0x311BDB0", Offset = "0x311B1B0", Length = "0x40")]
	[Token(Token = "0x60000B4")]
	private static void Emit_Internal_Injected(IntPtr _unity_self, int count) { }

	[Address(RVA = "0x311BCC0", Offset = "0x311B0C0", Length = "0x85")]
	[NativeName("SyncJobs()->EmitParticleExternal")]
	[Token(Token = "0x6000065")]
	private void EmitOld_Internal(ref Particle particle) { }

	[Address(RVA = "0x311BC70", Offset = "0x311B070", Length = "0x42")]
	[Token(Token = "0x60000B6")]
	private static void EmitOld_Internal_Injected(IntPtr _unity_self, ref Particle particle) { }

	[Address(RVA = "0x311F5C0", Offset = "0x311E9C0", Length = "0x76")]
	[Token(Token = "0x6000025")]
	public bool get_automaticCullingEnabled() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000089")]
	public CollisionModule get_collision() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000082")]
	public ColorBySpeedModule get_colorBySpeed() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000081")]
	public ColorOverLifetimeModule get_colorOverLifetime() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600008F")]
	public CustomDataModule get_customData() { }

	[Address(RVA = "0x311F640", Offset = "0x311EA40", Length = "0x54")]
	[Token(Token = "0x600000A")]
	public float get_duration() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600007A")]
	public EmissionModule get_emission() { }

	[Address(RVA = "0x311F6A0", Offset = "0x311EAA0", Length = "0x54")]
	[Token(Token = "0x600000F")]
	public float get_emissionRate() { }

	[Address(RVA = "0x311F700", Offset = "0x311EB00", Length = "0x54")]
	[Token(Token = "0x600000D")]
	public bool get_enableEmission() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000087")]
	public ExternalForcesModule get_externalForces() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000080")]
	public ForceOverLifetimeModule get_forceOverLifetime() { }

	[Address(RVA = "0x311F760", Offset = "0x311EB60", Length = "0x54")]
	[Token(Token = "0x600001D")]
	public float get_gravityModifier() { }

	[Address(RVA = "0x311F800", Offset = "0x311EC00", Length = "0x76")]
	[NativeName("Has3DParticleRotations")]
	[Token(Token = "0x6000071")]
	public bool get_has3DParticleRotations() { }

	[Address(RVA = "0x311F7C0", Offset = "0x311EBC0", Length = "0x33")]
	[Token(Token = "0x60000BD")]
	private static bool get_has3DParticleRotations_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311F8C0", Offset = "0x311ECC0", Length = "0x76")]
	[NativeName("HasNonUniformParticleSizes")]
	[Token(Token = "0x6000072")]
	public bool get_hasNonUniformParticleSizes() { }

	[Address(RVA = "0x311F880", Offset = "0x311EC80", Length = "0x33")]
	[Token(Token = "0x60000BE")]
	private static bool get_hasNonUniformParticleSizes_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600007E")]
	public InheritVelocityModule get_inheritVelocity() { }

	[Address(RVA = "0x311F980", Offset = "0x311ED80", Length = "0x76")]
	[NativeName("SyncJobs(false)->IsEmitting")]
	[Token(Token = "0x6000027")]
	public bool get_isEmitting() { }

	[Address(RVA = "0x311F940", Offset = "0x311ED40", Length = "0x33")]
	[Token(Token = "0x6000093")]
	private static bool get_isEmitting_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311FA40", Offset = "0x311EE40", Length = "0x76")]
	[NativeName("SyncJobs(false)->IsPaused")]
	[Token(Token = "0x6000029")]
	public bool get_isPaused() { }

	[Address(RVA = "0x311FA00", Offset = "0x311EE00", Length = "0x33")]
	[Token(Token = "0x6000095")]
	private static bool get_isPaused_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311FB00", Offset = "0x311EF00", Length = "0x76")]
	[NativeName("SyncJobs(false)->IsPlaying")]
	[Token(Token = "0x6000026")]
	public bool get_isPlaying() { }

	[Address(RVA = "0x311FAC0", Offset = "0x311EEC0", Length = "0x33")]
	[Token(Token = "0x6000092")]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311FBC0", Offset = "0x311EFC0", Length = "0x76")]
	[NativeName("SyncJobs(false)->IsStopped")]
	[Token(Token = "0x6000028")]
	public bool get_isStopped() { }

	[Address(RVA = "0x311FB80", Offset = "0x311EF80", Length = "0x33")]
	[Token(Token = "0x6000094")]
	private static bool get_isStopped_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600007F")]
	public LifetimeByEmitterSpeedModule get_lifetimeByEmitterSpeed() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600008D")]
	public LightsModule get_lights() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600007D")]
	public LimitVelocityOverLifetimeModule get_limitVelocityOverLifetime() { }

	[Address(RVA = "0x311FC40", Offset = "0x311F040", Length = "0x54")]
	[Token(Token = "0x6000006")]
	public bool get_loop() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000079")]
	public MainModule get_main() { }

	[Address(RVA = "0x311FCA0", Offset = "0x311F0A0", Length = "0x54")]
	[Token(Token = "0x600001F")]
	public int get_maxParticles() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000088")]
	public NoiseModule get_noise() { }

	[Address(RVA = "0x311FD40", Offset = "0x311F140", Length = "0x76")]
	[NativeName("SyncJobs(false)->GetParticleCount")]
	[Token(Token = "0x600002A")]
	public int get_particleCount() { }

	[Address(RVA = "0x311FD00", Offset = "0x311F100", Length = "0x33")]
	[Token(Token = "0x6000096")]
	private static int get_particleCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311FE20", Offset = "0x311F220", Length = "0x54")]
	[Token(Token = "0x600000B")]
	public float get_playbackSpeed() { }

	[Address(RVA = "0x311FDC0", Offset = "0x311F1C0", Length = "0x54")]
	[Token(Token = "0x6000008")]
	public bool get_playOnAwake() { }

	[Address(RVA = "0x311F5C0", Offset = "0x311E9C0", Length = "0x76")]
	[Token(Token = "0x6000032")]
	public bool get_proceduralSimulationSupported() { }

	[Address(RVA = "0x311FE80", Offset = "0x311F280", Length = "0x33")]
	[Token(Token = "0x600009E")]
	private static bool get_proceduralSimulationSupported_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311FF00", Offset = "0x311F300", Length = "0x76")]
	[NativeName("GetRandomSeed")]
	[Token(Token = "0x600002E")]
	public uint get_randomSeed() { }

	[Address(RVA = "0x311FEC0", Offset = "0x311F2C0", Length = "0x33")]
	[Token(Token = "0x600009A")]
	private static uint get_randomSeed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000086")]
	public RotationBySpeedModule get_rotationBySpeed() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000085")]
	public RotationOverLifetimeModule get_rotationOverLifetime() { }

	[Address(RVA = "0x311FF80", Offset = "0x311F380", Length = "0x54")]
	[Token(Token = "0x6000023")]
	public ParticleSystemScalingMode get_scalingMode() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600007B")]
	public ShapeModule get_shape() { }

	[Address(RVA = "0x311FFE0", Offset = "0x311F3E0", Length = "0x54")]
	[Token(Token = "0x6000021")]
	public ParticleSystemSimulationSpace get_simulationSpace() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000084")]
	public SizeBySpeedModule get_sizeBySpeed() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x6000083")]
	public SizeOverLifetimeModule get_sizeOverLifetime() { }

	[Address(RVA = "0x3120040", Offset = "0x311F440", Length = "0x74")]
	[Token(Token = "0x6000015")]
	public Color get_startColor() { }

	[Address(RVA = "0x31200C0", Offset = "0x311F4C0", Length = "0x54")]
	[Token(Token = "0x6000004")]
	public float get_startDelay() { }

	[Address(RVA = "0x3120120", Offset = "0x311F520", Length = "0x54")]
	[Token(Token = "0x600001B")]
	public float get_startLifetime() { }

	[Address(RVA = "0x31202A0", Offset = "0x311F6A0", Length = "0x54")]
	[Token(Token = "0x6000017")]
	public float get_startRotation() { }

	[Address(RVA = "0x3120180", Offset = "0x311F580", Length = "0x118")]
	[Token(Token = "0x6000019")]
	public Vector3 get_startRotation3D() { }

	[Address(RVA = "0x3120300", Offset = "0x311F700", Length = "0x54")]
	[Token(Token = "0x6000013")]
	public float get_startSize() { }

	[Address(RVA = "0x3120360", Offset = "0x311F760", Length = "0x54")]
	[Token(Token = "0x6000011")]
	public float get_startSpeed() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600008B")]
	public SubEmittersModule get_subEmitters() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600008C")]
	public TextureSheetAnimationModule get_textureSheetAnimation() { }

	[Address(RVA = "0x3120400", Offset = "0x311F800", Length = "0x76")]
	[NativeName("SyncJobs(false)->GetSecPosition")]
	[Token(Token = "0x600002B")]
	public float get_time() { }

	[Address(RVA = "0x31203C0", Offset = "0x311F7C0", Length = "0x33")]
	[Token(Token = "0x6000097")]
	private static float get_time_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x31204C0", Offset = "0x311F8C0", Length = "0x76")]
	[NativeName("SyncJobs(false)->GetTotalSecPosition")]
	[Token(Token = "0x600002D")]
	public float get_totalTime() { }

	[Address(RVA = "0x3120480", Offset = "0x311F880", Length = "0x33")]
	[Token(Token = "0x6000099")]
	private static float get_totalTime_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600008E")]
	public TrailModule get_trails() { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600008A")]
	public TriggerModule get_trigger() { }

	[Address(RVA = "0x3120580", Offset = "0x311F980", Length = "0x76")]
	[NativeName("GetAutoRandomSeed")]
	[Token(Token = "0x6000030")]
	public bool get_useAutoRandomSeed() { }

	[Address(RVA = "0x3120540", Offset = "0x311F940", Length = "0x33")]
	[Token(Token = "0x600009C")]
	private static bool get_useAutoRandomSeed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x20B5710", Offset = "0x20B4B10", Length = "0x20")]
	[Token(Token = "0x600007C")]
	public VelocityOverLifetimeModule get_velocityOverLifetime() { }

	[Address(RVA = "0x311C200", Offset = "0x311B600", Length = "0x226")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000046")]
	public int GetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	[Address(RVA = "0x311C1A0", Offset = "0x311B5A0", Length = "0x52")]
	[Token(Token = "0x60000A8")]
	private static int GetCustomParticleData_Injected(IntPtr _unity_self, ref BlittableListWrapper customData, ParticleSystemCustomData streamIndex) { }

	[Address(RVA = "0x311C470", Offset = "0x311B870", Length = "0x76")]
	[Token(Token = "0x6000073")]
	internal Void* GetManagedJobData() { }

	[Address(RVA = "0x311C430", Offset = "0x311B830", Length = "0x33")]
	[Token(Token = "0x60000BF")]
	private static Void* GetManagedJobData_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x311C540", Offset = "0x311B940", Length = "0x8E")]
	[Token(Token = "0x6000074")]
	internal JobHandle GetManagedJobHandle() { }

	[Address(RVA = "0x311C4F0", Offset = "0x311B8F0", Length = "0x42")]
	[Token(Token = "0x60000C0")]
	private static void GetManagedJobHandle_Injected(IntPtr _unity_self, out JobHandle ret) { }

	[Address(RVA = "0x311C630", Offset = "0x311BA30", Length = "0x96")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = True)]
	[Token(Token = "0x6000035")]
	internal Color32 GetParticleCurrentColor(ref Particle particle) { }

	[Address(RVA = "0x311C5D0", Offset = "0x311B9D0", Length = "0x52")]
	[Token(Token = "0x60000A1")]
	private static void GetParticleCurrentColor_Injected(IntPtr _unity_self, ref Particle particle, out Color32 ret) { }

	[Address(RVA = "0x311C830", Offset = "0x311BC30", Length = "0x85")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = True)]
	[Token(Token = "0x6000033")]
	internal float GetParticleCurrentSize(ref Particle particle) { }

	[Address(RVA = "0x311C7E0", Offset = "0x311BBE0", Length = "0x42")]
	[Token(Token = "0x600009F")]
	private static float GetParticleCurrentSize_Injected(IntPtr _unity_self, ref Particle particle) { }

	[Address(RVA = "0x311C730", Offset = "0x311BB30", Length = "0xA0")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = True)]
	[Token(Token = "0x6000034")]
	internal Vector3 GetParticleCurrentSize3D(ref Particle particle) { }

	[Address(RVA = "0x311C6D0", Offset = "0x311BAD0", Length = "0x52")]
	[Token(Token = "0x60000A0")]
	private static void GetParticleCurrentSize3D_Injected(IntPtr _unity_self, ref Particle particle, out Vector3 ret) { }

	[Address(RVA = "0x311C910", Offset = "0x311BD10", Length = "0x85")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = True)]
	[Token(Token = "0x6000036")]
	internal int GetParticleMeshIndex(ref Particle particle) { }

	[Address(RVA = "0x311C8C0", Offset = "0x311BCC0", Length = "0x42")]
	[Token(Token = "0x60000A2")]
	private static int GetParticleMeshIndex_Injected(IntPtr _unity_self, ref Particle particle) { }

	[Address(RVA = "0x311CFD0", Offset = "0x311C3D0", Length = "0x1A")]
	[Token(Token = "0x600003F")]
	public int GetParticles(out Particle[] particles, int size) { }

	[Address(RVA = "0x311CB50", Offset = "0x311BF50", Length = "0xE3")]
	[Token(Token = "0x6000044")]
	public int GetParticles(out NativeArray<Particle> particles) { }

	[Address(RVA = "0x311CC40", Offset = "0x311C040", Length = "0xEF")]
	[Token(Token = "0x6000043")]
	public int GetParticles(out NativeArray<Particle> particles, int size) { }

	[Address(RVA = "0x311CD30", Offset = "0x311C130", Length = "0xF0")]
	[Token(Token = "0x6000042")]
	public int GetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	[Address(RVA = "0x311CE30", Offset = "0x311C230", Length = "0x19D")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600003E")]
	public int GetParticles(out Particle[] particles, int size, int offset) { }

	[Address(RVA = "0x311CB30", Offset = "0x311BF30", Length = "0x20")]
	[Token(Token = "0x6000040")]
	public int GetParticles(out Particle[] particles) { }

	[Address(RVA = "0x311CAC0", Offset = "0x311BEC0", Length = "0x62")]
	[Token(Token = "0x60000A5")]
	private static int GetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset) { }

	[Address(RVA = "0x311CA10", Offset = "0x311BE10", Length = "0xA7")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000041")]
	private int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	[Address(RVA = "0x311C9A0", Offset = "0x311BDA0", Length = "0x62")]
	[Token(Token = "0x60000A6")]
	private static int GetParticlesWithNativeArray_Injected(IntPtr _unity_self, IntPtr particles, int particlesLength, int size, int offset) { }

	[Address(RVA = "0x311D040", Offset = "0x311C440", Length = "0x98")]
	[Token(Token = "0x6000047")]
	public PlaybackState GetPlaybackState() { }

	[Address(RVA = "0x311CFF0", Offset = "0x311C3F0", Length = "0x42")]
	[Token(Token = "0x60000A9")]
	private static void GetPlaybackState_Injected(IntPtr _unity_self, out PlaybackState ret) { }

	[Address(RVA = "0x311D130", Offset = "0x311C530", Length = "0x85")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = True)]
	[Token(Token = "0x6000049")]
	private void GetTrailDataInternal(ref Trails trailData) { }

	[Address(RVA = "0x311D0E0", Offset = "0x311C4E0", Length = "0x42")]
	[Token(Token = "0x60000AB")]
	private static void GetTrailDataInternal_Injected(IntPtr _unity_self, ref Trails trailData) { }

	[Address(RVA = "0x311D290", Offset = "0x311C690", Length = "0xB6")]
	[Token(Token = "0x600004B")]
	public int GetTrails(ref Trails trailData) { }

	[Address(RVA = "0x311D1C0", Offset = "0x311C5C0", Length = "0xCD")]
	[Token(Token = "0x600004A")]
	public Trails GetTrails() { }

	[Address(RVA = "0x311D430", Offset = "0x311C830", Length = "0x78")]
	[Token(Token = "0x6000061")]
	public bool IsAlive() { }

	[Address(RVA = "0x311D3A0", Offset = "0x311C7A0", Length = "0x86")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = True)]
	[Token(Token = "0x6000060")]
	public bool IsAlive(bool withChildren) { }

	[Address(RVA = "0x311D350", Offset = "0x311C750", Length = "0x42")]
	[Token(Token = "0x60000B3")]
	private static bool IsAlive_Injected(IntPtr _unity_self, bool withChildren) { }

	[Address(RVA = "0x311D580", Offset = "0x311C980", Length = "0x86")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = True)]
	[Token(Token = "0x6000059")]
	public void Pause(bool withChildren) { }

	[Address(RVA = "0x311D500", Offset = "0x311C900", Length = "0x78")]
	[Token(Token = "0x600005A")]
	public void Pause() { }

	[Address(RVA = "0x311D4B0", Offset = "0x311C8B0", Length = "0x42")]
	[Token(Token = "0x60000B0")]
	private static void Pause_Injected(IntPtr _unity_self, bool withChildren) { }

	[Address(RVA = "0x311D660", Offset = "0x311CA60", Length = "0x86")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = True)]
	[Token(Token = "0x6000057")]
	public void Play(bool withChildren) { }

	[Address(RVA = "0x311D6F0", Offset = "0x311CAF0", Length = "0x78")]
	[Token(Token = "0x6000058")]
	public void Play() { }

	[Address(RVA = "0x311D610", Offset = "0x311CA10", Length = "0x42")]
	[Token(Token = "0x60000AF")]
	private static void Play_Injected(IntPtr _unity_self, bool withChildren) { }

	[Address(RVA = "0x311D770", Offset = "0x311CB70", Length = "0x2A")]
	[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
	[Token(Token = "0x600006C")]
	public static void ResetPreMappedBufferMemory() { }

	[Address(RVA = "0x311D800", Offset = "0x311CC00", Length = "0x5B")]
	[FreeFunction("ScheduleManagedJob", ThrowsException = True)]
	[Token(Token = "0x6000076")]
	internal static JobHandle ScheduleManagedJob(ref JobScheduleParameters parameters, Void* additionalData) { }

	[Address(RVA = "0x311D7A0", Offset = "0x311CBA0", Length = "0x52")]
	[Token(Token = "0x60000C2")]
	private static void ScheduleManagedJob_Injected(ref JobScheduleParameters parameters, Void* additionalData, out JobHandle ret) { }

	[Address(RVA = "0x3120600", Offset = "0x311FA00", Length = "0xDE")]
	[Token(Token = "0x6000010")]
	public void set_emissionRate(float value) { }

	[Address(RVA = "0x31206E0", Offset = "0x311FAE0", Length = "0x5D")]
	[Token(Token = "0x600000E")]
	public void set_enableEmission(bool value) { }

	[Address(RVA = "0x3120740", Offset = "0x311FB40", Length = "0x64")]
	[Token(Token = "0x600001E")]
	public void set_gravityModifier(float value) { }

	[Address(RVA = "0x31207B0", Offset = "0x311FBB0", Length = "0x5D")]
	[Token(Token = "0x6000007")]
	public void set_loop(bool value) { }

	[Address(RVA = "0x3120810", Offset = "0x311FC10", Length = "0x5B")]
	[Token(Token = "0x6000020")]
	public void set_maxParticles(int value) { }

	[Address(RVA = "0x31208D0", Offset = "0x311FCD0", Length = "0x64")]
	[Token(Token = "0x600000C")]
	public void set_playbackSpeed(float value) { }

	[Address(RVA = "0x3120870", Offset = "0x311FC70", Length = "0x5D")]
	[Token(Token = "0x6000009")]
	public void set_playOnAwake(bool value) { }

	[Address(RVA = "0x3120980", Offset = "0x311FD80", Length = "0x83")]
	[NativeName("SyncJobs(false)->SetRandomSeed")]
	[Token(Token = "0x600002F")]
	public void set_randomSeed(uint value) { }

	[Address(RVA = "0x3120940", Offset = "0x311FD40", Length = "0x40")]
	[Token(Token = "0x600009B")]
	private static void set_randomSeed_Injected(IntPtr _unity_self, uint value) { }

	[Address(RVA = "0x3120A10", Offset = "0x311FE10", Length = "0x5B")]
	[Token(Token = "0x6000024")]
	public void set_scalingMode(ParticleSystemScalingMode value) { }

	[Address(RVA = "0x3120A70", Offset = "0x311FE70", Length = "0x5B")]
	[Token(Token = "0x6000022")]
	public void set_simulationSpace(ParticleSystemSimulationSpace value) { }

	[Address(RVA = "0x3120AD0", Offset = "0x311FED0", Length = "0xC7")]
	[Token(Token = "0x6000016")]
	public void set_startColor(Color value) { }

	[Address(RVA = "0x3120BA0", Offset = "0x311FFA0", Length = "0x64")]
	[Token(Token = "0x6000005")]
	public void set_startDelay(float value) { }

	[Address(RVA = "0x3120C10", Offset = "0x3120010", Length = "0x64")]
	[Token(Token = "0x600001C")]
	public void set_startLifetime(float value) { }

	[Address(RVA = "0x3120D40", Offset = "0x3120140", Length = "0x64")]
	[Token(Token = "0x6000018")]
	public void set_startRotation(float value) { }

	[Address(RVA = "0x3120C80", Offset = "0x3120080", Length = "0xB4")]
	[Token(Token = "0x600001A")]
	public void set_startRotation3D(Vector3 value) { }

	[Address(RVA = "0x3120DB0", Offset = "0x31201B0", Length = "0x64")]
	[Token(Token = "0x6000014")]
	public void set_startSize(float value) { }

	[Address(RVA = "0x3120E20", Offset = "0x3120220", Length = "0x64")]
	[Token(Token = "0x6000012")]
	public void set_startSpeed(float value) { }

	[Address(RVA = "0x3120EE0", Offset = "0x31202E0", Length = "0x86")]
	[NativeName("SyncJobs(false)->SetSecPosition")]
	[Token(Token = "0x600002C")]
	public void set_time(float value) { }

	[Address(RVA = "0x3120E90", Offset = "0x3120290", Length = "0x43")]
	[Token(Token = "0x6000098")]
	private static void set_time_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x3120FC0", Offset = "0x31203C0", Length = "0x86")]
	[NativeName("SyncJobs(false)->SetAutoRandomSeed")]
	[Token(Token = "0x6000031")]
	public void set_useAutoRandomSeed(bool value) { }

	[Address(RVA = "0x3120F70", Offset = "0x3120370", Length = "0x42")]
	[Token(Token = "0x600009D")]
	private static void set_useAutoRandomSeed_Injected(IntPtr _unity_self, bool value) { }

	[Address(RVA = "0x311D8C0", Offset = "0x311CCC0", Length = "0x20D")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000045")]
	public void SetCustomParticleData(List<Vector4> customData, ParticleSystemCustomData streamIndex) { }

	[Address(RVA = "0x311D860", Offset = "0x311CC60", Length = "0x52")]
	[Token(Token = "0x60000A7")]
	private static void SetCustomParticleData_Injected(IntPtr _unity_self, ref BlittableListWrapper customData, ParticleSystemCustomData streamIndex) { }

	[Address(RVA = "0x311DB20", Offset = "0x311CF20", Length = "0x85")]
	[Token(Token = "0x6000075")]
	internal void SetManagedJobHandle(JobHandle handle) { }

	[Address(RVA = "0x311DAD0", Offset = "0x311CED0", Length = "0x42")]
	[Token(Token = "0x60000C1")]
	private static void SetManagedJobHandle_Injected(IntPtr _unity_self, in JobHandle handle) { }

	[Address(RVA = "0x311DBB0", Offset = "0x311CFB0", Length = "0x3E")]
	[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
	[Token(Token = "0x600006D")]
	public static void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount) { }

	[Address(RVA = "0x311E690", Offset = "0x311DA90", Length = "0x153")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000037")]
	public void SetParticles(out Particle[] particles, int size, int offset) { }

	[Address(RVA = "0x311E670", Offset = "0x311DA70", Length = "0x1A")]
	[Token(Token = "0x6000038")]
	public void SetParticles(out Particle[] particles, int size) { }

	[Address(RVA = "0x311E7F0", Offset = "0x311DBF0", Length = "0xF0")]
	[Token(Token = "0x600003B")]
	public void SetParticles(out NativeArray<Particle> particles, int size, int offset) { }

	[Address(RVA = "0x311E470", Offset = "0x311D870", Length = "0x20")]
	[Token(Token = "0x6000039")]
	public void SetParticles(out Particle[] particles) { }

	[Address(RVA = "0x311E490", Offset = "0x311D890", Length = "0xE3")]
	[Token(Token = "0x600003D")]
	public void SetParticles(out NativeArray<Particle> particles) { }

	[Address(RVA = "0x311E580", Offset = "0x311D980", Length = "0xEF")]
	[Token(Token = "0x600003C")]
	public void SetParticles(out NativeArray<Particle> particles, int size) { }

	[Address(RVA = "0x311E400", Offset = "0x311D800", Length = "0x62")]
	[Token(Token = "0x60000A3")]
	private static void SetParticles_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, int size, int offset) { }

	[Address(RVA = "0x311DD90", Offset = "0x311D190", Length = "0x16C")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesAndTrailData", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600004C")]
	public void SetParticlesAndTrails(out Particle[] particles, Trails trailData, int size, int offset) { }

	[Address(RVA = "0x311E140", Offset = "0x311D540", Length = "0x3B")]
	[Token(Token = "0x600004D")]
	public void SetParticlesAndTrails(out Particle[] particles, Trails trailData, int size) { }

	[Address(RVA = "0x311E290", Offset = "0x311D690", Length = "0x41")]
	[Token(Token = "0x600004E")]
	public void SetParticlesAndTrails(out Particle[] particles, Trails trailData) { }

	[Address(RVA = "0x311DF00", Offset = "0x311D300", Length = "0x115")]
	[Token(Token = "0x6000050")]
	public void SetParticlesAndTrails(out NativeArray<Particle> particles, Trails trailData, int size, int offset) { }

	[Address(RVA = "0x311E180", Offset = "0x311D580", Length = "0x108")]
	[Token(Token = "0x6000052")]
	public void SetParticlesAndTrails(out NativeArray<Particle> particles, Trails trailData) { }

	[Address(RVA = "0x311E020", Offset = "0x311D420", Length = "0x112")]
	[Token(Token = "0x6000051")]
	public void SetParticlesAndTrails(out NativeArray<Particle> particles, Trails trailData, int size) { }

	[Address(RVA = "0x311DD20", Offset = "0x311D120", Length = "0x62")]
	[Token(Token = "0x60000AC")]
	private static void SetParticlesAndTrails_Injected(IntPtr _unity_self, out BlittableArrayWrapper particles, in Trails trailData, int size, int offset) { }

	[Address(RVA = "0x311DC60", Offset = "0x311D060", Length = "0xB7")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesAndTrailDataWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600004F")]
	private void SetParticlesAndTrailsWithNativeArray(IntPtr particles, Trails trailData, int particlesLength, int size, int offset) { }

	[Address(RVA = "0x311DBF0", Offset = "0x311CFF0", Length = "0x62")]
	[Token(Token = "0x60000AD")]
	private static void SetParticlesAndTrailsWithNativeArray_Injected(IntPtr _unity_self, IntPtr particles, in Trails trailData, int particlesLength, int size, int offset) { }

	[Address(RVA = "0x311E350", Offset = "0x311D750", Length = "0xA7")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x600003A")]
	private void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset) { }

	[Address(RVA = "0x311E2E0", Offset = "0x311D6E0", Length = "0x62")]
	[Token(Token = "0x60000A4")]
	private static void SetParticlesWithNativeArray_Injected(IntPtr _unity_self, IntPtr particles, int particlesLength, int size, int offset) { }

	[Address(RVA = "0x311E940", Offset = "0x311DD40", Length = "0x85")]
	[Token(Token = "0x6000048")]
	public void SetPlaybackState(PlaybackState playbackState) { }

	[Address(RVA = "0x311E8F0", Offset = "0x311DCF0", Length = "0x42")]
	[Token(Token = "0x60000AA")]
	private static void SetPlaybackState_Injected(IntPtr _unity_self, in PlaybackState playbackState) { }

	[Address(RVA = "0x311EA20", Offset = "0x311DE20", Length = "0x85")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = True)]
	[Obsolete("SetTrails is deprecated. Use SetParticlesAndTrails() instead. Avoid SetTrails when ParticleSystem.trails.dieWithParticles is false.", False)]
	[Token(Token = "0x6000001")]
	public void SetTrails(Trails trailData) { }

	[Address(RVA = "0x311E9D0", Offset = "0x311DDD0", Length = "0x42")]
	[Token(Token = "0x6000091")]
	private static void SetTrails_Injected(IntPtr _unity_self, in Trails trailData) { }

	[Address(RVA = "0x311EBE0", Offset = "0x311DFE0", Length = "0x92")]
	[Token(Token = "0x6000056")]
	public void Simulate(float t) { }

	[Address(RVA = "0x311EC80", Offset = "0x311E080", Length = "0x9F")]
	[Token(Token = "0x6000055")]
	public void Simulate(float t, bool withChildren) { }

	[Address(RVA = "0x311EB20", Offset = "0x311DF20", Length = "0xB2")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = True)]
	[Token(Token = "0x6000053")]
	public void Simulate(float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	[Address(RVA = "0x311ED20", Offset = "0x311E120", Length = "0xAE")]
	[Token(Token = "0x6000054")]
	public void Simulate(float t, bool withChildren, bool restart) { }

	[Address(RVA = "0x311EAB0", Offset = "0x311DEB0", Length = "0x6F")]
	[Token(Token = "0x60000AE")]
	private static void Simulate_Injected(IntPtr _unity_self, float t, bool withChildren, bool restart, bool fixedTimeStep) { }

	[Address(RVA = "0x311EF50", Offset = "0x311E350", Length = "0x96")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = True)]
	[Token(Token = "0x600005B")]
	public void Stop(bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	[Address(RVA = "0x311EEC0", Offset = "0x311E2C0", Length = "0x8C")]
	[Token(Token = "0x600005C")]
	public void Stop(bool withChildren) { }

	[Address(RVA = "0x311EE30", Offset = "0x311E230", Length = "0x80")]
	[Token(Token = "0x600005D")]
	public void Stop() { }

	[Address(RVA = "0x311EDD0", Offset = "0x311E1D0", Length = "0x53")]
	[Token(Token = "0x60000B1")]
	private static void Stop_Injected(IntPtr _unity_self, bool withChildren, ParticleSystemStopBehavior stopBehavior) { }

	[Address(RVA = "0x311F030", Offset = "0x311E430", Length = "0x83")]
	[Token(Token = "0x6000066")]
	public void TriggerSubEmitter(int subEmitterIndex) { }

	[Address(RVA = "0x311F490", Offset = "0x311E890", Length = "0xF0")]
	[Token(Token = "0x6000067")]
	public void TriggerSubEmitter(int subEmitterIndex, ref Particle particle) { }

	[Address(RVA = "0x311F3F0", Offset = "0x311E7F0", Length = "0x9B")]
	[Token(Token = "0x6000068")]
	public void TriggerSubEmitter(int subEmitterIndex, List<Particle> particles) { }

	[Address(RVA = "0x311F030", Offset = "0x311E430", Length = "0x83")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForAllParticles", HasExplicitThis = True)]
	[Token(Token = "0x600006B")]
	private void TriggerSubEmitterForAllParticles(int subEmitterIndex) { }

	[Address(RVA = "0x311EFF0", Offset = "0x311E3F0", Length = "0x40")]
	[Token(Token = "0x60000B9")]
	private static void TriggerSubEmitterForAllParticles_Injected(IntPtr _unity_self, int subEmitterIndex) { }

	[Address(RVA = "0x311F110", Offset = "0x311E510", Length = "0x93")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = True)]
	[Token(Token = "0x6000069")]
	internal void TriggerSubEmitterForParticle(int subEmitterIndex, Particle particle) { }

	[Address(RVA = "0x311F0C0", Offset = "0x311E4C0", Length = "0x50")]
	[Token(Token = "0x60000B7")]
	private static void TriggerSubEmitterForParticle_Injected(IntPtr _unity_self, int subEmitterIndex, in Particle particle) { }

	[Address(RVA = "0x311F200", Offset = "0x311E600", Length = "0x1E7")]
	[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticles", HasExplicitThis = True)]
	[Token(Token = "0x600006A")]
	private void TriggerSubEmitterForParticles(int subEmitterIndex, List<Particle> particles) { }

	[Address(RVA = "0x311F1B0", Offset = "0x311E5B0", Length = "0x50")]
	[Token(Token = "0x60000B8")]
	private static void TriggerSubEmitterForParticles_Injected(IntPtr _unity_self, int subEmitterIndex, ref BlittableListWrapper particles) { }

	[Address(RVA = "0x311F590", Offset = "0x311E990", Length = "0x2A")]
	[Token(Token = "0x6000078")]
	internal static bool UserJobCanBeScheduled() { }

}

