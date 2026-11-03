namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Raycast Binder")]
[Token(Token = "0x200005A")]
[VFXBinder("Physics/Raycast")]
internal class VFXRaycastBinder : VFXBinderBase
{
	[Token(Token = "0x200005B")]
	internal enum Space : int
	{
		Local = 0,
		World = 1,
	}

	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001CC")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.Position"})]
	protected ExposedProperty m_TargetPosition; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001CD")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.DirectionType"})]
	protected ExposedProperty m_TargetNormal; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001CE")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_TargetHit; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001CF")]
	protected ExposedProperty m_TargetPosition_position; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001D0")]
	protected ExposedProperty m_TargetNormal_direction; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001D1")]
	public GameObject RaycastSource; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001D2")]
	public Vector3 RaycastDirection; //Field offset: 0x58
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x40001D3")]
	public Space RaycastDirectionSpace; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40001D4")]
	public LayerMask Layers; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x40001D5")]
	public float MaxDistance; //Field offset: 0x6C
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40001D6")]
	private RaycastHit m_HitInfo; //Field offset: 0x70

	[Token(Token = "0x17000035")]
	public string TargetHit
	{
		[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
		[Token(Token = "0x600019B")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7DDA0", Offset = "0x2F7D1A0", Length = "0x2B")]
		[Token(Token = "0x600019C")]
		 set { } //Length: 43
	}

	[Token(Token = "0x17000034")]
	public string TargetNormal
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x6000199")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7FBD0", Offset = "0x2F7EFD0", Length = "0x35")]
		[Token(Token = "0x600019A")]
		 set { } //Length: 53
	}

	[Token(Token = "0x17000033")]
	public string TargetPosition
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x6000197")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7FC10", Offset = "0x2F7F010", Length = "0x35")]
		[Token(Token = "0x6000198")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x2F7FAD0", Offset = "0x2F7EED0", Length = "0xF6")]
	[Token(Token = "0x60001A3")]
	public VFXRaycastBinder() { }

	[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
	[Token(Token = "0x600019B")]
	public string get_TargetHit() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x6000199")]
	public string get_TargetNormal() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x6000197")]
	public string get_TargetPosition() { }

	[Address(RVA = "0x2F7F4A0", Offset = "0x2F7E8A0", Length = "0xCB")]
	[Token(Token = "0x60001A0")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7F570", Offset = "0x2F7E970", Length = "0x1F")]
	[Token(Token = "0x600019D")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F7F590", Offset = "0x2F7E990", Length = "0x7")]
	[Token(Token = "0x600019E")]
	private void OnValidate() { }

	[Address(RVA = "0x2F7DDA0", Offset = "0x2F7D1A0", Length = "0x2B")]
	[Token(Token = "0x600019C")]
	public void set_TargetHit(string value) { }

	[Address(RVA = "0x2F7FBD0", Offset = "0x2F7EFD0", Length = "0x35")]
	[Token(Token = "0x600019A")]
	public void set_TargetNormal(string value) { }

	[Address(RVA = "0x2F7FC10", Offset = "0x2F7F010", Length = "0x35")]
	[Token(Token = "0x6000198")]
	public void set_TargetPosition(string value) { }

	[Address(RVA = "0x2F7F5A0", Offset = "0x2F7E9A0", Length = "0x1A3")]
	[Token(Token = "0x60001A2")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F7F750", Offset = "0x2F7EB50", Length = "0x2D7")]
	[Token(Token = "0x60001A1")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F7FA30", Offset = "0x2F7EE30", Length = "0x9F")]
	[Token(Token = "0x600019F")]
	private void UpdateSubProperties() { }

}

