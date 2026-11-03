namespace Newtonsoft.Json.Utilities;

[Extension]
[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x20000BC")]
internal static class DynamicUtils
{
	[Nullable(0)]
	[Token(Token = "0x20000BD")]
	public static class BinderWrapper
	{
		[Token(Token = "0x4000430")]
		public const string CSharpAssemblyName = "Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		[Token(Token = "0x4000431")]
		private const string BinderTypeName = "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		[Token(Token = "0x4000432")]
		private const string CSharpArgumentInfoTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		[Token(Token = "0x4000433")]
		private const string CSharpArgumentInfoFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		[Token(Token = "0x4000434")]
		private const string CSharpBinderFlagsTypeName = "Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"; //Field offset: 0x0
		[Nullable(2)]
		[Token(Token = "0x4000435")]
		private static object _getCSharpArgumentInfoArray; //Field offset: 0x0
		[Nullable(2)]
		[Token(Token = "0x4000436")]
		private static object _setCSharpArgumentInfoArray; //Field offset: 0x8
		[Nullable(2)]
		[Token(Token = "0x4000437")]
		private static MethodCall<Object, Object> _getMemberCall; //Field offset: 0x10
		[Nullable(2)]
		[Token(Token = "0x4000438")]
		private static MethodCall<Object, Object> _setMemberCall; //Field offset: 0x18
		[Token(Token = "0x4000439")]
		private static bool _init; //Field offset: 0x20

		[Address(RVA = "0x2118030", Offset = "0x2117430", Length = "0x5D7")]
		[Token(Token = "0x60005F0")]
		private static void CreateMemberCalls() { }

		[Address(RVA = "0x2118610", Offset = "0x2117A10", Length = "0x2EF")]
		[Token(Token = "0x60005EF")]
		private static object CreateSharpArgumentInfoArray(Int32[] values) { }

		[Address(RVA = "0x2118900", Offset = "0x2117D00", Length = "0x24F")]
		[Token(Token = "0x60005F1")]
		public static CallSiteBinder GetMember(string name, Type context) { }

		[Address(RVA = "0x2118B50", Offset = "0x2117F50", Length = "0x217")]
		[Token(Token = "0x60005EE")]
		private static void Init() { }

		[Address(RVA = "0x2118D70", Offset = "0x2118170", Length = "0x250")]
		[Token(Token = "0x60005F2")]
		public static CallSiteBinder SetMember(string name, Type context) { }

	}


	[Address(RVA = "0x2123C50", Offset = "0x2123050", Length = "0xF7")]
	[Extension]
	[Token(Token = "0x60005ED")]
	public static IEnumerable<String> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }

}

