namespace System.ComponentModel;

[Token(Token = "0x200016E")]
internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000616")]
	private readonly Type _type; //Field offset: 0x20

	[Token(Token = "0x170001A3")]
	internal TypeDescriptionProvider Provider
	{
		[Address(RVA = "0x265F6E0", Offset = "0x265EAE0", Length = "0x4D")]
		[Token(Token = "0x60008CB")]
		internal get { } //Length: 77
	}

	[Address(RVA = "0x265F6A0", Offset = "0x265EAA0", Length = "0x31")]
	[Token(Token = "0x60008CA")]
	internal DelegatingTypeDescriptionProvider(Type type) { }

	[Address(RVA = "0x265F350", Offset = "0x265E750", Length = "0xA2")]
	[Token(Token = "0x60008CC")]
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	[Address(RVA = "0x265F6E0", Offset = "0x265EAE0", Length = "0x4D")]
	[Token(Token = "0x60008CB")]
	internal TypeDescriptionProvider get_Provider() { }

	[Address(RVA = "0x265F400", Offset = "0x265E800", Length = "0x7D")]
	[Token(Token = "0x60008CD")]
	public virtual IDictionary GetCache(object instance) { }

	[Address(RVA = "0x265F480", Offset = "0x265E880", Length = "0x7D")]
	[Token(Token = "0x60008CE")]
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	[Address(RVA = "0x265F500", Offset = "0x265E900", Length = "0x7D")]
	[Token(Token = "0x60008CF")]
	protected private virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	[Address(RVA = "0x265F580", Offset = "0x265E980", Length = "0x8D")]
	[Token(Token = "0x60008D0")]
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	[Address(RVA = "0x265F610", Offset = "0x265EA10", Length = "0x8D")]
	[Token(Token = "0x60008D1")]
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

