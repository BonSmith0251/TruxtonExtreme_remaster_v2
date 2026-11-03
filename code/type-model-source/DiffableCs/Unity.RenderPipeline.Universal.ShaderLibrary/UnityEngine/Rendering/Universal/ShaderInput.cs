namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x2000013")]
public static class ShaderInput
{
	[GenerateHLSL(PackingRules::Exact (0), False, False, False, 1, False, False, False, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@a6e30d1f59f5\\ShaderLibrary\\ShaderTypes.cs")]
	[Token(Token = "0x2000015")]
	internal struct LightData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006F")]
		public Vector4 position; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000070")]
		public Vector4 color; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000071")]
		public Vector4 attenuation; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000072")]
		public Vector4 spotDirection; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000073")]
		public Vector4 occlusionProbeChannels; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000074")]
		public uint layerMask; //Field offset: 0x50

	}

	[Obsolete("ShaderInput.ShadowData was deprecated. Shadow slice matrices and per-light shadow parameters are now passed to the GPU using entries in buffers m_AdditionalLightsWorldToShadow_SSBO and m_AdditionalShadowParams_SSBO. #from(2021.1) #breakingFrom(2023.1)", True)]
	[Token(Token = "0x2000014")]
	internal struct ShadowData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400006D")]
		public Matrix4x4 worldToShadowMatrix; //Field offset: 0x0
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400006E")]
		public Vector4 shadowParams; //Field offset: 0x40

	}


}

