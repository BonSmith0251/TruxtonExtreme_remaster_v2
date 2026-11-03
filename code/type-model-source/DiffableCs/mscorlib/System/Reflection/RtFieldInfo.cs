namespace System.Reflection;

[Token(Token = "0x2000519")]
internal abstract class RtFieldInfo : FieldInfo
{

	[Address(RVA = "0xB0D600", Offset = "0xB0CA00", Length = "0x7")]
	[Token(Token = "0x6002462")]
	protected RtFieldInfo() { }

	[Token(Token = "0x6002461")]
	internal abstract void CheckConsistency(object target) { }

	[Token(Token = "0x600245F")]
	internal abstract object UnsafeGetValue(object obj) { }

	[Token(Token = "0x6002460")]
	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

}

