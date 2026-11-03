namespace UnityEngine.UIElements;

[Token(Token = "0x2000258")]
internal static class FilterFunctionDefinitionUtils
{
	[Token(Token = "0x4000916")]
	private static FilterFunctionDefinition s_BlurDef; //Field offset: 0x0
	[Token(Token = "0x4000917")]
	private static FilterFunctionDefinition s_TintDef; //Field offset: 0x8
	[Token(Token = "0x4000918")]
	private static FilterFunctionDefinition s_OpacityDef; //Field offset: 0x10
	[Token(Token = "0x4000919")]
	private static FilterFunctionDefinition s_InvertDef; //Field offset: 0x18
	[Token(Token = "0x400091A")]
	private static FilterFunctionDefinition s_GrayscaleDef; //Field offset: 0x20
	[Token(Token = "0x400091B")]
	private static FilterFunctionDefinition s_SepiaDef; //Field offset: 0x28
	[Token(Token = "0x400091C")]
	private static FilterFunctionDefinition s_ContrastDef; //Field offset: 0x30
	[Token(Token = "0x400091D")]
	private static FilterFunctionDefinition s_HueRotateDef; //Field offset: 0x38

	[Address(RVA = "0x33CECE0", Offset = "0x33CE0E0", Length = "0x138")]
	[Token(Token = "0x600101A")]
	private static void ApplySettings(MaterialPropertyBlock mpb, FilterPassContext context) { }

	[Address(RVA = "0x33CF5E0", Offset = "0x33CE9E0", Length = "0x114")]
	[Token(Token = "0x6001018")]
	private static PostProcessingMargins ComputeHorizontalBlurMargins(FilterFunction func) { }

	[Address(RVA = "0x33CF700", Offset = "0x33CEB00", Length = "0x120")]
	[Token(Token = "0x6001019")]
	private static PostProcessingMargins ComputeVerticalBlurMargins(FilterFunction func) { }

	[Address(RVA = "0x33CF820", Offset = "0x33CEC20", Length = "0x6FB")]
	[Token(Token = "0x6001016")]
	private static FilterFunctionDefinition CreateBlurFilterFunctionDefinition() { }

	[Address(RVA = "0x33CFF20", Offset = "0x33CF320", Length = "0x494")]
	[Token(Token = "0x6001017")]
	private static FilterFunctionDefinition CreateColorEffectFilterFunctionDefinition(FilterFunctionType filterType) { }

	[Address(RVA = "0x33D03E0", Offset = "0x33CF7E0", Length = "0x4C")]
	[Token(Token = "0x6001015")]
	public static FilterFunctionDefinition GetBuiltinDefinition(FilterFunctionType type) { }

	[Address(RVA = "0x33D08A0", Offset = "0x33CFCA0", Length = "0x94")]
	[Token(Token = "0x6001014")]
	public static string GetBuiltinFilterName(FilterFunctionType type) { }

}

