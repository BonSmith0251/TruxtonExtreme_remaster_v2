namespace UnityEngine.Rendering.UI;

[Token(Token = "0x20002D5")]
public class DebugUIHandlerContainer : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20002D6")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D2F")]
		public DebugUIHandlerWidget widget; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600140F")]
		public <>c__DisplayClass3_0() { }

		[Address(RVA = "0x2CBFA30", Offset = "0x2CBEE30", Length = "0x5D")]
		[Token(Token = "0x6001410")]
		internal bool <IsDirectChild>b__0(DebugUIHandlerWidget x) { }

	}

	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000D2E")]
	public RectTransform contentHolder; //Field offset: 0x20

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x600140E")]
	public DebugUIHandlerContainer() { }

	[Address(RVA = "0x2CB0150", Offset = "0x2CAF550", Length = "0x2CA")]
	[Token(Token = "0x600140D")]
	private List<DebugUIHandlerWidget> GetActiveChildren() { }

	[Address(RVA = "0x2CB0420", Offset = "0x2CAF820", Length = "0x7D")]
	[Token(Token = "0x600140A")]
	internal DebugUIHandlerWidget GetFirstItem() { }

	[Address(RVA = "0x2CB04A0", Offset = "0x2CAF8A0", Length = "0x80")]
	[Token(Token = "0x600140B")]
	internal DebugUIHandlerWidget GetLastItem() { }

	[Address(RVA = "0x2CB0530", Offset = "0x2CAF930", Length = "0x10A")]
	[Token(Token = "0x600140C")]
	internal bool IsDirectChild(DebugUIHandlerWidget widget) { }

}

