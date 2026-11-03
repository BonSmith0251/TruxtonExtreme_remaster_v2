namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRMeshBuilder.bindings.h")]
[Token(Token = "0x20002A9")]
internal static class MeshBuilderNative
{
	[Token(Token = "0x20002AB")]
	internal struct NativeBorderParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A82")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A83")]
		public Color leftColor; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A84")]
		public Color topColor; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A85")]
		public Color rightColor; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A86")]
		public Color bottomColor; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A87")]
		public float leftWidth; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000A88")]
		public float topWidth; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A89")]
		public float rightWidth; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000A8A")]
		public float bottomWidth; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A8B")]
		public Vector2 topLeftRadius; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000A8C")]
		public Vector2 topRightRadius; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A8D")]
		public Vector2 bottomRightRadius; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000A8E")]
		public Vector2 bottomLeftRadius; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000A8F")]
		internal NativeColorPage leftColorPage; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000A90")]
		internal NativeColorPage topColorPage; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000A91")]
		internal NativeColorPage rightColorPage; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000A92")]
		internal NativeColorPage bottomColorPage; //Field offset: 0x98

	}

	[Token(Token = "0x20002AA")]
	internal struct NativeColorPage
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A80")]
		public int isValid; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000A81")]
		public Color32 pageAndID; //Field offset: 0x4

	}

	[Token(Token = "0x20002AC")]
	internal struct NativeRectParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A93")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A94")]
		public Rect subRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A95")]
		public Rect uv; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A96")]
		public Color color; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A97")]
		public ScaleMode scaleMode; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A98")]
		public IntPtr backgroundRepeatInstanceList; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A99")]
		public int backgroundRepeatInstanceListStartIndex; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000A9A")]
		public int backgroundRepeatInstanceListEndIndex; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A9B")]
		public Vector2 topLeftRadius; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A9C")]
		public Vector2 topRightRadius; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000A9D")]
		public Vector2 bottomRightRadius; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A9E")]
		public Vector2 bottomLeftRadius; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000A9F")]
		public Rect backgroundRepeatRect; //Field offset: 0x78
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000AA0")]
		public IntPtr texture; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000AA1")]
		public IntPtr sprite; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000AA2")]
		public IntPtr vectorImage; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000AA3")]
		public IntPtr spriteTexture; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000AA4")]
		public IntPtr spriteVertices; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000AA5")]
		public IntPtr spriteUVs; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000AA6")]
		public IntPtr spriteTriangles; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000AA7")]
		public Rect spriteGeomRect; //Field offset: 0xC0
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000AA8")]
		public Vector2 contentSize; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000AA9")]
		public Vector2 textureSize; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000AAA")]
		public float texturePixelsPerPoint; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE4")]
		[Token(Token = "0x4000AAB")]
		public int leftSlice; //Field offset: 0xE4
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4000AAC")]
		public int topSlice; //Field offset: 0xE8
		[FieldOffset(Offset = "0xEC")]
		[Token(Token = "0x4000AAD")]
		public int rightSlice; //Field offset: 0xEC
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4000AAE")]
		public int bottomSlice; //Field offset: 0xF0
		[FieldOffset(Offset = "0xF4")]
		[Token(Token = "0x4000AAF")]
		public float sliceScale; //Field offset: 0xF4
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4000AB0")]
		public Vector4 rectInset; //Field offset: 0xF8
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4000AB1")]
		public NativeColorPage colorPage; //Field offset: 0x108
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4000AB2")]
		public int meshFlags; //Field offset: 0x110

	}


	[Address(RVA = "0x3404D70", Offset = "0x3404170", Length = "0x51")]
	[ThreadSafe]
	[Token(Token = "0x6001262")]
	public static MeshWriteDataInterface MakeBorder(ref NativeBorderParams borderParams) { }

	[Address(RVA = "0x3404D20", Offset = "0x3404120", Length = "0x42")]
	[Token(Token = "0x6001267")]
	private static void MakeBorder_Injected(ref NativeBorderParams borderParams, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x3404E20", Offset = "0x3404220", Length = "0x51")]
	[ThreadSafe]
	[Token(Token = "0x6001263")]
	public static MeshWriteDataInterface MakeSolidRect(ref NativeRectParams rectParams) { }

	[Address(RVA = "0x3404DD0", Offset = "0x34041D0", Length = "0x42")]
	[Token(Token = "0x6001268")]
	private static void MakeSolidRect_Injected(ref NativeRectParams rectParams, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x3404ED0", Offset = "0x34042D0", Length = "0x51")]
	[ThreadSafe]
	[Token(Token = "0x6001264")]
	public static MeshWriteDataInterface MakeTexturedRect(ref NativeRectParams rectParams) { }

	[Address(RVA = "0x3404E80", Offset = "0x3404280", Length = "0x42")]
	[Token(Token = "0x6001269")]
	private static void MakeTexturedRect_Injected(ref NativeRectParams rectParams, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x3404FA0", Offset = "0x34043A0", Length = "0x1C2")]
	[ThreadSafe]
	[Token(Token = "0x6001266")]
	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage) { }

	[Address(RVA = "0x3404F30", Offset = "0x3404330", Length = "0x65")]
	[Token(Token = "0x600126B")]
	private static void MakeVectorGraphics9SliceBackground_Injected(ref ManagedSpanWrapper svgVertices, ref ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, in Rect targetRect, in Vector4 sliceLTRB, in Color tint, in NativeColorPage colorPage, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x34051E0", Offset = "0x34045E0", Length = "0x1CD")]
	[ThreadSafe]
	[Token(Token = "0x6001265")]
	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage) { }

	[Address(RVA = "0x3405170", Offset = "0x3404570", Length = "0x65")]
	[Token(Token = "0x600126A")]
	private static void MakeVectorGraphicsStretchBackground_Injected(ref ManagedSpanWrapper svgVertices, ref ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, in Rect targetRect, in Rect sourceUV, ScaleMode scaleMode, in Color tint, in NativeColorPage colorPage, out MeshWriteDataInterface ret) { }

}

