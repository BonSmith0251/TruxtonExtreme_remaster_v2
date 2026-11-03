namespace UnityEngine.LowLevelPhysics2D;

[IsReadOnly]
[RequiredByNativeCode(GenerateProxy = True)]
[Token(Token = "0x2000064")]
internal struct PhysicsNativeMethods
{
	[Token(Token = "0x2000065")]
	private struct FastWriteTransformsJob : IJobParallelForTransform
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40001FF")]
		public NativeArray<TransformWriteTween> TransformWriteTweens; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x4000200")]
		public TransformPlane TransformPlane; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[ReadOnly]
		[Token(Token = "0x4000201")]
		public bool TransformTweening; //Field offset: 0x14

		[Address(RVA = "0x3126040", Offset = "0x3125440", Length = "0x2BB")]
		[Token(Token = "0x60001E8")]
		public override void Execute(int index, TransformAccess transform) { }

	}

	[Token(Token = "0x2000066")]
	private struct Slow3DWriteTransformsJob : IJobParallelForTransform
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000202")]
		public NativeArray<TransformWriteTween> TransformWriteTweens; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x4000203")]
		public TransformPlane TransformPlane; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[ReadOnly]
		[Token(Token = "0x4000204")]
		public bool TransformTweening; //Field offset: 0x14

		[Address(RVA = "0x31336C0", Offset = "0x3132AC0", Length = "0x2EB")]
		[Token(Token = "0x60001E9")]
		public override void Execute(int index, TransformAccess transform) { }

	}

	[Token(Token = "0x2000067")]
	private struct WriteTransformTweensJob : IJobParallelForTransform
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4000205")]
		public NativeArray<TransformWriteTween> TransformWriteTweens; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		[Token(Token = "0x4000206")]
		public TransformWriteMode TransformWriteMode; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[ReadOnly]
		[Token(Token = "0x4000207")]
		public TransformPlane TransformPlane; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[ReadOnly]
		[Token(Token = "0x4000208")]
		public float InterpolationTime; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[ReadOnly]
		[Token(Token = "0x4000209")]
		public float ExtrapolationTime; //Field offset: 0x1C

		[Address(RVA = "0x3133F30", Offset = "0x3133330", Length = "0x6C9")]
		[Token(Token = "0x60001EA")]
		public override void Execute(int index, TransformAccess transform) { }

	}

	[Token(Token = "0x40001FE")]
	private static TransformAccessArray[] s_WorldTransformAccessArrays; //Field offset: 0x0

	[Address(RVA = "0x312D460", Offset = "0x312C860", Length = "0x68")]
	[Token(Token = "0x60001E7")]
	private static PhysicsNativeMethods() { }

	[Address(RVA = "0x312CB40", Offset = "0x312BF40", Length = "0x113")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001E2")]
	private static void CreateWorldTransformAccessArray(PhysicsWorld world, int capacity, int desiredJobCount) { }

	[Address(RVA = "0x312CC60", Offset = "0x312C060", Length = "0xDE")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001E3")]
	private static void DestroyWorldTransformAccessArray(PhysicsWorld world) { }

	[Address(RVA = "0x312CD40", Offset = "0x312C140", Length = "0x11A")]
	[Token(Token = "0x60001E4")]
	private static TransformAccessArray GetWorldTransformAccessArray(PhysicsWorld world) { }

	[Address(RVA = "0x312CE60", Offset = "0x312C260", Length = "0x206")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001E6")]
	private static void WriteTransformTweens(PhysicsWorld world, double lastSimulationTimestamp, float lastSimulationDeltaTime, TransformWriteMode transformWriteMode, TransformPlane transformPlane, PhysicsBuffer transformWriteTweensBuffer) { }

	[Address(RVA = "0x312D070", Offset = "0x312C470", Length = "0x3EF")]
	[RequiredByNativeCode]
	[Token(Token = "0x60001E5")]
	private static void WriteWorldTransforms(PhysicsWorld world, TransformWriteMode transformWriteMode, TransformPlane transformPlane, int eventCount, bool transformTweening) { }

}

