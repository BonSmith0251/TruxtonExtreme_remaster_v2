namespace UnityEngine.Rendering.Universal;

[BurstCompile(FloatMode = FloatMode::Default (0), DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
[Token(Token = "0x20001BD")]
internal struct TilingJob : IJobFor
{
	[CompilerGenerated]
	[Token(Token = "0x20001BE")]
	private struct <>c__DisplayClass20_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400099C")]
		public VisibleLight light; //Field offset: 0x0
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400099D")]
		public float3 lightPositionVS; //Field offset: 0x80
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x400099E")]
		public float3 lightDirectionVS; //Field offset: 0x8C
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400099F")]
		public float cosHalfAngle; //Field offset: 0x98
		[FieldOffset(Offset = "0x9C")]
		[Token(Token = "0x40009A0")]
		public float coneHeight; //Field offset: 0x9C

	}

	[CompilerGenerated]
	[Token(Token = "0x20001BF")]
	private struct <>c__DisplayClass21_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40009A1")]
		public VisibleLight light; //Field offset: 0x0
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40009A2")]
		public float3 lightPosVS; //Field offset: 0x80
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x40009A3")]
		public float3 lightDirVS; //Field offset: 0x8C
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x40009A4")]
		public float cosHalfAngle; //Field offset: 0x98

	}

	[Token(Token = "0x400099A")]
	private static readonly float3[] k_CubePoints; //Field offset: 0x0
	[Token(Token = "0x400099B")]
	private static readonly int4[] k_CubeLineIndices; //Field offset: 0x8
	[FieldOffset(Offset = "0x0")]
	[ReadOnly]
	[Token(Token = "0x4000987")]
	public NativeArray<VisibleLight> lights; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[ReadOnly]
	[Token(Token = "0x4000988")]
	public NativeArray<VisibleReflectionProbe> reflectionProbes; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[ReadOnly]
	[Token(Token = "0x4000989")]
	public bool reflectionProbeRotation; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[NativeDisableParallelForRestriction]
	[Token(Token = "0x400098A")]
	public NativeArray<InclusiveRange> tileRanges; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400098B")]
	public int itemsPerTile; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400098C")]
	public int rangesPerItem; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400098D")]
	public Fixed2<float4x4> worldToViews; //Field offset: 0x40
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x400098E")]
	public float2 tileScale; //Field offset: 0xC0
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x400098F")]
	public float2 tileScaleInv; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000990")]
	public Fixed2<Single> viewPlaneBottoms; //Field offset: 0xD0
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000991")]
	public Fixed2<Single> viewPlaneTops; //Field offset: 0xD8
	[FieldOffset(Offset = "0xE0")]
	[Token(Token = "0x4000992")]
	public Fixed2<float4> viewToViewportScaleBiases; //Field offset: 0xE0
	[FieldOffset(Offset = "0x100")]
	[Token(Token = "0x4000993")]
	public int2 tileCount; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000994")]
	public float near; //Field offset: 0x108
	[FieldOffset(Offset = "0x10C")]
	[Token(Token = "0x4000995")]
	public bool isOrthographic; //Field offset: 0x10C
	[FieldOffset(Offset = "0x10E")]
	[Token(Token = "0x4000996")]
	private InclusiveRange m_TileYRange; //Field offset: 0x10E
	[FieldOffset(Offset = "0x114")]
	[Token(Token = "0x4000997")]
	private int m_Offset; //Field offset: 0x114
	[FieldOffset(Offset = "0x118")]
	[Token(Token = "0x4000998")]
	private int m_ViewIndex; //Field offset: 0x118
	[FieldOffset(Offset = "0x11C")]
	[Token(Token = "0x4000999")]
	private float2 m_CenterOffset; //Field offset: 0x11C

	[Address(RVA = "0x2DFAA60", Offset = "0x2DF9E60", Length = "0x1F2")]
	[Token(Token = "0x6000996")]
	private static TilingJob() { }

	[Address(RVA = "0x2DFA7A0", Offset = "0x2DF9BA0", Length = "0x141")]
	[CompilerGenerated]
	[Token(Token = "0x6000998")]
	internal static bool <TileLight>g__ConicPointIsValid|20_1(float3 p, ref <>c__DisplayClass20_0 unnamed_param_1) { }

	[Address(RVA = "0x2DFA6A0", Offset = "0x2DF9AA0", Length = "0xFF")]
	[CompilerGenerated]
	[Token(Token = "0x6000997")]
	internal static bool <TileLight>g__SpherePointIsValid|20_0(float3 p, ref <>c__DisplayClass20_0 unnamed_param_1) { }

	[Address(RVA = "0x2DFA6A0", Offset = "0x2DF9AA0", Length = "0xFF")]
	[CompilerGenerated]
	[Token(Token = "0x6000999")]
	internal static bool <TileLightOrthographic>g__SpherePointIsValid|21_0(float3 p, ref <>c__DisplayClass21_0 unnamed_param_1) { }

	[Address(RVA = "0x2DF3AD0", Offset = "0x2DF2ED0", Length = "0x267")]
	[Token(Token = "0x6000993")]
	private static float3 EvaluateNearConic(float near, float3 o, float3 d, float r, float3 u, float3 v, float theta) { }

	[Address(RVA = "0x2DF3D40", Offset = "0x2DF3140", Length = "0x11C")]
	[Token(Token = "0x6000982")]
	public override void Execute(int jobIndex) { }

	[Address(RVA = "0x2DF3E60", Offset = "0x2DF3260", Length = "0x101")]
	[Token(Token = "0x6000989")]
	private void ExpandOrthographic(float3 positionVS) { }

	[Address(RVA = "0x2DF3F70", Offset = "0x2DF3370", Length = "0xD4")]
	[Token(Token = "0x600098A")]
	private void ExpandRangeOrthographic(ref InclusiveRange range, float xVS) { }

	[Address(RVA = "0x2DF4050", Offset = "0x2DF3450", Length = "0x101")]
	[Token(Token = "0x6000988")]
	private void ExpandY(float3 positionVS) { }

	[Address(RVA = "0x2DF4160", Offset = "0x2DF3560", Length = "0x2EC")]
	[Token(Token = "0x6000994")]
	private static float2 FindNearConicTangentTheta(float2 o, float2 d, float r, float2 u, float2 v) { }

	[Address(RVA = "0x2DF4450", Offset = "0x2DF3850", Length = "0x74D")]
	[Token(Token = "0x6000995")]
	private static float2 FindNearConicYTheta(float near, float3 o, float3 d, float r, float3 u, float3 v, float y) { }

	[Address(RVA = "0x2DF4BA0", Offset = "0x2DF3FA0", Length = "0x273")]
	[Token(Token = "0x600098E")]
	private static bool GetCircleClipPoints(float3 circleCenter, float3 circleNormal, float circleRadius, float near, out float3 p0, out float3 p1) { }

	[Address(RVA = "0x2DF4E20", Offset = "0x2DF4220", Length = "0x5DC")]
	[Token(Token = "0x6000992")]
	private static void GetConeSideTangentPoints(float3 vertex, float3 axis, float cosHalfAngle, float circleRadius, float coneHeight, float range, float3 circleU, float3 circleV, out float3 l1, out float3 l2) { }

	[Address(RVA = "0x2DF5400", Offset = "0x2DF4800", Length = "0x2A3")]
	[Token(Token = "0x6000990")]
	private static void GetProjectedCircleHorizon(float2 center, float radius, float2 U, float2 V, out float2 uv1, out float2 uv2) { }

	[Address(RVA = "0x2DF56B0", Offset = "0x2DF4AB0", Length = "0x2F0")]
	[Token(Token = "0x600098C")]
	private static void GetSphereHorizon(float2 center, float radius, float near, float clipRadius, out float2 p0, out float2 p1) { }

	[Address(RVA = "0x2DF59A0", Offset = "0x2DF4DA0", Length = "0x422")]
	[Token(Token = "0x600098D")]
	private static void GetSphereYPlaneHorizon(float3 center, float sphereRadius, float near, float clipRadius, float y, out float3 left, out float3 right) { }

	[Address(RVA = "0x2DF5DD0", Offset = "0x2DF51D0", Length = "0x3E4")]
	[Token(Token = "0x6000991")]
	private static bool IntersectCircleYPlane(float y, float3 circleCenter, float3 circleNormal, float3 circleU, float3 circleV, float circleRadius, out float3 p1, out float3 p2) { }

	[Address(RVA = "0x2DF61C0", Offset = "0x2DF55C0", Length = "0x186")]
	[Token(Token = "0x600098F")]
	private static ValueTuple<Single, Single> IntersectEllipseLine(float a, float b, float3 line) { }

	[Address(RVA = "0x1DE8820", Offset = "0x1DE7C20", Length = "0x5")]
	[Token(Token = "0x600098B")]
	private static float square(float x) { }

	[Address(RVA = "0x2DF73A0", Offset = "0x2DF67A0", Length = "0x261A")]
	[Token(Token = "0x6000983")]
	private void TileLight(int lightIndex) { }

	[Address(RVA = "0x2DF6350", Offset = "0x2DF5750", Length = "0x1049")]
	[Token(Token = "0x6000984")]
	private void TileLightOrthographic(int lightIndex) { }

	[Address(RVA = "0x2DF99C0", Offset = "0x2DF8DC0", Length = "0xCD1")]
	[Token(Token = "0x6000985")]
	private void TileReflectionProbe(int index) { }

	[Address(RVA = "0x2DFA9A0", Offset = "0x2DF9DA0", Length = "0xB8")]
	[Token(Token = "0x6000986")]
	private float2 ViewToTileSpace(float3 positionVS) { }

	[Address(RVA = "0x2DFA8F0", Offset = "0x2DF9CF0", Length = "0xAE")]
	[Token(Token = "0x6000987")]
	private float2 ViewToTileSpaceOrthographic(float3 positionVS) { }

}

