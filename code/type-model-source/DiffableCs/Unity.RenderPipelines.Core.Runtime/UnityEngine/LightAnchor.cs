namespace UnityEngine;

[AddComponentMenu("Rendering/Light Anchor")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[Token(Token = "0x2000009")]
public class LightAnchor : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	private struct Axes
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000020")]
		public Vector3 up; //Field offset: 0x0
		[FieldOffset(Offset = "0xC")]
		[Token(Token = "0x4000021")]
		public Vector3 right; //Field offset: 0xC
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000022")]
		public Vector3 forward; //Field offset: 0x18

	}

	[Token(Token = "0x200000A")]
	internal enum UpDirection : int
	{
		World = 0,
		Local = 1,
	}

	[Token(Token = "0x4000013")]
	private const float k_ArcRadius = 5; //Field offset: 0x0
	[Token(Token = "0x4000014")]
	private const float k_AxisLength = 10; //Field offset: 0x0
	[Token(Token = "0x4000015")]
	internal const float k_MaxDistance = 10000; //Field offset: 0x0
	[FieldOffset(Offset = "0x20")]
	[Min(0)]
	[SerializeField]
	[Token(Token = "0x4000016")]
	private float m_Distance; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Token(Token = "0x4000017")]
	private UpDirection m_FrameSpace; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000018")]
	private Transform m_AnchorPositionOverride; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000019")]
	private Vector3 m_AnchorPositionOffset; //Field offset: 0x30
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Token(Token = "0x400001A")]
	private float m_Yaw; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x400001B")]
	private float m_Pitch; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	[Token(Token = "0x400001C")]
	private float m_Roll; //Field offset: 0x44

	[Token(Token = "0x17000006")]
	public Vector3 anchorPosition
	{
		[Address(RVA = "0x2BC3C10", Offset = "0x2BC3010", Length = "0x1A8")]
		[Token(Token = "0x600001A")]
		 get { } //Length: 424
	}

	[Token(Token = "0x17000008")]
	public Vector3 anchorPositionOffset
	{
		[Address(RVA = "0x2BC3BF0", Offset = "0x2BC2FF0", Length = "0x13")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 19
		[Address(RVA = "0x2BC3DC0", Offset = "0x2BC31C0", Length = "0x10")]
		[Token(Token = "0x600001E")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000007")]
	public Transform anchorPositionOverride
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x600001B")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x600001C")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000004")]
	public float distance
	{
		[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
		[Token(Token = "0x6000016")]
		 get { } //Length: 6
		[Address(RVA = "0x2BC3DD0", Offset = "0x2BC31D0", Length = "0x21")]
		[Token(Token = "0x6000017")]
		 set { } //Length: 33
	}

	[Token(Token = "0x17000005")]
	public UpDirection frameSpace
	{
		[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
		[Token(Token = "0x6000018")]
		 get { } //Length: 4
		[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
		[Token(Token = "0x6000019")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000002")]
	public float pitch
	{
		[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
		[Token(Token = "0x6000012")]
		 get { } //Length: 6
		[Address(RVA = "0x2BC3E00", Offset = "0x2BC3200", Length = "0x4D")]
		[Token(Token = "0x6000013")]
		 set { } //Length: 77
	}

	[Token(Token = "0x17000003")]
	public float roll
	{
		[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
		[Token(Token = "0x6000014")]
		 get { } //Length: 6
		[Address(RVA = "0x2BC3E50", Offset = "0x2BC3250", Length = "0x4D")]
		[Token(Token = "0x6000015")]
		 set { } //Length: 77
	}

	[Token(Token = "0x17000001")]
	public float yaw
	{
		[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
		[Token(Token = "0x6000010")]
		 get { } //Length: 6
		[Address(RVA = "0x2BC3EA0", Offset = "0x2BC32A0", Length = "0x4D")]
		[Token(Token = "0x6000011")]
		 set { } //Length: 77
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x6000026")]
	public LightAnchor() { }

	[Address(RVA = "0x2BC3C10", Offset = "0x2BC3010", Length = "0x1A8")]
	[Token(Token = "0x600001A")]
	public Vector3 get_anchorPosition() { }

	[Address(RVA = "0x2BC3BF0", Offset = "0x2BC2FF0", Length = "0x13")]
	[Token(Token = "0x600001D")]
	public Vector3 get_anchorPositionOffset() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x600001B")]
	public Transform get_anchorPositionOverride() { }

	[Address(RVA = "0x1D40680", Offset = "0x1D3FA80", Length = "0x6")]
	[Token(Token = "0x6000016")]
	public float get_distance() { }

	[Address(RVA = "0xEA4200", Offset = "0xEA3600", Length = "0x4")]
	[Token(Token = "0x6000018")]
	public UpDirection get_frameSpace() { }

	[Address(RVA = "0x1116940", Offset = "0x1115D40", Length = "0x6")]
	[Token(Token = "0x6000012")]
	public float get_pitch() { }

	[Address(RVA = "0x1D14EB0", Offset = "0x1D142B0", Length = "0x6")]
	[Token(Token = "0x6000014")]
	public float get_roll() { }

	[Address(RVA = "0x1D633E0", Offset = "0x1D627E0", Length = "0x6")]
	[Token(Token = "0x6000010")]
	public float get_yaw() { }

	[Address(RVA = "0x2BC1E60", Offset = "0x2BC1260", Length = "0xC21")]
	[Token(Token = "0x6000022")]
	private Axes GetWorldSpaceAxes(Camera camera, Vector3 anchor) { }

	[Address(RVA = "0x2BC2A90", Offset = "0x2BC1E90", Length = "0x45")]
	[Token(Token = "0x600001F")]
	public static float NormalizeAngleDegree(float angle) { }

	[Address(RVA = "0x2BC2AE0", Offset = "0x2BC1EE0", Length = "0xEC")]
	[Token(Token = "0x6000024")]
	private void OnDrawGizmosSelected() { }

	[Address(RVA = "0x2BC3DC0", Offset = "0x2BC31C0", Length = "0x10")]
	[Token(Token = "0x600001E")]
	public void set_anchorPositionOffset(Vector3 value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x600001C")]
	public void set_anchorPositionOverride(Transform value) { }

	[Address(RVA = "0x2BC3DD0", Offset = "0x2BC31D0", Length = "0x21")]
	[Token(Token = "0x6000017")]
	public void set_distance(float value) { }

	[Address(RVA = "0x5C4BB0", Offset = "0x5C3FB0", Length = "0x4")]
	[Token(Token = "0x6000019")]
	public void set_frameSpace(UpDirection value) { }

	[Address(RVA = "0x2BC3E00", Offset = "0x2BC3200", Length = "0x4D")]
	[Token(Token = "0x6000013")]
	public void set_pitch(float value) { }

	[Address(RVA = "0x2BC3E50", Offset = "0x2BC3250", Length = "0x4D")]
	[Token(Token = "0x6000015")]
	public void set_roll(float value) { }

	[Address(RVA = "0x2BC3EA0", Offset = "0x2BC32A0", Length = "0x4D")]
	[Token(Token = "0x6000011")]
	public void set_yaw(float value) { }

	[Address(RVA = "0x2BC2BD0", Offset = "0x2BC1FD0", Length = "0x7BB")]
	[Token(Token = "0x6000020")]
	public void SynchronizeOnTransform(Camera camera) { }

	[Address(RVA = "0x2BC3A10", Offset = "0x2BC2E10", Length = "0x1D6")]
	[Token(Token = "0x6000023")]
	private void Update() { }

	[Address(RVA = "0x2BC3480", Offset = "0x2BC2880", Length = "0x58C")]
	[Token(Token = "0x6000025")]
	private void UpdateTransform(Vector3 up, Vector3 right, Vector3 forward, Vector3 anchor) { }

	[Address(RVA = "0x2BC3390", Offset = "0x2BC2790", Length = "0xEE")]
	[Token(Token = "0x6000021")]
	public void UpdateTransform(Camera camera, Vector3 anchor) { }

}

