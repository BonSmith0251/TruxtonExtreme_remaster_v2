namespace UnityEngine.Rendering;

[MovedFrom("UnityEngine.Experimental.Rendering")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Graphics/RayTracing/RayTracingAccelerationStructure.h")]
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingShader.h")]
[Token(Token = "0x2000403")]
internal class RayTracingShaderHelpURLAttribute : HelpURLAttribute
{

	[Token(Token = "0x1700049E")]
	public virtual string URL
	{
		[Address(RVA = "0x30C3470", Offset = "0x30C2870", Length = "0x99")]
		[Token(Token = "0x6001F12")]
		 get { } //Length: 153
	}

	[Address(RVA = "0x30C3460", Offset = "0x30C2860", Length = "0xA")]
	[Token(Token = "0x6001F11")]
	public RayTracingShaderHelpURLAttribute() { }

	[Address(RVA = "0x30C3470", Offset = "0x30C2870", Length = "0x99")]
	[Token(Token = "0x6001F12")]
	public virtual string get_URL() { }

}

