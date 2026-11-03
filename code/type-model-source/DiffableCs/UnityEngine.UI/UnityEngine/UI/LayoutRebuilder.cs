namespace UnityEngine.UI;

[Token(Token = "0x2000050")]
public class LayoutRebuilder : ICanvasElement
{
	[CompilerGenerated]
	[Token(Token = "0x2000051")]
	private sealed class <>c
	{
		[Token(Token = "0x4000189")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400018A")]
		public static Predicate<Component> <>9__10_0; //Field offset: 0x8
		[Token(Token = "0x400018B")]
		public static UnityAction<Component> <>9__12_0; //Field offset: 0x10
		[Token(Token = "0x400018C")]
		public static UnityAction<Component> <>9__12_1; //Field offset: 0x18
		[Token(Token = "0x400018D")]
		public static UnityAction<Component> <>9__12_2; //Field offset: 0x20
		[Token(Token = "0x400018E")]
		public static UnityAction<Component> <>9__12_3; //Field offset: 0x28

		[Address(RVA = "0x344A5E0", Offset = "0x34499E0", Length = "0x67")]
		[Token(Token = "0x600031B")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600031C")]
		public <>c() { }

		[Address(RVA = "0x344A4E0", Offset = "0x34498E0", Length = "0x44")]
		[Token(Token = "0x600031D")]
		internal LayoutRebuilder <.cctor>b__5_0() { }

		[Address(RVA = "0x344A530", Offset = "0x3449930", Length = "0x33")]
		[Token(Token = "0x600031E")]
		internal void <.cctor>b__5_1(LayoutRebuilder x) { }

		[Address(RVA = "0x344A280", Offset = "0x3449680", Length = "0x63")]
		[Token(Token = "0x6000320")]
		internal void <Rebuild>b__12_0(Component e) { }

		[Address(RVA = "0x344A2F0", Offset = "0x34496F0", Length = "0x63")]
		[Token(Token = "0x6000321")]
		internal void <Rebuild>b__12_1(Component e) { }

		[Address(RVA = "0x344A360", Offset = "0x3449760", Length = "0x66")]
		[Token(Token = "0x6000322")]
		internal void <Rebuild>b__12_2(Component e) { }

		[Address(RVA = "0x344A3D0", Offset = "0x34497D0", Length = "0x66")]
		[Token(Token = "0x6000323")]
		internal void <Rebuild>b__12_3(Component e) { }

		[Address(RVA = "0x344A440", Offset = "0x3449840", Length = "0x98")]
		[Token(Token = "0x600031F")]
		internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	}

	[Token(Token = "0x4000188")]
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000186")]
	private RectTransform m_ToRebuild; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000187")]
	private int m_CachedHashFromTransform; //Field offset: 0x18

	[Token(Token = "0x170000D5")]
	public override Transform transform
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x600030B")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3445940", Offset = "0x3444D40", Length = "0x1C6")]
	[Token(Token = "0x6000309")]
	private static LayoutRebuilder() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600031A")]
	public LayoutRebuilder() { }

	[Address(RVA = "0x34442A0", Offset = "0x34436A0", Length = "0x29")]
	[Token(Token = "0x6000308")]
	private void Clear() { }

	[Address(RVA = "0x34442D0", Offset = "0x34436D0", Length = "0x5A")]
	[Token(Token = "0x6000318")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x3444330", Offset = "0x3443730", Length = "0xFB")]
	[Token(Token = "0x600030E")]
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x600030B")]
	public override Transform get_transform() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x6000317")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000316")]
	public override void GraphicUpdateComplete() { }

	[Address(RVA = "0x3444430", Offset = "0x3443830", Length = "0x4B")]
	[Token(Token = "0x6000307")]
	private void Initialize(RectTransform controller) { }

	[Address(RVA = "0x3444480", Offset = "0x3443880", Length = "0x50")]
	[Token(Token = "0x600030C")]
	public override bool IsDestroyed() { }

	[Address(RVA = "0x34444D0", Offset = "0x34438D0", Length = "0x78")]
	[Token(Token = "0x6000315")]
	public override void LayoutComplete() { }

	[Address(RVA = "0x3444550", Offset = "0x3443950", Length = "0x519")]
	[Token(Token = "0x6000312")]
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	[Address(RVA = "0x3444A70", Offset = "0x3443E70", Length = "0x171")]
	[Token(Token = "0x6000314")]
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	[Address(RVA = "0x3444BF0", Offset = "0x3443FF0", Length = "0x270")]
	[Token(Token = "0x6000311")]
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	[Address(RVA = "0x3444E70", Offset = "0x3444270", Length = "0x3A2")]
	[Token(Token = "0x6000310")]
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	[Address(RVA = "0x3445220", Offset = "0x3444620", Length = "0x49")]
	[Token(Token = "0x600030A")]
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	[Address(RVA = "0x3445270", Offset = "0x3444670", Length = "0x34B")]
	[Token(Token = "0x600030F")]
	public override void Rebuild(CanvasUpdate executing) { }

	[Address(RVA = "0x34455C0", Offset = "0x34449C0", Length = "0x117")]
	[Token(Token = "0x600030D")]
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	[Address(RVA = "0x34456E0", Offset = "0x3444AE0", Length = "0x5F")]
	[Token(Token = "0x6000319")]
	public virtual string ToString() { }

	[Address(RVA = "0x3445740", Offset = "0x3444B40", Length = "0x1F3")]
	[Token(Token = "0x6000313")]
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

}

