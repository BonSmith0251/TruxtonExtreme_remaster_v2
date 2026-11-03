namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Confiner 2D")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineConfiner2D.html")]
[SaveDuringPlay]
[Token(Token = "0x2000012")]
public class CinemachineConfiner2D : CinemachineExtension
{
	[Token(Token = "0x2000013")]
	internal struct OversizeWindowSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000045")]
		[Tooltip("Enable optimizing of computation and memory costs in the event that the window size is expected to be larger than will fit inside the confining shape.\nEnable only if needed, because it's costly")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000046")]
		[Tooltip("To optimize computation and memory costs, set this to the largest view size that the camera is expected to have.  The confiner will not compute a polygon cache for frustum sizes larger than this.  This refers to the size in world units of the frustum at the confiner plane (for orthographic cameras, this is just the orthographic size).  If set to 0, then this parameter is ignored and a polygon cache will be calculated for all potential window sizes.")]
		public float MaxWindowSize; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Range(0, 100)]
		[Token(Token = "0x4000047")]
		[Tooltip("For large window sizes, the confiner will potentially generate polygons with zero area.  The padding may be used to add a small amount of area to these polygons, to prevent them from being a series of disconnected dots.")]
		public float Padding; //Field offset: 0x8

	}

	[Token(Token = "0x2000015")]
	private struct ShapeCache
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400004D")]
		public ConfinerOven ConfinerOven; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400004E")]
		public List<List`1<Vector2>> OriginalPath; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400004F")]
		public Matrix4x4 DeltaWorldToBaked; //Field offset: 0x10
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000050")]
		public Matrix4x4 DeltaBakedToWorld; //Field offset: 0x50
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000051")]
		public float AspectRatio; //Field offset: 0x90
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x4000052")]
		private OversizeWindowSettings m_OversizeWindowSettings; //Field offset: 0x94
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000053")]
		internal float MaxComputationTimePerFrameInSeconds; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA4")]
		[Token(Token = "0x4000054")]
		private Matrix4x4 m_BakedToWorld; //Field offset: 0xA4
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4000055")]
		private Collider2D m_BoundingShape2D; //Field offset: 0xE8

		[Address(RVA = "0x2817380", Offset = "0x2816780", Length = "0x96")]
		[CompilerGenerated]
		[Token(Token = "0x6000070")]
		internal static bool <ValidateCache>g__HasAnyPoints|10_0(List<List`1<Vector2>> originalPath) { }

		[Address(RVA = "0x2816F50", Offset = "0x2816350", Length = "0x1DE")]
		[Token(Token = "0x600006F")]
		private void CalculateDeltaTransformationMatrix() { }

		[Address(RVA = "0x2817130", Offset = "0x2816530", Length = "0xCA")]
		[Token(Token = "0x600006C")]
		public void Invalidate() { }

		[Address(RVA = "0x2817200", Offset = "0x2816600", Length = "0x17F")]
		[Token(Token = "0x600006E")]
		private bool IsValid(in Collider2D boundingShape2D, in OversizeWindowSettings oversize, float aspectRatio) { }

		[Address(RVA = "0x2817420", Offset = "0x2816820", Length = "0xB01")]
		[Token(Token = "0x600006D")]
		public bool ValidateCache(Collider2D boundingShape2D, OversizeWindowSettings oversize, float aspectRatio, out bool confinerStateChanged) { }

	}

	[Token(Token = "0x2000014")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000048")]
		public BakedSolution BakedSolution; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000049")]
		public Vector3 PreviousDisplacement; //Field offset: 0x20
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x400004A")]
		public Vector3 DampedDisplacement; //Field offset: 0x2C
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400004B")]
		public Vector3 PreviousCameraPosition; //Field offset: 0x38
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x400004C")]
		public float FrustumHeight; //Field offset: 0x44

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600006B")]
		public VcamExtraState() { }

	}

	[Token(Token = "0x4000044")]
	private const float k_CornerAngleThreshold = 10; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_BoundingShape2D")]
	[Token(Token = "0x400003D")]
	[Tooltip("The 2D shape within which the camera is to be contained.  Can be polygon-, box-, or composite collider 2D.\n\nRemark: When assigning a GameObject here in the editor, this will be set to the first Collider2D found on the assigned GameObject!")]
	public Collider2D BoundingShape2D; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_Damping")]
	[Range(0, 5)]
	[Token(Token = "0x400003E")]
	[Tooltip("Damping applied around corners to avoid jumps.  Higher numbers are more gradual.")]
	public float Damping; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x400003F")]
	[Tooltip("Size of the slow-down zone at the edge of the bounding shape.")]
	public float SlowingDistance; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x4000040")]
	public OversizeWindowSettings OversizeWindow; //Field offset: 0x40
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000041")]
	private List<VcamExtraState> m_ExtraStateCache; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000042")]
	private ShapeCache m_ShapeCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x148")]
	[FormerlySerializedAs("m_MaxWindowSize")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x4000043")]
	private float m_LegacyMaxWindowSize; //Field offset: 0x148

	[Token(Token = "0x17000013")]
	public bool BoundingShapeIsBaked
	{
		[Address(RVA = "0x2805E80", Offset = "0x2805280", Length = "0x12")]
		[Token(Token = "0x6000064")]
		 get { } //Length: 18
	}

	[Address(RVA = "0x2805E60", Offset = "0x2805260", Length = "0x11")]
	[Token(Token = "0x600006A")]
	public CinemachineConfiner2D() { }

	[Address(RVA = "0x2804A90", Offset = "0x2803E90", Length = "0x176")]
	[Token(Token = "0x6000065")]
	public bool BakeBoundingShape(CinemachineVirtualCameraBase vcam, float maxTimeInSeconds) { }

	[Address(RVA = "0x2804C10", Offset = "0x2804010", Length = "0x91")]
	[Token(Token = "0x6000069")]
	public static float CalculateHalfFrustumHeight(in LensSettings lens, in float cameraPosLocalZ) { }

	[Address(RVA = "0x2804CB0", Offset = "0x28040B0", Length = "0x1F9")]
	[Token(Token = "0x6000067")]
	private Vector3 ConfinePoint(Vector3 pos, VcamExtraState extra, Vector3 fwd) { }

	[Address(RVA = "0x2805E80", Offset = "0x2805280", Length = "0x12")]
	[Token(Token = "0x6000064")]
	public bool get_BoundingShapeIsBaked() { }

	[Address(RVA = "0x2804EB0", Offset = "0x28042B0", Length = "0x12F")]
	[Token(Token = "0x6000068")]
	private float GetDistanceFromEdge(Vector3 p, Vector3 dirUnit, float max, VcamExtraState extra, Vector3 fwd) { }

	[Address(RVA = "0x2804FE0", Offset = "0x28043E0", Length = "0x19")]
	[Token(Token = "0x600005F")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2805000", Offset = "0x2804400", Length = "0x23")]
	[Token(Token = "0x6000062")]
	public void InvalidateBoundingShapeCache() { }

	[Address(RVA = "0x2805000", Offset = "0x2804400", Length = "0x23")]
	[Obsolete("Call InvalidateBoundingShapeCache() instead.", False)]
	[Token(Token = "0x6000063")]
	public void InvalidateCache() { }

	[Address(RVA = "0x2805030", Offset = "0x2804430", Length = "0x163")]
	[Token(Token = "0x6000061")]
	public void InvalidateLensCache() { }

	[Address(RVA = "0x28051A0", Offset = "0x28045A0", Length = "0x100")]
	[Token(Token = "0x6000060")]
	public virtual void OnTargetObjectWarped(CinemachineVirtualCameraBase vcam, Transform target, Vector3 positionDelta) { }

	[Address(RVA = "0x28052B0", Offset = "0x28046B0", Length = "0x84")]
	[Token(Token = "0x600005D")]
	private void OnValidate() { }

	[Address(RVA = "0x2805340", Offset = "0x2804740", Length = "0xAFB")]
	[Token(Token = "0x6000066")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2805E40", Offset = "0x2805240", Length = "0x18")]
	[Token(Token = "0x600005E")]
	private void Reset() { }

}

