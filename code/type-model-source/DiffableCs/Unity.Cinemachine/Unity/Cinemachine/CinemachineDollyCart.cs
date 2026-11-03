namespace Unity.Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExecuteAlways]
[Obsolete("CinemachineDollyCart has been deprecated. Use CinemachineSplineCart instead.")]
[Token(Token = "0x200010B")]
public class CinemachineDollyCart : MonoBehaviour
{
	[Token(Token = "0x200010C")]
	internal enum UpdateMethod : int
	{
		Update = 0,
		FixedUpdate = 1,
		LateUpdate = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000420")]
	[Tooltip("The path to follow")]
	public CinemachinePathBase m_Path; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000421")]
	[Tooltip("When to move the cart, if Velocity is non-zero")]
	public UpdateMethod m_UpdateMethod; //Field offset: 0x28
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4000422")]
	[Tooltip("How to interpret the Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
	public PositionUnits m_PositionUnits; //Field offset: 0x2C
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Velocity")]
	[Token(Token = "0x4000423")]
	[Tooltip("Move the cart with this speed along the path.  The value is interpreted according to the Position Units setting.")]
	public float m_Speed; //Field offset: 0x30
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("m_CurrentDistance")]
	[Token(Token = "0x4000424")]
	[Tooltip("The position along the path at which the cart will be placed.  This can be animated directly or, if the velocity is non-zero, will be updated automatically.  The value is interpreted according to the Position Units setting.")]
	public float m_Position; //Field offset: 0x34

	[Address(RVA = "0x285A500", Offset = "0x2859900", Length = "0xE")]
	[Token(Token = "0x6000518")]
	public CinemachineDollyCart() { }

	[Address(RVA = "0x285A0E0", Offset = "0x28594E0", Length = "0x50")]
	[Token(Token = "0x6000513")]
	private void FixedUpdate() { }

	[Address(RVA = "0x285A130", Offset = "0x2859530", Length = "0xA6")]
	[Token(Token = "0x6000515")]
	private void LateUpdate() { }

	[Address(RVA = "0x285A1E0", Offset = "0x28595E0", Length = "0x14F")]
	[Token(Token = "0x6000516")]
	private void SetCartPosition(float distanceAlongPath) { }

	[Address(RVA = "0x285A330", Offset = "0x2859730", Length = "0x91")]
	[Token(Token = "0x6000514")]
	private void Update() { }

	[Address(RVA = "0x285A3D0", Offset = "0x28597D0", Length = "0x12F")]
	[Token(Token = "0x6000517")]
	internal void UpgradeToCm3(CinemachineSplineCart c) { }

}

