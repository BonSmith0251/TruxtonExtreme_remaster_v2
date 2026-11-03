namespace System.ComponentModel;

[Token(Token = "0x2000177")]
internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor
{
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400062C")]
	private readonly ReflectPropertyDescriptor _extenderInfo; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400062D")]
	private readonly IExtenderProvider _provider; //Field offset: 0x90

	[Token(Token = "0x170001B5")]
	public virtual Type ComponentType
	{
		[Address(RVA = "0x2663090", Offset = "0x2662490", Length = "0x2D")]
		[Token(Token = "0x6000919")]
		 get { } //Length: 45
	}

	[Token(Token = "0x170001B8")]
	public virtual string DisplayName
	{
		[Address(RVA = "0x26630C0", Offset = "0x26624C0", Length = "0x25B")]
		[Token(Token = "0x600091C")]
		 get { } //Length: 603
	}

	[Token(Token = "0x170001B6")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x2663320", Offset = "0x2662720", Length = "0xE7")]
		[Token(Token = "0x600091A")]
		 get { } //Length: 231
	}

	[Token(Token = "0x170001B7")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x2663410", Offset = "0x2662810", Length = "0x2D")]
		[Token(Token = "0x600091B")]
		 get { } //Length: 45
	}

	[Address(RVA = "0x2662DF0", Offset = "0x26621F0", Length = "0x297")]
	[Token(Token = "0x6000917")]
	public ExtendedPropertyDescriptor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	[Address(RVA = "0x2662CE0", Offset = "0x26620E0", Length = "0x2E")]
	[Token(Token = "0x6000918")]
	public virtual bool CanResetValue(object comp) { }

	[Address(RVA = "0x2663090", Offset = "0x2662490", Length = "0x2D")]
	[Token(Token = "0x6000919")]
	public virtual Type get_ComponentType() { }

	[Address(RVA = "0x26630C0", Offset = "0x26624C0", Length = "0x25B")]
	[Token(Token = "0x600091C")]
	public virtual string get_DisplayName() { }

	[Address(RVA = "0x2663320", Offset = "0x2662720", Length = "0xE7")]
	[Token(Token = "0x600091A")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x2663410", Offset = "0x2662810", Length = "0x2D")]
	[Token(Token = "0x600091B")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x2662D10", Offset = "0x2662110", Length = "0x2E")]
	[Token(Token = "0x600091D")]
	public virtual object GetValue(object comp) { }

	[Address(RVA = "0x2662D40", Offset = "0x2662140", Length = "0x38")]
	[Token(Token = "0x600091E")]
	public virtual void ResetValue(object comp) { }

	[Address(RVA = "0x2662D80", Offset = "0x2662180", Length = "0x3D")]
	[Token(Token = "0x600091F")]
	public virtual void SetValue(object component, object value) { }

	[Address(RVA = "0x2662DC0", Offset = "0x26621C0", Length = "0x2E")]
	[Token(Token = "0x6000920")]
	public virtual bool ShouldSerializeValue(object comp) { }

}

