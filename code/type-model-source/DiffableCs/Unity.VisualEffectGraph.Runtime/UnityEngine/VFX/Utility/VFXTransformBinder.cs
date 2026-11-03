namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Transform Binder")]
[Token(Token = "0x2000060")]
[VFXBinder("Transform/Transform")]
internal class VFXTransformBinder : VFXSpaceableBinder
{
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001EA")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.Transform"})]
	protected ExposedProperty m_Property; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001EB")]
	public Transform Target; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001EC")]
	private ExposedProperty Position; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001ED")]
	private ExposedProperty Angles; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001EE")]
	private ExposedProperty Scale; //Field offset: 0x50

	[Token(Token = "0x17000038")]
	public string Property
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x60001BD")]
		 get { } //Length: 27
		[Address(RVA = "0x2F81780", Offset = "0x2F80B80", Length = "0x35")]
		[Token(Token = "0x60001BE")]
		 set { } //Length: 53
	}

	[Address(RVA = "0x2F81720", Offset = "0x2F80B20", Length = "0x52")]
	[Token(Token = "0x60001C5")]
	public VFXTransformBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x60001BD")]
	public string get_Property() { }

	[Address(RVA = "0x2F81360", Offset = "0x2F80760", Length = "0xD6")]
	[Token(Token = "0x60001C2")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F81440", Offset = "0x2F80840", Length = "0x1F")]
	[Token(Token = "0x60001BF")]
	protected virtual void OnEnable() { }

	[Address(RVA = "0x2F81460", Offset = "0x2F80860", Length = "0x7")]
	[Token(Token = "0x60001C0")]
	private void OnValidate() { }

	[Address(RVA = "0x2F81780", Offset = "0x2F80B80", Length = "0x35")]
	[Token(Token = "0x60001BE")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F81470", Offset = "0x2F80870", Length = "0xB9")]
	[Token(Token = "0x60001C4")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F81530", Offset = "0x2F80930", Length = "0x106")]
	[Token(Token = "0x60001C3")]
	public virtual void UpdateBinding(VisualEffect component) { }

	[Address(RVA = "0x2F81640", Offset = "0x2F80A40", Length = "0xDB")]
	[Token(Token = "0x60001C1")]
	private void UpdateSubProperties() { }

}

