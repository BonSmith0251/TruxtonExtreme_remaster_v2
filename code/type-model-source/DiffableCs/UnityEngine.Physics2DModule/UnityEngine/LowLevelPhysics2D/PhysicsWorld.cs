namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[Token(Token = "0x200004D")]
public struct PhysicsWorld : IEquatable<PhysicsWorld>
{
	[Token(Token = "0x2000059")]
	internal struct DrawColors
	{
		[DefaultMember("Item")]
		[Token(Token = "0x200005A")]
		private struct ConstraintGraphArray
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x40001A3")]
			public Color graphConstraint0; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x40001A4")]
			public Color graphConstraint1; //Field offset: 0x10
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x40001A5")]
			public Color graphConstraint2; //Field offset: 0x20
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x40001A6")]
			public Color graphConstraint3; //Field offset: 0x30
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x40001A7")]
			public Color graphConstraint4; //Field offset: 0x40
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x40001A8")]
			public Color graphConstraint5; //Field offset: 0x50
			[FieldOffset(Offset = "0x60")]
			[Token(Token = "0x40001A9")]
			public Color graphConstraint6; //Field offset: 0x60
			[FieldOffset(Offset = "0x70")]
			[Token(Token = "0x40001AA")]
			public Color graphConstraint7; //Field offset: 0x70
			[FieldOffset(Offset = "0x80")]
			[Token(Token = "0x40001AB")]
			public Color graphConstraint8; //Field offset: 0x80
			[FieldOffset(Offset = "0x90")]
			[Token(Token = "0x40001AC")]
			public Color graphConstraint9; //Field offset: 0x90
			[FieldOffset(Offset = "0xA0")]
			[Token(Token = "0x40001AD")]
			public Color graphConstraint10; //Field offset: 0xA0
			[FieldOffset(Offset = "0xB0")]
			[Token(Token = "0x40001AE")]
			public Color graphConstraint11; //Field offset: 0xB0
			[FieldOffset(Offset = "0xC0")]
			[Token(Token = "0x40001AF")]
			public Color graphConstraint12; //Field offset: 0xC0
			[FieldOffset(Offset = "0xD0")]
			[Token(Token = "0x40001B0")]
			public Color graphConstraint13; //Field offset: 0xD0
			[FieldOffset(Offset = "0xE0")]
			[Token(Token = "0x40001B1")]
			public Color graphConstraint14; //Field offset: 0xE0
			[FieldOffset(Offset = "0xF0")]
			[Token(Token = "0x40001B2")]
			public Color graphConstraint15; //Field offset: 0xF0
			[FieldOffset(Offset = "0x100")]
			[Token(Token = "0x40001B3")]
			public Color graphConstraint16; //Field offset: 0x100
			[FieldOffset(Offset = "0x110")]
			[Token(Token = "0x40001B4")]
			public Color graphConstraint17; //Field offset: 0x110
			[FieldOffset(Offset = "0x120")]
			[Token(Token = "0x40001B5")]
			public Color graphConstraint18; //Field offset: 0x120
			[FieldOffset(Offset = "0x130")]
			[Token(Token = "0x40001B6")]
			public Color graphConstraint19; //Field offset: 0x130
			[FieldOffset(Offset = "0x140")]
			[Token(Token = "0x40001B7")]
			public Color graphConstraint20; //Field offset: 0x140
			[FieldOffset(Offset = "0x150")]
			[Token(Token = "0x40001B8")]
			public Color graphConstraint21; //Field offset: 0x150
			[FieldOffset(Offset = "0x160")]
			[Token(Token = "0x40001B9")]
			public Color graphConstraint22; //Field offset: 0x160
			[FieldOffset(Offset = "0x170")]
			[Token(Token = "0x40001BA")]
			public Color graphConstraint23; //Field offset: 0x170

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018D")]
		public Color transformAxisX; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400018E")]
		public Color transformAxisY; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400018F")]
		public Color bodyBad; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000190")]
		public Color bodyDisabled; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000191")]
		public Color bodyAwake; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000192")]
		public Color bodyStatic; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000193")]
		public Color bodyKinematic; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000194")]
		public Color bodyTimeOfImpactEvent; //Field offset: 0x70
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000195")]
		public Color bodyFastCollisions; //Field offset: 0x80
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000196")]
		public Color bodyMovingFast; //Field offset: 0x90
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000197")]
		public Color bodySpeedCapped; //Field offset: 0xA0
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000198")]
		public Color shapeTrigger; //Field offset: 0xB0
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000199")]
		public Color shapeOther; //Field offset: 0xC0
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x400019A")]
		public Color shapeBounds; //Field offset: 0xD0
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x400019B")]
		public Color contactSpeculative; //Field offset: 0xE0
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x400019C")]
		public Color contactAdded; //Field offset: 0xF0
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x400019D")]
		public Color contactPersisted; //Field offset: 0x100
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x400019E")]
		public Color contactNormal; //Field offset: 0x110
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x400019F")]
		public Color contactImpulse; //Field offset: 0x120
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x40001A0")]
		public Color contactFriction; //Field offset: 0x130
		[FieldOffset(Offset = "0x140")]
		[Token(Token = "0x40001A1")]
		public Color solverIsland; //Field offset: 0x140
		[FieldOffset(Offset = "0x150")]
		[Token(Token = "0x40001A2")]
		private readonly ConstraintGraphArray m_ConstraintGraph; //Field offset: 0x150

	}

	[Flags]
	[Token(Token = "0x2000052")]
	internal enum DrawFillOptions : int
	{
		Interior = 1,
		Outline = 2,
		Orientation = 4,
		All = 7,
	}

	[Flags]
	[Token(Token = "0x2000051")]
	internal enum DrawOptions : int
	{
		Off = 0,
		SelectedBodies = 1,
		SelectedShapes = 2,
		SelectedShapeBounds = 4,
		SelectedJoints = 8,
		AllBodies = 16,
		AllShapes = 32,
		AllShapeBounds = 64,
		AllJoints = 128,
		AllContactPoints = 256,
		AllContactNormal = 512,
		AllContactImpulse = 1024,
		AllContactFriction = 2048,
		AllCustom = 4096,
		AllSolverIslands = 8192,
		DefaultAll = 4256,
		DefaultSelected = 4106,
	}

	[IsReadOnly]
	[Token(Token = "0x2000053")]
	public struct DrawResults
	{
		[IsReadOnly]
		[Token(Token = "0x2000056")]
		internal struct CapsuleGeometryElement
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400017F")]
			public readonly PhysicsTransform transform; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000180")]
			public readonly float radius; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000181")]
			public readonly float length; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000182")]
			public readonly float elementDepth; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x4000183")]
			public readonly DrawFillOptions drawFillOptions; //Field offset: 0x1C
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000184")]
			public readonly Color color; //Field offset: 0x20

			[Address(RVA = "0x3122D70", Offset = "0x3122170", Length = "0x8")]
			[Token(Token = "0x60001C7")]
			public static int Size() { }

		}

		[IsReadOnly]
		[Token(Token = "0x2000055")]
		internal struct CircleGeometryElement
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400017A")]
			public readonly PhysicsTransform transform; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400017B")]
			public readonly float radius; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x400017C")]
			public readonly float elementDepth; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400017D")]
			public readonly DrawFillOptions drawFillOptions; //Field offset: 0x18
			[FieldOffset(Offset = "0x1C")]
			[Token(Token = "0x400017E")]
			public readonly Color color; //Field offset: 0x1C

			[Address(RVA = "0x3123280", Offset = "0x3122680", Length = "0x8")]
			[Token(Token = "0x60001C6")]
			public static int Size() { }

		}

		[IsReadOnly]
		[Token(Token = "0x2000057")]
		internal struct LineElement
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000185")]
			public readonly PhysicsTransform transform; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000186")]
			public readonly float length; //Field offset: 0x10
			[FieldOffset(Offset = "0x14")]
			[Token(Token = "0x4000187")]
			public readonly float elementDepth; //Field offset: 0x14
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000188")]
			public readonly Color color; //Field offset: 0x18

			[Address(RVA = "0x3126B60", Offset = "0x3125F60", Length = "0x8")]
			[Token(Token = "0x60001C8")]
			public static int Size() { }

		}

		[IsReadOnly]
		[Token(Token = "0x2000058")]
		internal struct PointElement
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000189")]
			public readonly Vector2 position; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400018A")]
			public readonly float radius; //Field offset: 0x8
			[FieldOffset(Offset = "0xC")]
			[Token(Token = "0x400018B")]
			public readonly float elementDepth; //Field offset: 0xC
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400018C")]
			public readonly Color color; //Field offset: 0x10

			[Address(RVA = "0x3131B90", Offset = "0x3130F90", Length = "0x8")]
			[Token(Token = "0x60001C9")]
			public static int Size() { }

		}

		[IsReadOnly]
		[Token(Token = "0x2000054")]
		internal struct PolygonGeometryElement
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400016C")]
			public readonly PhysicsTransform transform; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400016D")]
			public readonly Vector2 p0; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400016E")]
			public readonly Vector2 p1; //Field offset: 0x18
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x400016F")]
			public readonly Vector2 p2; //Field offset: 0x20
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000170")]
			public readonly Vector2 p3; //Field offset: 0x28
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000171")]
			public readonly Vector2 p4; //Field offset: 0x30
			[FieldOffset(Offset = "0x38")]
			[Token(Token = "0x4000172")]
			public readonly Vector2 p5; //Field offset: 0x38
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000173")]
			public readonly Vector2 p6; //Field offset: 0x40
			[FieldOffset(Offset = "0x48")]
			[Token(Token = "0x4000174")]
			public readonly Vector2 p7; //Field offset: 0x48
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x4000175")]
			public readonly int count; //Field offset: 0x50
			[FieldOffset(Offset = "0x54")]
			[Token(Token = "0x4000176")]
			public readonly float radius; //Field offset: 0x54
			[FieldOffset(Offset = "0x58")]
			[Token(Token = "0x4000177")]
			public readonly float elementDepth; //Field offset: 0x58
			[FieldOffset(Offset = "0x5C")]
			[Token(Token = "0x4000178")]
			public readonly DrawFillOptions drawFillOptions; //Field offset: 0x5C
			[FieldOffset(Offset = "0x60")]
			[Token(Token = "0x4000179")]
			public readonly Color color; //Field offset: 0x60

			[Address(RVA = "0x3132670", Offset = "0x3131A70", Length = "0x8")]
			[Token(Token = "0x60001C5")]
			public static int Size() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000167")]
		internal readonly PhysicsBuffer m_PolygonGeometryElements; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000168")]
		internal readonly PhysicsBuffer m_CircleGeometryElements; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000169")]
		internal readonly PhysicsBuffer m_CapsuleGeometryElements; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400016A")]
		internal readonly PhysicsBuffer m_LineElements; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400016B")]
		internal readonly PhysicsBuffer m_PointElements; //Field offset: 0x40

		[Token(Token = "0x17000088")]
		public NativeArray<CapsuleGeometryElement> capsuleGeometryArray
		{
			[Address(RVA = "0x31253A0", Offset = "0x31247A0", Length = "0x57")]
			[Token(Token = "0x60001C2")]
			 get { } //Length: 87
		}

		[Token(Token = "0x17000087")]
		public NativeArray<CircleGeometryElement> circleGeometryArray
		{
			[Address(RVA = "0x3125400", Offset = "0x3124800", Length = "0x57")]
			[Token(Token = "0x60001C1")]
			 get { } //Length: 87
		}

		[Token(Token = "0x17000089")]
		public NativeArray<LineElement> lineArray
		{
			[Address(RVA = "0x3125460", Offset = "0x3124860", Length = "0x57")]
			[Token(Token = "0x60001C3")]
			 get { } //Length: 87
		}

		[Token(Token = "0x1700008A")]
		public NativeArray<PointElement> pointArray
		{
			[Address(RVA = "0x31254C0", Offset = "0x31248C0", Length = "0x57")]
			[Token(Token = "0x60001C4")]
			 get { } //Length: 87
		}

		[Token(Token = "0x17000086")]
		public NativeArray<PolygonGeometryElement> polygonGeometryArray
		{
			[Address(RVA = "0x3125520", Offset = "0x3124920", Length = "0x56")]
			[Token(Token = "0x60001C0")]
			 get { } //Length: 86
		}

		[Address(RVA = "0x31253A0", Offset = "0x31247A0", Length = "0x57")]
		[Token(Token = "0x60001C2")]
		public NativeArray<CapsuleGeometryElement> get_capsuleGeometryArray() { }

		[Address(RVA = "0x3125400", Offset = "0x3124800", Length = "0x57")]
		[Token(Token = "0x60001C1")]
		public NativeArray<CircleGeometryElement> get_circleGeometryArray() { }

		[Address(RVA = "0x3125460", Offset = "0x3124860", Length = "0x57")]
		[Token(Token = "0x60001C3")]
		public NativeArray<LineElement> get_lineArray() { }

		[Address(RVA = "0x31254C0", Offset = "0x31248C0", Length = "0x57")]
		[Token(Token = "0x60001C4")]
		public NativeArray<PointElement> get_pointArray() { }

		[Address(RVA = "0x3125520", Offset = "0x3124920", Length = "0x56")]
		[Token(Token = "0x60001C0")]
		public NativeArray<PolygonGeometryElement> get_polygonGeometryArray() { }

		[Address(RVA = "0x3125110", Offset = "0x3124510", Length = "0x285")]
		[Token(Token = "0x60001BF")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x200004E")]
	internal enum SimulationType : int
	{
		FixedUpdate = 0,
		Update = 1,
		Script = 2,
	}

	[Token(Token = "0x2000050")]
	internal enum TransformPlane : int
	{
		XY = 0,
		XZ = 1,
		ZY = 2,
	}

	[Token(Token = "0x200004F")]
	internal enum TransformWriteMode : int
	{
		Off = 0,
		Fast2D = 1,
		Slow3D = 2,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000142")]
	internal readonly ushort m_Index1; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000143")]
	private readonly ushort m_Generation; //Field offset: 0x2

	[Token(Token = "0x17000083")]
	public static bool bypassLowLevel
	{
		[Address(RVA = "0x312A300", Offset = "0x3129700", Length = "0x2A")]
		[Token(Token = "0x60001B6")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000084")]
	public static bool isRenderingAllowed
	{
		[Address(RVA = "0x312A330", Offset = "0x3129730", Length = "0x2A")]
		[Token(Token = "0x60001B7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x17000085")]
	public bool isValid
	{
		[Address(RVA = "0x3131810", Offset = "0x3130C10", Length = "0x35")]
		[Token(Token = "0x60001B8")]
		 get { } //Length: 53
	}

	[Address(RVA = "0x3130810", Offset = "0x312FC10", Length = "0x37")]
	[Token(Token = "0x60001BE")]
	internal static void DrawAllWorlds(PhysicsAABB drawAABB) { }

	[Address(RVA = "0x3130850", Offset = "0x312FC50", Length = "0x5C")]
	[Token(Token = "0x60001B3")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x30CD340", Offset = "0x30CC740", Length = "0x13")]
	[Token(Token = "0x60001B4")]
	public override bool Equals(PhysicsWorld other) { }

	[Address(RVA = "0x312A300", Offset = "0x3129700", Length = "0x2A")]
	[Token(Token = "0x60001B6")]
	public static bool get_bypassLowLevel() { }

	[Address(RVA = "0x312A330", Offset = "0x3129730", Length = "0x2A")]
	[Token(Token = "0x60001B7")]
	public static bool get_isRenderingAllowed() { }

	[Address(RVA = "0x3131810", Offset = "0x3130C10", Length = "0x35")]
	[Token(Token = "0x60001B8")]
	public bool get_isValid() { }

	[Address(RVA = "0x31308B0", Offset = "0x312FCB0", Length = "0x6D")]
	[Token(Token = "0x60001B5")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x3130920", Offset = "0x312FD20", Length = "0x279")]
	[Token(Token = "0x60001BA")]
	public void SendBodyUpdateCallbacks() { }

	[Address(RVA = "0x3130BA0", Offset = "0x312FFA0", Length = "0x48F")]
	[Token(Token = "0x60001BB")]
	public void SendContactCallbacks() { }

	[Address(RVA = "0x3131030", Offset = "0x3130430", Length = "0x23C")]
	[Token(Token = "0x60001BD")]
	public void SendJointThresholdCallbacks() { }

	[Address(RVA = "0x3131270", Offset = "0x3130670", Length = "0x423")]
	[Token(Token = "0x60001BC")]
	public void SendTriggerCallbacks() { }

	[Address(RVA = "0x31316A0", Offset = "0x3130AA0", Length = "0x9E")]
	[Token(Token = "0x60001B9")]
	internal void SetTransformWriteTweens(ReadOnlySpan<TransformWriteTween> transformWriteTweens) { }

	[Address(RVA = "0x3131740", Offset = "0x3130B40", Length = "0xC9")]
	[Token(Token = "0x60001B2")]
	public virtual string ToString() { }

}

