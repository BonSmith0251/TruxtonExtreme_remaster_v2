namespace UnityEngine.Rendering;

[Token(Token = "0x200001C")]
public abstract class CameraHistoryItem : ContextItem
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000089")]
	private BufferedRTHandleSystem m_owner; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400008A")]
	private uint m_TypeId; //Field offset: 0x18

	[Token(Token = "0x1700002A")]
	protected BufferedRTHandleSystem storage
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60000C3")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BBA540", Offset = "0x2BB9940", Length = "0xE")]
	[Token(Token = "0x60000CA")]
	protected CameraHistoryItem() { }

	[Address(RVA = "0x2BBA3C0", Offset = "0x2BB97C0", Length = "0x6F")]
	[Token(Token = "0x60000C5")]
	protected RTHandle AllocHistoryFrameRT(int id, int count, ref RenderTextureDescriptor desc, string name = "") { }

	[Address(RVA = "0x2BBA430", Offset = "0x2BB9830", Length = "0x72")]
	[Token(Token = "0x60000C6")]
	protected RTHandle AllocHistoryFrameRT(int id, int count, ref RenderTextureDescriptor desc, FilterMode filterMode, string name = "") { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60000C3")]
	protected BufferedRTHandleSystem get_storage() { }

	[Address(RVA = "0x2BBA4B0", Offset = "0x2BB98B0", Length = "0x21")]
	[Token(Token = "0x60000C9")]
	protected RTHandle GetCurrentFrameRT(int id) { }

	[Address(RVA = "0x2BBA4E0", Offset = "0x2BB98E0", Length = "0x24")]
	[Token(Token = "0x60000C8")]
	protected RTHandle GetPreviousFrameRT(int id) { }

	[Address(RVA = "0x2BBA510", Offset = "0x2BB9910", Length = "0xC")]
	[Token(Token = "0x60000C4")]
	protected int MakeId(uint index) { }

	[Address(RVA = "0x207ACB0", Offset = "0x207A0B0", Length = "0x2B")]
	[Token(Token = "0x60000C2")]
	public override void OnCreate(BufferedRTHandleSystem owner, uint typeId) { }

	[Address(RVA = "0x2BBA520", Offset = "0x2BB9920", Length = "0x1E")]
	[Token(Token = "0x60000C7")]
	protected void ReleaseHistoryFrameRT(int id) { }

}

