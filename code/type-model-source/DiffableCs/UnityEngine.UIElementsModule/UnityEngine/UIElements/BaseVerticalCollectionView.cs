namespace UnityEngine.UIElements;

[Token(Token = "0x200008B")]
public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	[Token(Token = "0x2000090")]
	private sealed class <>c
	{
		[Token(Token = "0x400034F")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000350")]
		public static Action <>9__191_1; //Field offset: 0x8

		[Address(RVA = "0x33463E0", Offset = "0x33457E0", Length = "0x67")]
		[Token(Token = "0x600058D")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600058E")]
		public <>c() { }

		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x600058F")]
		internal void <.ctor>b__191_1() { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000091")]
	private sealed class <>c__DisplayClass194_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000351")]
		public int id; //Field offset: 0x10

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000590")]
		public <>c__DisplayClass194_0() { }

		[Address(RVA = "0x3346160", Offset = "0x3345560", Length = "0x1C")]
		[Token(Token = "0x6000591")]
		internal bool <GetRootElementForId>b__0(ReusableCollectionItem t) { }

	}

	[CompilerGenerated]
	[Token(Token = "0x2000092")]
	private struct <>c__DisplayClass205_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000352")]
		public bool selectedIndicesChanged; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000353")]
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000354")]
		public int previousSelectionCount; //Field offset: 0x10

	}

	[CompilerGenerated]
	[Token(Token = "0x2000093")]
	private struct <>c__DisplayClass216_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000355")]
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000356")]
		public bool shiftKey; //Field offset: 0x8

	}

	[CompilerGenerated]
	[Token(Token = "0x2000094")]
	private sealed class <get_selectedItems>d__88 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000357")]
		private int <>1__state; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000358")]
		private object <>2__current; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000359")]
		private int <>l__initialThreadId; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400035A")]
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400035B")]
		private Enumerator<Int32> <>s__1; //Field offset: 0x30
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400035C")]
		private int <index>5__2; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400035D")]
		private object <item>5__3; //Field offset: 0x50

		[Token(Token = "0x170000E4")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000596")]
			private get { } //Length: 5
		}

		[Token(Token = "0x170000E5")]
		private override object System.Collections.IEnumerator.Current
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[DebuggerHidden]
			[Token(Token = "0x6000598")]
			private get { } //Length: 5
		}

		[Address(RVA = "0xA66430", Offset = "0xA65830", Length = "0x2E")]
		[DebuggerHidden]
		[Token(Token = "0x6000592")]
		public <get_selectedItems>d__88(int <>1__state) { }

		[Address(RVA = "0x3346990", Offset = "0x3345D90", Length = "0x41")]
		[Token(Token = "0x6000595")]
		private void <>m__Finally1() { }

		[Address(RVA = "0x33465A0", Offset = "0x33459A0", Length = "0x27D")]
		[Token(Token = "0x6000594")]
		private override bool MoveNext() { }

		[Address(RVA = "0x3346820", Offset = "0x3345C20", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x6000599")]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000596")]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[Address(RVA = "0x3346820", Offset = "0x3345C20", Length = "0x9C")]
		[DebuggerHidden]
		[Token(Token = "0x600059A")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[DebuggerHidden]
		[Token(Token = "0x6000598")]
		private override object System.Collections.IEnumerator.get_Current() { }

		[Address(RVA = "0x33468C0", Offset = "0x3345CC0", Length = "0x3E")]
		[DebuggerHidden]
		[Token(Token = "0x6000597")]
		private override void System.Collections.IEnumerator.Reset() { }

		[Address(RVA = "0x3346900", Offset = "0x3345D00", Length = "0x85")]
		[DebuggerHidden]
		[Token(Token = "0x6000593")]
		private override void System.IDisposable.Dispose() { }

	}

	[Token(Token = "0x200008F")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	public enum pointerProcessingStateEnum : int
	{
		None = 0,
		PointerDown = 1,
	}

	[Token(Token = "0x200008E")]
	private enum RangeSelectionDirection : int
	{
		Up = -1,
		None = 0,
		Down = 1,
	}

	[Token(Token = "0x200008D")]
	private class Selection
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000341")]
		private readonly HashSet<Int32> m_IndexLookup; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000342")]
		private readonly HashSet<Int32> m_IdLookup; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000343")]
		private int m_MinIndex; //Field offset: 0x20
		[FieldOffset(Offset = "0x24")]
		[Token(Token = "0x4000344")]
		private int m_MaxIndex; //Field offset: 0x24
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000345")]
		private List<Int32> <selectedIds>k__BackingField; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000346")]
		public readonly List<Int32> indices; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000347")]
		public readonly Dictionary<Int32, Object> items; //Field offset: 0x38

		[Token(Token = "0x170000E3")]
		public int capacity
		{
			[Address(RVA = "0x33459E0", Offset = "0x3344DE0", Length = "0x44")]
			[Token(Token = "0x600057E")]
			 get { } //Length: 68
			[Address(RVA = "0x3345B10", Offset = "0x3344F10", Length = "0x8E")]
			[Token(Token = "0x600057F")]
			 set { } //Length: 142
		}

		[Token(Token = "0x170000E0")]
		public int idCount
		{
			[Address(RVA = "0x3345A30", Offset = "0x3344E30", Length = "0x3C")]
			[Token(Token = "0x600057B")]
			 get { } //Length: 60
		}

		[Token(Token = "0x170000DF")]
		public int indexCount
		{
			[Address(RVA = "0x3345A70", Offset = "0x3344E70", Length = "0x3C")]
			[Token(Token = "0x600057A")]
			 get { } //Length: 60
		}

		[Token(Token = "0x170000E2")]
		public int maxIndex
		{
			[Address(RVA = "0x3345AB0", Offset = "0x3344EB0", Length = "0x2C")]
			[Token(Token = "0x600057D")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000E1")]
		public int minIndex
		{
			[Address(RVA = "0x3345AE0", Offset = "0x3344EE0", Length = "0x2C")]
			[Token(Token = "0x600057C")]
			 get { } //Length: 44
		}

		[Token(Token = "0x170000DE")]
		public List<Int32> selectedIds
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000578")]
			 get { } //Length: 5
			[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000579")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x33458A0", Offset = "0x3344CA0", Length = "0x139")]
		[Token(Token = "0x600058C")]
		public Selection() { }

		[Address(RVA = "0x3345140", Offset = "0x3344540", Length = "0xB2")]
		[Token(Token = "0x6000584")]
		public void AddId(int id) { }

		[Address(RVA = "0x3345200", Offset = "0x3344600", Length = "0xFE")]
		[Token(Token = "0x6000585")]
		public void AddIndex(int index, object obj) { }

		[Address(RVA = "0x3345430", Offset = "0x3344830", Length = "0xF1")]
		[Token(Token = "0x600058B")]
		public void Clear() { }

		[Address(RVA = "0x3345300", Offset = "0x3344700", Length = "0x64")]
		[Token(Token = "0x6000589")]
		public void ClearIds() { }

		[Address(RVA = "0x3345370", Offset = "0x3344770", Length = "0x6C")]
		[Token(Token = "0x600058A")]
		public void ClearIndices() { }

		[Address(RVA = "0x33453E0", Offset = "0x33447E0", Length = "0x44")]
		[Token(Token = "0x6000588")]
		public void ClearItems() { }

		[Address(RVA = "0x3345530", Offset = "0x3344930", Length = "0x51")]
		[Token(Token = "0x6000583")]
		public bool ContainsId(int id) { }

		[Address(RVA = "0x3345590", Offset = "0x3344990", Length = "0x51")]
		[Token(Token = "0x6000582")]
		public bool ContainsIndex(int index) { }

		[Address(RVA = "0x33455F0", Offset = "0x33449F0", Length = "0x66")]
		[Token(Token = "0x6000580")]
		public int FirstIndex() { }

		[Address(RVA = "0x3345660", Offset = "0x3344A60", Length = "0xC2")]
		[Token(Token = "0x6000581")]
		public object FirstObject() { }

		[Address(RVA = "0x33459E0", Offset = "0x3344DE0", Length = "0x44")]
		[Token(Token = "0x600057E")]
		public int get_capacity() { }

		[Address(RVA = "0x3345A30", Offset = "0x3344E30", Length = "0x3C")]
		[Token(Token = "0x600057B")]
		public int get_idCount() { }

		[Address(RVA = "0x3345A70", Offset = "0x3344E70", Length = "0x3C")]
		[Token(Token = "0x600057A")]
		public int get_indexCount() { }

		[Address(RVA = "0x3345AB0", Offset = "0x3344EB0", Length = "0x2C")]
		[Token(Token = "0x600057D")]
		public int get_maxIndex() { }

		[Address(RVA = "0x3345AE0", Offset = "0x3344EE0", Length = "0x2C")]
		[Token(Token = "0x600057C")]
		public int get_minIndex() { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000578")]
		public List<Int32> get_selectedIds() { }

		[Address(RVA = "0x3345730", Offset = "0x3344B30", Length = "0x74")]
		[Token(Token = "0x6000587")]
		public void RemoveId(int id) { }

		[Address(RVA = "0x3345B10", Offset = "0x3344F10", Length = "0x8E")]
		[Token(Token = "0x600057F")]
		public void set_capacity(int value) { }

		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000579")]
		public void set_selectedIds(List<Int32> value) { }

		[Address(RVA = "0x33457B0", Offset = "0x3344BB0", Length = "0xEE")]
		[Token(Token = "0x6000586")]
		public bool TryRemove(int index) { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x200008C")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400033A")]
		private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400033B")]
		private readonly UxmlIntAttributeDescription m_FixedItemHeight; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400033C")]
		private readonly UxmlBoolAttributeDescription m_ShowBorder; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x400033D")]
		private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x400033E")]
		private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x400033F")]
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000340")]
		private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled; //Field offset: 0xC0

		[Address(RVA = "0x334A160", Offset = "0x3349560", Length = "0x41A")]
		[Token(Token = "0x6000576")]
		public UxmlTraits() { }

		[Address(RVA = "0x3348BC0", Offset = "0x3347FC0", Length = "0x6BD")]
		[Token(Token = "0x6000577")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x40002FB")]
	internal static readonly BindingId itemsSourceProperty; //Field offset: 0x0
	[Token(Token = "0x40002FC")]
	internal static readonly BindingId selectionTypeProperty; //Field offset: 0x98
	[Token(Token = "0x40002FD")]
	internal static readonly BindingId selectedItemProperty; //Field offset: 0x130
	[Token(Token = "0x40002FE")]
	internal static readonly BindingId selectedItemsProperty; //Field offset: 0x1C8
	[Token(Token = "0x40002FF")]
	internal static readonly BindingId selectedIndexProperty; //Field offset: 0x260
	[Token(Token = "0x4000300")]
	internal static readonly BindingId selectedIndicesProperty; //Field offset: 0x2F8
	[Token(Token = "0x4000301")]
	internal static readonly BindingId showBorderProperty; //Field offset: 0x390
	[Token(Token = "0x4000302")]
	internal static readonly BindingId reorderableProperty; //Field offset: 0x428
	[Token(Token = "0x4000303")]
	internal static readonly BindingId horizontalScrollingEnabledProperty; //Field offset: 0x4C0
	[Token(Token = "0x4000304")]
	internal static readonly BindingId showAlternatingRowBackgroundsProperty; //Field offset: 0x558
	[Token(Token = "0x4000305")]
	internal static readonly BindingId virtualizationMethodProperty; //Field offset: 0x5F0
	[Token(Token = "0x4000306")]
	internal static readonly BindingId fixedItemHeightProperty; //Field offset: 0x688
	[Token(Token = "0x4000307")]
	private static readonly ProfilerMarker k_RefreshMarker; //Field offset: 0x720
	[Token(Token = "0x4000308")]
	private static readonly ProfilerMarker k_RebuildMarker; //Field offset: 0x728
	[Token(Token = "0x4000314")]
	private static readonly List<ReusableCollectionItem> k_EmptyItems; //Field offset: 0x730
	[Token(Token = "0x4000318")]
	internal static readonly string k_InvalidTemplateError; //Field offset: 0x738
	[Token(Token = "0x4000326")]
	internal static CustomStyleProperty<Int32> s_ItemHeightProperty; //Field offset: 0x740
	[Token(Token = "0x400032A")]
	public static readonly string ussClassName; //Field offset: 0x748
	[Token(Token = "0x400032B")]
	public static readonly string borderUssClassName; //Field offset: 0x750
	[Token(Token = "0x400032C")]
	public static readonly string itemUssClassName; //Field offset: 0x758
	[Token(Token = "0x400032D")]
	public static readonly string dragHoverBarUssClassName; //Field offset: 0x760
	[Token(Token = "0x400032E")]
	public static readonly string dragHoverMarkerUssClassName; //Field offset: 0x768
	[Token(Token = "0x400032F")]
	public static readonly string itemDragHoverUssClassName; //Field offset: 0x770
	[Token(Token = "0x4000330")]
	public static readonly string itemSelectedVariantUssClassName; //Field offset: 0x778
	[Token(Token = "0x4000331")]
	public static readonly string itemAlternativeBackgroundUssClassName; //Field offset: 0x780
	[Token(Token = "0x4000332")]
	public static readonly string listScrollViewUssClassName; //Field offset: 0x788
	[Token(Token = "0x4000333")]
	internal static readonly string backgroundFillUssClassName; //Field offset: 0x790
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2D8")]
	[Token(Token = "0x4000309")]
	private Action<IEnumerable`1<Object>> itemsChosen; //Field offset: 0x2D8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E0")]
	[Token(Token = "0x400030A")]
	private Action<IEnumerable`1<Object>> selectionChanged; //Field offset: 0x2E0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2E8")]
	[Token(Token = "0x400030B")]
	private Action<IEnumerable`1<Int32>> selectedIndicesChanged; //Field offset: 0x2E8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F0")]
	[Token(Token = "0x400030C")]
	private Action<Int32, Int32> itemIndexChanged; //Field offset: 0x2F0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x2F8")]
	[Token(Token = "0x400030D")]
	private Action itemsSourceChanged; //Field offset: 0x2F8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x300")]
	[Token(Token = "0x400030E")]
	private Action m_SelectionNotChanged; //Field offset: 0x300
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x308")]
	[Token(Token = "0x400030F")]
	private Func<CanStartDragArgs, Boolean> canStartDrag; //Field offset: 0x308
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x310")]
	[Token(Token = "0x4000310")]
	private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop; //Field offset: 0x310
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x318")]
	[Token(Token = "0x4000311")]
	private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate; //Field offset: 0x318
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x320")]
	[Token(Token = "0x4000312")]
	private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop; //Field offset: 0x320
	[FieldOffset(Offset = "0x328")]
	[Token(Token = "0x4000313")]
	private SelectionType m_SelectionType; //Field offset: 0x328
	[FieldOffset(Offset = "0x32C")]
	[Token(Token = "0x4000315")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool allowSingleClickChoice; //Field offset: 0x32C
	[FieldOffset(Offset = "0x32D")]
	[Token(Token = "0x4000316")]
	private bool m_HorizontalScrollingEnabled; //Field offset: 0x32D
	[DontCreateProperty]
	[FieldOffset(Offset = "0x330")]
	[SerializeField]
	[Token(Token = "0x4000317")]
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; //Field offset: 0x330
	[FieldOffset(Offset = "0x334")]
	[Token(Token = "0x4000319")]
	internal float m_FixedItemHeight; //Field offset: 0x334
	[FieldOffset(Offset = "0x338")]
	[Token(Token = "0x400031A")]
	internal bool m_ItemHeightIsInline; //Field offset: 0x338
	[FieldOffset(Offset = "0x33C")]
	[Token(Token = "0x400031B")]
	private CollectionVirtualizationMethod m_VirtualizationMethod; //Field offset: 0x33C
	[FieldOffset(Offset = "0x340")]
	[Token(Token = "0x400031C")]
	private readonly ScrollView m_ScrollView; //Field offset: 0x340
	[FieldOffset(Offset = "0x348")]
	[Token(Token = "0x400031D")]
	private CollectionViewController m_ViewController; //Field offset: 0x348
	[FieldOffset(Offset = "0x350")]
	[Token(Token = "0x400031E")]
	private CollectionVirtualizationController m_VirtualizationController; //Field offset: 0x350
	[FieldOffset(Offset = "0x358")]
	[Token(Token = "0x400031F")]
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x358
	[DontCreateProperty]
	[FieldOffset(Offset = "0x360")]
	[SerializeField]
	[Token(Token = "0x4000320")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal SerializedVirtualizationData serializedVirtualizationData; //Field offset: 0x360
	[DontCreateProperty]
	[FieldOffset(Offset = "0x368")]
	[SerializeField]
	[Token(Token = "0x4000321")]
	private List<Int32> m_SelectedIds; //Field offset: 0x368
	[FieldOffset(Offset = "0x370")]
	[Token(Token = "0x4000322")]
	private readonly Selection m_Selection; //Field offset: 0x370
	[FieldOffset(Offset = "0x378")]
	[Token(Token = "0x4000323")]
	private float m_LastHeight; //Field offset: 0x378
	[FieldOffset(Offset = "0x37C")]
	[Token(Token = "0x4000324")]
	private RangeSelectionDirection m_RangeSelectionDirection; //Field offset: 0x37C
	[FieldOffset(Offset = "0x380")]
	[Token(Token = "0x4000325")]
	private ListViewDragger m_Dragger; //Field offset: 0x380
	[FieldOffset(Offset = "0x388")]
	[Token(Token = "0x4000327")]
	private readonly Action<Int32, Int32> m_ItemIndexChangedCallback; //Field offset: 0x388
	[FieldOffset(Offset = "0x390")]
	[Token(Token = "0x4000328")]
	private readonly Action m_ItemsSourceChangedCallback; //Field offset: 0x390
	[FieldOffset(Offset = "0x398")]
	[Token(Token = "0x4000329")]
	private IVisualElementScheduledItem m_RebuildScheduled; //Field offset: 0x398
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3A0")]
	[Token(Token = "0x4000334")]
	private pointerProcessingStateEnum <pointerProcessingState>k__BackingField; //Field offset: 0x3A0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x3A4")]
	[Token(Token = "0x4000335")]
	private int <currentPointerButton>k__BackingField; //Field offset: 0x3A4
	[FieldOffset(Offset = "0x3A8")]
	[Token(Token = "0x4000336")]
	internal int m_PreviousRefreshedCount; //Field offset: 0x3A8
	[FieldOffset(Offset = "0x3AC")]
	[Token(Token = "0x4000337")]
	private Vector3 m_TouchDownPosition; //Field offset: 0x3AC
	[FieldOffset(Offset = "0x3B8")]
	[Token(Token = "0x4000338")]
	private long m_LastPointerDownTimeStamp; //Field offset: 0x3B8
	[FieldOffset(Offset = "0x3C0")]
	[Token(Token = "0x4000339")]
	private int m_PointerDownCount; //Field offset: 0x3C0

	[Token(Token = "0x170000D0")]
	internal IEnumerable<ReusableCollectionItem> activeItems
	{
		[Address(RVA = "0x3337860", Offset = "0x3336C60", Length = "0x7C")]
		[Token(Token = "0x6000521")]
		internal get { } //Length: 124
	}

	[Token(Token = "0x170000C9")]
	public virtual VisualElement contentContainer
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000518")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000DD")]
	private int currentPointerButton
	{
		[Address(RVA = "0x3337D10", Offset = "0x3337110", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600053E")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170000D2")]
	internal ListViewDragger dragger
	{
		[Address(RVA = "0x16A56D0", Offset = "0x16A4AD0", Length = "0x8")]
		[Token(Token = "0x6000523")]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x170000DA")]
	public float fixedItemHeight
	{
		[Address(RVA = "0x33378E0", Offset = "0x3336CE0", Length = "0x9")]
		[Token(Token = "0x6000531")]
		 get { } //Length: 9
		[Address(RVA = "0x3337D20", Offset = "0x3337120", Length = "0x140")]
		[Token(Token = "0x6000532")]
		 set { } //Length: 320
	}

	[CreateProperty]
	[Token(Token = "0x170000D7")]
	public bool horizontalScrollingEnabled
	{
		[Address(RVA = "0x33378F0", Offset = "0x3336CF0", Length = "0x8")]
		[Token(Token = "0x600052B")]
		 get { } //Length: 8
		[Address(RVA = "0x3337E60", Offset = "0x3337260", Length = "0xB7")]
		[Token(Token = "0x600052C")]
		 set { } //Length: 183
	}

	[Token(Token = "0x170000DB")]
	internal bool isRebuildScheduled
	{
		[Address(RVA = "0x3337900", Offset = "0x3336D00", Length = "0x4C")]
		[Token(Token = "0x6000533")]
		internal get { } //Length: 76
	}

	[CreateProperty]
	[Token(Token = "0x170000C8")]
	public IList itemsSource
	{
		[Address(RVA = "0x3337950", Offset = "0x3336D50", Length = "0x23")]
		[Token(Token = "0x6000516")]
		 get { } //Length: 35
		[Address(RVA = "0x33304B0", Offset = "0x332F8B0", Length = "0x79")]
		[Token(Token = "0x6000517")]
		 set { } //Length: 121
	}

	[Token(Token = "0x170000DC")]
	private pointerProcessingStateEnum pointerProcessingState
	{
		[Address(RVA = "0x3337F20", Offset = "0x3337320", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600053D")]
		private set { } //Length: 7
	}

	[CreateProperty]
	[Token(Token = "0x170000D6")]
	public bool reorderable
	{
		[Address(RVA = "0x3337980", Offset = "0x3336D80", Length = "0x8D")]
		[Token(Token = "0x6000529")]
		 get { } //Length: 141
		[Address(RVA = "0x3337F30", Offset = "0x3337330", Length = "0x106")]
		[Token(Token = "0x600052A")]
		 set { } //Length: 262
	}

	[Token(Token = "0x170000D1")]
	internal ScrollView scrollView
	{
		[Address(RVA = "0x2EF44D0", Offset = "0x2EF38D0", Length = "0x8")]
		[Token(Token = "0x6000522")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEngine.HierarchyModule"})]
		internal get { } //Length: 8
	}

	[Token(Token = "0x170000CF")]
	public IEnumerable<Int32> selectedIds
	{
		[Address(RVA = "0x3337A10", Offset = "0x3336E10", Length = "0x1E")]
		[Token(Token = "0x6000520")]
		 get { } //Length: 30
	}

	[CreateProperty]
	[Token(Token = "0x170000CD")]
	public int selectedIndex
	{
		[Address(RVA = "0x3337A30", Offset = "0x3336E30", Length = "0xBB")]
		[Token(Token = "0x600051D")]
		 get { } //Length: 187
		[Address(RVA = "0x3333B90", Offset = "0x3332F90", Length = "0x8")]
		[Token(Token = "0x600051E")]
		 set { } //Length: 8
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000CE")]
	public IEnumerable<Int32> selectedIndices
	{
		[Address(RVA = "0x3337AF0", Offset = "0x3336EF0", Length = "0x1E")]
		[Token(Token = "0x600051F")]
		 get { } //Length: 30
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000CB")]
	public object selectedItem
	{
		[Address(RVA = "0x3337B10", Offset = "0x3336F10", Length = "0xD6")]
		[Token(Token = "0x600051B")]
		 get { } //Length: 214
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x170000CC")]
	public IEnumerable<Object> selectedItems
	{
		[Address(RVA = "0x3337BF0", Offset = "0x3336FF0", Length = "0x71")]
		[IteratorStateMachine(typeof(<get_selectedItems>d__88))]
		[Token(Token = "0x600051C")]
		 get { } //Length: 113
	}

	[CreateProperty]
	[Token(Token = "0x170000CA")]
	public SelectionType selectionType
	{
		[Address(RVA = "0x3337C70", Offset = "0x3337070", Length = "0x9")]
		[Token(Token = "0x6000519")]
		 get { } //Length: 9
		[Address(RVA = "0x3338040", Offset = "0x3337440", Length = "0x105")]
		[Token(Token = "0x600051A")]
		 set { } //Length: 261
	}

	[CreateProperty]
	[Token(Token = "0x170000D8")]
	public AlternatingRowBackground showAlternatingRowBackgrounds
	{
		[Address(RVA = "0x3337C80", Offset = "0x3337080", Length = "0x9")]
		[Token(Token = "0x600052D")]
		 get { } //Length: 9
		[Address(RVA = "0x3338150", Offset = "0x3337550", Length = "0x86")]
		[Token(Token = "0x600052E")]
		 set { } //Length: 134
	}

	[CreateProperty]
	[Token(Token = "0x170000D5")]
	public bool showBorder
	{
		[Address(RVA = "0x3337C90", Offset = "0x3337090", Length = "0x73")]
		[Token(Token = "0x6000527")]
		 get { } //Length: 115
		[Address(RVA = "0x33381E0", Offset = "0x33375E0", Length = "0xEC")]
		[Token(Token = "0x6000528")]
		 set { } //Length: 236
	}

	[Token(Token = "0x170000D4")]
	public CollectionViewController viewController
	{
		[Address(RVA = "0x1662BE0", Offset = "0x1661FE0", Length = "0x8")]
		[Token(Token = "0x6000525")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170000D3")]
	internal CollectionVirtualizationController virtualizationController
	{
		[Address(RVA = "0x3331E10", Offset = "0x3331210", Length = "0x40")]
		[Token(Token = "0x6000524")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEngine.HierarchyModule"})]
		internal get { } //Length: 64
	}

	[CreateProperty]
	[Token(Token = "0x170000D9")]
	public CollectionVirtualizationMethod virtualizationMethod
	{
		[Address(RVA = "0x788D60", Offset = "0x788160", Length = "0xF2")]
		[Token(Token = "0x600052F")]
		 get { } //Length: 242
		[Address(RVA = "0x33382D0", Offset = "0x33376D0", Length = "0x9C")]
		[Token(Token = "0x6000530")]
		 set { } //Length: 156
	}

	[Address(RVA = "0x3335F40", Offset = "0x3335340", Length = "0xEE5")]
	[Token(Token = "0x6000572")]
	private static BaseVerticalCollectionView() { }

	[Address(RVA = "0x3336E30", Offset = "0x3336230", Length = "0x92D")]
	[Token(Token = "0x600053F")]
	public BaseVerticalCollectionView() { }

	[Address(RVA = "0x3337760", Offset = "0x3336B60", Length = "0xF3")]
	[Token(Token = "0x6000540")]
	public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1) { }

	[Address(RVA = "0x3335E70", Offset = "0x3335270", Length = "0x82")]
	[CompilerGenerated]
	[Token(Token = "0x6000573")]
	private void <.ctor>b__191_0(float v) { }

	[Address(RVA = "0x3335CE0", Offset = "0x33350E0", Length = "0x10D")]
	[CompilerGenerated]
	[Token(Token = "0x6000575")]
	private void <Apply>g__HandleSelectionAndScroll|216_0(int index, ref <>c__DisplayClass216_0 unnamed_param_1) { }

	[Address(RVA = "0x3335DF0", Offset = "0x33351F0", Length = "0x72")]
	[CompilerGenerated]
	[Token(Token = "0x6000574")]
	private void <RefreshSelection>g__NotifyIfChanged|205_0(ref <>c__DisplayClass205_0 unnamed_param_0) { }

	[Address(RVA = "0x3330820", Offset = "0x332FC20", Length = "0x9F")]
	[Token(Token = "0x600055D")]
	public void AddToSelection(int index) { }

	[Address(RVA = "0x33308C0", Offset = "0x332FCC0", Length = "0x135")]
	[Token(Token = "0x600055E")]
	internal void AddToSelection(ReadOnlySpan<Int32> indexes) { }

	[Address(RVA = "0x3330530", Offset = "0x332F930", Length = "0x2E6")]
	[Token(Token = "0x600055F")]
	private void AddToSelectionWithoutValidation(int index) { }

	[Address(RVA = "0x3330FF0", Offset = "0x33303F0", Length = "0x1B4")]
	[Token(Token = "0x6000551")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	[Address(RVA = "0x3330A00", Offset = "0x332FE00", Length = "0x5C4")]
	[Token(Token = "0x6000550")]
	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	[Address(RVA = "0x3331470", Offset = "0x3330870", Length = "0x80")]
	[Token(Token = "0x6000569")]
	public void ClearSelection() { }

	[Address(RVA = "0x33311B0", Offset = "0x33305B0", Length = "0x2BF")]
	[Token(Token = "0x600056A")]
	private void ClearSelectionWithoutValidation() { }

	[Token(Token = "0x600053C")]
	internal abstract ICollectionDragAndDropController CreateDragAndDropController() { }

	[Address(RVA = "0x3331500", Offset = "0x3330900", Length = "0x54")]
	[Token(Token = "0x600053A")]
	internal override ListViewDragger CreateDragger() { }

	[Token(Token = "0x6000538")]
	protected abstract CollectionViewController CreateViewController() { }

	[Address(RVA = "0x3331560", Offset = "0x3330960", Length = "0x39")]
	[Token(Token = "0x6000534")]
	override void CreateVirtualizationController() { }

	[Address(RVA = "0x7974D0", Offset = "0x7968D0", Length = "0x153")]
	[Token(Token = "0x6000536")]
	internal void CreateVirtualizationController() { }

	[Address(RVA = "0x33315A0", Offset = "0x33309A0", Length = "0x2C4")]
	[Token(Token = "0x600055A")]
	internal void DoRangeSelection(int rangeSelectionFinalIndex) { }

	[Address(RVA = "0x3331870", Offset = "0x3330C70", Length = "0x535")]
	[Token(Token = "0x6000559")]
	private void DoSelect(Vector2 localPosition, int mouseButton, int clickCount, bool actionKey, bool shiftKey) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", False)]
	[Token(Token = "0x600056D")]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	[Address(RVA = "0x3337860", Offset = "0x3336C60", Length = "0x7C")]
	[Token(Token = "0x6000521")]
	internal IEnumerable<ReusableCollectionItem> get_activeItems() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000518")]
	public virtual VisualElement get_contentContainer() { }

	[Address(RVA = "0x16A56D0", Offset = "0x16A4AD0", Length = "0x8")]
	[Token(Token = "0x6000523")]
	internal ListViewDragger get_dragger() { }

	[Address(RVA = "0x33378E0", Offset = "0x3336CE0", Length = "0x9")]
	[Token(Token = "0x6000531")]
	public float get_fixedItemHeight() { }

	[Address(RVA = "0x33378F0", Offset = "0x3336CF0", Length = "0x8")]
	[Token(Token = "0x600052B")]
	public bool get_horizontalScrollingEnabled() { }

	[Address(RVA = "0x3337900", Offset = "0x3336D00", Length = "0x4C")]
	[Token(Token = "0x6000533")]
	internal bool get_isRebuildScheduled() { }

	[Address(RVA = "0x3337950", Offset = "0x3336D50", Length = "0x23")]
	[Token(Token = "0x6000516")]
	public IList get_itemsSource() { }

	[Address(RVA = "0x3337980", Offset = "0x3336D80", Length = "0x8D")]
	[Token(Token = "0x6000529")]
	public bool get_reorderable() { }

	[Address(RVA = "0x2EF44D0", Offset = "0x2EF38D0", Length = "0x8")]
	[Token(Token = "0x6000522")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEngine.HierarchyModule"})]
	internal ScrollView get_scrollView() { }

	[Address(RVA = "0x3337A10", Offset = "0x3336E10", Length = "0x1E")]
	[Token(Token = "0x6000520")]
	public IEnumerable<Int32> get_selectedIds() { }

	[Address(RVA = "0x3337A30", Offset = "0x3336E30", Length = "0xBB")]
	[Token(Token = "0x600051D")]
	public int get_selectedIndex() { }

	[Address(RVA = "0x3337AF0", Offset = "0x3336EF0", Length = "0x1E")]
	[Token(Token = "0x600051F")]
	public IEnumerable<Int32> get_selectedIndices() { }

	[Address(RVA = "0x3337B10", Offset = "0x3336F10", Length = "0xD6")]
	[Token(Token = "0x600051B")]
	public object get_selectedItem() { }

	[Address(RVA = "0x3337BF0", Offset = "0x3336FF0", Length = "0x71")]
	[IteratorStateMachine(typeof(<get_selectedItems>d__88))]
	[Token(Token = "0x600051C")]
	public IEnumerable<Object> get_selectedItems() { }

	[Address(RVA = "0x3337C70", Offset = "0x3337070", Length = "0x9")]
	[Token(Token = "0x6000519")]
	public SelectionType get_selectionType() { }

	[Address(RVA = "0x3337C80", Offset = "0x3337080", Length = "0x9")]
	[Token(Token = "0x600052D")]
	public AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	[Address(RVA = "0x3337C90", Offset = "0x3337090", Length = "0x73")]
	[Token(Token = "0x6000527")]
	public bool get_showBorder() { }

	[Address(RVA = "0x1662BE0", Offset = "0x1661FE0", Length = "0x8")]
	[Token(Token = "0x6000525")]
	public CollectionViewController get_viewController() { }

	[Address(RVA = "0x3331E10", Offset = "0x3331210", Length = "0x40")]
	[Token(Token = "0x6000524")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEngine.HierarchyModule"})]
	internal CollectionVirtualizationController get_virtualizationController() { }

	[Address(RVA = "0x788D60", Offset = "0x788160", Length = "0xF2")]
	[Token(Token = "0x600052F")]
	public CollectionVirtualizationMethod get_virtualizationMethod() { }

	[Address(RVA = "0x3331DB0", Offset = "0x33311B0", Length = "0x5A")]
	[Token(Token = "0x6000537")]
	internal CollectionViewController GetOrCreateViewController() { }

	[Address(RVA = "0x3331E10", Offset = "0x3331210", Length = "0x40")]
	[Token(Token = "0x6000535")]
	internal CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	[Address(RVA = "0x3331E50", Offset = "0x3331250", Length = "0xFC")]
	[Token(Token = "0x6000541")]
	public VisualElement GetRootElementForId(int id) { }

	[Address(RVA = "0x3331F50", Offset = "0x3331350", Length = "0x373")]
	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(PointerUpEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(NavigationSubmitEvent)})]
	[Token(Token = "0x600056C")]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x8E85F0", Offset = "0x8E79F0", Length = "0x5")]
	[Token(Token = "0x6000552")]
	override bool HandleItemNavigation(bool moveIn, bool altKey) { }

	[Address(RVA = "0x33322D0", Offset = "0x33316D0", Length = "0xC")]
	[Token(Token = "0x6000511")]
	internal bool HasCanStartDrag() { }

	[Address(RVA = "0x33322E0", Offset = "0x33316E0", Length = "0x3D")]
	[Token(Token = "0x6000542")]
	internal override bool HasValidDataAndBindings() { }

	[Address(RVA = "0x3332320", Offset = "0x3331720", Length = "0x121")]
	[Token(Token = "0x600053B")]
	internal void InitializeDragAndDropController(bool enableReordering) { }

	[Address(RVA = "0x3332450", Offset = "0x3331850", Length = "0x23D")]
	[Token(Token = "0x6000567")]
	private bool MatchesExistingSelection(ReadOnlySpan<Int32> indices) { }

	[Address(RVA = "0x3332690", Offset = "0x3331A90", Length = "0x8D")]
	[Token(Token = "0x6000568")]
	private void NotifyOfSelectionChange() { }

	[Address(RVA = "0x3332720", Offset = "0x3331B20", Length = "0x33F")]
	[Token(Token = "0x600054E")]
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	[Address(RVA = "0x3332A60", Offset = "0x3331E60", Length = "0x1AF")]
	[Token(Token = "0x600056F")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	[Address(RVA = "0x3332C10", Offset = "0x3332010", Length = "0x2BB")]
	[Token(Token = "0x600054F")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	[Address(RVA = "0x3332ED0", Offset = "0x33322D0", Length = "0x32")]
	[Token(Token = "0x6000543")]
	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	[Address(RVA = "0x3332F10", Offset = "0x3332310", Length = "0x75")]
	[Token(Token = "0x6000544")]
	private void OnItemsSourceChanged() { }

	[Address(RVA = "0x3332F90", Offset = "0x3332390", Length = "0x6E")]
	[Token(Token = "0x6000555")]
	private void OnPointerCancel(PointerCancelEvent evt) { }

	[Address(RVA = "0x3333000", Offset = "0x3332400", Length = "0x8")]
	[Token(Token = "0x6000554")]
	private void OnPointerDown(PointerDownEvent evt) { }

	[Address(RVA = "0x3333010", Offset = "0x3332410", Length = "0x7C")]
	[Token(Token = "0x6000553")]
	private void OnPointerMove(PointerMoveEvent evt) { }

	[Address(RVA = "0x3333090", Offset = "0x3332490", Length = "0x8")]
	[Token(Token = "0x6000556")]
	private void OnPointerUp(PointerUpEvent evt) { }

	[Address(RVA = "0x33330A0", Offset = "0x33324A0", Length = "0x7E")]
	[Token(Token = "0x600054C")]
	private void OnScroll(Vector2 offset) { }

	[Address(RVA = "0x3333120", Offset = "0x3332520", Length = "0x106")]
	[Token(Token = "0x600056E")]
	private void OnSizeChanged(GeometryChangedEvent evt) { }

	[Address(RVA = "0x3333230", Offset = "0x3332630", Length = "0x48")]
	[Token(Token = "0x600056B")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x3333280", Offset = "0x3332680", Length = "0x143")]
	[Token(Token = "0x6000549")]
	override void PostRefresh() { }

	[Address(RVA = "0x33333D0", Offset = "0x33327D0", Length = "0x3E2")]
	[Token(Token = "0x6000557")]
	private void ProcessPointerDown(IPointerEvent evt) { }

	[Address(RVA = "0x33337C0", Offset = "0x3332BC0", Length = "0x3CC")]
	[Token(Token = "0x6000558")]
	private void ProcessPointerUp(IPointerEvent evt) { }

	[Address(RVA = "0x3333B90", Offset = "0x3332F90", Length = "0x8")]
	[Token(Token = "0x600055B")]
	private void ProcessSingleClick(int clickedIndex) { }

	[Address(RVA = "0x3333BA0", Offset = "0x3332FA0", Length = "0x112")]
	[Token(Token = "0x6000512")]
	internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<Int32> ids, EventModifiers modifiers) { }

	[Address(RVA = "0x3333CC0", Offset = "0x33330C0", Length = "0x97")]
	[Token(Token = "0x6000515")]
	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	[Address(RVA = "0x3333D60", Offset = "0x3333160", Length = "0x97")]
	[Token(Token = "0x6000514")]
	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	[Address(RVA = "0x3333E00", Offset = "0x3333200", Length = "0x143")]
	[Token(Token = "0x6000513")]
	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<Int32> ids, StartDragArgs args) { }

	[Address(RVA = "0x3333F50", Offset = "0x3333350", Length = "0x194")]
	[Token(Token = "0x6000546")]
	public void Rebuild() { }

	[Address(RVA = "0x33340F0", Offset = "0x33334F0", Length = "0x1C1")]
	[Token(Token = "0x6000545")]
	public void RefreshItems() { }

	[Address(RVA = "0x33342C0", Offset = "0x33336C0", Length = "0x676")]
	[Token(Token = "0x6000548")]
	private void RefreshSelection() { }

	[Address(RVA = "0x3334CB0", Offset = "0x33340B0", Length = "0x52")]
	[Token(Token = "0x6000560")]
	public void RemoveFromSelection(int index) { }

	[Address(RVA = "0x3334940", Offset = "0x3333D40", Length = "0x362")]
	[Token(Token = "0x6000561")]
	private void RemoveFromSelectionWithoutValidation(int index) { }

	[Address(RVA = "0x3334D10", Offset = "0x3334110", Length = "0xB7")]
	[Token(Token = "0x600054D")]
	private void Resize(Vector2 size) { }

	[Address(RVA = "0x3334DD0", Offset = "0x33341D0", Length = "0x15")]
	[Token(Token = "0x6000526")]
	internal float ResolveItemHeight(float height = -1) { }

	[Address(RVA = "0x3334DF0", Offset = "0x33341F0", Length = "0x11E")]
	[Token(Token = "0x6000547")]
	internal void ScheduleRebuild() { }

	[Address(RVA = "0x3334FB0", Offset = "0x33343B0", Length = "0x77")]
	[Token(Token = "0x600054A")]
	public void ScrollToItem(int index) { }

	[Address(RVA = "0x3334F10", Offset = "0x3334310", Length = "0x9B")]
	[Token(Token = "0x600054B")]
	public void ScrollToItemById(int id) { }

	[Address(RVA = "0x3335030", Offset = "0x3334430", Length = "0x2EF")]
	[Token(Token = "0x600055C")]
	internal void SelectAll() { }

	[Address(RVA = "0x3337D10", Offset = "0x3337110", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600053E")]
	private void set_currentPointerButton(int value) { }

	[Address(RVA = "0x3337D20", Offset = "0x3337120", Length = "0x140")]
	[Token(Token = "0x6000532")]
	public void set_fixedItemHeight(float value) { }

	[Address(RVA = "0x3337E60", Offset = "0x3337260", Length = "0xB7")]
	[Token(Token = "0x600052C")]
	public void set_horizontalScrollingEnabled(bool value) { }

	[Address(RVA = "0x33304B0", Offset = "0x332F8B0", Length = "0x79")]
	[Token(Token = "0x6000517")]
	public void set_itemsSource(IList value) { }

	[Address(RVA = "0x3337F20", Offset = "0x3337320", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600053D")]
	private void set_pointerProcessingState(pointerProcessingStateEnum value) { }

	[Address(RVA = "0x3337F30", Offset = "0x3337330", Length = "0x106")]
	[Token(Token = "0x600052A")]
	public void set_reorderable(bool value) { }

	[Address(RVA = "0x3333B90", Offset = "0x3332F90", Length = "0x8")]
	[Token(Token = "0x600051E")]
	public void set_selectedIndex(int value) { }

	[Address(RVA = "0x3338040", Offset = "0x3337440", Length = "0x105")]
	[Token(Token = "0x600051A")]
	public void set_selectionType(SelectionType value) { }

	[Address(RVA = "0x3338150", Offset = "0x3337550", Length = "0x86")]
	[Token(Token = "0x600052E")]
	public void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	[Address(RVA = "0x33381E0", Offset = "0x33375E0", Length = "0xEC")]
	[Token(Token = "0x6000528")]
	public void set_showBorder(bool value) { }

	[Address(RVA = "0x33382D0", Offset = "0x33376D0", Length = "0x9C")]
	[Token(Token = "0x6000530")]
	public void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	[Address(RVA = "0x3335AE0", Offset = "0x3334EE0", Length = "0x21")]
	[Token(Token = "0x6000563")]
	internal void SetSelection(ReadOnlySpan<Int32> indices) { }

	[Address(RVA = "0x3335B10", Offset = "0x3334F10", Length = "0xBE")]
	[Token(Token = "0x6000562")]
	public void SetSelection(int index) { }

	[Address(RVA = "0x3335320", Offset = "0x3334720", Length = "0x503")]
	[Token(Token = "0x6000565")]
	internal void SetSelectionInternal(IEnumerable<Int32> indices, bool sendNotification) { }

	[Address(RVA = "0x3335830", Offset = "0x3334C30", Length = "0x29C")]
	[Token(Token = "0x6000566")]
	internal void SetSelectionInternal(ReadOnlySpan<Int32> indices, bool sendNotification) { }

	[Address(RVA = "0x3335AD0", Offset = "0x3334ED0", Length = "0xB")]
	[Token(Token = "0x6000564")]
	public void SetSelectionWithoutNotify(IEnumerable<Int32> indices) { }

	[Address(RVA = "0x3335BD0", Offset = "0x3334FD0", Length = "0x103")]
	[Token(Token = "0x6000539")]
	public override void SetViewController(CollectionViewController controller) { }

	[Address(RVA = "0x3335F00", Offset = "0x3335300", Length = "0x3D")]
	[Token(Token = "0x6000571")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000570")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

