namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
[Token(Token = "0x200013A")]
public sealed class CubemapArray : Texture
{

	[Token(Token = "0x1700023F")]
	public virtual bool isReadable
	{
		[Address(RVA = "0x301D0D0", Offset = "0x301C4D0", Length = "0x76")]
		[Token(Token = "0x6000EDB")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x301CB90", Offset = "0x301BF90", Length = "0x1DD")]
	[Token(Token = "0x6000EE5")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x301CFE0", Offset = "0x301C3E0", Length = "0xAD")]
	[Token(Token = "0x6000EE9")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	[Address(RVA = "0x301CE30", Offset = "0x301C230", Length = "0xB1")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EE8")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[Address(RVA = "0x301CAE0", Offset = "0x301BEE0", Length = "0xA6")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EE1")]
	public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x301CEF0", Offset = "0x301C2F0", Length = "0x4C")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EE2")]
	public CubemapArray(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x301CF40", Offset = "0x301C340", Length = "0x9D")]
	[RequiredByNativeCode]
	[Token(Token = "0x6000EE3")]
	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[Address(RVA = "0x301C910", Offset = "0x301BD10", Length = "0x197")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EE4")]
	public CubemapArray(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[Address(RVA = "0x301CAB0", Offset = "0x301BEB0", Length = "0x2D")]
	[Token(Token = "0x6000EE6")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	[Address(RVA = "0x301CD70", Offset = "0x301C170", Length = "0xBD")]
	[Token(Token = "0x6000EE7")]
	public CubemapArray(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[Address(RVA = "0x301C3E0", Offset = "0x301B7E0", Length = "0xB0")]
	[ExcludeFromDocs]
	[Token(Token = "0x6000EEB")]
	public void Apply() { }

	[Address(RVA = "0x301C310", Offset = "0x301B710", Length = "0xCD")]
	[Token(Token = "0x6000EEA")]
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x301C270", Offset = "0x301B670", Length = "0x98")]
	[FreeFunction(Name = "CubemapArrayScripting::Apply", HasExplicitThis = True)]
	[Token(Token = "0x6000EDE")]
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x301C210", Offset = "0x301B610", Length = "0x55")]
	[Token(Token = "0x6000EEE")]
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	[Address(RVA = "0x301D0D0", Offset = "0x301C4D0", Length = "0x76")]
	[Token(Token = "0x6000EDB")]
	public virtual bool get_isReadable() { }

	[Address(RVA = "0x301D090", Offset = "0x301C490", Length = "0x33")]
	[Token(Token = "0x6000EED")]
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x301C500", Offset = "0x301B900", Length = "0xC9")]
	[Token(Token = "0x6000EDD")]
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[Address(RVA = "0x301C4A0", Offset = "0x301B8A0", Length = "0x60")]
	[FreeFunction("CubemapArrayScripting::Create")]
	[Token(Token = "0x6000EDC")]
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[Address(RVA = "0x301C640", Offset = "0x301BA40", Length = "0x131")]
	[FreeFunction(Name = "CubemapArrayScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000EDF")]
	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement, int miplevel) { }

	[Address(RVA = "0x301C780", Offset = "0x301BB80", Length = "0x12E")]
	[Token(Token = "0x6000EE0")]
	public void SetPixels(Color[] colors, CubemapFace face, int arrayElement) { }

	[Address(RVA = "0x301C5D0", Offset = "0x301B9D0", Length = "0x62")]
	[Token(Token = "0x6000EEF")]
	private static void SetPixels_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, CubemapFace face, int arrayElement, int miplevel) { }

	[Address(RVA = "0x301C8B0", Offset = "0x301BCB0", Length = "0x60")]
	[Token(Token = "0x6000EEC")]
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

}

