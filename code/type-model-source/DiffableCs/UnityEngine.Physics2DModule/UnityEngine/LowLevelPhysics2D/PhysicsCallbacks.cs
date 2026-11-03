namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[Token(Token = "0x2000031")]
public struct PhysicsCallbacks
{
	[IsReadOnly]
	[Token(Token = "0x2000038")]
	internal struct BodyUpdateCallbackTargets : IDisposable
	{
		[IsReadOnly]
		[Token(Token = "0x2000039")]
		internal struct BodyUpdateTarget
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000119")]
			private readonly BodyUpdateEvent m_BodyUpdateEvent; //Field offset: 0x0

			[Token(Token = "0x17000058")]
			public IBodyUpdateCallback bodyTarget
			{
				[Address(RVA = "0x3122510", Offset = "0x3121910", Length = "0xA4")]
				[Token(Token = "0x6000170")]
				 get { } //Length: 164
			}

			[Token(Token = "0x17000057")]
			public BodyUpdateEvent bodyUpdateEvent
			{
				[Address(RVA = "0x19B22C0", Offset = "0x19B16C0", Length = "0x1C")]
				[Token(Token = "0x600016F")]
				 get { } //Length: 28
			}

			[Address(RVA = "0x3122510", Offset = "0x3121910", Length = "0xA4")]
			[Token(Token = "0x6000170")]
			public IBodyUpdateCallback get_bodyTarget() { }

			[Address(RVA = "0x19B22C0", Offset = "0x19B16C0", Length = "0x1C")]
			[Token(Token = "0x600016F")]
			public BodyUpdateEvent get_bodyUpdateEvent() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000118")]
		private readonly PhysicsBuffer m_BodyUpdateCallbackTargets; //Field offset: 0x0

		[Token(Token = "0x17000056")]
		public ReadOnlySpan<BodyUpdateTarget> bodyUpdateCallbackTargets
		{
			[Address(RVA = "0x31223E0", Offset = "0x31217E0", Length = "0x56")]
			[Token(Token = "0x600016D")]
			 get { } //Length: 86
		}

		[Address(RVA = "0x31223C0", Offset = "0x31217C0", Length = "0x1D")]
		[Token(Token = "0x600016E")]
		public override void Dispose() { }

		[Address(RVA = "0x31223E0", Offset = "0x31217E0", Length = "0x56")]
		[Token(Token = "0x600016D")]
		public ReadOnlySpan<BodyUpdateTarget> get_bodyUpdateCallbackTargets() { }

	}

	[IsReadOnly]
	[Token(Token = "0x200003D")]
	internal struct ContactCallbackTargets : IDisposable
	{
		[IsReadOnly]
		[Token(Token = "0x200003E")]
		internal struct ContactBeginTarget
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000120")]
			private readonly ContactBeginEvent m_BeginEvent; //Field offset: 0x0

			[Token(Token = "0x17000063")]
			public ContactBeginEvent beginEvent
			{
				[Address(RVA = "0x3124630", Offset = "0x3123A30", Length = "0x1A")]
				[Token(Token = "0x600017D")]
				 get { } //Length: 26
			}

			[Token(Token = "0x17000064")]
			public IContactCallback shapeTargetA
			{
				[Address(RVA = "0x3124650", Offset = "0x3123A50", Length = "0xA2")]
				[Token(Token = "0x600017E")]
				 get { } //Length: 162
			}

			[Token(Token = "0x17000065")]
			public IContactCallback shapeTargetB
			{
				[Address(RVA = "0x3124700", Offset = "0x3123B00", Length = "0xA4")]
				[Token(Token = "0x600017F")]
				 get { } //Length: 164
			}

			[Address(RVA = "0x3124630", Offset = "0x3123A30", Length = "0x1A")]
			[Token(Token = "0x600017D")]
			public ContactBeginEvent get_beginEvent() { }

			[Address(RVA = "0x3124650", Offset = "0x3123A50", Length = "0xA2")]
			[Token(Token = "0x600017E")]
			public IContactCallback get_shapeTargetA() { }

			[Address(RVA = "0x3124700", Offset = "0x3123B00", Length = "0xA4")]
			[Token(Token = "0x600017F")]
			public IContactCallback get_shapeTargetB() { }

		}

		[IsReadOnly]
		[Token(Token = "0x200003F")]
		internal struct ContactEndTarget
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000121")]
			private readonly ContactEndEvent m_EndEvent; //Field offset: 0x0

			[Token(Token = "0x17000066")]
			public ContactEndEvent endEvent
			{
				[Address(RVA = "0x3124630", Offset = "0x3123A30", Length = "0x1A")]
				[Token(Token = "0x6000180")]
				 get { } //Length: 26
			}

			[Token(Token = "0x17000067")]
			public IContactCallback shapeTargetA
			{
				[Address(RVA = "0x3124990", Offset = "0x3123D90", Length = "0xA2")]
				[Token(Token = "0x6000181")]
				 get { } //Length: 162
			}

			[Token(Token = "0x17000068")]
			public IContactCallback shapeTargetB
			{
				[Address(RVA = "0x3124A40", Offset = "0x3123E40", Length = "0xA4")]
				[Token(Token = "0x6000182")]
				 get { } //Length: 164
			}

			[Address(RVA = "0x3124630", Offset = "0x3123A30", Length = "0x1A")]
			[Token(Token = "0x6000180")]
			public ContactEndEvent get_endEvent() { }

			[Address(RVA = "0x3124990", Offset = "0x3123D90", Length = "0xA2")]
			[Token(Token = "0x6000181")]
			public IContactCallback get_shapeTargetA() { }

			[Address(RVA = "0x3124A40", Offset = "0x3123E40", Length = "0xA4")]
			[Token(Token = "0x6000182")]
			public IContactCallback get_shapeTargetB() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011E")]
		private readonly PhysicsBuffer m_BeginCallbackTargets; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011F")]
		private readonly PhysicsBuffer m_EndCallbackTargets; //Field offset: 0x10

		[Token(Token = "0x17000061")]
		public ReadOnlySpan<ContactBeginTarget> BeginCallbackTargets
		{
			[Address(RVA = "0x3124800", Offset = "0x3123C00", Length = "0x56")]
			[Token(Token = "0x600017A")]
			 get { } //Length: 86
		}

		[Token(Token = "0x17000062")]
		public ReadOnlySpan<ContactEndTarget> EndCallbackTargets
		{
			[Address(RVA = "0x3124860", Offset = "0x3123C60", Length = "0x57")]
			[Token(Token = "0x600017B")]
			 get { } //Length: 87
		}

		[Address(RVA = "0x31247B0", Offset = "0x3123BB0", Length = "0x4D")]
		[Token(Token = "0x600017C")]
		public override void Dispose() { }

		[Address(RVA = "0x3124800", Offset = "0x3123C00", Length = "0x56")]
		[Token(Token = "0x600017A")]
		public ReadOnlySpan<ContactBeginTarget> get_BeginCallbackTargets() { }

		[Address(RVA = "0x3124860", Offset = "0x3123C60", Length = "0x57")]
		[Token(Token = "0x600017B")]
		public ReadOnlySpan<ContactEndTarget> get_EndCallbackTargets() { }

	}

	[Token(Token = "0x2000032")]
	internal interface IBodyUpdateCallback
	{

		[Token(Token = "0x6000165")]
		public void OnBodyUpdate2D(BodyUpdateEvent bodyUpdateEvent) { }

	}

	[Token(Token = "0x2000036")]
	internal interface IContactCallback
	{

		[Token(Token = "0x600016A")]
		public void OnContactBegin2D(ContactBeginEvent beginEvent) { }

		[Token(Token = "0x600016B")]
		public void OnContactEnd2D(ContactEndEvent endEvent) { }

	}

	[Token(Token = "0x2000033")]
	internal interface IContactFilterCallback
	{

		[Token(Token = "0x6000166")]
		public bool OnContactFilter2D(ContactFilterEvent contactFilterEvent) { }

	}

	[Token(Token = "0x2000037")]
	internal interface IJointThresholdCallback
	{

		[Token(Token = "0x600016C")]
		public void OnJointThreshold2D(JointThresholdEvent thresholdEvent) { }

	}

	[Token(Token = "0x2000034")]
	internal interface IPreSolveCallback
	{

		[Token(Token = "0x6000167")]
		public bool OnPreSolve2D(PreSolveEvent preSolveEvent) { }

	}

	[Token(Token = "0x2000035")]
	internal interface ITriggerCallback
	{

		[Token(Token = "0x6000168")]
		public void OnTriggerBegin2D(TriggerBeginEvent beginEvent) { }

		[Token(Token = "0x6000169")]
		public void OnTriggerEnd2D(TriggerEndEvent endEvent) { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000040")]
	internal struct JointThresholdCallbackTargets : IDisposable
	{
		[IsReadOnly]
		[Token(Token = "0x2000041")]
		internal struct JointThresholdTarget
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000123")]
			private readonly JointThresholdEvent m_JointThresholdEvent; //Field offset: 0x0

			[Token(Token = "0x1700006B")]
			public IJointThresholdCallback jointTarget
			{
				[Address(RVA = "0x3126430", Offset = "0x3125830", Length = "0xA2")]
				[Token(Token = "0x6000186")]
				 get { } //Length: 162
			}

			[Token(Token = "0x1700006A")]
			public JointThresholdEvent jointThresholdEvent
			{
				[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
				[Token(Token = "0x6000185")]
				 get { } //Length: 10
			}

			[Address(RVA = "0x3126430", Offset = "0x3125830", Length = "0xA2")]
			[Token(Token = "0x6000186")]
			public IJointThresholdCallback get_jointTarget() { }

			[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
			[Token(Token = "0x6000185")]
			public JointThresholdEvent get_jointThresholdEvent() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000122")]
		private readonly PhysicsBuffer m_JointThresholdCallbackTargets; //Field offset: 0x0

		[Token(Token = "0x17000069")]
		public ReadOnlySpan<JointThresholdTarget> jointThresholdCallbackTargets
		{
			[Address(RVA = "0x3126360", Offset = "0x3125760", Length = "0x56")]
			[Token(Token = "0x6000183")]
			 get { } //Length: 86
		}

		[Address(RVA = "0x31223C0", Offset = "0x31217C0", Length = "0x1D")]
		[Token(Token = "0x6000184")]
		public override void Dispose() { }

		[Address(RVA = "0x3126360", Offset = "0x3125760", Length = "0x56")]
		[Token(Token = "0x6000183")]
		public ReadOnlySpan<JointThresholdTarget> get_jointThresholdCallbackTargets() { }

	}

	[IsReadOnly]
	[Token(Token = "0x200003A")]
	internal struct TriggerCallbackTargets : IDisposable
	{
		[IsReadOnly]
		[Token(Token = "0x200003B")]
		internal struct TriggerBeginTarget
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400011C")]
			private readonly TriggerBeginEvent m_BeginEvent; //Field offset: 0x0

			[Token(Token = "0x1700005B")]
			public TriggerBeginEvent beginEvent
			{
				[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
				[Token(Token = "0x6000174")]
				 get { } //Length: 10
			}

			[Token(Token = "0x1700005C")]
			public ITriggerCallback triggerShapeTarget
			{
				[Address(RVA = "0x3133B20", Offset = "0x3132F20", Length = "0xA2")]
				[Token(Token = "0x6000175")]
				 get { } //Length: 162
			}

			[Token(Token = "0x1700005D")]
			public ITriggerCallback visitorShapeTarget
			{
				[Address(RVA = "0x3133BD0", Offset = "0x3132FD0", Length = "0xA4")]
				[Token(Token = "0x6000176")]
				 get { } //Length: 164
			}

			[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
			[Token(Token = "0x6000174")]
			public TriggerBeginEvent get_beginEvent() { }

			[Address(RVA = "0x3133B20", Offset = "0x3132F20", Length = "0xA2")]
			[Token(Token = "0x6000175")]
			public ITriggerCallback get_triggerShapeTarget() { }

			[Address(RVA = "0x3133BD0", Offset = "0x3132FD0", Length = "0xA4")]
			[Token(Token = "0x6000176")]
			public ITriggerCallback get_visitorShapeTarget() { }

		}

		[IsReadOnly]
		[Token(Token = "0x200003C")]
		internal struct TriggerEndTarget
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400011D")]
			private readonly TriggerEndEvent m_EndEvent; //Field offset: 0x0

			[Token(Token = "0x1700005E")]
			public TriggerEndEvent endEvent
			{
				[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
				[Token(Token = "0x6000177")]
				 get { } //Length: 10
			}

			[Token(Token = "0x1700005F")]
			public ITriggerCallback triggerShapeTarget
			{
				[Address(RVA = "0x3133DD0", Offset = "0x31331D0", Length = "0xA2")]
				[Token(Token = "0x6000178")]
				 get { } //Length: 162
			}

			[Token(Token = "0x17000060")]
			public ITriggerCallback visitorShapeTarget
			{
				[Address(RVA = "0x3133E80", Offset = "0x3133280", Length = "0xA4")]
				[Token(Token = "0x6000179")]
				 get { } //Length: 164
			}

			[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
			[Token(Token = "0x6000177")]
			public TriggerEndEvent get_endEvent() { }

			[Address(RVA = "0x3133DD0", Offset = "0x31331D0", Length = "0xA2")]
			[Token(Token = "0x6000178")]
			public ITriggerCallback get_triggerShapeTarget() { }

			[Address(RVA = "0x3133E80", Offset = "0x3133280", Length = "0xA4")]
			[Token(Token = "0x6000179")]
			public ITriggerCallback get_visitorShapeTarget() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011A")]
		private readonly PhysicsBuffer m_BeginCallbackTargets; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400011B")]
		private readonly PhysicsBuffer m_EndCallbackTargets; //Field offset: 0x10

		[Token(Token = "0x17000059")]
		public ReadOnlySpan<TriggerBeginTarget> BeginCallbackTargets
		{
			[Address(RVA = "0x3133C80", Offset = "0x3133080", Length = "0x56")]
			[Token(Token = "0x6000171")]
			 get { } //Length: 86
		}

		[Token(Token = "0x1700005A")]
		public ReadOnlySpan<TriggerEndTarget> EndCallbackTargets
		{
			[Address(RVA = "0x3133CE0", Offset = "0x31330E0", Length = "0x57")]
			[Token(Token = "0x6000172")]
			 get { } //Length: 87
		}

		[Address(RVA = "0x31247B0", Offset = "0x3123BB0", Length = "0x4D")]
		[Token(Token = "0x6000173")]
		public override void Dispose() { }

		[Address(RVA = "0x3133C80", Offset = "0x3133080", Length = "0x56")]
		[Token(Token = "0x6000171")]
		public ReadOnlySpan<TriggerBeginTarget> get_BeginCallbackTargets() { }

		[Address(RVA = "0x3133CE0", Offset = "0x31330E0", Length = "0x57")]
		[Token(Token = "0x6000172")]
		public ReadOnlySpan<TriggerEndTarget> get_EndCallbackTargets() { }

	}


}

