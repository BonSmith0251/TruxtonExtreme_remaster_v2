namespace UnityEngine.VFX;

[Token(Token = "0x200003A")]
internal class VFXRuntimeResources : ScriptableObject
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40000CA")]
	private ComputeShader m_SDFRayMapCS; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40000CB")]
	private ComputeShader m_SDFNormalsCS; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40000CC")]
	private Shader m_SDFRayMapShader; //Field offset: 0x28

	[Token(Token = "0x1700001B")]
	public static VFXRuntimeResources runtimeResources
	{
		[Address(RVA = "0x2F783A0", Offset = "0x2F777A0", Length = "0x93")]
		[Token(Token = "0x60000B7")]
		 get { } //Length: 147
	}

	[Token(Token = "0x17000019")]
	internal ComputeShader sdfNormalsCS
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60000B3")]
		internal get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60000B4")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x17000018")]
	internal ComputeShader sdfRayMapCS
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60000B1")]
		internal get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60000B2")]
		internal set { } //Length: 13
	}

	[Token(Token = "0x1700001A")]
	internal Shader sdfRayMapShader
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60000B5")]
		internal get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60000B6")]
		internal set { } //Length: 13
	}

	[Address(RVA = "0x5B3AF0", Offset = "0x5B2EF0", Length = "0x7")]
	[Token(Token = "0x60000B8")]
	public VFXRuntimeResources() { }

	[Address(RVA = "0x2F783A0", Offset = "0x2F777A0", Length = "0x93")]
	[Token(Token = "0x60000B7")]
	public static VFXRuntimeResources get_runtimeResources() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60000B3")]
	internal ComputeShader get_sdfNormalsCS() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60000B1")]
	internal ComputeShader get_sdfRayMapCS() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60000B5")]
	internal Shader get_sdfRayMapShader() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60000B4")]
	internal void set_sdfNormalsCS(ComputeShader value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60000B2")]
	internal void set_sdfRayMapCS(ComputeShader value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60000B6")]
	internal void set_sdfRayMapShader(Shader value) { }

}

