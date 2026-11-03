namespace UnityEngine.Rendering;

[Token(Token = "0x2000194")]
public class BufferedRTHandleSystem : IDisposable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40007C4")]
	private Dictionary<Int32, RTHandle[]> m_RTHandles; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40007C5")]
	private RTHandleSystem m_RTHandleSystem; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40007C6")]
	private bool m_DisposedValue; //Field offset: 0x20

	[Token(Token = "0x1700016F")]
	public int maxHeight
	{
		[Address(RVA = "0x2C44260", Offset = "0x2C43660", Length = "0x1A")]
		[Token(Token = "0x6000BB1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x1700016E")]
	public int maxWidth
	{
		[Address(RVA = "0x2C44280", Offset = "0x2C43680", Length = "0x1A")]
		[Token(Token = "0x6000BB0")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000170")]
	public RTHandleProperties rtHandleProperties
	{
		[Address(RVA = "0x2C442A0", Offset = "0x2C436A0", Length = "0x31")]
		[Token(Token = "0x6000BB2")]
		 get { } //Length: 49
	}

	[Address(RVA = "0x2C441B0", Offset = "0x2C435B0", Length = "0xAC")]
	[Token(Token = "0x6000BC0")]
	public BufferedRTHandleSystem() { }

	[Address(RVA = "0x2C43430", Offset = "0x2C42830", Length = "0x24F")]
	[Token(Token = "0x6000BB5")]
	public void AllocBuffer(int bufferId, Func<RTHandleSystem, Int32, RTHandle> allocator, int bufferCount) { }

	[Address(RVA = "0x2C43060", Offset = "0x2C42460", Length = "0x3C9")]
	[Token(Token = "0x6000BB6")]
	public void AllocBuffer(int bufferId, int bufferCount, ref RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	[Address(RVA = "0x2C43680", Offset = "0x2C42A80", Length = "0x37")]
	[Token(Token = "0x6000BBB")]
	public Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	[Address(RVA = "0x2C436C0", Offset = "0x2C42AC0", Length = "0x207")]
	[Token(Token = "0x6000BB4")]
	public void ClearBuffers(CommandBuffer cmd) { }

	[Address(RVA = "0x2C43920", Offset = "0x2C42D20", Length = "0x4B")]
	[Token(Token = "0x6000BBE")]
	public override void Dispose() { }

	[Address(RVA = "0x2C438D0", Offset = "0x2C42CD0", Length = "0x4F")]
	[Token(Token = "0x6000BBD")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x2C44260", Offset = "0x2C43660", Length = "0x1A")]
	[Token(Token = "0x6000BB1")]
	public int get_maxHeight() { }

	[Address(RVA = "0x2C44280", Offset = "0x2C43680", Length = "0x1A")]
	[Token(Token = "0x6000BB0")]
	public int get_maxWidth() { }

	[Address(RVA = "0x2C442A0", Offset = "0x2C436A0", Length = "0x31")]
	[Token(Token = "0x6000BB2")]
	public RTHandleProperties get_rtHandleProperties() { }

	[Address(RVA = "0x2C43970", Offset = "0x2C42D70", Length = "0xAD")]
	[Token(Token = "0x6000BB3")]
	public RTHandle GetFrameRT(int bufferId, int frameIndex) { }

	[Address(RVA = "0x2C43A20", Offset = "0x2C42E20", Length = "0x8E")]
	[Token(Token = "0x6000BBA")]
	public int GetNumFramesAllocated(int bufferId) { }

	[Address(RVA = "0x2C43AB0", Offset = "0x2C42EB0", Length = "0x1D7")]
	[Token(Token = "0x6000BBF")]
	public void ReleaseAll() { }

	[Address(RVA = "0x2C43C90", Offset = "0x2C43090", Length = "0xDE")]
	[Token(Token = "0x6000BB7")]
	public void ReleaseBuffer(int bufferId) { }

	[Address(RVA = "0x2C43D70", Offset = "0x2C43170", Length = "0x2F")]
	[Token(Token = "0x6000BB9")]
	public void ResetReferenceSize(int width, int height) { }

	[Address(RVA = "0x2C43E00", Offset = "0x2C43200", Length = "0x3A9")]
	[Token(Token = "0x6000BBC")]
	private void Swap() { }

	[Address(RVA = "0x2C43DA0", Offset = "0x2C431A0", Length = "0x52")]
	[Token(Token = "0x6000BB8")]
	public void SwapAndSetReferenceSize(int width, int height) { }

}

