namespace System.Data;

[Token(Token = "0x2000032")]
internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400010C")]
	private readonly DataColumn <Column>k__BackingField; //Field offset: 0x88

	[Token(Token = "0x17000088")]
	public virtual AttributeCollection Attributes
	{
		[Address(RVA = "0x23184E0", Offset = "0x23178E0", Length = "0x1CA")]
		[Token(Token = "0x60003A4")]
		 get { } //Length: 458
	}

	[Token(Token = "0x17000089")]
	internal DataColumn Column
	{
		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60003A5")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700008A")]
	public virtual Type ComponentType
	{
		[Address(RVA = "0x23186B0", Offset = "0x2317AB0", Length = "0x4D")]
		[Token(Token = "0x60003A6")]
		 get { } //Length: 77
	}

	[Token(Token = "0x1700008B")]
	public virtual bool IsReadOnly
	{
		[Address(RVA = "0x2318700", Offset = "0x2317B00", Length = "0x1E")]
		[Token(Token = "0x60003A7")]
		 get { } //Length: 30
	}

	[Token(Token = "0x1700008C")]
	public virtual Type PropertyType
	{
		[Address(RVA = "0x2318720", Offset = "0x2317B20", Length = "0x1E")]
		[Token(Token = "0x60003A8")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x2318490", Offset = "0x2317890", Length = "0x49")]
	[Token(Token = "0x60003A3")]
	internal DataColumnPropertyDescriptor(DataColumn dataColumn) { }

	[Address(RVA = "0x2318050", Offset = "0x2317450", Length = "0x125")]
	[Token(Token = "0x60003AB")]
	public virtual bool CanResetValue(object component) { }

	[Address(RVA = "0x2318180", Offset = "0x2317580", Length = "0x91")]
	[Token(Token = "0x60003A9")]
	public virtual bool Equals(object other) { }

	[Address(RVA = "0x23184E0", Offset = "0x23178E0", Length = "0x1CA")]
	[Token(Token = "0x60003A4")]
	public virtual AttributeCollection get_Attributes() { }

	[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60003A5")]
	internal DataColumn get_Column() { }

	[Address(RVA = "0x23186B0", Offset = "0x2317AB0", Length = "0x4D")]
	[Token(Token = "0x60003A6")]
	public virtual Type get_ComponentType() { }

	[Address(RVA = "0x2318700", Offset = "0x2317B00", Length = "0x1E")]
	[Token(Token = "0x60003A7")]
	public virtual bool get_IsReadOnly() { }

	[Address(RVA = "0x2318720", Offset = "0x2317B20", Length = "0x1E")]
	[Token(Token = "0x60003A8")]
	public virtual Type get_PropertyType() { }

	[Address(RVA = "0x2318220", Offset = "0x2317620", Length = "0x2D")]
	[Token(Token = "0x60003AA")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2318250", Offset = "0x2317650", Length = "0x86")]
	[Token(Token = "0x60003AC")]
	public virtual object GetValue(object component) { }

	[Address(RVA = "0x23182E0", Offset = "0x23176E0", Length = "0xBE")]
	[Token(Token = "0x60003AD")]
	public virtual void ResetValue(object component) { }

	[Address(RVA = "0x23183A0", Offset = "0x23177A0", Length = "0xEA")]
	[Token(Token = "0x60003AE")]
	public virtual void SetValue(object component, object value) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x60003AF")]
	public virtual bool ShouldSerializeValue(object component) { }

}

