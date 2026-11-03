namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x2000178")]
public sealed class ExtenderProvidedPropertyAttribute : Attribute
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400062E")]
	private PropertyDescriptor <ExtenderProperty>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400062F")]
	private IExtenderProvider <Provider>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000630")]
	private Type <ReceiverType>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x170001B9")]
	public private PropertyDescriptor ExtenderProperty
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000923")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000924")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001BA")]
	public private IExtenderProvider Provider
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000925")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000926")]
		private set { } //Length: 13
	}

	[Token(Token = "0x170001BB")]
	public private Type ReceiverType
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000927")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000928")]
		private set { } //Length: 13
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x6000922")]
	public ExtenderProvidedPropertyAttribute() { }

	[Address(RVA = "0x2663440", Offset = "0x2662840", Length = "0xA4")]
	[Token(Token = "0x6000921")]
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	[Address(RVA = "0x26634F0", Offset = "0x26628F0", Length = "0xF8")]
	[Token(Token = "0x6000929")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000923")]
	public PropertyDescriptor get_ExtenderProperty() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000925")]
	public IExtenderProvider get_Provider() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000927")]
	public Type get_ReceiverType() { }

	[Address(RVA = "0x2647A90", Offset = "0x2646E90", Length = "0x7")]
	[Token(Token = "0x600092A")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x26635F0", Offset = "0x26629F0", Length = "0x31")]
	[Token(Token = "0x600092B")]
	public virtual bool IsDefaultAttribute() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000924")]
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000926")]
	private void set_Provider(IExtenderProvider value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000928")]
	private void set_ReceiverType(Type value) { }

}

