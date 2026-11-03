namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Sphere Collider Binder")]
[Token(Token = "0x200005E")]
[VFXBinder("Collider/Sphere")]
internal class VFXSphereBinder : VFXSpaceableBinder
{
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Parameter")]
	[SerializeField]
	[Token(Token = "0x40001DF")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.Sphere", "UnityEditor.VFX.TSphere"})]
	protected ExposedProperty m_Property; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001E0")]
	public SphereCollider Target; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001E1")]
	private ExposedProperty m_Old_Center; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001E2")]
	private ExposedProperty m_New_Center; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001E3")]
	private ExposedProperty m_Radius; //Field offset: 0x50

	[Token(Token = "0x17000036")]
	public string Property
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x60001AA")]
		 get { } //Length: 27
		[Address(RVA = "0x2F80DF0", Offset = "0x2F801F0", Length = "0x35")]
		[Token(Token = "0x60001AB")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x2F80D90", Offset = "0x2F80190", Length = "0x52")]
	[Token(Token = "0x60001B3")]
	public VFXSphereBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x60001AA")]
	public string get_Property() { }

	[Address(RVA = "0x2F807A0", Offset = "0x2F7FBA0", Length = "0x15")]
	[Token(Token = "0x60001B1")]
	public float GetSphereColliderScale(Vector3 scale) { }

	[Address(RVA = "0x2F807C0", Offset = "0x2F7FBC0", Length = "0xD6")]
	[Token(Token = "0x60001AF")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F808A0", Offset = "0x2F7FCA0", Length = "0x1F")]
	[Token(Token = "0x60001AC")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F808C0", Offset = "0x2F7FCC0", Length = "0x7")]
	[Token(Token = "0x60001AD")]
	private void OnValidate() { }

	[Address(RVA = "0x2F80DF0", Offset = "0x2F801F0", Length = "0x35")]
	[Token(Token = "0x60001AB")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F808D0", Offset = "0x2F7FCD0", Length = "0xB9")]
	[Token(Token = "0x60001B2")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F80990", Offset = "0x2F7FD90", Length = "0x312")]
	[Token(Token = "0x60001B0")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F80CB0", Offset = "0x2F800B0", Length = "0xDB")]
	[Token(Token = "0x60001AE")]
	private void UpdateSubProperties() { }

}

