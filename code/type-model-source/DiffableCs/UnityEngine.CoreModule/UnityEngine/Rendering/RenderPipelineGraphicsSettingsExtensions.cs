namespace UnityEngine.Rendering;

[Extension]
[Token(Token = "0x200038E")]
public static class RenderPipelineGraphicsSettingsExtensions
{

	[Address(RVA = "0x8E8360", Offset = "0x8E7760", Length = "0x44")]
	[Extension]
	[Token(Token = "0x6001CB4")]
	public static void SetValueAndNotify(IRenderPipelineGraphicsSettings settings, ref T currentPropertyValue, T newValue, string propertyName = null) { }

}

