namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

[DefaultMember("Item")]
[Token(Token = "0x20002B5")]
public struct FixedAttachmentArray
{
	[Token(Token = "0x4000C3F")]
	public static FixedAttachmentArray<DataType> Empty; //Field offset: 0x0
	[Token(Token = "0x4000C40")]
	public const int MaxAttachments = 8; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C41")]
	private DataType a0; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C42")]
	private DataType a1; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C43")]
	private DataType a2; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C44")]
	private DataType a3; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C45")]
	private DataType a4; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C46")]
	private DataType a5; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C47")]
	private DataType a6; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C48")]
	private DataType a7; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C49")]
	private int activeAttachments; //Field offset: 0x0

	[Token(Token = "0x17000266")]
	public DataType Item
	{
		[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
		[Token(Token = "0x600134F")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000265")]
	public int size
	{
		[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
		[Token(Token = "0x600134C")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x1BC3810", Offset = "0x1BC2C10", Length = "0xDD")]
	[Token(Token = "0x6001350")]
	private static FixedAttachmentArray`1() { }

	[Address(RVA = "0x1BC4980", Offset = "0x1BC3D80", Length = "0x60")]
	[Token(Token = "0x6001349")]
	public FixedAttachmentArray`1(int numAttachments) { }

	[Address(RVA = "0x1BC5280", Offset = "0x1BC4680", Length = "0x17F")]
	[Token(Token = "0x600134A")]
	public FixedAttachmentArray`1(DataType[] attachments) { }

	[Address(RVA = "0x1BC49E0", Offset = "0x1BC3DE0", Length = "0x161")]
	[Token(Token = "0x600134B")]
	public FixedAttachmentArray`1(NativeArray<DataType> attachments) { }

	[Address(RVA = "0x1BC3750", Offset = "0x1BC2B50", Length = "0xF")]
	[Token(Token = "0x600134E")]
	public int Add(in DataType data) { }

	[Address(RVA = "0x1BC3770", Offset = "0x1BC2B70", Length = "0x8")]
	[Token(Token = "0x600134D")]
	public void Clear() { }

	[Address(RVA = "0x9D7570", Offset = "0x9D6970", Length = "0x8")]
	[Token(Token = "0x600134F")]
	public DataType get_Item(int index) { }

	[Address(RVA = "0xD8E9F0", Offset = "0xD8DDF0", Length = "0x4")]
	[Token(Token = "0x600134C")]
	public int get_size() { }

}

