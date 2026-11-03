namespace UnityEngine.Rendering.Universal;

[Token(Token = "0x20000DC")]
public abstract class UniversalResourceDataBase : ContextItem
{
	[Token(Token = "0x20000DD")]
	public enum ActiveID : int
	{
		Camera = 0,
		BackBuffer = 1,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000502")]
	private bool <isAccessible>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000196")]
	internal bool isAccessible
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60005CB")]
		internal get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60005CC")]
		internal set { } //Length: 4
	}

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60005D4")]
	protected UniversalResourceDataBase() { }

	[Address(RVA = "0x2DA3EC0", Offset = "0x2DA32C0", Length = "0xFD")]
	[Token(Token = "0x60005D0")]
	protected TextureHandle CheckAndGetTextureHandle(ref TextureHandle handle) { }

	[Address(RVA = "0x2DA3D80", Offset = "0x2DA3180", Length = "0x130")]
	[Token(Token = "0x60005D2")]
	protected TextureHandle[] CheckAndGetTextureHandle(ref TextureHandle[] handle) { }

	[Address(RVA = "0x2DA3FC0", Offset = "0x2DA33C0", Length = "0x85")]
	[Token(Token = "0x60005CF")]
	protected void CheckAndSetTextureHandle(ref TextureHandle handle, TextureHandle newHandle) { }

	[Address(RVA = "0x2DA4050", Offset = "0x2DA3450", Length = "0x112")]
	[Token(Token = "0x60005D1")]
	protected void CheckAndSetTextureHandle(ref TextureHandle[] handle, TextureHandle[] newHandle) { }

	[Address(RVA = "0x2DA4170", Offset = "0x2DA3570", Length = "0x64")]
	[Token(Token = "0x60005D3")]
	protected bool CheckAndWarnAboutAccessibility() { }

	[Address(RVA = "0x2170560", Offset = "0x216F960", Length = "0x5")]
	[Token(Token = "0x60005CE")]
	internal void EndFrame() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x60005CB")]
	internal bool get_isAccessible() { }

	[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
	[Token(Token = "0x60005CD")]
	internal void InitFrame() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x60005CC")]
	internal void set_isAccessible(bool value) { }

}

