namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Hierarchy to Attribute Map Binder")]
[Token(Token = "0x200004C")]
[VFXBinder("Point Cache/Hierarchy to Attribute Map")]
internal class VFXHierarchyAttributeMapBinder : VFXBinderBase
{
	[Token(Token = "0x200004E")]
	private struct Bone
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400018F")]
		public Transform source; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000190")]
		public float sourceRadius; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000191")]
		public Transform target; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000192")]
		public float targetRadius; //Field offset: 0x18

	}

	[Token(Token = "0x200004D")]
	internal enum RadiusMode : int
	{
		Fixed = 0,
		Interpolate = 1,
	}

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000180")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.UInt32"})]
	protected ExposedProperty m_BoneCount; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000181")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Texture2D"})]
	protected ExposedProperty m_PositionMap; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000182")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Texture2D"})]
	protected ExposedProperty m_TargetPositionMap; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Token(Token = "0x4000183")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Texture2D"})]
	protected ExposedProperty m_RadiusPositionMap; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000184")]
	public Transform HierarchyRoot; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000185")]
	public float DefaultRadius; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x4000186")]
	public uint MaximumDepth; //Field offset: 0x54
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000187")]
	public RadiusMode Radius; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000188")]
	private Texture2D position; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000189")]
	private Texture2D targetPosition; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400018A")]
	private Texture2D radius; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400018B")]
	private List<Bone> bones; //Field offset: 0x78

	[Address(RVA = "0x2F74650", Offset = "0x2F73A50", Length = "0x205")]
	[Token(Token = "0x600013C")]
	public VFXHierarchyAttributeMapBinder() { }

	[Address(RVA = "0x2F735B0", Offset = "0x2F729B0", Length = "0x469")]
	[Token(Token = "0x6000137")]
	private List<Bone> ChildrenOf(Transform source, uint depth) { }

	[Address(RVA = "0x2F73A20", Offset = "0x2F72E20", Length = "0x1F0")]
	[Token(Token = "0x6000139")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F73C20", Offset = "0x2F73020", Length = "0x1F")]
	[Token(Token = "0x6000134")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F73C40", Offset = "0x2F73040", Length = "0x7")]
	[Token(Token = "0x6000135")]
	private void OnValidate() { }

	[Address(RVA = "0x2F73C50", Offset = "0x2F73050", Length = "0xAC")]
	[Token(Token = "0x600013B")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F73D00", Offset = "0x2F73100", Length = "0x2B1")]
	[Token(Token = "0x600013A")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F73FC0", Offset = "0x2F733C0", Length = "0x51B")]
	[Token(Token = "0x6000138")]
	private void UpdateData() { }

	[Address(RVA = "0x2F744E0", Offset = "0x2F738E0", Length = "0x163")]
	[Token(Token = "0x6000136")]
	private void UpdateHierarchy() { }

}

