namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x20005AE")]
internal interface IMeshGenerator
{

	[Token(Token = "0x17000A4F")]
	public VisualElement currentElement
	{
		[Token(Token = "0x60028E3")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000A50")]
	public TextJobSystem textJobSystem
	{
		[Token(Token = "0x60028E4")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60028E8")]
	public void DrawBorder(BorderParams borderParams) { }

	[Token(Token = "0x60028E7")]
	public void DrawRectangle(RectangleParams rectParams) { }

	[Token(Token = "0x60028E9")]
	public void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[Token(Token = "0x60028E5")]
	public void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<Single> sdfScales) { }

	[Token(Token = "0x60028E6")]
	public void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	[Token(Token = "0x60028E4")]
	public TextJobSystem get_textJobSystem() { }

	[Token(Token = "0x60028EA")]
	public void ScheduleJobs(MeshGenerationContext mgc) { }

	[Token(Token = "0x60028E3")]
	public void set_currentElement(VisualElement value) { }

}

