namespace Newtonsoft.Json.Utilities;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000E3")]
internal class ReflectionObject
{
	[CompilerGenerated]
	[Token(Token = "0x20000E4")]
	private sealed class <>c__DisplayClass11_0
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1})]
		[Token(Token = "0x40004B6")]
		public Func<Object> ctor; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006A9")]
		public <>c__DisplayClass11_0() { }

		[Address(RVA = "0x2131A30", Offset = "0x2130E30", Length = "0x25")]
		[Token(Token = "0x60006AA")]
		internal object <Create>b__0(Object[] args) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E5")]
	private sealed class <>c__DisplayClass11_1
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		[Token(Token = "0x40004B7")]
		public MethodCall<Object, Object> call; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006AB")]
		public <>c__DisplayClass11_1() { }

		[Address(RVA = "0x2131A60", Offset = "0x2130E60", Length = "0xC3")]
		[Token(Token = "0x60006AC")]
		internal object <Create>b__1(object target) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x20000E6")]
	private sealed class <>c__DisplayClass11_2
	{
		[FieldOffset(Offset = "0x10")]
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
		[Token(Token = "0x40004B8")]
		public MethodCall<Object, Object> call; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006AD")]
		public <>c__DisplayClass11_2() { }

		[Address(RVA = "0x2131B30", Offset = "0x2130F30", Length = "0xCE")]
		[Token(Token = "0x60006AE")]
		internal void <Create>b__2(object target, object arg) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x40004B4")]
	private readonly ObjectConstructor<Object> <Creator>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40004B5")]
	private readonly IDictionary<String, ReflectionMember> <Members>k__BackingField; //Field offset: 0x18

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1})]
	[Token(Token = "0x170000DB")]
	public ObjectConstructor<Object> Creator
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006A1")]
		 get { } //Length: 5
	}

	[Token(Token = "0x170000DC")]
	public IDictionary<String, ReflectionMember> Members
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006A2")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x212C720", Offset = "0x212BB20", Length = "0x94")]
	[Token(Token = "0x60006A3")]
	private ReflectionObject(ObjectConstructor<Object> creator) { }

	[Address(RVA = "0x212BC60", Offset = "0x212B060", Length = "0xD")]
	[Token(Token = "0x60006A7")]
	public static ReflectionObject Create(Type t, String[] memberNames) { }

	[Address(RVA = "0x212BC70", Offset = "0x212B070", Length = "0x914")]
	[Token(Token = "0x60006A8")]
	public static ReflectionObject Create(Type t, MethodBase creator, String[] memberNames) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60006A1")]
	public ObjectConstructor<Object> get_Creator() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60006A2")]
	public IDictionary<String, ReflectionMember> get_Members() { }

	[Address(RVA = "0x212C590", Offset = "0x212B990", Length = "0x5F")]
	[Token(Token = "0x60006A6")]
	public Type GetType(string member) { }

	[Address(RVA = "0x212C5F0", Offset = "0x212B9F0", Length = "0x82")]
	[Token(Token = "0x60006A4")]
	public object GetValue(object target, string member) { }

	[Address(RVA = "0x212C680", Offset = "0x212BA80", Length = "0x92")]
	[Token(Token = "0x60006A5")]
	public void SetValue(object target, string member, object value) { }

}

