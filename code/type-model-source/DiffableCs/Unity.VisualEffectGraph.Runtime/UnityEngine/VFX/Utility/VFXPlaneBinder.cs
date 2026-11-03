namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Plane Binder")]
[Token(Token = "0x2000057")]
[VFXBinder("Utility/Plane")]
internal class VFXPlaneBinder : VFXSpaceableBinder
{
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_Parameter")]
	[SerializeField]
	[Token(Token = "0x40001C3")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.Plane"})]
	protected ExposedProperty m_Property; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001C4")]
	public Transform Target; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001C5")]
	private ExposedProperty Position; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001C6")]
	private ExposedProperty Normal; //Field offset: 0x48

	[Token(Token = "0x17000031")]
	public string Property
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x6000183")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7E890", Offset = "0x2F7DC90", Length = "0x35")]
		[Token(Token = "0x6000184")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x2F7E830", Offset = "0x2F7DC30", Length = "0x52")]
	[Token(Token = "0x600018B")]
	public VFXPlaneBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x6000183")]
	public string get_Property() { }

	[Address(RVA = "0x2F7E4F0", Offset = "0x2F7D8F0", Length = "0xBA")]
	[Token(Token = "0x6000188")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F7E5B0", Offset = "0x2F7D9B0", Length = "0x1F")]
	[Token(Token = "0x6000185")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F7E5D0", Offset = "0x2F7D9D0", Length = "0x7")]
	[Token(Token = "0x6000186")]
	private void OnValidate() { }

	[Address(RVA = "0x2F7E890", Offset = "0x2F7DC90", Length = "0x35")]
	[Token(Token = "0x6000184")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F7E5E0", Offset = "0x2F7D9E0", Length = "0xB9")]
	[Token(Token = "0x600018A")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F7E6A0", Offset = "0x2F7DAA0", Length = "0xED")]
	[Token(Token = "0x6000189")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F7E790", Offset = "0x2F7DB90", Length = "0x9F")]
	[Token(Token = "0x6000187")]
	private void UpdateSubProperties() { }

}

