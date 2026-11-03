namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExecuteAlways]
[Obsolete("CinemachineConfiner has been deprecated. Use CinemachineConfiner2D or CinemachineConfiner3D instead")]
[SaveDuringPlay]
[Token(Token = "0x2000108")]
public class CinemachineConfiner : CinemachineExtension
{
	[Token(Token = "0x2000109")]
	internal enum Mode : int
	{
		Confine2D = 0,
		Confine3D = 1,
	}

	[Token(Token = "0x200010A")]
	private class VcamExtraState : VcamExtraStateBase
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400041E")]
		public Vector3 PreviousDisplacement; //Field offset: 0x18
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x400041F")]
		public float ConfinerDisplacement; //Field offset: 0x24

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x6000512")]
		public VcamExtraState() { }

	}

	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000413")]
	[Tooltip("The confiner can operate using a 2D bounding shape or a 3D bounding volume")]
	public Mode m_ConfineMode; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000414")]
	[Tooltip("The volume within which the camera is to be contained")]
	public Collider m_BoundingVolume; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000415")]
	[Tooltip("The 2D shape within which the camera is to be contained")]
	public Collider2D m_BoundingShape2D; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000416")]
	private Collider2D m_BoundingShape2DCache; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000417")]
	[Tooltip("If camera is orthographic, screen edges will be confined to the volume.  If not checked, then only the camera center will be confined")]
	public bool m_ConfineScreenEdges; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Range(0, 10)]
	[Token(Token = "0x4000418")]
	[Tooltip("How gradually to return the camera to the bounding volume if it goes beyond the borders.  Higher numbers are more gradual.")]
	public float m_Damping; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000419")]
	private List<List`1<Vector2>> m_PathCache; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400041A")]
	private int m_PathTotalPointCount; //Field offset: 0x60

	[Token(Token = "0x1700010B")]
	public bool IsValid
	{
		[Address(RVA = "0x2859D80", Offset = "0x2859180", Length = "0x129")]
		[Token(Token = "0x6000506")]
		 get { } //Length: 297
	}

	[Address(RVA = "0x2859D70", Offset = "0x2859170", Length = "0xB")]
	[Token(Token = "0x6000511")]
	public CinemachineConfiner() { }

	[Address(RVA = "0x2858560", Offset = "0x2857960", Length = "0x61")]
	[Token(Token = "0x6000501")]
	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x28585D0", Offset = "0x28579D0", Length = "0x6B8")]
	[Token(Token = "0x600050D")]
	private Vector3 ConfineOrthoCameraToScreenEdges(ref CameraState state) { }

	[Address(RVA = "0x2858C90", Offset = "0x2858090", Length = "0x51E")]
	[Token(Token = "0x600050C")]
	private Vector3 ConfinePoint(Vector3 camPos) { }

	[Address(RVA = "0x28591B0", Offset = "0x28585B0", Length = "0x8")]
	[Token(Token = "0x6000505")]
	protected virtual void ConnectToVcam(bool connect) { }

	[Address(RVA = "0x2859D80", Offset = "0x2859180", Length = "0x129")]
	[Token(Token = "0x6000506")]
	public bool get_IsValid() { }

	[Address(RVA = "0x28591C0", Offset = "0x28585C0", Length = "0x58")]
	[Token(Token = "0x6000502")]
	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	[Address(RVA = "0x5B3830", Offset = "0x5B2C30", Length = "0x6")]
	[Token(Token = "0x6000507")]
	public virtual float GetMaxDampTime() { }

	[Address(RVA = "0x2859220", Offset = "0x2858620", Length = "0x34")]
	[Token(Token = "0x600050A")]
	public void InvalidateCache() { }

	[Address(RVA = "0x2859260", Offset = "0x2858660", Length = "0x4")]
	[Obsolete("Please use InvalidateCache() instead")]
	[Token(Token = "0x6000509")]
	public void InvalidatePathCache() { }

	[Address(RVA = "0x2859270", Offset = "0x2858670", Length = "0x10")]
	[Token(Token = "0x6000504")]
	private void OnValidate() { }

	[Address(RVA = "0x2859280", Offset = "0x2858680", Length = "0x404")]
	[Token(Token = "0x6000508")]
	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	[Address(RVA = "0x2859690", Offset = "0x2858A90", Length = "0x47")]
	[Token(Token = "0x6000503")]
	private void Reset() { }

	[Address(RVA = "0x2859780", Offset = "0x2858B80", Length = "0x3C")]
	[Token(Token = "0x6000510")]
	internal void UpgradeToCm3(CinemachineConfiner2D c) { }

	[Address(RVA = "0x2859750", Offset = "0x2858B50", Length = "0x26")]
	[Token(Token = "0x600050F")]
	internal void UpgradeToCm3(CinemachineConfiner3D c) { }

	[Address(RVA = "0x28596E0", Offset = "0x2858AE0", Length = "0x69")]
	[Token(Token = "0x600050E")]
	internal Type UpgradeToCm3_GetTargetType() { }

	[Address(RVA = "0x28597C0", Offset = "0x2858BC0", Length = "0x5A7")]
	[Token(Token = "0x600050B")]
	private bool ValidatePathCache() { }

}

