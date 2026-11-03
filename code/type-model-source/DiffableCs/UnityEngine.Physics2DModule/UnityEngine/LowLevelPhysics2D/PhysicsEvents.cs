namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000043")]
public struct PhysicsEvents
{
	[IsReadOnly]
	[Token(Token = "0x2000044")]
	internal struct BodyUpdateEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012A")]
		private readonly IntPtr m_UserData; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400012B")]
		private readonly PhysicsTransform m_Transform; //Field offset: 0x8
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012C")]
		private readonly PhysicsBody m_Body; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012D")]
		private readonly bool m_FellAsleep; //Field offset: 0x20

		[Token(Token = "0x1700006E")]
		public PhysicsBody body
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000193")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700006F")]
		public bool fellAsleep
		{
			[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
			[Token(Token = "0x6000194")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700006D")]
		public PhysicsTransform transform
		{
			[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
			[Token(Token = "0x6000192")]
			 get { } //Length: 11
		}

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000193")]
		public PhysicsBody get_body() { }

		[Address(RVA = "0xA9A650", Offset = "0xA99A50", Length = "0x5")]
		[Token(Token = "0x6000194")]
		public bool get_fellAsleep() { }

		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[Token(Token = "0x6000192")]
		public PhysicsTransform get_transform() { }

		[Address(RVA = "0x3122440", Offset = "0x3121840", Length = "0xC7")]
		[Token(Token = "0x6000195")]
		public virtual string ToString() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000047")]
	internal struct ContactBeginEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000132")]
		private readonly PhysicsShape m_ShapeA; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000133")]
		private readonly PhysicsShape m_ShapeB; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000134")]
		private readonly ContactId m_ContactId; //Field offset: 0x10

		[Token(Token = "0x17000076")]
		public ContactId contactId
		{
			[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
			[Token(Token = "0x600019E")]
			 get { } //Length: 19
		}

		[Token(Token = "0x17000074")]
		public PhysicsShape shapeA
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x600019C")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000075")]
		public PhysicsShape shapeB
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[Token(Token = "0x600019D")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
		[Token(Token = "0x600019E")]
		public ContactId get_contactId() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x600019C")]
		public PhysicsShape get_shapeA() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x600019D")]
		public PhysicsShape get_shapeB() { }

		[Address(RVA = "0x3124560", Offset = "0x3123960", Length = "0xD0")]
		[Token(Token = "0x600019F")]
		public virtual string ToString() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000048")]
	internal struct ContactEndEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000135")]
		private readonly PhysicsShape m_ShapeA; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000136")]
		private readonly PhysicsShape m_ShapeB; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000137")]
		private readonly ContactId m_ContactId; //Field offset: 0x10

		[Token(Token = "0x17000079")]
		public ContactId contactId
		{
			[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
			[Token(Token = "0x60001A2")]
			 get { } //Length: 19
		}

		[Token(Token = "0x17000077")]
		public PhysicsShape shapeA
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x60001A0")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000078")]
		public PhysicsShape shapeB
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[Token(Token = "0x60001A1")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x6620A0", Offset = "0x6614A0", Length = "0x13")]
		[Token(Token = "0x60001A2")]
		public ContactId get_contactId() { }

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60001A0")]
		public PhysicsShape get_shapeA() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x60001A1")]
		public PhysicsShape get_shapeB() { }

		[Address(RVA = "0x31248C0", Offset = "0x3123CC0", Length = "0xD0")]
		[Token(Token = "0x60001A3")]
		public virtual string ToString() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000049")]
	internal struct ContactFilterEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000138")]
		private readonly PhysicsWorld m_PhysicsWorld; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000139")]
		private readonly PhysicsShape m_ShapeA; //Field offset: 0x4
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400013A")]
		private readonly PhysicsShape m_ShapeB; //Field offset: 0xC

		[Token(Token = "0x1700007A")]
		public PhysicsWorld physicsWorld
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x60001A4")]
			 get { } //Length: 3
		}

		[Token(Token = "0x1700007B")]
		public PhysicsShape shapeA
		{
			[Address(RVA = "0xAEF2E0", Offset = "0xAEE6E0", Length = "0x5")]
			[Token(Token = "0x60001A5")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700007C")]
		public PhysicsShape shapeB
		{
			[Address(RVA = "0x3124E70", Offset = "0x3124270", Length = "0x5")]
			[Token(Token = "0x60001A6")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60001A4")]
		public PhysicsWorld get_physicsWorld() { }

		[Address(RVA = "0xAEF2E0", Offset = "0xAEE6E0", Length = "0x5")]
		[Token(Token = "0x60001A5")]
		public PhysicsShape get_shapeA() { }

		[Address(RVA = "0x3124E70", Offset = "0x3124270", Length = "0x5")]
		[Token(Token = "0x60001A6")]
		public PhysicsShape get_shapeB() { }

		[Address(RVA = "0x3124DB0", Offset = "0x31241B0", Length = "0xB6")]
		[Token(Token = "0x60001A7")]
		public virtual string ToString() { }

	}

	[IsReadOnly]
	[Token(Token = "0x200004B")]
	internal struct JointThresholdEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000140")]
		private readonly PhysicsJoint m_Joint; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000141")]
		private readonly IntPtr m_UserData; //Field offset: 0x8

		[Token(Token = "0x17000082")]
		public PhysicsJoint joint
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x60001AE")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60001AE")]
		public PhysicsJoint get_joint() { }

		[Address(RVA = "0x31263C0", Offset = "0x31257C0", Length = "0x62")]
		[Token(Token = "0x60001AF")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x200004C")]
	internal sealed class PreSimulateEventHandler : MulticastDelegate
	{

		[Address(RVA = "0x3132680", Offset = "0x3131A80", Length = "0xA6")]
		[Token(Token = "0x60001B0")]
		public PreSimulateEventHandler(object object, IntPtr method) { }

		[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
		[Token(Token = "0x60001B1")]
		public override void Invoke(PhysicsWorld world, float deltaTime) { }

	}

	[IsReadOnly]
	[Token(Token = "0x200004A")]
	internal struct PreSolveEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400013B")]
		private readonly PhysicsWorld m_PhysicsWorld; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400013C")]
		private readonly PhysicsShape m_ShapeA; //Field offset: 0x4
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x400013D")]
		private readonly PhysicsShape m_ShapeB; //Field offset: 0xC
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400013E")]
		private readonly Vector2 m_Point; //Field offset: 0x14
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400013F")]
		private readonly Vector2 m_Normal; //Field offset: 0x1C

		[Token(Token = "0x17000081")]
		public Vector2 normal
		{
			[Address(RVA = "0x31329C0", Offset = "0x3131DC0", Length = "0x13")]
			[Token(Token = "0x60001AC")]
			 get { } //Length: 19
		}

		[Token(Token = "0x1700007D")]
		public PhysicsWorld physicsWorld
		{
			[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
			[Token(Token = "0x60001A8")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000080")]
		public Vector2 point
		{
			[Address(RVA = "0x1806A80", Offset = "0x1805E80", Length = "0x13")]
			[Token(Token = "0x60001AB")]
			 get { } //Length: 19
		}

		[Token(Token = "0x1700007E")]
		public PhysicsShape shapeA
		{
			[Address(RVA = "0xAEF2E0", Offset = "0xAEE6E0", Length = "0x5")]
			[Token(Token = "0x60001A9")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700007F")]
		public PhysicsShape shapeB
		{
			[Address(RVA = "0x3124E70", Offset = "0x3124270", Length = "0x5")]
			[Token(Token = "0x60001AA")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x31329C0", Offset = "0x3131DC0", Length = "0x13")]
		[Token(Token = "0x60001AC")]
		public Vector2 get_normal() { }

		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x60001A8")]
		public PhysicsWorld get_physicsWorld() { }

		[Address(RVA = "0x1806A80", Offset = "0x1805E80", Length = "0x13")]
		[Token(Token = "0x60001AB")]
		public Vector2 get_point() { }

		[Address(RVA = "0xAEF2E0", Offset = "0xAEE6E0", Length = "0x5")]
		[Token(Token = "0x60001A9")]
		public PhysicsShape get_shapeA() { }

		[Address(RVA = "0x3124E70", Offset = "0x3124270", Length = "0x5")]
		[Token(Token = "0x60001AA")]
		public PhysicsShape get_shapeB() { }

		[Address(RVA = "0x3132730", Offset = "0x3131B30", Length = "0x28A")]
		[Token(Token = "0x60001AD")]
		public virtual string ToString() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000045")]
	internal struct TriggerBeginEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400012E")]
		private readonly PhysicsShape m_TriggerShape; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400012F")]
		private readonly PhysicsShape m_VisitorShape; //Field offset: 0x8

		[Token(Token = "0x17000070")]
		public PhysicsShape triggerShape
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x6000196")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000071")]
		public PhysicsShape visitorShape
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[Token(Token = "0x6000197")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000196")]
		public PhysicsShape get_triggerShape() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000197")]
		public PhysicsShape get_visitorShape() { }

		[Address(RVA = "0x3133A90", Offset = "0x3132E90", Length = "0x8B")]
		[Token(Token = "0x6000198")]
		public virtual string ToString() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000046")]
	internal struct TriggerEndEvent
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000130")]
		private readonly PhysicsShape m_TriggerShape; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000131")]
		private readonly PhysicsShape m_VisitorShape; //Field offset: 0x8

		[Token(Token = "0x17000072")]
		public PhysicsShape triggerShape
		{
			[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
			[Token(Token = "0x6000199")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000073")]
		public PhysicsShape visitorShape
		{
			[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
			[Token(Token = "0x600019A")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000199")]
		public PhysicsShape get_triggerShape() { }

		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x600019A")]
		public PhysicsShape get_visitorShape() { }

		[Address(RVA = "0x3133D40", Offset = "0x3133140", Length = "0x8B")]
		[Token(Token = "0x600019B")]
		public virtual string ToString() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000128")]
	private static PreSimulateEventHandler s_PreSimulate; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000129")]
	private static PreSimulateEventHandler s_PostSimulate; //Field offset: 0x8

	[Address(RVA = "0x31290F0", Offset = "0x31284F0", Length = "0xAC")]
	[RequiredByNativeCode]
	[Token(Token = "0x600018B")]
	private static void InvokePostSimulate(PhysicsWorld world, float deltaTime) { }

	[Address(RVA = "0x31291A0", Offset = "0x31285A0", Length = "0xAB")]
	[RequiredByNativeCode]
	[Token(Token = "0x600018A")]
	private static void InvokePreSimulate(PhysicsWorld world, float deltaTime) { }

	[Address(RVA = "0x3129250", Offset = "0x3128650", Length = "0x19")]
	[RequiredByNativeCode]
	[Token(Token = "0x600018E")]
	private static void SendBodyUpdateCallbacks(PhysicsWorld world) { }

	[Address(RVA = "0x3129270", Offset = "0x3128670", Length = "0x19")]
	[RequiredByNativeCode]
	[Token(Token = "0x600018F")]
	private static void SendContactCallbacks(PhysicsWorld world) { }

	[Address(RVA = "0x3129290", Offset = "0x3128690", Length = "0xD8")]
	[RequiredByNativeCode]
	[Token(Token = "0x600018C")]
	private static bool SendContactFilterCallback(object callbackTarget, ContactFilterEvent contactFilterEvent) { }

	[Address(RVA = "0x3129370", Offset = "0x3128770", Length = "0x19")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000191")]
	private static void SendJointThresholdCallbacks(PhysicsWorld world) { }

	[Address(RVA = "0x3129390", Offset = "0x3128790", Length = "0xE1")]
	[RequiredByNativeCode]
	[Token(Token = "0x600018D")]
	private static bool SendPreSolveCallback(object callbackTarget, PreSolveEvent preSolveEvent) { }

	[Address(RVA = "0x3129480", Offset = "0x3128880", Length = "0x19")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000190")]
	private static void SendTriggerCallbacks(PhysicsWorld world) { }

}

