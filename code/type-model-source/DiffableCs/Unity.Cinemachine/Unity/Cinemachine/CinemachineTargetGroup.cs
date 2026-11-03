namespace Unity.Cinemachine;

[AddComponentMenu("Cinemachine/Helpers/Cinemachine Target Group")]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@3.1/manual/CinemachineTargetGroup.html")]
[SaveDuringPlay]
[Token(Token = "0x2000053")]
public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup
{
	[Token(Token = "0x2000055")]
	internal enum PositionModes : int
	{
		GroupCenter = 0,
		GroupAverage = 1,
	}

	[Token(Token = "0x2000056")]
	internal enum RotationModes : int
	{
		Manual = 0,
		GroupAverage = 1,
	}

	[Token(Token = "0x2000054")]
	internal class Target
	{
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("target")]
		[Token(Token = "0x4000150")]
		[Tooltip("The target object.  This object's position and rotation will contribute to the group's average position and rotation, in accordance with its weight")]
		public Transform Object; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("weight")]
		[Token(Token = "0x4000151")]
		[Tooltip("How much weight to give the target when averaging.  Cannot be negative")]
		public float Weight; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("radius")]
		[Token(Token = "0x4000152")]
		[Tooltip("The radius of the target, used for calculating the bounding box.  Cannot be negative")]
		public float Radius; //Field offset: 0x1C

		[Address(RVA = "0x28335E0", Offset = "0x28329E0", Length = "0x15")]
		[Token(Token = "0x600017E")]
		public Target() { }

	}

	[Token(Token = "0x2000057")]
	internal enum UpdateMethods : int
	{
		Update = 0,
		FixedUpdate = 1,
		LateUpdate = 2,
	}

	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("m_PositionMode")]
	[Token(Token = "0x4000143")]
	[Tooltip("How the group's position is calculated.  Select GroupCenter for the center of the bounding box, and GroupAverage for a weighted average of the positions of the members.")]
	public PositionModes PositionMode; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("m_RotationMode")]
	[Token(Token = "0x4000144")]
	[Tooltip("How the group's rotation is calculated.  Select Manual to use the value in the group's transform, and GroupAverage for a weighted average of the orientations of the members.")]
	public RotationModes RotationMode; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_UpdateMethod")]
	[Token(Token = "0x4000145")]
	[Tooltip("When to update the group's transform based on the position of the group members")]
	public UpdateMethods UpdateMethod; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[NoSaveDuringPlay]
	[Token(Token = "0x4000146")]
	[Tooltip("The target objects, together with their weights and radii, that will contribute to the group's average position, orientation, and size.")]
	public List<Target> Targets; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000147")]
	private float m_MaxWeight; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000148")]
	private float m_WeightSum; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000149")]
	private Vector3 m_AveragePos; //Field offset: 0x40
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400014A")]
	private Bounds m_BoundingBox; //Field offset: 0x4C
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x400014B")]
	private BoundingSphere m_BoundingSphere; //Field offset: 0x64
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x400014C")]
	private int m_LastUpdateFrame; //Field offset: 0x74
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400014D")]
	private List<Int32> m_ValidMembers; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400014E")]
	private List<Boolean> m_MemberValidity; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[FormerlySerializedAs("m_Targets")]
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	[Token(Token = "0x400014F")]
	private Target[] m_LegacyTargets; //Field offset: 0x88

	[Token(Token = "0x17000033")]
	public private override Bounds BoundingBox
	{
		[Address(RVA = "0x282F6B0", Offset = "0x282EAB0", Length = "0xBB")]
		[Token(Token = "0x6000166")]
		 get { } //Length: 187
		[Address(RVA = "0x282FA00", Offset = "0x282EE00", Length = "0x12")]
		[Token(Token = "0x6000167")]
		private set { } //Length: 18
	}

	[Token(Token = "0x17000036")]
	private bool CachedCountIsValid
	{
		[Address(RVA = "0x282F770", Offset = "0x282EB70", Length = "0x5A")]
		[Token(Token = "0x6000170")]
		private get { } //Length: 90
	}

	[Token(Token = "0x17000035")]
	public override bool IsEmpty
	{
		[Address(RVA = "0x282F7D0", Offset = "0x282EBD0", Length = "0xBB")]
		[Token(Token = "0x600016A")]
		 get { } //Length: 187
	}

	[Token(Token = "0x17000032")]
	public override bool IsValid
	{
		[Address(RVA = "0x282F890", Offset = "0x282EC90", Length = "0x4C")]
		[Token(Token = "0x6000165")]
		 get { } //Length: 76
	}

	[Obsolete("m_Targets is obsolete.  Please use Targets instead")]
	[Token(Token = "0x17000030")]
	public Target[] m_Targets
	{
		[Address(RVA = "0x282F9B0", Offset = "0x282EDB0", Length = "0x44")]
		[Token(Token = "0x6000162")]
		 get { } //Length: 68
		[Address(RVA = "0x282FA30", Offset = "0x282EE30", Length = "0x89")]
		[Token(Token = "0x6000163")]
		 set { } //Length: 137
	}

	[Token(Token = "0x17000034")]
	public private override BoundingSphere Sphere
	{
		[Address(RVA = "0x282F8E0", Offset = "0x282ECE0", Length = "0xB1")]
		[Token(Token = "0x6000168")]
		 get { } //Length: 177
		[Address(RVA = "0x282FA20", Offset = "0x282EE20", Length = "0x8")]
		[Token(Token = "0x6000169")]
		private set { } //Length: 8
	}

	[Token(Token = "0x17000031")]
	public override Transform Transform
	{
		[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
		[Token(Token = "0x6000164")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x282F590", Offset = "0x282E990", Length = "0x117")]
	[Token(Token = "0x600017D")]
	public CinemachineTargetGroup() { }

	[Address(RVA = "0x282C340", Offset = "0x282B740", Length = "0x114")]
	[Token(Token = "0x600016B")]
	public void AddMember(Transform t, float weight, float radius) { }

	[Address(RVA = "0x282C460", Offset = "0x282B860", Length = "0x78")]
	[Token(Token = "0x6000161")]
	private void Awake() { }

	[Address(RVA = "0x282C4E0", Offset = "0x282B8E0", Length = "0x47E")]
	[Token(Token = "0x6000178")]
	private Quaternion CalculateAverageOrientation() { }

	[Address(RVA = "0x282C960", Offset = "0x282BD60", Length = "0x21E")]
	[Token(Token = "0x6000175")]
	private Vector3 CalculateAveragePosition() { }

	[Address(RVA = "0x282CB80", Offset = "0x282BF80", Length = "0x4B3")]
	[Token(Token = "0x6000176")]
	private Bounds CalculateBoundingBox() { }

	[Address(RVA = "0x282D040", Offset = "0x282C440", Length = "0x3BB")]
	[Token(Token = "0x6000177")]
	private BoundingSphere CalculateBoundingSphere() { }

	[Address(RVA = "0x282D400", Offset = "0x282C800", Length = "0x1AE")]
	[Token(Token = "0x6000173")]
	public void DoUpdate() { }

	[Address(RVA = "0x282D5B0", Offset = "0x282C9B0", Length = "0xDC")]
	[Token(Token = "0x600016D")]
	public int FindMember(Transform t) { }

	[Address(RVA = "0x282D690", Offset = "0x282CA90", Length = "0xE")]
	[Token(Token = "0x6000179")]
	private void FixedUpdate() { }

	[Address(RVA = "0x282F6B0", Offset = "0x282EAB0", Length = "0xBB")]
	[Token(Token = "0x6000166")]
	public override Bounds get_BoundingBox() { }

	[Address(RVA = "0x282F770", Offset = "0x282EB70", Length = "0x5A")]
	[Token(Token = "0x6000170")]
	private bool get_CachedCountIsValid() { }

	[Address(RVA = "0x282F7D0", Offset = "0x282EBD0", Length = "0xBB")]
	[Token(Token = "0x600016A")]
	public override bool get_IsEmpty() { }

	[Address(RVA = "0x282F890", Offset = "0x282EC90", Length = "0x4C")]
	[Token(Token = "0x6000165")]
	public override bool get_IsValid() { }

	[Address(RVA = "0x282F9B0", Offset = "0x282EDB0", Length = "0x44")]
	[Token(Token = "0x6000162")]
	public Target[] get_m_Targets() { }

	[Address(RVA = "0x282F8E0", Offset = "0x282ECE0", Length = "0xB1")]
	[Token(Token = "0x6000168")]
	public override BoundingSphere get_Sphere() { }

	[Address(RVA = "0x282F9A0", Offset = "0x282EDA0", Length = "0x7")]
	[Token(Token = "0x6000164")]
	public override Transform get_Transform() { }

	[Address(RVA = "0x282D6A0", Offset = "0x282CAA0", Length = "0xCBE")]
	[Token(Token = "0x600017C")]
	public override void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange) { }

	[Address(RVA = "0x282E360", Offset = "0x282D760", Length = "0x752")]
	[Token(Token = "0x600016F")]
	public override Bounds GetViewSpaceBoundingBox(Matrix4x4 observer, bool includeBehind) { }

	[Address(RVA = "0x282EAC0", Offset = "0x282DEC0", Length = "0x1CE")]
	[Token(Token = "0x600016E")]
	public BoundingSphere GetWeightedBoundsForMember(int index) { }

	[Address(RVA = "0x282EC90", Offset = "0x282E090", Length = "0xA0")]
	[Token(Token = "0x6000171")]
	private bool IndexIsValid(int index) { }

	[Address(RVA = "0x282ED40", Offset = "0x282E140", Length = "0xE")]
	[Token(Token = "0x600017B")]
	private void LateUpdate() { }

	[Address(RVA = "0x282ED50", Offset = "0x282E150", Length = "0x131")]
	[Token(Token = "0x600015F")]
	private void OnValidate() { }

	[Address(RVA = "0x282EE90", Offset = "0x282E290", Length = "0x10C")]
	[Token(Token = "0x600016C")]
	public void RemoveMember(Transform t) { }

	[Address(RVA = "0x282EFA0", Offset = "0x282E3A0", Length = "0x66")]
	[Token(Token = "0x6000160")]
	private void Reset() { }

	[Address(RVA = "0x282FA00", Offset = "0x282EE00", Length = "0x12")]
	[Token(Token = "0x6000167")]
	private void set_BoundingBox(Bounds value) { }

	[Address(RVA = "0x282FA30", Offset = "0x282EE30", Length = "0x89")]
	[Token(Token = "0x6000163")]
	public void set_m_Targets(Target[] value) { }

	[Address(RVA = "0x282FA20", Offset = "0x282EE20", Length = "0x8")]
	[Token(Token = "0x6000169")]
	private void set_Sphere(BoundingSphere value) { }

	[Address(RVA = "0x282F3B0", Offset = "0x282E7B0", Length = "0x60")]
	[Token(Token = "0x600017A")]
	private void Update() { }

	[Address(RVA = "0x282F010", Offset = "0x282E410", Length = "0x39C")]
	[Token(Token = "0x6000174")]
	private void UpdateMemberValidity() { }

	[Address(RVA = "0x282F410", Offset = "0x282E810", Length = "0x170")]
	[Token(Token = "0x6000172")]
	private static BoundingSphere WeightedMemberBoundsForValidMember(Target t, Vector3 avgPos, float maxWeight) { }

}

