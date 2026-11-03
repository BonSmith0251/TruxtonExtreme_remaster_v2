namespace System;

[AttributeUsage(AttributeTargets::All (32767), Inherited = True, AllowMultiple = False)]
[Token(Token = "0x2000180")]
public abstract class Attribute
{

	[Token(Token = "0x1700011F")]
	public override object TypeId
	{
		[Address(RVA = "0x2051E40", Offset = "0x2051240", Length = "0x7")]
		[Token(Token = "0x6000DB1")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000DAD")]
	protected Attribute() { }

	[Address(RVA = "0x2059E90", Offset = "0x2059290", Length = "0x1B4")]
	[Token(Token = "0x6000DAF")]
	private static bool AreFieldValuesEqual(object thisValue, object thatValue) { }

	[Address(RVA = "0x205A050", Offset = "0x2059450", Length = "0x26F")]
	[Token(Token = "0x6000DAE")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2051E40", Offset = "0x2051240", Length = "0x7")]
	[Token(Token = "0x6000DB1")]
	public override object get_TypeId() { }

	[Address(RVA = "0x205A2C0", Offset = "0x20596C0", Length = "0xA2")]
	[Token(Token = "0x6000DAC")]
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205A370", Offset = "0x2059770", Length = "0xA5")]
	[Token(Token = "0x6000DAB")]
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Address(RVA = "0x205A4D0", Offset = "0x20598D0", Length = "0xA5")]
	[Token(Token = "0x6000DA1")]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Address(RVA = "0x205A420", Offset = "0x2059820", Length = "0xA2")]
	[Token(Token = "0x6000DA2")]
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205AAB0", Offset = "0x2059EB0", Length = "0x267")]
	[Token(Token = "0x6000DA8")]
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205A770", Offset = "0x2059B70", Length = "0xB")]
	[Token(Token = "0x6000DA7")]
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType) { }

	[Address(RVA = "0x205B1A0", Offset = "0x205A5A0", Length = "0x288")]
	[Token(Token = "0x6000DA6")]
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205AD20", Offset = "0x205A120", Length = "0x147")]
	[Token(Token = "0x6000DA5")]
	public static Attribute[] GetCustomAttributes(Module element, bool inherit) { }

	[Address(RVA = "0x205A790", Offset = "0x2059B90", Length = "0x30C")]
	[Token(Token = "0x6000DA3")]
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205A580", Offset = "0x2059980", Length = "0x1E7")]
	[Token(Token = "0x6000DA4")]
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit) { }

	[Address(RVA = "0x205B680", Offset = "0x205AA80", Length = "0x231")]
	[Token(Token = "0x6000D9E")]
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit) { }

	[Address(RVA = "0x205A780", Offset = "0x2059B80", Length = "0xA")]
	[Token(Token = "0x6000D9D")]
	public static Attribute[] GetCustomAttributes(MemberInfo element) { }

	[Address(RVA = "0x205AE70", Offset = "0x205A270", Length = "0x320")]
	[Token(Token = "0x6000D9C")]
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit) { }

	[Address(RVA = "0x205AAA0", Offset = "0x2059EA0", Length = "0xB")]
	[Token(Token = "0x6000D9B")]
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type) { }

	[Address(RVA = "0x205B560", Offset = "0x205A960", Length = "0x119")]
	[Token(Token = "0x6000DA9")]
	public static Attribute[] GetCustomAttributes(Assembly element) { }

	[Address(RVA = "0x205B430", Offset = "0x205A830", Length = "0x126")]
	[Token(Token = "0x6000DAA")]
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit) { }

	[Address(RVA = "0x205B8C0", Offset = "0x205ACC0", Length = "0x174")]
	[Token(Token = "0x6000DB0")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x205BAF0", Offset = "0x205AEF0", Length = "0xA2")]
	[Token(Token = "0x6000D96")]
	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit) { }

	[Address(RVA = "0x205BA40", Offset = "0x205AE40", Length = "0xA2")]
	[Token(Token = "0x6000D97")]
	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit) { }

	[Address(RVA = "0x205BBA0", Offset = "0x205AFA0", Length = "0x6B")]
	[Token(Token = "0x6000D9A")]
	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205BC10", Offset = "0x205B010", Length = "0x6B")]
	[Token(Token = "0x6000D99")]
	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205BC80", Offset = "0x205B080", Length = "0x4DB")]
	[Token(Token = "0x6000D98")]
	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit) { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000DB3")]
	public override bool IsDefaultAttribute() { }

	[Address(RVA = "0x205C170", Offset = "0x205B570", Length = "0x347")]
	[Token(Token = "0x6000DA0")]
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit) { }

	[Address(RVA = "0x205C160", Offset = "0x205B560", Length = "0xB")]
	[Token(Token = "0x6000D9F")]
	public static bool IsDefined(MemberInfo element, Type attributeType) { }

	[Address(RVA = "0x205C4C0", Offset = "0x205B8C0", Length = "0x14")]
	[Token(Token = "0x6000DB2")]
	public override bool Match(object obj) { }

}

