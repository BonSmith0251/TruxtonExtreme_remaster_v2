namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Velocity Binder")]
[Token(Token = "0x2000064")]
[VFXBinder("Transform/Velocity")]
internal class VFXVelocityBinder : VFXSpaceableBinder
{
	[Token(Token = "0x40001F7")]
	private static readonly float invalidPreviousTime; //Field offset: 0x0
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001F5")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Vector3"})]
	public ExposedProperty m_Property; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40001F6")]
	public Transform Target; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001F8")]
	private float m_PreviousTime; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x40001F9")]
	private Vector3 m_PreviousPosition; //Field offset: 0x44

	[Token(Token = "0x1700003C")]
	public string Property
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x60001D8")]
		 get { } //Length: 27
		[Address(RVA = "0x2F7EB70", Offset = "0x2F7DF70", Length = "0x2B")]
		[Token(Token = "0x60001D9")]
		 set { } //Length: 43
	}

	[Address(RVA = "0x2F821F0", Offset = "0x2F815F0", Length = "0x39")]
	[Token(Token = "0x60001DF")]
	private static VFXVelocityBinder() { }

	[Address(RVA = "0x2F82230", Offset = "0x2F81630", Length = "0xC2")]
	[Token(Token = "0x60001DE")]
	public VFXVelocityBinder() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x60001D8")]
	public string get_Property() { }

	[Address(RVA = "0x2F81E10", Offset = "0x2F81210", Length = "0x9C")]
	[Token(Token = "0x60001DA")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F81EB0", Offset = "0x2F812B0", Length = "0x56")]
	[Token(Token = "0x60001DB")]
	public virtual void Reset() { }

	[Address(RVA = "0x2F7EB70", Offset = "0x2F7DF70", Length = "0x2B")]
	[Token(Token = "0x60001D9")]
	public void set_Property(string value) { }

	[Address(RVA = "0x2F81F10", Offset = "0x2F81310", Length = "0xB9")]
	[Token(Token = "0x60001DD")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F81FD0", Offset = "0x2F813D0", Length = "0x21E")]
	[Token(Token = "0x60001DC")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

