namespace System.Reflection;

[Token(Token = "0x20004D8")]
public abstract class Binder
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600220F")]
	protected Binder() { }

	[Token(Token = "0x6002210")]
	public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture) { }

	[Token(Token = "0x6002211")]
	public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref Object[] args, ParameterModifier[] modifiers, CultureInfo culture, String[] names, out object state) { }

	[Token(Token = "0x6002212")]
	public abstract object ChangeType(object value, Type type, CultureInfo culture) { }

	[Token(Token = "0x6002213")]
	public abstract void ReorderArgumentArray(ref Object[] args, object state) { }

	[Token(Token = "0x6002214")]
	public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	[Token(Token = "0x6002215")]
	public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

}

