namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000E1")]
internal abstract class ReflectionDelegateFactory
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000699")]
	protected ReflectionDelegateFactory() { }

	[Token(Token = "0x6000694")]
	public abstract Func<T> CreateDefaultConstructor(Type type) { }

	[Address(RVA = "0x8E5920", Offset = "0x8E4D20", Length = "0x1FA")]
	[Token(Token = "0x6000690")]
	public Func<T, Object> CreateGet(MemberInfo memberInfo) { }

	[Token(Token = "0x6000695")]
	public abstract Func<T, Object> CreateGet(PropertyInfo propertyInfo) { }

	[Token(Token = "0x6000696")]
	public abstract Func<T, Object> CreateGet(FieldInfo fieldInfo) { }

	[Token(Token = "0x6000692")]
	public abstract MethodCall<T, Object> CreateMethodCall(MethodBase method) { }

	[Token(Token = "0x6000693")]
	public abstract ObjectConstructor<Object> CreateParameterizedConstructor(MethodBase method) { }

	[Address(RVA = "0x8E5B20", Offset = "0x8E4F20", Length = "0x157")]
	[Token(Token = "0x6000691")]
	public Action<T, Object> CreateSet(MemberInfo memberInfo) { }

	[Token(Token = "0x6000697")]
	public abstract Action<T, Object> CreateSet(FieldInfo fieldInfo) { }

	[Token(Token = "0x6000698")]
	public abstract Action<T, Object> CreateSet(PropertyInfo propertyInfo) { }

}

