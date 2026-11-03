namespace System.ComponentModel;

[Token(Token = "0x200018B")]
public abstract class PropertyDescriptor : MemberDescriptor
{
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400064C")]
	private TypeConverter _converter; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400064D")]
	private Hashtable _valueChangedHandlers; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400064E")]
	private Object[] _editors; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400064F")]
	private Type[] _editorTypes; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000650")]
	private int _editorCount; //Field offset: 0x80

	[Token(Token = "0x170001D2")]
	public abstract Type ComponentType
	{
		[Token(Token = "0x600098D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001D3")]
	public override TypeConverter Converter
	{
		[Address(RVA = "0x26699D0", Offset = "0x2668DD0", Length = "0x2B1")]
		[Token(Token = "0x600098E")]
		 get { } //Length: 689
	}

	[Token(Token = "0x170001D4")]
	public abstract bool IsReadOnly
	{
		[Token(Token = "0x600098F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170001D5")]
	public abstract Type PropertyType
	{
		[Token(Token = "0x6000990")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2662C70", Offset = "0x2662070", Length = "0x8")]
	[Token(Token = "0x600098B")]
	protected PropertyDescriptor(string name, Attribute[] attrs) { }

	[Address(RVA = "0x26699C0", Offset = "0x2668DC0", Length = "0x8")]
	[Token(Token = "0x600098C")]
	protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs) { }

	[Token(Token = "0x6000991")]
	public abstract bool CanResetValue(object component) { }

	[Address(RVA = "0x26690F0", Offset = "0x26684F0", Length = "0x20D")]
	[Token(Token = "0x6000993")]
	protected object CreateInstance(Type type) { }

	[Address(RVA = "0x2669300", Offset = "0x2668700", Length = "0x17D")]
	[Token(Token = "0x6000992")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2669480", Offset = "0x2668880", Length = "0x67")]
	[Token(Token = "0x6000994")]
	protected virtual void FillAttributes(IList attributeList) { }

	[Token(Token = "0x600098D")]
	public abstract Type get_ComponentType() { }

	[Address(RVA = "0x26699D0", Offset = "0x2668DD0", Length = "0x2B1")]
	[Token(Token = "0x600098E")]
	public override TypeConverter get_Converter() { }

	[Token(Token = "0x600098F")]
	public abstract bool get_IsReadOnly() { }

	[Token(Token = "0x6000990")]
	public abstract Type get_PropertyType() { }

	[Address(RVA = "0x26694F0", Offset = "0x26688F0", Length = "0x67")]
	[Token(Token = "0x6000995")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2669560", Offset = "0x2668960", Length = "0x177")]
	[Token(Token = "0x6000996")]
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	[Address(RVA = "0x26696E0", Offset = "0x2668AE0", Length = "0x23B")]
	[Token(Token = "0x6000997")]
	protected Type GetTypeFromName(string typeName) { }

	[Token(Token = "0x6000998")]
	public abstract object GetValue(object component) { }

	[Address(RVA = "0x2669920", Offset = "0x2668D20", Length = "0x9E")]
	[Token(Token = "0x6000999")]
	protected override void OnValueChanged(object component, EventArgs e) { }

	[Token(Token = "0x600099A")]
	public abstract void ResetValue(object component) { }

	[Token(Token = "0x600099B")]
	public abstract void SetValue(object component, object value) { }

	[Token(Token = "0x600099C")]
	public abstract bool ShouldSerializeValue(object component) { }

}

