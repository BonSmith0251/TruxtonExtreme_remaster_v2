namespace UnityEngine.VFX.Utility;

[AddComponentMenu("VFX/Property Binders/Input Mouse Binder")]
[Token(Token = "0x2000052")]
[VFXBinder("Input/Mouse")]
internal class VFXInputMouseBinder : VFXBinderBase
{
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("m_MouseLeftClickParameter")]
	[SerializeField]
	[Token(Token = "0x40001A1")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_MouseLeftClickProperty; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("m_MouseRightClickParameter")]
	[SerializeField]
	[Token(Token = "0x40001A2")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"System.Boolean"})]
	protected ExposedProperty m_MouseRightClickProperty; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("m_PositionParameter")]
	[SerializeField]
	[Token(Token = "0x40001A3")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEditor.VFX.Position", "UnityEngine.Vector3"})]
	protected ExposedProperty m_PositionProperty; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("m_VelocityParameter")]
	[SerializeField]
	[Token(Token = "0x40001A4")]
	[VFXPropertyBinding(new IL2CPP_TYPE_STRING[] {"UnityEngine.Vector3"})]
	protected ExposedProperty m_VelocityProperty; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40001A5")]
	public Camera Target; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40001A6")]
	public float Distance; //Field offset: 0x50
	[FieldOffset(Offset = "0x54")]
	[Token(Token = "0x40001A7")]
	public bool SetVelocity; //Field offset: 0x54
	[FieldOffset(Offset = "0x55")]
	[Token(Token = "0x40001A8")]
	public bool CheckLeftClick; //Field offset: 0x55
	[FieldOffset(Offset = "0x56")]
	[Token(Token = "0x40001A9")]
	public bool CheckRightClick; //Field offset: 0x56
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40001AA")]
	private Vector3 m_PreviousPosition; //Field offset: 0x58

	[Token(Token = "0x17000027")]
	public string MouseLeftClickProperty
	{
		[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
		[Token(Token = "0x6000155")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
		[Token(Token = "0x6000156")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000028")]
	public string MouseRightClickProperty
	{
		[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
		[Token(Token = "0x6000157")]
		 get { } //Length: 27
		[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
		[Token(Token = "0x6000158")]
		 set { } //Length: 128
	}

	[Token(Token = "0x17000029")]
	public string PositionProperty
	{
		[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
		[Token(Token = "0x6000159")]
		 get { } //Length: 27
		[Address(RVA = "0x2F75BD0", Offset = "0x2F74FD0", Length = "0x80")]
		[Token(Token = "0x600015A")]
		 set { } //Length: 128
	}

	[Token(Token = "0x1700002A")]
	public string VelocityProperty
	{
		[Address(RVA = "0x2F75BB0", Offset = "0x2F74FB0", Length = "0x1B")]
		[Token(Token = "0x600015B")]
		 get { } //Length: 27
		[Address(RVA = "0x2F75C50", Offset = "0x2F75050", Length = "0x80")]
		[Token(Token = "0x600015C")]
		 set { } //Length: 128
	}

	[Address(RVA = "0x2F75980", Offset = "0x2F74D80", Length = "0x202")]
	[Token(Token = "0x6000163")]
	public VFXInputMouseBinder() { }

	[Address(RVA = "0x1C9E670", Offset = "0x1C9DA70", Length = "0x1B")]
	[Token(Token = "0x6000155")]
	public string get_MouseLeftClickProperty() { }

	[Address(RVA = "0x2525420", Offset = "0x2524820", Length = "0x1B")]
	[Token(Token = "0x6000157")]
	public string get_MouseRightClickProperty() { }

	[Address(RVA = "0x2F75B90", Offset = "0x2F74F90", Length = "0x1B")]
	[Token(Token = "0x6000159")]
	public string get_PositionProperty() { }

	[Address(RVA = "0x2F75BB0", Offset = "0x2F74FB0", Length = "0x1B")]
	[Token(Token = "0x600015B")]
	public string get_VelocityProperty() { }

	[Address(RVA = "0x2F750E0", Offset = "0x2F744E0", Length = "0x73")]
	[Token(Token = "0x6000161")]
	private Vector2 GetMousePosition() { }

	[Address(RVA = "0x2F75160", Offset = "0x2F74560", Length = "0x87")]
	[Token(Token = "0x6000160")]
	private bool IsLeftClickPressed() { }

	[Address(RVA = "0x2F751F0", Offset = "0x2F745F0", Length = "0x87")]
	[Token(Token = "0x600015F")]
	private bool IsRightClickPressed() { }

	[Address(RVA = "0x2F75280", Offset = "0x2F74680", Length = "0x1CA")]
	[Token(Token = "0x600015D")]
	public virtual bool IsValid(VisualEffect component) { }

	[Address(RVA = "0x2F72F60", Offset = "0x2F72360", Length = "0x80")]
	[Token(Token = "0x6000156")]
	public void set_MouseLeftClickProperty(string value) { }

	[Address(RVA = "0x2F72FE0", Offset = "0x2F723E0", Length = "0x80")]
	[Token(Token = "0x6000158")]
	public void set_MouseRightClickProperty(string value) { }

	[Address(RVA = "0x2F75BD0", Offset = "0x2F74FD0", Length = "0x80")]
	[Token(Token = "0x600015A")]
	public void set_PositionProperty(string value) { }

	[Address(RVA = "0x2F75C50", Offset = "0x2F75050", Length = "0x80")]
	[Token(Token = "0x600015C")]
	public void set_VelocityProperty(string value) { }

	[Address(RVA = "0x2F75450", Offset = "0x2F74850", Length = "0xB9")]
	[Token(Token = "0x6000162")]
	public virtual string ToString() { }

	[Address(RVA = "0x2F75510", Offset = "0x2F74910", Length = "0x46D")]
	[Token(Token = "0x600015E")]
	public virtual void UpdateBinding(VisualEffect component) { }

}

