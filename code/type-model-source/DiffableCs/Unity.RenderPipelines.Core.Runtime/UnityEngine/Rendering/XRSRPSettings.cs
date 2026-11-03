namespace UnityEngine.Rendering;

[Token(Token = "0x2000234")]
public class XRSRPSettings
{

	[Token(Token = "0x17000208")]
	public static bool enabled
	{
		[Address(RVA = "0x2C8A890", Offset = "0x2C89C90", Length = "0x7")]
		[Token(Token = "0x6000FC7")]
		 get { } //Length: 7
	}

	[Token(Token = "0x1700020C")]
	public static RenderTextureDescriptor eyeTextureDesc
	{
		[Address(RVA = "0x2C8A8A0", Offset = "0x2C89CA0", Length = "0x71")]
		[Token(Token = "0x6000FCB")]
		 get { } //Length: 113
	}

	[Token(Token = "0x1700020E")]
	public static int eyeTextureHeight
	{
		[Address(RVA = "0x2C8A920", Offset = "0x2C89D20", Length = "0x21")]
		[Token(Token = "0x6000FCD")]
		 get { } //Length: 33
	}

	[Token(Token = "0x1700020D")]
	public static int eyeTextureWidth
	{
		[Address(RVA = "0x2C8A950", Offset = "0x2C89D50", Length = "0x21")]
		[Token(Token = "0x6000FCC")]
		 get { } //Length: 33
	}

	[Token(Token = "0x17000209")]
	public static bool isDeviceActive
	{
		[Address(RVA = "0x2C8A980", Offset = "0x2C89D80", Length = "0x1F")]
		[Token(Token = "0x6000FC8")]
		 get { } //Length: 31
	}

	[Token(Token = "0x1700020A")]
	public static string loadedDeviceName
	{
		[Address(RVA = "0x2C8A9A0", Offset = "0x2C89DA0", Length = "0x42")]
		[Token(Token = "0x6000FC9")]
		 get { } //Length: 66
	}

	[Token(Token = "0x17000211")]
	public static int mirrorViewMode
	{
		[Address(RVA = "0x2C8A9F0", Offset = "0x2C89DF0", Length = "0x52")]
		[Token(Token = "0x6000FD2")]
		 get { } //Length: 82
		[Address(RVA = "0x2C8ABD0", Offset = "0x2C89FD0", Length = "0x58")]
		[Token(Token = "0x6000FD3")]
		 set { } //Length: 88
	}

	[Token(Token = "0x1700020F")]
	public static float occlusionMeshScale
	{
		[Address(RVA = "0x2C8AA50", Offset = "0x2C89E50", Length = "0x91")]
		[Token(Token = "0x6000FCE")]
		 get { } //Length: 145
		[Address(RVA = "0x2C8AC30", Offset = "0x2C8A030", Length = "0x96")]
		[Token(Token = "0x6000FCF")]
		 set { } //Length: 150
	}

	[Token(Token = "0x1700020B")]
	public static String[] supportedDevices
	{
		[Address(RVA = "0x2C8AAF0", Offset = "0x2C89EF0", Length = "0x4B")]
		[Token(Token = "0x6000FCA")]
		 get { } //Length: 75
	}

	[Token(Token = "0x17000210")]
	public static bool useVisibilityMesh
	{
		[Address(RVA = "0x2C8AB40", Offset = "0x2C89F40", Length = "0x8D")]
		[Token(Token = "0x6000FD0")]
		 get { } //Length: 141
		[Address(RVA = "0x2C8ACD0", Offset = "0x2C8A0D0", Length = "0x3A5")]
		[Token(Token = "0x6000FD1")]
		 set { } //Length: 933
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000FD4")]
	public XRSRPSettings() { }

	[Address(RVA = "0x2C8A890", Offset = "0x2C89C90", Length = "0x7")]
	[Token(Token = "0x6000FC7")]
	public static bool get_enabled() { }

	[Address(RVA = "0x2C8A8A0", Offset = "0x2C89CA0", Length = "0x71")]
	[Token(Token = "0x6000FCB")]
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	[Address(RVA = "0x2C8A920", Offset = "0x2C89D20", Length = "0x21")]
	[Token(Token = "0x6000FCD")]
	public static int get_eyeTextureHeight() { }

	[Address(RVA = "0x2C8A950", Offset = "0x2C89D50", Length = "0x21")]
	[Token(Token = "0x6000FCC")]
	public static int get_eyeTextureWidth() { }

	[Address(RVA = "0x2C8A980", Offset = "0x2C89D80", Length = "0x1F")]
	[Token(Token = "0x6000FC8")]
	public static bool get_isDeviceActive() { }

	[Address(RVA = "0x2C8A9A0", Offset = "0x2C89DA0", Length = "0x42")]
	[Token(Token = "0x6000FC9")]
	public static string get_loadedDeviceName() { }

	[Address(RVA = "0x2C8A9F0", Offset = "0x2C89DF0", Length = "0x52")]
	[Token(Token = "0x6000FD2")]
	public static int get_mirrorViewMode() { }

	[Address(RVA = "0x2C8AA50", Offset = "0x2C89E50", Length = "0x91")]
	[Token(Token = "0x6000FCE")]
	public static float get_occlusionMeshScale() { }

	[Address(RVA = "0x2C8AAF0", Offset = "0x2C89EF0", Length = "0x4B")]
	[Token(Token = "0x6000FCA")]
	public static String[] get_supportedDevices() { }

	[Address(RVA = "0x2C8AB40", Offset = "0x2C89F40", Length = "0x8D")]
	[Token(Token = "0x6000FD0")]
	public static bool get_useVisibilityMesh() { }

	[Address(RVA = "0x2C8ABD0", Offset = "0x2C89FD0", Length = "0x58")]
	[Token(Token = "0x6000FD3")]
	public static void set_mirrorViewMode(int value) { }

	[Address(RVA = "0x2C8AC30", Offset = "0x2C8A030", Length = "0x96")]
	[Token(Token = "0x6000FCF")]
	public static void set_occlusionMeshScale(float value) { }

	[Address(RVA = "0x2C8ACD0", Offset = "0x2C8A0D0", Length = "0x3A5")]
	[Token(Token = "0x6000FD1")]
	public static void set_useVisibilityMesh(bool value) { }

}

