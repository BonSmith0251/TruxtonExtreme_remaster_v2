namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Procedural/Extensions/Cinemachine Decollider")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineDecollider.html")]
[RequiredTarget(RequiredTargets::Tracking (1))]
[SaveDuringPlay]
[Token(Token = "0x2000018")]
public class CinemachineDecollider : CinemachineExtension
{
	[CompilerGenerated]
	[Token(Token = "0x200001D")]
	private sealed class <>c
	{
		[Token(Token = "0x4000073")]
		public static readonly <>c <>9; //Field offset: 0x0

		[Address(RVA = "0x2818620", Offset = "0x2817A20", Length = "0x67")]
		[Token(Token = "0x600008B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600008C")]
		public <>c() { }

		[Address(RVA = "0x2818530", Offset = "0x2817930", Length = "0xED")]
		[Token(Token = "0x600008D")]
		internal int <.cctor>b__22_0(int a, int b) { }

	}

	[Token(Token = "0x2000019")]
	internal struct DecollisionSettings
	{
		[Token(Token = "0x200001A")]
		internal struct FollowTargetSettings
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000067")]
			[Tooltip("Use the Follow target when resolving occlusions, instead of the LookAt target.")]
			public bool Enabled; //Field offset: 0x0
			[FieldOffset(Offset = "0x4")]
			[Token(Token = "0x4000068")]
			[Tooltip("Vertical offset from the Follow target's root, in target local space")]
			public float YOffset; //Field offset: 0x4

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000062")]
		[Tooltip("When enabled, will attempt to push the camera out of intersecting objects")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000063")]
		[Tooltip("Objects on these layers will be detected")]
		public LayerMask ObstacleLayers; //Field offset: 0x4
		[EnabledProperty("Enabled", null)]
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000064")]
		public FollowTargetSettings UseFollowTarget; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Range(0, 10)]
		[Token(Token = "0x4000065")]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
		public float Damping; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Range(0, 2)]
		[Token(Token = "0x4000066")]
		[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
		public float SmoothingTime; //Field offset: 0x14

	}

	[Token(Token = "0x200001B")]
	internal struct TerrainSettings
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000069")]
		[Tooltip("When enabled, will attempt to place the camera on top of terrain layers")]
		public bool Enabled; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x400006A")]
		[Tooltip("Colliders on these layers will be detected")]
		public LayerMask TerrainLayers; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400006B")]
		[Tooltip("Specifies the maximum length of a raycast used to find terrain colliders")]
		public float MaximumRaycast; //Field offset: 0x8
		[FieldOffset(Offset = "0xC")]
		[Range(0, 10)]
		[Token(Token = "0x400006C")]
		[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
		public float Damping; //Field offset: 0xC

	}

	[Token(Token = "0x200001C")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400006D")]
		public float PreviousTerrainDisplacement; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400006E")]
		public float PreviousDistanceFromTarget; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400006F")]
		public Vector3 PreviouDecollisionDisplacement; //Field offset: 0x20
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000070")]
		public Vector3 PreviousCorrectedCameraPosition; //Field offset: 0x2C
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000071")]
		private float m_SmoothedDistance; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000072")]
		private float m_SmoothingStartTime; //Field offset: 0x3C

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x600008A")]
		public VcamExtraState() { }

		[Address(RVA = "0x28189F0", Offset = "0x2817DF0", Length = "0x110")]
		[Token(Token = "0x6000089")]
		public float UpdateDistanceSmoothing(float distance, float smoothingTime, bool haveDisplacement) { }

	}

	[Token(Token = "0x400005D")]
	private const int kColliderBufferSize = 10; //Field offset: 0x0
	[Token(Token = "0x400005E")]
	private static Collider[] s_ColliderBuffer; //Field offset: 0x0
	[Token(Token = "0x400005F")]
	private static Single[] s_ColliderDistanceBuffer; //Field offset: 0x8
	[Token(Token = "0x4000060")]
	private static Int32[] s_ColliderOrderBuffer; //Field offset: 0x10
	[Token(Token = "0x4000061")]
	private static readonly IComparer<Int32> s_ColliderBufferSorter; //Field offset: 0x18
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400005A")]
	[Tooltip("Camera will try to maintain this distance from any obstacle or terrain.  Increase it if necessary to keep the camera from clipping the near edge of obsacles.")]
	public float CameraRadius; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x400005B")]
	public DecollisionSettings Decollision; //Field offset: 0x34
	[FieldOffset(Offset = "0x4C")]
	[FoldoutWithEnabledButton("Enabled")]
	[Token(Token = "0x400005C")]
	public TerrainSettings TerrainResolution; //Field offset: 0x4C

	[Address(RVA = "0x2808AC0", Offset = "0x2807EC0", Length = "0x1BE")]
	[Token(Token = "0x6000088")]
	private static CinemachineDecollider() { }

	[Address(RVA = "0x2808C80", Offset = "0x2808080", Length = "0xE")]
	[Token(Token = "0x6000087")]
	public CinemachineDecollider() { }

	[Address(RVA = "0x2806970", Offset = "0x2805D70", Length = "0x441")]
	[Token(Token = "0x6000086")]
	private Vector3 ApplySmoothingAndDamping(Vector3 displacement, Vector3 lookAtPoint, Vector3 oldCamPos, VcamExtraState extra, float deltaTime) { }

	[Address(RVA = "0x2806DC0", Offset = "0x28061C0", Length = "0x913")]
	[Token(Token = "0x6000085")]
	private Vector3 DecollideCamera(Vector3 cameraPos, Vector3 lookAtPoint) { }

	[Address(RVA = "0x28076E0", Offset = "0x2806AE0", Length = "0x6F")]
	[Token(Token = "0x6000081")]
	public virtual void ForceCameraPosition(CinemachineVirtualCameraBase vcam, Vector3 pos, Quaternion rot) { }

	[Address(RVA = "0x2807750", Offset = "0x2806B50", Length = "0x2B1")]
	[Token(Token = "0x6000083")]
	private Vector3 GetAvoidanceResolutionTargetPoint(CinemachineVirtualCameraBase vcam, ref CameraState state) { }

	[Address(RVA = "0x2807A10", Offset = "0x2806E10", Length = "0x23")]
	[Token(Token = "0x6000080")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2807A40", Offset = "0x2806E40", Length = "0x50")]
	[Token(Token = "0x600007F")]
	protected virtual void OnDestroy() { }

	[Address(RVA = "0x2807A90", Offset = "0x2806E90", Length = "0x15")]
	[Token(Token = "0x600007D")]
	private void OnValidate() { }

	[Address(RVA = "0x2807AB0", Offset = "0x2806EB0", Length = "0xCF4")]
	[Token(Token = "0x6000082")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x28087B0", Offset = "0x2807BB0", Length = "0x87")]
	[Token(Token = "0x600007E")]
	private void Reset() { }

	[Address(RVA = "0x2808840", Offset = "0x2807C40", Length = "0x27B")]
	[Token(Token = "0x6000084")]
	private float ResolveTerrain(VcamExtraState extra, Vector3 camPos, Vector3 up, float deltaTime) { }

}

