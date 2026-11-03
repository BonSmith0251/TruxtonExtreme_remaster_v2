namespace System.ComponentModel;

[Token(Token = "0x2000199")]
public abstract class TypeDescriptionProvider
{
	[Token(Token = "0x200019A")]
	private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000A0E")]
		public EmptyCustomTypeDescriptor() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400066C")]
	private readonly TypeDescriptionProvider _parent; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400066D")]
	private EmptyCustomTypeDescriptor _emptyDescriptor; //Field offset: 0x18

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000A04")]
	protected TypeDescriptionProvider() { }

	[Address(RVA = "0x2678C70", Offset = "0x2678070", Length = "0xC0")]
	[Token(Token = "0x6000A05")]
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, Object[] args) { }

	[Address(RVA = "0x2678D40", Offset = "0x2678140", Length = "0x20")]
	[Token(Token = "0x6000A06")]
	public override IDictionary GetCache(object instance) { }

	[Address(RVA = "0x2678D60", Offset = "0x2678160", Length = "0xA2")]
	[Token(Token = "0x6000A07")]
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	[Address(RVA = "0x2678E10", Offset = "0x2678210", Length = "0xC6")]
	[Token(Token = "0x6000A08")]
	protected private override IExtenderProvider[] GetExtenderProviders(object instance) { }

	[Address(RVA = "0x20C6110", Offset = "0x20C5510", Length = "0x17")]
	[Token(Token = "0x6000A09")]
	public Type GetReflectionType(Type objectType) { }

	[Address(RVA = "0x2678EE0", Offset = "0x26782E0", Length = "0x23")]
	[Token(Token = "0x6000A0A")]
	public override Type GetReflectionType(Type objectType, object instance) { }

	[Address(RVA = "0x1E57D60", Offset = "0x1E57160", Length = "0x17")]
	[Token(Token = "0x6000A0B")]
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	[Address(RVA = "0x2678FD0", Offset = "0x26783D0", Length = "0x8E")]
	[Token(Token = "0x6000A0C")]
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	[Address(RVA = "0x2678F10", Offset = "0x2678310", Length = "0xB7")]
	[Token(Token = "0x6000A0D")]
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

}

