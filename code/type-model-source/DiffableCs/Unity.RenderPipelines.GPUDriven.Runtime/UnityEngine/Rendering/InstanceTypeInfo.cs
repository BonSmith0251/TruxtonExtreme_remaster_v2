namespace UnityEngine.Rendering;

[Token(Token = "0x20000A1")]
internal static class InstanceTypeInfo
{
	[Token(Token = "0x400030A")]
	public const int kInstanceTypeBitCount = 1; //Field offset: 0x0
	[Token(Token = "0x400030B")]
	public const int kMaxInstanceTypesCount = 2; //Field offset: 0x0
	[Token(Token = "0x400030C")]
	public const uint kInstanceTypeMask = 1; //Field offset: 0x0
	[Token(Token = "0x400030D")]
	private static InstanceType[] s_ParentTypes; //Field offset: 0x0
	[Token(Token = "0x400030E")]
	private static List<InstanceType>[] s_ChildTypes; //Field offset: 0x8

	[Address(RVA = "0x2CF68F0", Offset = "0x2CF5CF0", Length = "0x203")]
	[Token(Token = "0x60002EB")]
	private static InstanceTypeInfo() { }

	[Address(RVA = "0x2CF6070", Offset = "0x2CF5470", Length = "0x1B1")]
	[Token(Token = "0x60002EF")]
	private static void FlattenChildInstanceTypes(InstanceType instanceType, NativeList<InstanceType> instanceTypes) { }

	[Address(RVA = "0x2CF6230", Offset = "0x2CF5630", Length = "0x6F")]
	[Token(Token = "0x60002F2")]
	public static List<InstanceType> GetChildTypes(InstanceType type) { }

	[Address(RVA = "0x2CF62A0", Offset = "0x2CF56A0", Length = "0x19A")]
	[Token(Token = "0x60002EE")]
	private static InstanceType GetMaxChildTypeRecursively(InstanceType type) { }

	[Address(RVA = "0x2CF6440", Offset = "0x2CF5840", Length = "0x6D")]
	[Token(Token = "0x60002F1")]
	public static InstanceType GetParentType(InstanceType type) { }

	[Address(RVA = "0x2CF64B0", Offset = "0x2CF58B0", Length = "0x23E")]
	[Token(Token = "0x60002ED")]
	private static void InitChildTypes() { }

	[Address(RVA = "0x2CF66F0", Offset = "0x2CF5AF0", Length = "0xCF")]
	[Token(Token = "0x60002EC")]
	private static void InitParentTypes() { }

	[Address(RVA = "0x2CF67C0", Offset = "0x2CF5BC0", Length = "0x127")]
	[Token(Token = "0x60002F0")]
	private static void ValidateTypeRelationsAreCorrectlySorted() { }

}

