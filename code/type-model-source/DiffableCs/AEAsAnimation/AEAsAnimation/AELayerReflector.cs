namespace AEAsAnimation;

[Token(Token = "0x200003F")]
public class AELayerReflector
{
	[Token(Token = "0x2000041")]
	internal class ColorData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A1")]
		public Color color; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000123")]
		public ColorData() { }

	}

	[Token(Token = "0x2000048")]
	internal sealed class ColorDataEvent : MulticastDelegate
	{

		[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
		[Token(Token = "0x600012C")]
		public ColorDataEvent(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x600012E")]
		public override IAsyncResult BeginInvoke(ColorData data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600012F")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x600012D")]
		public override void Invoke(ColorData data) { }

	}

	[Token(Token = "0x2000043")]
	internal class FootageData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A7")]
		public Sprite sprite; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000125")]
		public FootageData() { }

	}

	[Token(Token = "0x200004A")]
	internal sealed class FootageDataEvent : MulticastDelegate
	{

		[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
		[Token(Token = "0x6000134")]
		public FootageDataEvent(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6000136")]
		public override IAsyncResult BeginInvoke(FootageData data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000137")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000135")]
		public override void Invoke(FootageData data) { }

	}

	[Token(Token = "0x2000045")]
	internal class FrameCommandData
	{
		[Token(Token = "0x2000046")]
		internal enum Type : int
		{
			None = 0,
			GotoFrame = 1,
			Restart = 2,
			Loop = 3,
			Stop = 4,
			Play = 5,
			Activate = 6,
			Deactivate = 7,
		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001B8")]
		public Type command; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001B9")]
		public int gotoFrame; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001BA")]
		public int periodFrame; //Field offset: 0x18
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x40001BB")]
		public int loopFrom; //Field offset: 0x1C
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001BC")]
		public int loopTo; //Field offset: 0x20

		[Address(RVA = "0x5C4970", Offset = "0x5C3D70", Length = "0x17")]
		[Token(Token = "0x6000127")]
		public FrameCommandData() { }

	}

	[Token(Token = "0x200004B")]
	internal sealed class FrameCommandDataEvent : MulticastDelegate
	{

		[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
		[Token(Token = "0x6000138")]
		public FrameCommandDataEvent(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x600013A")]
		public override IAsyncResult BeginInvoke(FrameCommandData data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600013B")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000139")]
		public override void Invoke(FrameCommandData data) { }

	}

	[Token(Token = "0x2000042")]
	internal class MaskData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A2")]
		public float width; //Field offset: 0x10
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x40001A3")]
		public float height; //Field offset: 0x14
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A4")]
		public List<AEMaskProcessor> masks; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001A5")]
		public int depth; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001A6")]
		public AVLayerStyleStrokeData stroke; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000124")]
		public MaskData() { }

	}

	[Token(Token = "0x2000049")]
	internal sealed class MaskDataEvent : MulticastDelegate
	{

		[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
		[Token(Token = "0x6000130")]
		public MaskDataEvent(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x6000132")]
		public override IAsyncResult BeginInvoke(MaskData data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x6000133")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000131")]
		public override void Invoke(MaskData data) { }

	}

	[Token(Token = "0x2000044")]
	internal class MetaData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40001A8")]
		public string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x40001A9")]
		public AEItemsAccessor accessor; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40001AA")]
		public AELayer layer; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40001AB")]
		public AEFootage footage; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x40001AC")]
		public string textData; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x40001AD")]
		public string textId; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40001AE")]
		public string textFont; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001AF")]
		public int textSize; //Field offset: 0x48
		[FieldOffset(Offset = "0x4C")]
		[Token(Token = "0x40001B0")]
		public int textLineSpace; //Field offset: 0x4C
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40001B1")]
		public Color textColor; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x40001B2")]
		public Rect textRect; //Field offset: 0x60
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x40001B3")]
		public CompositionData child; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x40001B4")]
		public AVLayerBlendingMode blendMode; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x40001B5")]
		public AVLayerStyleStrokeData stroke; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x40001B6")]
		public bool compositionEnable; //Field offset: 0x88
		[FieldOffset(Offset = "0x89")]
		[Token(Token = "0x40001B7")]
		public bool layerEnable; //Field offset: 0x89

		[Address(RVA = "0x5C4C80", Offset = "0x5C4080", Length = "0x113")]
		[Token(Token = "0x6000126")]
		public MetaData() { }

	}

	[Token(Token = "0x2000040")]
	internal class TransformData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400019B")]
		public Vector3 position; //Field offset: 0x10
		[FieldOffset(Offset = "0x1C")]
		[Token(Token = "0x400019C")]
		public Vector3 scale; //Field offset: 0x1C
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400019D")]
		public Quaternion rotation; //Field offset: 0x28
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400019E")]
		public Vector2 size; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400019F")]
		public Vector2 pivot; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40001A0")]
		public Vector2 anchor; //Field offset: 0x48

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000122")]
		public TransformData() { }

	}

	[Token(Token = "0x2000047")]
	internal sealed class TransformDataEvent : MulticastDelegate
	{

		[Address(RVA = "0x5C4330", Offset = "0x5C3730", Length = "0x124")]
		[Token(Token = "0x6000128")]
		public TransformDataEvent(object object, IntPtr method) { }

		[Address(RVA = "0x5BC6A0", Offset = "0x5BBAA0", Length = "0x21")]
		[Token(Token = "0x600012A")]
		public override IAsyncResult BeginInvoke(TransformData data, AsyncCallback callback, object object) { }

		[Address(RVA = "0x5BC6D0", Offset = "0x5BBAD0", Length = "0xA")]
		[Token(Token = "0x600012B")]
		public override void EndInvoke(IAsyncResult result) { }

		[Address(RVA = "0x5BC6E0", Offset = "0x5BBAE0", Length = "0xF")]
		[Token(Token = "0x6000129")]
		public override void Invoke(TransformData data) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000195")]
	private TransformDataEvent OnTransformUpdated; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000196")]
	private ColorDataEvent OnColorUpdated; //Field offset: 0x18
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000197")]
	private MaskDataEvent OnMaskUpdated; //Field offset: 0x20
	[CompilerGenerated]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000198")]
	private FootageDataEvent OnFootageUpdated; //Field offset: 0x28
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000199")]
	private FrameCommandDataEvent OnFrameCommandOrdered; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400019A")]
	private MetaData _metaData; //Field offset: 0x38

	[Token(Token = "0x14000003")]
	public event ColorDataEvent OnColorUpdated
	{
		[Address(RVA = "0x5C17D0", Offset = "0x5C0BD0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000113")]
		 add { } //Length: 158
		[Address(RVA = "0x5C1AF0", Offset = "0x5C0EF0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000114")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000005")]
	public event FootageDataEvent OnFootageUpdated
	{
		[Address(RVA = "0x5C1870", Offset = "0x5C0C70", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000117")]
		 add { } //Length: 158
		[Address(RVA = "0x5C1B90", Offset = "0x5C0F90", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000118")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000006")]
	public event FrameCommandDataEvent OnFrameCommandOrdered
	{
		[Address(RVA = "0x5C1910", Offset = "0x5C0D10", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000119")]
		 add { } //Length: 158
		[Address(RVA = "0x5C1C30", Offset = "0x5C1030", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x600011A")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000004")]
	public event MaskDataEvent OnMaskUpdated
	{
		[Address(RVA = "0x5C19B0", Offset = "0x5C0DB0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000115")]
		 add { } //Length: 158
		[Address(RVA = "0x5C1CD0", Offset = "0x5C10D0", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000116")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x14000002")]
	public event TransformDataEvent OnTransformUpdated
	{
		[Address(RVA = "0x5C1A50", Offset = "0x5C0E50", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000111")]
		 add { } //Length: 158
		[Address(RVA = "0x5C1D70", Offset = "0x5C1170", Length = "0x9E")]
		[CompilerGenerated]
		[Token(Token = "0x6000112")]
		 remove { } //Length: 158
	}

	[Token(Token = "0x17000032")]
	public MetaData metaData
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x6000121")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x5C1790", Offset = "0x5C0B90", Length = "0x31")]
	[Token(Token = "0x600011B")]
	public AELayerReflector(MetaData data) { }

	[Address(RVA = "0x5C17D0", Offset = "0x5C0BD0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000113")]
	public void add_OnColorUpdated(ColorDataEvent value) { }

	[Address(RVA = "0x5C1870", Offset = "0x5C0C70", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000117")]
	public void add_OnFootageUpdated(FootageDataEvent value) { }

	[Address(RVA = "0x5C1910", Offset = "0x5C0D10", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000119")]
	public void add_OnFrameCommandOrdered(FrameCommandDataEvent value) { }

	[Address(RVA = "0x5C19B0", Offset = "0x5C0DB0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000115")]
	public void add_OnMaskUpdated(MaskDataEvent value) { }

	[Address(RVA = "0x5C1A50", Offset = "0x5C0E50", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000111")]
	public void add_OnTransformUpdated(TransformDataEvent value) { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x6000121")]
	public MetaData get_metaData() { }

	[Address(RVA = "0x5C16F0", Offset = "0x5C0AF0", Length = "0x1B")]
	[Token(Token = "0x6000120")]
	public void OrderFrameCommand(FrameCommandData data) { }

	[Address(RVA = "0x5C1AF0", Offset = "0x5C0EF0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000114")]
	public void remove_OnColorUpdated(ColorDataEvent value) { }

	[Address(RVA = "0x5C1B90", Offset = "0x5C0F90", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000118")]
	public void remove_OnFootageUpdated(FootageDataEvent value) { }

	[Address(RVA = "0x5C1C30", Offset = "0x5C1030", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x600011A")]
	public void remove_OnFrameCommandOrdered(FrameCommandDataEvent value) { }

	[Address(RVA = "0x5C1CD0", Offset = "0x5C10D0", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000116")]
	public void remove_OnMaskUpdated(MaskDataEvent value) { }

	[Address(RVA = "0x5C1D70", Offset = "0x5C1170", Length = "0x9E")]
	[CompilerGenerated]
	[Token(Token = "0x6000112")]
	public void remove_OnTransformUpdated(TransformDataEvent value) { }

	[Address(RVA = "0x5C1710", Offset = "0x5C0B10", Length = "0x1B")]
	[Token(Token = "0x600011D")]
	public void UpdateColor(ColorData data) { }

	[Address(RVA = "0x5C1730", Offset = "0x5C0B30", Length = "0x1B")]
	[Token(Token = "0x600011F")]
	public void UpdateFootage(FootageData data) { }

	[Address(RVA = "0x5C1750", Offset = "0x5C0B50", Length = "0x1B")]
	[Token(Token = "0x600011E")]
	public void UpdateMask(MaskData data) { }

	[Address(RVA = "0x5C1770", Offset = "0x5C0B70", Length = "0x1B")]
	[Token(Token = "0x600011C")]
	public void UpdateTransform(TransformData data) { }

}

