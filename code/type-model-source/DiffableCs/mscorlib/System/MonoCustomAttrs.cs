namespace System;

[Token(Token = "0x20001BC")]
internal static class MonoCustomAttrs
{
	[Token(Token = "0x20001BD")]
	private class AttributeInfo
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000712")]
		private AttributeUsageAttribute _usage; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000713")]
		private int _inheritanceLevel; //Field offset: 0x18

		[Token(Token = "0x17000165")]
		public int InheritanceLevel
		{
			[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
			[Token(Token = "0x6000FEC")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000164")]
		public AttributeUsageAttribute Usage
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x6000FEB")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x207ACB0", Offset = "0x207A0B0", Length = "0x2B")]
		[Token(Token = "0x6000FEA")]
		public AttributeInfo(AttributeUsageAttribute usage, int inheritanceLevel) { }

		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x6000FEC")]
		public int get_InheritanceLevel() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000FEB")]
		public AttributeUsageAttribute get_Usage() { }

	}

	[ThreadStatic]
	[Token(Token = "0x4000710")]
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; //Field offset: 0x80000000
	[Token(Token = "0x400070F")]
	private static Assembly corlib; //Field offset: 0x0
	[Token(Token = "0x4000711")]
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; //Field offset: 0x8

	[Address(RVA = "0x2085A20", Offset = "0x2084E20", Length = "0x7E")]
	[Token(Token = "0x6000FE9")]
	private static MonoCustomAttrs() { }

	[Address(RVA = "0x2082500", Offset = "0x2081900", Length = "0x47B")]
	[Token(Token = "0x6000FE6")]
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	[Address(RVA = "0x2081F50", Offset = "0x2081350", Length = "0x236")]
	[Token(Token = "0x6000FE5")]
	private static EventInfo GetBaseEventDefinition(RuntimeEventInfo evt) { }

	[Address(RVA = "0x2082190", Offset = "0x2081590", Length = "0x362")]
	[Token(Token = "0x6000FE4")]
	private static PropertyInfo GetBasePropertyDefinition(RuntimePropertyInfo property) { }

	[Address(RVA = "0x2083B60", Offset = "0x2082F60", Length = "0xB3D")]
	[Token(Token = "0x6000FDA")]
	internal static Object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	[Address(RVA = "0x20846A0", Offset = "0x2083AA0", Length = "0x17A")]
	[Token(Token = "0x6000FDB")]
	internal static Object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	[Address(RVA = "0x2082980", Offset = "0x2081D80", Length = "0x1DD")]
	[Token(Token = "0x6000FD9")]
	internal static Object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	[Address(RVA = "0x2082CE0", Offset = "0x20820E0", Length = "0xD39")]
	[Token(Token = "0x6000FDE")]
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	[Address(RVA = "0x2083A20", Offset = "0x2082E20", Length = "0x126")]
	[Token(Token = "0x6000FDD")]
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj, bool inherit = false) { }

	[Address(RVA = "0x2082B60", Offset = "0x2081F60", Length = "0x169")]
	[Token(Token = "0x6000FDF")]
	internal static IList<CustomAttributeData> GetCustomAttributesDataBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	[Address(RVA = "0x2082CD0", Offset = "0x20820D0", Length = "0x5")]
	[Token(Token = "0x6000FDC")]
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	[Address(RVA = "0x2083B50", Offset = "0x2082F50", Length = "0x5")]
	[Token(Token = "0x6000FD6")]
	internal static Attribute[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	[Address(RVA = "0x2084D20", Offset = "0x2084120", Length = "0x18D")]
	[Token(Token = "0x6000FD8")]
	private static Object[] GetPseudoCustomAttributes(Type type) { }

	[Address(RVA = "0x2084EB0", Offset = "0x20842B0", Length = "0x297")]
	[Token(Token = "0x6000FD7")]
	internal static Object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	[Address(RVA = "0x2084820", Offset = "0x2083C20", Length = "0x299")]
	[Token(Token = "0x6000FE0")]
	internal static CustomAttributeData[] GetPseudoCustomAttributesData(ICustomAttributeProvider obj, Type attributeType) { }

	[Address(RVA = "0x2084AC0", Offset = "0x2083EC0", Length = "0x253")]
	[Token(Token = "0x6000FE1")]
	private static CustomAttributeData[] GetPseudoCustomAttributesData(Type type) { }

	[Address(RVA = "0x2085160", Offset = "0x2084560", Length = "0x2C2")]
	[Token(Token = "0x6000FE2")]
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	[Address(RVA = "0x2085150", Offset = "0x2084550", Length = "0x5")]
	[Token(Token = "0x6000FE3")]
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	[Address(RVA = "0x2085430", Offset = "0x2084830", Length = "0x1F7")]
	[Token(Token = "0x6000FD5")]
	private static bool IsUserCattrProvider(object obj) { }

	[Address(RVA = "0x2085890", Offset = "0x2084C90", Length = "0x185")]
	[Token(Token = "0x6000FE8")]
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	[Address(RVA = "0x2085630", Offset = "0x2084A30", Length = "0x25C")]
	[Token(Token = "0x6000FE7")]
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

}

