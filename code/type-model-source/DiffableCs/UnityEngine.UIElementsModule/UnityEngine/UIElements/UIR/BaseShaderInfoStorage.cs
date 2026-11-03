namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005D6")]
internal abstract class BaseShaderInfoStorage : IDisposable
{
	[Token(Token = "0x400152F")]
	protected static int s_TextureCounter; //Field offset: 0x0
	[Token(Token = "0x4001530")]
	internal static ProfilerMarker s_MarkerCopyTexture; //Field offset: 0x8
	[Token(Token = "0x4001531")]
	internal static ProfilerMarker s_MarkerGetTextureData; //Field offset: 0x10
	[Token(Token = "0x4001532")]
	internal static ProfilerMarker s_MarkerUpdateTexture; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001533")]
	private bool <disposed>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x17000A88")]
	protected private bool disposed
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002A0E")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002A0F")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000A87")]
	public abstract Texture2D texture
	{
		[Token(Token = "0x6002A0A")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x33171F0", Offset = "0x33165F0", Length = "0xD3")]
	[Token(Token = "0x6002A13")]
	private static BaseShaderInfoStorage() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002A12")]
	protected BaseShaderInfoStorage() { }

	[Token(Token = "0x6002A0B")]
	public abstract bool AllocateRect(int width, int height, out RectInt uvs) { }

	[Address(RVA = "0x3317180", Offset = "0x3316580", Length = "0x61")]
	[Token(Token = "0x6002A10")]
	public override void Dispose() { }

	[Address(RVA = "0x3317170", Offset = "0x3316570", Length = "0xB")]
	[Token(Token = "0x6002A11")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002A0E")]
	protected bool get_disposed() { }

	[Token(Token = "0x6002A0A")]
	public abstract Texture2D get_texture() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002A0F")]
	private void set_disposed(bool value) { }

	[Token(Token = "0x6002A0C")]
	public abstract void SetTexel(int x, int y, Color color) { }

	[Token(Token = "0x6002A0D")]
	public abstract void UpdateTexture() { }

}

