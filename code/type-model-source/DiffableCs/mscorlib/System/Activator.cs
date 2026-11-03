namespace System;

[ClassInterface(ClassInterfaceType::None (0))]
[ComDefaultInterface(typeof(_Activator))]
[ComVisible(True)]
[Token(Token = "0x200017F")]
public sealed class Activator
{

	[Address(RVA = "0x2059350", Offset = "0x2058750", Length = "0x24")]
	[Token(Token = "0x6000D8E")]
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture) { }

	[Address(RVA = "0x20593C0", Offset = "0x20587C0", Length = "0x23E")]
	[Token(Token = "0x6000D8F")]
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, Object[] args, CultureInfo culture, Object[] activationAttributes) { }

	[Address(RVA = "0x2059600", Offset = "0x2058A00", Length = "0x2A")]
	[Token(Token = "0x6000D90")]
	public static object CreateInstance(Type type, Object[] args) { }

	[Address(RVA = "0x2059380", Offset = "0x2058780", Length = "0x2A")]
	[Token(Token = "0x6000D91")]
	public static object CreateInstance(Type type, Object[] args, Object[] activationAttributes) { }

	[Address(RVA = "0x2059630", Offset = "0x2058A30", Length = "0xD")]
	[Token(Token = "0x6000D92")]
	public static object CreateInstance(Type type) { }

	[Address(RVA = "0x20593B0", Offset = "0x20587B0", Length = "0xB")]
	[Token(Token = "0x6000D93")]
	public static object CreateInstance(Type type, bool nonPublic) { }

	[Address(RVA = "0x20591A0", Offset = "0x20585A0", Length = "0x1A1")]
	[Token(Token = "0x6000D94")]
	internal static object CreateInstance(Type type, bool nonPublic, bool wrapExceptions) { }

	[Address(RVA = "0x6DBD00", Offset = "0x6DB100", Length = "0x180")]
	[Token(Token = "0x6000D95")]
	public static T CreateInstance() { }

}

