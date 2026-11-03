namespace AEAsAnimation;

[Token(Token = "0x2000036")]
public class AELayerReflection : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000039")]
	private sealed class <>c
	{
		[Token(Token = "0x4000178")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000179")]
		public static Action<Component, Color> <>9__29_1; //Field offset: 0x8
		[Token(Token = "0x400017A")]
		public static Func<Component, Vector2> <>9__29_2; //Field offset: 0x10

		[Address(RVA = "0x5C1400", Offset = "0x5C0800", Length = "0x67")]
		[Token(Token = "0x60000F3")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000F4")]
		public <>c() { }

		[Address(RVA = "0x5C0090", Offset = "0x5BF490", Length = "0xDF")]
		[Token(Token = "0x60000F5")]
		internal void <CreateTextReflector>b__29_1(Component component, Color color) { }

		[Address(RVA = "0x5AA690", Offset = "0x5A9A90", Length = "0x2EB")]
		[Token(Token = "0x60000F6")]
		internal Vector2 <CreateTextReflector>b__29_2(Component component) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003A")]
	private sealed class <>c__DisplayClass14_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400017B")]
		public Action<AELayerReflection> callback; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000F7")]
		public <>c__DisplayClass14_0() { }

		[Address(RVA = "0x5C02B0", Offset = "0x5BF6B0", Length = "0x25")]
		[Token(Token = "0x60000F8")]
		internal void <AttachAsync>b__0(AELayerReflection reflection) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003B")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400017C")]
		public bool isStop; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400017D")]
		public AELayerReflection <>4__this; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400017E")]
		public AELayerReflector reflector; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000F9")]
		public <>c__DisplayClass17_0() { }

		[Address(RVA = "0x5C02E0", Offset = "0x5BF6E0", Length = "0x752")]
		[Token(Token = "0x60000FA")]
		internal void <SetUpEvents>b__0(TransformData transformData) { }

		[Address(RVA = "0x5C0A40", Offset = "0x5BFE40", Length = "0xFA")]
		[Token(Token = "0x60000FB")]
		internal void <SetUpEvents>b__1(ColorData colorData) { }

		[Address(RVA = "0x5C0B40", Offset = "0x5BFF40", Length = "0x250")]
		[Token(Token = "0x60000FC")]
		internal void <SetUpEvents>b__2(MaskData maskData) { }

		[Address(RVA = "0x5C0DA0", Offset = "0x5C01A0", Length = "0x9C")]
		[Token(Token = "0x60000FD")]
		internal void <SetUpEvents>b__3(FootageData footageData) { }

		[Address(RVA = "0x5C0E40", Offset = "0x5C0240", Length = "0x112")]
		[Token(Token = "0x60000FE")]
		internal void <SetUpEvents>b__4(FrameCommandData commandData) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003C")]
	private sealed class <AttachAsync>d__14 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400017F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000180")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000181")]
		public Action<AELayerReflection> callback; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000182")]
		public AELayerReflector reflector; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000183")]
		public Transform parent; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000184")]
		public TextReflector textReflector; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000185")]
		public Stopwatch stopWatch; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000186")]
		private IEnumerator <enumerator>5__2; //Field offset: 0x48

		[Token(Token = "0x1700002C")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000102")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700002D")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000104")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x60000FF")]
		public <AttachAsync>d__14(int <>1__state) { }

		[Address(RVA = "0x5BC970", Offset = "0x5BBD70", Length = "0x3EE")]
		[Token(Token = "0x6000101")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000102")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000104")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5BCD70", Offset = "0x5BC170", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000103")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000100")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003D")]
	private sealed class <SetUpAsync>d__16 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000187")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000188")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000189")]
		public AELayerReflection <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400018A")]
		public AELayerReflector reflector; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400018B")]
		public Stopwatch stopWatch; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400018C")]
		public TextReflector textReflector; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400018D")]
		public Action<AELayerReflection> callback; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400018E")]
		private IEnumerator <enumerator>5__2; //Field offset: 0x48

		[Token(Token = "0x1700002E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000108")]
			private get { } //Length: 5
		}

		[Token(Token = "0x1700002F")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600010A")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x6000105")]
		public <SetUpAsync>d__16(int <>1__state) { }

		[Address(RVA = "0x5BEFA0", Offset = "0x5BE3A0", Length = "0x268")]
		[Token(Token = "0x6000107")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000108")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600010A")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5BF5E0", Offset = "0x5BE9E0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000109")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x6000106")]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x200003E")]
	private sealed class <SetUpChildAsync>d__25 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400018F")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000190")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000191")]
		public AELayerReflection <>4__this; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000192")]
		public MetaData metaData; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000193")]
		public Stopwatch stopWatch; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000194")]
		private IEnumerator <enumerator>5__2; //Field offset: 0x38

		[Token(Token = "0x17000030")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x600010E")]
			private get { } //Length: 5
		}

		[Token(Token = "0x17000031")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000110")]
			private get { } //Length: 5
		}

		[Address(RVA = "0x5BCDC0", Offset = "0x5BC1C0", Length = "0x24")]
		[DebuggerHidden]
		[Token(Token = "0x600010B")]
		public <SetUpChildAsync>d__25(int <>1__state) { }

		[Address(RVA = "0x5BF620", Offset = "0x5BEA20", Length = "0x1DC")]
		[Token(Token = "0x600010D")]
		private override bool MoveNext() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x600010E")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000110")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x5BF800", Offset = "0x5BEC00", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x600010F")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[DebuggerHidden]
		[Token(Token = "0x600010C")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x2000037")]
	private class AEMaskObject
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000171")]
		public AEMaskProcessor _maskData; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000172")]
		public GameObject _maskNode; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000173")]
		public AEShapeImage _maskImage; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000174")]
		public AELineImage _maskLine; //Field offset: 0x28

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000F1")]
		public AEMaskObject() { }

	}

	[Token(Token = "0x2000038")]
	internal class TextReflector
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000175")]
		public Func0<GameObject, String, Int32, Int32, Color, String, String, AVLayerStyleStrokeData, Rect, Component> Setup; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000176")]
		public Action<Component, Color> UpdateColor; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000177")]
		public Func<Component, Vector2> GetPreferredSize; //Field offset: 0x20

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60000F2")]
		public TextReflector() { }

	}

	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000166")]
	private AELayerReflector _reflector; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000167")]
	private AEMaterial _material; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000168")]
	private Image _image; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000169")]
	private AEComposition _childComposition; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400016A")]
	private GameObject _footage; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400016B")]
	private GameObject _maskNode; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400016C")]
	private List<AEMaskObject> _maskObjects; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400016D")]
	private GameObject _maskEnd; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x400016E")]
	private bool _defaultMask; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400016F")]
	private TextReflector _textReflector; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000170")]
	private Component _text; //Field offset: 0x70

	[Token(Token = "0x17000029")]
	public List<String> allImageFiles
	{
		[Address(RVA = "0x5B7920", Offset = "0x5B6D20", Length = "0xB6")]
		[Token(Token = "0x60000E5")]
		 get { } //Length: 182
	}

	[Token(Token = "0x1700002B")]
	public List<String> allLayerMetaData
	{
		[Address(RVA = "0x5B79E0", Offset = "0x5B6DE0", Length = "0xB6")]
		[Token(Token = "0x60000E7")]
		 get { } //Length: 182
	}

	[Token(Token = "0x1700002A")]
	public List<String> allLayerNames
	{
		[Address(RVA = "0x5B7AA0", Offset = "0x5B6EA0", Length = "0xB6")]
		[Token(Token = "0x60000E6")]
		 get { } //Length: 182
	}

	[Address(RVA = "0x5B7910", Offset = "0x5B6D10", Length = "0x7")]
	[Token(Token = "0x60000EE")]
	public AELayerReflection() { }

	[Address(RVA = "0x5B7730", Offset = "0x5B6B30", Length = "0x1C2")]
	[CompilerGenerated]
	[Token(Token = "0x60000F0")]
	private Component <CreateTextReflector>b__29_0(GameObject target, string fontName, int size, int line, Color color, string textData, string textId, AVLayerStyleStrokeData stroke, Rect boxRect) { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x60000EF")]
	private void <SetUpChildAsync>b__25_0(AEComposition aeComposition) { }

	[Address(RVA = "0x5B4330", Offset = "0x5B3730", Length = "0x34B")]
	[Token(Token = "0x60000EB")]
	private Image AddImage(Sprite sprite, GameObject target) { }

	[Address(RVA = "0x5B4680", Offset = "0x5B3A80", Length = "0x2DE")]
	[Token(Token = "0x60000EC")]
	private Component AddText(string fontName, int size, int line, Color color, string textData, string textId, AVLayerStyleStrokeData stroke, Rect textRect, GameObject target, TextReflector textReflector) { }

	[Address(RVA = "0x5B4A40", Offset = "0x5B3E40", Length = "0x1F0")]
	[Token(Token = "0x60000E0")]
	public static AELayerReflection Attach(Transform parent, AELayerReflector reflector, TextReflector textReflector) { }

	[Address(RVA = "0x5B4960", Offset = "0x5B3D60", Length = "0xD2")]
	[IteratorStateMachine(typeof(<AttachAsync>d__14))]
	[Token(Token = "0x60000E1")]
	public static IEnumerator AttachAsync(Transform parent, AELayerReflector reflector, TextReflector textReflector, Action<AELayerReflection> callback, Stopwatch stopWatch) { }

	[Address(RVA = "0x5B4C40", Offset = "0x5B4040", Length = "0x244")]
	[Token(Token = "0x60000ED")]
	private TextReflector CreateTextReflector() { }

	[Address(RVA = "0x5B7920", Offset = "0x5B6D20", Length = "0xB6")]
	[Token(Token = "0x60000E5")]
	public List<String> get_allImageFiles() { }

	[Address(RVA = "0x5B79E0", Offset = "0x5B6DE0", Length = "0xB6")]
	[Token(Token = "0x60000E7")]
	public List<String> get_allLayerMetaData() { }

	[Address(RVA = "0x5B7AA0", Offset = "0x5B6EA0", Length = "0xB6")]
	[Token(Token = "0x60000E6")]
	public List<String> get_allLayerNames() { }

	[Address(RVA = "0x5B72A0", Offset = "0x5B66A0", Length = "0x464")]
	[Token(Token = "0x60000E2")]
	public AELayerReflection SetUp(AELayerReflector reflector, TextReflector textReflector) { }

	[Address(RVA = "0x5B4E90", Offset = "0x5B4290", Length = "0xD2")]
	[IteratorStateMachine(typeof(<SetUpAsync>d__16))]
	[Token(Token = "0x60000E3")]
	public IEnumerator SetUpAsync(AELayerReflector reflector, TextReflector textReflector, Action<AELayerReflection> callback, Stopwatch stopWatch) { }

	[Address(RVA = "0x5B5020", Offset = "0x5B4420", Length = "0x6C")]
	[Token(Token = "0x60000E8")]
	private void SetUpChild(MetaData metaData) { }

	[Address(RVA = "0x5B4F70", Offset = "0x5B4370", Length = "0xA1")]
	[IteratorStateMachine(typeof(<SetUpChildAsync>d__25))]
	[Token(Token = "0x60000E9")]
	private IEnumerator SetUpChildAsync(MetaData metaData, Stopwatch stopWatch) { }

	[Address(RVA = "0x5B5090", Offset = "0x5B4490", Length = "0x259")]
	[Token(Token = "0x60000E4")]
	private AELayerReflection SetUpEvents(AELayerReflector reflector) { }

	[Address(RVA = "0x5B52F0", Offset = "0x5B46F0", Length = "0x1FA5")]
	[Token(Token = "0x60000EA")]
	private void SetUpMask(MaskData maskData) { }

}

