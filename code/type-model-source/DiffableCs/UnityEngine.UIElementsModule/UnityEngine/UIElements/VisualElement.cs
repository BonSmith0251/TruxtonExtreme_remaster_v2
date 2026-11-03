namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x2000386")]
public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler
{
	[CompilerGenerated]
	[Token(Token = "0x2000391")]
	private sealed class <>c__DisplayClass556_0
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D22")]
		public VisualElement <>4__this; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D23")]
		public StyleValues to; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001C27")]
		public <>c__DisplayClass556_0() { }

		[Address(RVA = "0x32806C0", Offset = "0x327FAC0", Length = "0x25")]
		[Token(Token = "0x6001C28")]
		internal StyleValues <UnityEngine.UIElements.Experimental.ITransitionAnimations.Start>b__0(VisualElement e) { }

	}

	[Token(Token = "0x200038B")]
	private abstract class BaseVisualElementScheduledItem : ScheduledItem, IVisualElementScheduledItem
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000D16")]
		private VisualElement <element>k__BackingField; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000D17")]
		public TimerEventScheduler scheduler; //Field offset: 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000D18")]
		private bool <isActive>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x49")]
		[Token(Token = "0x4000D19")]
		private bool <isDetaching>k__BackingField; //Field offset: 0x49
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000D1A")]
		private readonly EventCallback<AttachToPanelEvent> m_OnAttachToPanelCallback; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000D1B")]
		private readonly EventCallback<DetachFromPanelEvent> m_OnDetachFromPanelCallback; //Field offset: 0x58

		[Token(Token = "0x17000796")]
		public private override VisualElement element
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001BFC")]
			 get { } //Length: 5
			[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6001BFD")]
			private set { } //Length: 13
		}

		[Token(Token = "0x17000798")]
		public private override bool isActive
		{
			[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001BFF")]
			 get { } //Length: 5
			[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001C00")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000799")]
		public private bool isDetaching
		{
			[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001C01")]
			 get { } //Length: 5
			[Address(RVA = "0x2E37650", Offset = "0x2E36A50", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001C02")]
			private set { } //Length: 4
		}

		[Token(Token = "0x17000797")]
		public bool isScheduled
		{
			[Address(RVA = "0x3269780", Offset = "0x3268B80", Length = "0x9")]
			[Token(Token = "0x6001BFE")]
			 get { } //Length: 9
		}

		[Address(RVA = "0x3269640", Offset = "0x3268A40", Length = "0x139")]
		[Token(Token = "0x6001C03")]
		protected BaseVisualElementScheduledItem(VisualElement handler) { }

		[Address(RVA = "0x3268F70", Offset = "0x3268370", Length = "0x3C")]
		[Token(Token = "0x6001C12")]
		public bool CanBeActivated() { }

		[Address(RVA = "0x3268FB0", Offset = "0x32683B0", Length = "0xB1")]
		[Token(Token = "0x6001C0B")]
		public override IVisualElementScheduledItem Every(long intervalMs) { }

		[Address(RVA = "0x3269070", Offset = "0x3268470", Length = "0x53")]
		[Token(Token = "0x6001C0F")]
		public override void ExecuteLater(long delayMs) { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001BFC")]
		public override VisualElement get_element() { }

		[Address(RVA = "0x1DFC3F0", Offset = "0x1DFB7F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001BFF")]
		public override bool get_isActive() { }

		[Address(RVA = "0x24F8BE0", Offset = "0x24F7FE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001C01")]
		public bool get_isDetaching() { }

		[Address(RVA = "0x3269780", Offset = "0x3268B80", Length = "0x9")]
		[Token(Token = "0x6001BFE")]
		public bool get_isScheduled() { }

		[Address(RVA = "0x32690D0", Offset = "0x32684D0", Length = "0x119")]
		[Token(Token = "0x6001C07")]
		private void OnElementAttachToPanelCallback(AttachToPanelEvent evt) { }

		[Address(RVA = "0x32691F0", Offset = "0x32685F0", Length = "0x5B")]
		[Token(Token = "0x6001C08")]
		private void OnElementDetachFromPanelCallback(DetachFromPanelEvent evt) { }

		[Address(RVA = "0x3269250", Offset = "0x3268650", Length = "0x41")]
		[Token(Token = "0x6001C0C")]
		internal virtual void OnItemUnscheduled() { }

		[Address(RVA = "0x32692A0", Offset = "0x32686A0", Length = "0x7E")]
		[Token(Token = "0x6001C10")]
		public void OnPanelActivate() { }

		[Address(RVA = "0x3269320", Offset = "0x3268720", Length = "0x45")]
		[Token(Token = "0x6001C11")]
		public void OnPanelDeactivate() { }

		[Address(RVA = "0x3269370", Offset = "0x3268770", Length = "0xA")]
		[Token(Token = "0x6001C0E")]
		public override void Pause() { }

		[Address(RVA = "0x3269380", Offset = "0x3268780", Length = "0xA")]
		[Token(Token = "0x6001C0D")]
		public override void Resume() { }

		[Address(RVA = "0x3269390", Offset = "0x3268790", Length = "0xAA")]
		[Token(Token = "0x6001C05")]
		private void SendActivation() { }

		[Address(RVA = "0x3269440", Offset = "0x3268840", Length = "0x6D")]
		[Token(Token = "0x6001C06")]
		private void SendDeactivation() { }

		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001BFD")]
		private void set_element(VisualElement value) { }

		[Address(RVA = "0x1E523D0", Offset = "0x1E517D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001C00")]
		private void set_isActive(bool value) { }

		[Address(RVA = "0x2E37650", Offset = "0x2E36A50", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001C02")]
		private void set_isDetaching(bool value) { }

		[Address(RVA = "0x32694B0", Offset = "0x32688B0", Length = "0xF1")]
		[Token(Token = "0x6001C04")]
		private void SetActive(bool action) { }

		[Address(RVA = "0x32695B0", Offset = "0x32689B0", Length = "0x8")]
		[Token(Token = "0x6001C09")]
		public override IVisualElementScheduledItem StartingIn(long delayMs) { }

		[Address(RVA = "0x32695C0", Offset = "0x32689C0", Length = "0x78")]
		[Token(Token = "0x6001C0A")]
		public override IVisualElementScheduledItem Until(Func<Boolean> stopCondition) { }

	}

	[Token(Token = "0x200038F")]
	public class CustomStyleAccess : ICustomStyle
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D1D")]
		private Dictionary<String, StylePropertyValue> m_CustomProperties; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D1E")]
		private float m_DpiScaling; //Field offset: 0x18

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001C22")]
		public CustomStyleAccess() { }

		[Address(RVA = "0x326A770", Offset = "0x3269B70", Length = "0xD3")]
		[Token(Token = "0x6001C21")]
		private static void LogCustomPropertyWarning(string propertyName, StyleValueType valueType, StylePropertyValue customProp) { }

		[Address(RVA = "0x326A850", Offset = "0x3269C50", Length = "0x2E")]
		[Token(Token = "0x6001C18")]
		public void SetContext(Dictionary<String, StylePropertyValue> customProperties, float dpiScaling) { }

		[Address(RVA = "0x326AC80", Offset = "0x326A080", Length = "0x114")]
		[Token(Token = "0x6001C19")]
		public override bool TryGetValue(CustomStyleProperty<Single> property, out float value) { }

		[Address(RVA = "0x326A980", Offset = "0x3269D80", Length = "0x11B")]
		[Token(Token = "0x6001C1A")]
		public override bool TryGetValue(CustomStyleProperty<Int32> property, out int value) { }

		[Address(RVA = "0x326A880", Offset = "0x3269C80", Length = "0xFB")]
		[Token(Token = "0x6001C1B")]
		public override bool TryGetValue(CustomStyleProperty<Color> property, out Color value) { }

		[Address(RVA = "0x326AAA0", Offset = "0x3269EA0", Length = "0x114")]
		[Token(Token = "0x6001C1C")]
		public override bool TryGetValue(CustomStyleProperty<Texture2D> property, out Texture2D value) { }

		[Address(RVA = "0x326AEC0", Offset = "0x326A2C0", Length = "0x114")]
		[Token(Token = "0x6001C1D")]
		public override bool TryGetValue(CustomStyleProperty<Sprite> property, out Sprite value) { }

		[Address(RVA = "0x326ADA0", Offset = "0x326A1A0", Length = "0x114")]
		[Token(Token = "0x6001C1E")]
		public override bool TryGetValue(CustomStyleProperty<VectorImage> property, out VectorImage value) { }

		[Address(RVA = "0x326AFE0", Offset = "0x326A3E0", Length = "0xB8")]
		[Token(Token = "0x6001C1F")]
		public override bool TryGetValue(CustomStyleProperty<String> property, out string value) { }

		[Address(RVA = "0x326ABC0", Offset = "0x3269FC0", Length = "0xBA")]
		[Token(Token = "0x6001C20")]
		private bool TryGetValue(string propertyName, StyleValueType valueType, out StylePropertyValue customProp) { }

	}

	[DefaultMember("Item")]
	[Token(Token = "0x200038A")]
	internal struct Hierarchy
	{
		[Token(Token = "0x4000D14")]
		private const string k_InvalidHierarchyChangeMsg = "Cannot modify VisualElement hierarchy during layout calculation"; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D15")]
		private readonly VisualElement m_Owner; //Field offset: 0x0

		[Token(Token = "0x17000794")]
		public int childCount
		{
			[Address(RVA = "0x326D2E0", Offset = "0x326C6E0", Length = "0x47")]
			[Token(Token = "0x6001BEF")]
			 get { } //Length: 71
		}

		[Token(Token = "0x17000793")]
		internal List<VisualElement> children
		{
			[Address(RVA = "0x326BC30", Offset = "0x326B030", Length = "0x1D")]
			[Token(Token = "0x6001BE4")]
			internal get { } //Length: 29
		}

		[Token(Token = "0x17000795")]
		public VisualElement Item
		{
			[Address(RVA = "0x326C1E0", Offset = "0x326B5E0", Length = "0x5C")]
			[Token(Token = "0x6001BF0")]
			 get { } //Length: 92
		}

		[Token(Token = "0x17000792")]
		public VisualElement parent
		{
			[Address(RVA = "0x326D330", Offset = "0x326C730", Length = "0x1D")]
			[Token(Token = "0x6001BE3")]
			 get { } //Length: 29
		}

		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x6001BE5")]
		internal Hierarchy(VisualElement element) { }

		[Address(RVA = "0x326BA50", Offset = "0x326AE50", Length = "0xAE")]
		[Token(Token = "0x6001BE6")]
		public void Add(VisualElement child) { }

		[Address(RVA = "0x326BB00", Offset = "0x326AF00", Length = "0x123")]
		[Token(Token = "0x6001BEB")]
		internal void BringToFront(VisualElement child) { }

		[Address(RVA = "0x326BC30", Offset = "0x326B030", Length = "0x1D")]
		[Token(Token = "0x6001BF3")]
		public IEnumerable<VisualElement> Children() { }

		[Address(RVA = "0x326BC50", Offset = "0x326B050", Length = "0x58A")]
		[Token(Token = "0x6001BEA")]
		public void Clear() { }

		[Address(RVA = "0x326C1E0", Offset = "0x326B5E0", Length = "0x5C")]
		[Token(Token = "0x6001BF2")]
		public VisualElement ElementAt(int index) { }

		[Address(RVA = "0x326C240", Offset = "0x326B640", Length = "0x9F")]
		[Token(Token = "0x6001BF9")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x326C2E0", Offset = "0x326B6E0", Length = "0x9")]
		[Token(Token = "0x6001BF8")]
		public bool Equals(Hierarchy other) { }

		[Address(RVA = "0x326D2E0", Offset = "0x326C6E0", Length = "0x47")]
		[Token(Token = "0x6001BEF")]
		public int get_childCount() { }

		[Address(RVA = "0x326BC30", Offset = "0x326B030", Length = "0x1D")]
		[Token(Token = "0x6001BE4")]
		internal List<VisualElement> get_children() { }

		[Address(RVA = "0x326C1E0", Offset = "0x326B5E0", Length = "0x5C")]
		[Token(Token = "0x6001BF0")]
		public VisualElement get_Item(int key) { }

		[Address(RVA = "0x326D330", Offset = "0x326C730", Length = "0x1D")]
		[Token(Token = "0x6001BE3")]
		public VisualElement get_parent() { }

		[Address(RVA = "0x326C2F0", Offset = "0x326B6F0", Length = "0x2C")]
		[Token(Token = "0x6001BFA")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x326C320", Offset = "0x326B720", Length = "0x5E")]
		[Token(Token = "0x6001BF1")]
		public int IndexOf(VisualElement element) { }

		[Address(RVA = "0x326C380", Offset = "0x326B780", Length = "0x3CA")]
		[Token(Token = "0x6001BE7")]
		public void Insert(int index, VisualElement child) { }

		[Address(RVA = "0x326C750", Offset = "0x326BB50", Length = "0x104")]
		[Token(Token = "0x6001BEE")]
		private void MoveChildElement(VisualElement child, int currentIndex, int nextIndex) { }

		[Address(RVA = "0x30C25C0", Offset = "0x30C19C0", Length = "0x9")]
		[Token(Token = "0x6001BFB")]
		public static bool op_Equality(Hierarchy x, Hierarchy y) { }

		[Address(RVA = "0x326C860", Offset = "0x326BC60", Length = "0xF1")]
		[Token(Token = "0x6001BED")]
		internal void PlaceBehind(VisualElement child, VisualElement over) { }

		[Address(RVA = "0x326C960", Offset = "0x326BD60", Length = "0x1F0")]
		[Token(Token = "0x6001BF5")]
		private void PutChildAtIndex(VisualElement child, int index) { }

		[Address(RVA = "0x326CB60", Offset = "0x326BF60", Length = "0xFC")]
		[Token(Token = "0x6001BF7")]
		private void ReleaseChildList() { }

		[Address(RVA = "0x326D020", Offset = "0x326C420", Length = "0x127")]
		[Token(Token = "0x6001BE8")]
		public void Remove(VisualElement child) { }

		[Address(RVA = "0x326CC60", Offset = "0x326C060", Length = "0x333")]
		[Token(Token = "0x6001BE9")]
		public void RemoveAt(int index) { }

		[Address(RVA = "0x326CFA0", Offset = "0x326C3A0", Length = "0x78")]
		[Token(Token = "0x6001BF6")]
		private void RemoveChildAtIndex(int index) { }

		[Address(RVA = "0x326D150", Offset = "0x326C550", Length = "0x9F")]
		[Token(Token = "0x6001BEC")]
		internal void SendToBack(VisualElement child) { }

		[Address(RVA = "0x326D1F0", Offset = "0x326C5F0", Length = "0xEF")]
		[Token(Token = "0x6001BF4")]
		private void SetParent(VisualElement value) { }

	}

	[Token(Token = "0x2000389")]
	internal enum MeasureMode : int
	{
		Undefined = 0,
		Exactly = 1,
		AtMost = 2,
	}

	[Token(Token = "0x200038E")]
	private class SimpleScheduledItem : VisualElementScheduledItem<Action>
	{

		[Address(RVA = "0x3278830", Offset = "0x3277C30", Length = "0x58")]
		[Token(Token = "0x6001C16")]
		public SimpleScheduledItem(VisualElement handler, Action updateEvent) { }

		[Address(RVA = "0x32787F0", Offset = "0x3277BF0", Length = "0x31")]
		[Token(Token = "0x6001C17")]
		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	[Token(Token = "0x200038D")]
	private class TimerStateScheduledItem : VisualElementScheduledItem<Action`1<TimerState>>
	{

		[Address(RVA = "0x327E3D0", Offset = "0x327D7D0", Length = "0x58")]
		[Token(Token = "0x6001C14")]
		public TimerStateScheduledItem(VisualElement handler, Action<TimerState> updateEvent) { }

		[Address(RVA = "0x327E390", Offset = "0x327D790", Length = "0x39")]
		[Token(Token = "0x6001C15")]
		public virtual void PerformTimerUpdate(TimerState state) { }

	}

	[Token(Token = "0x2000390")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	public class TypeData
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000D1F")]
		private readonly Type <type>k__BackingField; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D20")]
		private string m_FullTypeName; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D21")]
		private string m_TypeName; //Field offset: 0x20

		[Token(Token = "0x1700079B")]
		public string fullTypeName
		{
			[Address(RVA = "0x3280590", Offset = "0x327F990", Length = "0x53")]
			[Token(Token = "0x6001C25")]
			 get { } //Length: 83
		}

		[Token(Token = "0x1700079A")]
		public Type type
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001C23")]
			 get { } //Length: 5
		}

		[Token(Token = "0x1700079C")]
		public string typeName
		{
			[Address(RVA = "0x32805F0", Offset = "0x327F9F0", Length = "0xC6")]
			[Token(Token = "0x6001C26")]
			 get { } //Length: 198
		}

		[Address(RVA = "0x3280520", Offset = "0x327F920", Length = "0x70")]
		[Token(Token = "0x6001C24")]
		public TypeData(Type type) { }

		[Address(RVA = "0x3280590", Offset = "0x327F990", Length = "0x53")]
		[Token(Token = "0x6001C25")]
		public string get_fullTypeName() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001C23")]
		public Type get_type() { }

		[Address(RVA = "0x32805F0", Offset = "0x327F9F0", Length = "0xC6")]
		[Token(Token = "0x6001C26")]
		public string get_typeName() { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000387")]
	internal class UxmlFactory : UxmlFactory<VisualElement, UxmlTraits>
	{

		[Address(RVA = "0x3281CA0", Offset = "0x32810A0", Length = "0x39")]
		[Token(Token = "0x6001BDE")]
		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	[Token(Token = "0x2000388")]
	internal class UxmlTraits : UxmlTraits
	{
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000D02")]
		protected UxmlStringAttributeDescription m_Name; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000D03")]
		private UxmlBoolAttributeDescription m_EnabledSelf; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000D04")]
		private UxmlStringAttributeDescription m_ViewDataKey; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000D05")]
		protected UxmlEnumAttributeDescription<PickingMode> m_PickingMode; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000D06")]
		private UxmlStringAttributeDescription m_Tooltip; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000D07")]
		private UxmlEnumAttributeDescription<UsageHints> m_UsageHints; //Field offset: 0x40
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000D08")]
		private UxmlIntAttributeDescription <focusIndex>k__BackingField; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000D09")]
		private UxmlIntAttributeDescription m_TabIndex; //Field offset: 0x50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000D0A")]
		private UxmlBoolAttributeDescription <focusable>k__BackingField; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000D0B")]
		private UxmlStringAttributeDescription m_Class; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000D0C")]
		private UxmlStringAttributeDescription m_ContentContainer; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000D0D")]
		private UxmlStringAttributeDescription m_Style; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000D0E")]
		private UxmlAssetAttributeDescription<Object> m_DataSource; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000D0F")]
		private UxmlStringAttributeDescription m_DataSourcePath; //Field offset: 0x80

		[Token(Token = "0x17000791")]
		protected UxmlBoolAttributeDescription focusable
		{
			[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001BE0")]
			 get { } //Length: 5
		}

		[Token(Token = "0x17000790")]
		protected UxmlIntAttributeDescription focusIndex
		{
			[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001BDF")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x3282270", Offset = "0x3281670", Length = "0x699")]
		[Token(Token = "0x6001BE2")]
		public UxmlTraits() { }

		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001BE0")]
		protected UxmlBoolAttributeDescription get_focusable() { }

		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001BDF")]
		protected UxmlIntAttributeDescription get_focusIndex() { }

		[Address(RVA = "0x3281CE0", Offset = "0x32810E0", Length = "0x582")]
		[Token(Token = "0x6001BE1")]
		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	[Token(Token = "0x200038C")]
	private abstract class VisualElementScheduledItem : BaseVisualElementScheduledItem
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000D1C")]
		public ActionType updateEvent; //Field offset: 0x0

		[Address(RVA = "0x1408700", Offset = "0x1407B00", Length = "0x32")]
		[Token(Token = "0x6001C13")]
		public VisualElementScheduledItem`1(VisualElement handler, ActionType upEvent) { }

	}

	[Token(Token = "0x4000CA2")]
	internal static uint s_NextId; //Field offset: 0x0
	[Token(Token = "0x4000CF1")]
	internal const string k_RootVisualContainerName = "rootVisualContainer"; //Field offset: 0x0
	[Token(Token = "0x4000CF0")]
	private const string k_LinkedTemplateAssetOwnerPropertyName = "--unity-linked-template-asset-owner"; //Field offset: 0x0
	[Token(Token = "0x4000CEF")]
	private const string k_VisualElementAssetPropertyName = "--unity-visual-element-asset-property"; //Field offset: 0x0
	[Token(Token = "0x4000CB6")]
	private const VisualElementFlags worldTransformInverseDirtyDependencies = 3; //Field offset: 0x0
	[Token(Token = "0x4000CB4")]
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = 25; //Field offset: 0x0
	[Token(Token = "0x4000CA3")]
	private static List<String> s_EmptyClassList; //Field offset: 0x8
	[Token(Token = "0x4000CA4")]
	internal static readonly PropertyName userDataPropertyKey; //Field offset: 0x10
	[Token(Token = "0x4000CA5")]
	public static readonly string disabledUssClassName; //Field offset: 0x18
	[Token(Token = "0x4000CC4")]
	internal static int s_FinalizerCount; //Field offset: 0x20
	[Token(Token = "0x4000CC9")]
	private static readonly ProfilerMarker k_GenerateVisualContentMarker; //Field offset: 0x28
	[Token(Token = "0x4000CCB")]
	internal static readonly BindingId childCountProperty; //Field offset: 0x30
	[Token(Token = "0x4000CCC")]
	internal static readonly BindingId contentRectProperty; //Field offset: 0xC8
	[Token(Token = "0x4000CCD")]
	internal static readonly BindingId dataSourcePathProperty; //Field offset: 0x160
	[Token(Token = "0x4000CCE")]
	internal static readonly BindingId dataSourceProperty; //Field offset: 0x1F8
	[Token(Token = "0x4000CCF")]
	internal static readonly BindingId disablePlayModeTintProperty; //Field offset: 0x290
	[Token(Token = "0x4000CD0")]
	internal static readonly BindingId enabledInHierarchyProperty; //Field offset: 0x328
	[Token(Token = "0x4000CD1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal static readonly BindingId enabledSelfProperty; //Field offset: 0x3C0
	[Token(Token = "0x4000CD2")]
	internal static readonly BindingId layoutProperty; //Field offset: 0x458
	[Token(Token = "0x4000CD3")]
	internal static readonly BindingId languageDirectionProperty; //Field offset: 0x4F0
	[Token(Token = "0x4000CD4")]
	internal static readonly BindingId localBoundProperty; //Field offset: 0x588
	[Token(Token = "0x4000CD5")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal static readonly BindingId nameProperty; //Field offset: 0x620
	[Token(Token = "0x4000CD6")]
	internal static readonly BindingId panelProperty; //Field offset: 0x6B8
	[Token(Token = "0x4000CD7")]
	internal static readonly BindingId pickingModeProperty; //Field offset: 0x750
	[Token(Token = "0x4000CD8")]
	internal static readonly BindingId styleSheetsProperty; //Field offset: 0x7E8
	[Token(Token = "0x4000CD9")]
	internal static readonly BindingId tooltipProperty; //Field offset: 0x880
	[Token(Token = "0x4000CDA")]
	internal static readonly BindingId usageHintsProperty; //Field offset: 0x918
	[Token(Token = "0x4000CDB")]
	internal static readonly BindingId userDataProperty; //Field offset: 0x9B0
	[Token(Token = "0x4000CDC")]
	internal static readonly BindingId viewDataKeyProperty; //Field offset: 0xA48
	[Token(Token = "0x4000CDD")]
	internal static readonly BindingId visibleProperty; //Field offset: 0xAE0
	[Token(Token = "0x4000CDE")]
	internal static readonly BindingId visualTreeAssetSourceProperty; //Field offset: 0xB78
	[Token(Token = "0x4000CDF")]
	internal static readonly BindingId worldBoundProperty; //Field offset: 0xC10
	[Token(Token = "0x4000CE0")]
	internal static readonly BindingId worldTransformProperty; //Field offset: 0xCA8
	[Token(Token = "0x4000CEB")]
	private static uint s_NextParentVersion; //Field offset: 0xD40
	[Token(Token = "0x4000CF6")]
	private static readonly List<VisualElement> s_EmptyList; //Field offset: 0xD48
	[Token(Token = "0x4000CFA")]
	internal static CustomStyleAccess s_CustomStyleAccess; //Field offset: 0xD50
	[Token(Token = "0x4000CFE")]
	private static readonly Regex s_InternalStyleSheetPath; //Field offset: 0xD58
	[Token(Token = "0x4000CFF")]
	internal static readonly PropertyName tooltipPropertyKey; //Field offset: 0xD60
	[Token(Token = "0x4000D00")]
	private static readonly Dictionary<Type, TypeData> s_TypeData; //Field offset: 0xD68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000CA0")]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4000CA1")]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; //Field offset: 0x34
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000CA6")]
	private string m_Name; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CA7")]
	private List<String> m_ClassList; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CA8")]
	private Dictionary<PropertyName, Object> m_PropertyBag; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000CA9")]
	private VisualElementFlags m_Flags; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000CAA")]
	private string m_ViewDataKey; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000CAB")]
	private RenderHints m_RenderHints; //Field offset: 0x60
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000CAC")]
	internal Rect lastLayout; //Field offset: 0x64
	[FieldOffset(Offset = "0x74")]
	[Token(Token = "0x4000CAD")]
	internal Rect lastPseudoPadding; //Field offset: 0x74
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000CAE")]
	internal RenderData renderData; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000CAF")]
	internal RenderData nestedRenderData; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000CB0")]
	internal int hierarchyDepth; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x4000CB1")]
	internal int insertionIndex; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000CB2")]
	private Rect m_Layout; //Field offset: 0xA0
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000CB3")]
	private Rect m_BoundingBox; //Field offset: 0xB0
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4000CB5")]
	private Rect m_WorldBoundingBox; //Field offset: 0xC0
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4000CB7")]
	private Matrix4x4 m_WorldTransformCache; //Field offset: 0xD0
	[FieldOffset(Offset = "0x110")]
	[Token(Token = "0x4000CB8")]
	private Matrix4x4 m_WorldTransformInverseCache; //Field offset: 0x110
	[FieldOffset(Offset = "0x150")]
	[Token(Token = "0x4000CB9")]
	internal PseudoStates triggerPseudoMask; //Field offset: 0x150
	[FieldOffset(Offset = "0x154")]
	[Token(Token = "0x4000CBA")]
	internal PseudoStates dependencyPseudoMask; //Field offset: 0x154
	[FieldOffset(Offset = "0x158")]
	[Token(Token = "0x4000CBB")]
	private PseudoStates m_PseudoStates; //Field offset: 0x158
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x15C")]
	[Token(Token = "0x4000CBC")]
	private int <containedPointerIds>k__BackingField; //Field offset: 0x15C
	[FieldOffset(Offset = "0x160")]
	[Token(Token = "0x4000CBD")]
	private PickingMode m_PickingMode; //Field offset: 0x160
	[FieldOffset(Offset = "0x168")]
	[Token(Token = "0x4000CBE")]
	private LayoutNode m_LayoutNode; //Field offset: 0x168
	[FieldOffset(Offset = "0x1A8")]
	[Token(Token = "0x4000CBF")]
	internal ComputedStyle m_Style; //Field offset: 0x1A8
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x4000CC0")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal StyleVariableContext variableContext; //Field offset: 0x1F8
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x4000CC1")]
	internal int inheritedStylesHash; //Field offset: 0x200
	[FieldOffset(Offset = "0x204")]
	[Token(Token = "0x4000CC2")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal readonly uint controlid; //Field offset: 0x204
	[FieldOffset(Offset = "0x208")]
	[Token(Token = "0x4000CC3")]
	internal int imguiContainerDescendantCount; //Field offset: 0x208
	[FieldOffset(Offset = "0x20C")]
	[Token(Token = "0x4000CC5")]
	private bool m_EnabledSelf; //Field offset: 0x20C
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x4000CC6")]
	private LanguageDirection m_LanguageDirection; //Field offset: 0x210
	[FieldOffset(Offset = "0x214")]
	[Token(Token = "0x4000CC7")]
	private LanguageDirection m_LocalLanguageDirection; //Field offset: 0x214
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000CC8")]
	private Action<MeshGenerationContext> <generateVisualContent>k__BackingField; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000CCA")]
	private List<IValueAnimationUpdate> m_RunningAnimations; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000CE1")]
	private object m_DataSource; //Field offset: 0x228
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000CE2")]
	private PathRef m_DataSourcePath; //Field offset: 0x230
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000CE3")]
	private List<Binding> m_Bindings; //Field offset: 0x238
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000CE4")]
	private Type <dataSourceType>k__BackingField; //Field offset: 0x240
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000CE5")]
	private readonly int m_TrickleDownHandleEventCategories; //Field offset: 0x248
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000CE6")]
	private readonly int m_BubbleUpHandleEventCategories; //Field offset: 0x24C
	[FieldOffset(Offset = "0x250")]
	[Token(Token = "0x4000CE7")]
	private int m_BubbleUpEventCallbackCategories; //Field offset: 0x250
	[FieldOffset(Offset = "0x254")]
	[Token(Token = "0x4000CE8")]
	private int m_TrickleDownEventCallbackCategories; //Field offset: 0x254
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4000CE9")]
	private int m_EventInterestSelfCategories; //Field offset: 0x258
	[FieldOffset(Offset = "0x25C")]
	[Token(Token = "0x4000CEA")]
	private int m_CachedEventInterestParentCategories; //Field offset: 0x25C
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4000CEC")]
	private uint m_NextParentCachedVersion; //Field offset: 0x260
	[FieldOffset(Offset = "0x264")]
	[Token(Token = "0x4000CED")]
	private uint m_NextParentRequiredVersion; //Field offset: 0x264
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4000CEE")]
	private VisualElement m_CachedNextParentWithEventInterests; //Field offset: 0x268
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x270")]
	[Token(Token = "0x4000CF2")]
	private readonly Hierarchy <hierarchy>k__BackingField; //Field offset: 0x270
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4000CF3")]
	private bool <cacheAsBitmap>k__BackingField; //Field offset: 0x278
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4000CF4")]
	private VisualElement m_PhysicalParent; //Field offset: 0x280
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4000CF5")]
	private VisualElement m_LogicalParent; //Field offset: 0x288
	[FieldOffset(Offset = "0x290")]
	[Token(Token = "0x4000CF7")]
	private List<VisualElement> m_Children; //Field offset: 0x290
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x298")]
	[Token(Token = "0x4000CF8")]
	private BaseVisualElementPanel <elementPanel>k__BackingField; //Field offset: 0x298
	[FieldOffset(Offset = "0x2A0")]
	[Token(Token = "0x4000CF9")]
	private VisualTreeAsset m_VisualTreeAssetSource; //Field offset: 0x2A0
	[FieldOffset(Offset = "0x2A8")]
	[Token(Token = "0x4000CFB")]
	internal InlineStyleAccess inlineStyleAccess; //Field offset: 0x2A8
	[FieldOffset(Offset = "0x2B0")]
	[Token(Token = "0x4000CFC")]
	internal ResolvedStyleAccess resolvedStyleAccess; //Field offset: 0x2B0
	[FieldOffset(Offset = "0x2B8")]
	[Token(Token = "0x4000CFD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<StyleSheet> styleSheetList; //Field offset: 0x2B8
	[FieldOffset(Offset = "0x2C0")]
	[Token(Token = "0x4000D01")]
	private TypeData m_TypeData; //Field offset: 0x2C0

	[Token(Token = "0x17000731")]
	internal bool areAncestorsAndSelfDisplayed
	{
		[Address(RVA = "0x3262FD0", Offset = "0x32623D0", Length = "0x9")]
		[Token(Token = "0x6001AC3")]
		internal get { } //Length: 9
		[Address(RVA = "0x32658F0", Offset = "0x3264CF0", Length = "0x84")]
		[Token(Token = "0x6001AC4")]
		internal set { } //Length: 132
	}

	[Token(Token = "0x1700074A")]
	internal Rect boundingBox
	{
		[Address(RVA = "0x32630F0", Offset = "0x32624F0", Length = "0x42")]
		[Token(Token = "0x6001AEC")]
		internal get { } //Length: 66
	}

	[Token(Token = "0x1700075D")]
	internal bool boundingBoxDirtiedSinceLastLayoutPass
	{
		[Address(RVA = "0x3262FE0", Offset = "0x32623E0", Length = "0x9")]
		[Token(Token = "0x6001B09")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265980", Offset = "0x3264D80", Length = "0x2D")]
		[Token(Token = "0x6001B0A")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x1700074D")]
	private Rect boundingBoxInParentSpace
	{
		[Address(RVA = "0x3262FF0", Offset = "0x32623F0", Length = "0x51")]
		[Token(Token = "0x6001AEF")]
		private get { } //Length: 81
	}

	[Token(Token = "0x1700074B")]
	internal Rect boundingBoxWithoutNested
	{
		[Address(RVA = "0x3263050", Offset = "0x3262450", Length = "0x9F")]
		[Token(Token = "0x6001AED")]
		internal get { } //Length: 159
	}

	[Token(Token = "0x17000737")]
	public virtual bool canGrabFocus
	{
		[Address(RVA = "0x3263140", Offset = "0x3262540", Length = "0x105")]
		[Token(Token = "0x6001ACE")]
		 get { } //Length: 261
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000783")]
	public int childCount
	{
		[Address(RVA = "0x3263250", Offset = "0x3262650", Length = "0x83")]
		[Token(Token = "0x6001B9E")]
		 get { } //Length: 131
	}

	[Token(Token = "0x17000762")]
	internal List<String> classList
	{
		[Address(RVA = "0x32632E0", Offset = "0x32626E0", Length = "0xB1")]
		[Token(Token = "0x6001B19")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 177
	}

	[Token(Token = "0x17000766")]
	internal ComputedStyle computedStyle
	{
		[Address(RVA = "0x32633A0", Offset = "0x32627A0", Length = "0x8")]
		[Token(Token = "0x6001B1D")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700075F")]
	internal int containedPointerIds
	{
		[Address(RVA = "0x2EC3330", Offset = "0x2EC2730", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001B0F")]
		internal get { } //Length: 7
		[Address(RVA = "0x2EC3610", Offset = "0x2EC2A10", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001B10")]
		internal set { } //Length: 7
	}

	[Token(Token = "0x17000780")]
	public override VisualElement contentContainer
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x6001B93")]
		 get { } //Length: 6
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000742")]
	public Rect contentRect
	{
		[Address(RVA = "0x32633B0", Offset = "0x32627B0", Length = "0x312")]
		[Token(Token = "0x6001AE0")]
		 get { } //Length: 786
	}

	[Token(Token = "0x1700078C")]
	public ICustomStyle customStyle
	{
		[Address(RVA = "0x32636D0", Offset = "0x3262AD0", Length = "0x8E")]
		[Token(Token = "0x6001BD1")]
		 get { } //Length: 142
	}

	[CreateProperty]
	[Token(Token = "0x17000771")]
	public object dataSource
	{
		[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
		[Token(Token = "0x6001B66")]
		 get { } //Length: 8
		[Address(RVA = "0x3265C60", Offset = "0x3265060", Length = "0xE0")]
		[Token(Token = "0x6001B67")]
		 set { } //Length: 224
	}

	[CreateProperty]
	[Token(Token = "0x17000772")]
	public PropertyPath dataSourcePath
	{
		[Address(RVA = "0x3263760", Offset = "0x3262B60", Length = "0xC9")]
		[Token(Token = "0x6001B68")]
		 get { } //Length: 201
		[Address(RVA = "0x32659B0", Offset = "0x3264DB0", Length = "0x2A0")]
		[Token(Token = "0x6001B69")]
		 set { } //Length: 672
	}

	[Token(Token = "0x1700077B")]
	internal bool disableClipping
	{
		[Address(RVA = "0x3263830", Offset = "0x3262C30", Length = "0x9")]
		[Token(Token = "0x6001B8A")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265D40", Offset = "0x3265140", Length = "0x2D")]
		[Token(Token = "0x6001B8B")]
		internal set { } //Length: 45
	}

	[CreateProperty]
	[Token(Token = "0x17000739")]
	public bool disablePlayModeTint
	{
		[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
		[Token(Token = "0x6001AD0")]
		 get { } //Length: 5
		[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
		[Token(Token = "0x6001AD1")]
		 set { } //Length: 3
	}

	[Token(Token = "0x1700077C")]
	internal bool disableRendering
	{
		[Address(RVA = "0x3263840", Offset = "0x3262C40", Length = "0x9")]
		[Token(Token = "0x6001B8D")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265D70", Offset = "0x3265170", Length = "0x56")]
		[Token(Token = "0x6001B8E")]
		internal set { } //Length: 86
	}

	[Token(Token = "0x1700077E")]
	internal BaseVisualElementPanel elementPanel
	{
		[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001B90")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 8
		[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001B91")]
		private set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700076A")]
	public bool enabledInHierarchy
	{
		[Address(RVA = "0x3263860", Offset = "0x3262C60", Length = "0x10")]
		[Token(Token = "0x6001B30")]
		 get { } //Length: 16
	}

	[CreateProperty]
	[Token(Token = "0x1700076B")]
	public bool enabledSelf
	{
		[Address(RVA = "0x3263870", Offset = "0x3262C70", Length = "0x8")]
		[Token(Token = "0x6001B31")]
		 get { } //Length: 8
		[Address(RVA = "0x3265DD0", Offset = "0x32651D0", Length = "0x8E")]
		[Token(Token = "0x6001B32")]
		 set { } //Length: 142
	}

	[Token(Token = "0x17000735")]
	internal bool enableViewDataPersistence
	{
		[Address(RVA = "0x3263850", Offset = "0x3262C50", Length = "0x9")]
		[Token(Token = "0x6001ACB")]
		internal get { } //Length: 9
	}

	[Token(Token = "0x17000775")]
	internal int eventInterestParentCategories
	{
		[Address(RVA = "0x3263880", Offset = "0x3262C80", Length = "0x3B")]
		[Token(Token = "0x6001B77")]
		internal get { } //Length: 59
	}

	[Token(Token = "0x17000777")]
	public IExperimentalFeatures experimental
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x6001B86")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000733")]
	internal VisualElementFlags flags
	{
		[Address(RVA = "0x32638C0", Offset = "0x3262CC0", Length = "0x56")]
		[Token(Token = "0x6001AC7")]
		internal get { } //Length: 86
		[Address(RVA = "0x3265E60", Offset = "0x3265260", Length = "0xAA")]
		[Token(Token = "0x6001AC8")]
		internal set { } //Length: 170
	}

	[Token(Token = "0x17000738")]
	public virtual FocusController focusController
	{
		[Address(RVA = "0x3263920", Offset = "0x3262D20", Length = "0xD1")]
		[Token(Token = "0x6001ACF")]
		 get { } //Length: 209
	}

	[Token(Token = "0x17000763")]
	internal string fullTypeName
	{
		[Address(RVA = "0x3263A00", Offset = "0x3262E00", Length = "0x23")]
		[Token(Token = "0x6001B1A")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 35
	}

	[Token(Token = "0x1700076F")]
	public Action<MeshGenerationContext> generateVisualContent
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001B3C")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6001B3D")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000788")]
	private bool has3DRotation
	{
		[Address(RVA = "0x3263A30", Offset = "0x3262E30", Length = "0x112")]
		[Token(Token = "0x6001BBA")]
		private get { } //Length: 274
	}

	[Token(Token = "0x17000786")]
	internal bool has3DTransform
	{
		[Address(RVA = "0x3263B50", Offset = "0x3262F50", Length = "0x173")]
		[Token(Token = "0x6001BB8")]
		internal get { } //Length: 371
	}

	[Token(Token = "0x17000787")]
	private bool has3DTranslation
	{
		[Address(RVA = "0x3263CD0", Offset = "0x32630D0", Length = "0x35")]
		[Token(Token = "0x6001BB9")]
		private get { } //Length: 53
	}

	[Token(Token = "0x1700072C")]
	internal bool hasCompletedAnimations
	{
		[Address(RVA = "0x3263D10", Offset = "0x3263110", Length = "0x4E")]
		[Token(Token = "0x6001A9E")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000785")]
	internal bool hasDefaultRotationAndScale
	{
		[Address(RVA = "0x3263D60", Offset = "0x3263160", Length = "0x12B")]
		[Token(Token = "0x6001BB7")]
		internal get { } //Length: 299
	}

	[Token(Token = "0x17000767")]
	internal bool hasInlineStyle
	{
		[Address(RVA = "0x3263E90", Offset = "0x3263290", Length = "0xC")]
		[Token(Token = "0x6001B1E")]
		internal get { } //Length: 12
	}

	[Token(Token = "0x17000732")]
	internal bool hasOneOrMorePointerCaptures
	{
		[Address(RVA = "0x3263EA0", Offset = "0x32632A0", Length = "0x9")]
		[Token(Token = "0x6001AC5")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265F10", Offset = "0x3265310", Length = "0x2D")]
		[Token(Token = "0x6001AC6")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x1700072B")]
	internal bool hasRunningAnimations
	{
		[Address(RVA = "0x3263EB0", Offset = "0x32632B0", Length = "0x4E")]
		[Token(Token = "0x6001A9D")]
		internal get { } //Length: 78
	}

	[Token(Token = "0x17000779")]
	public Hierarchy hierarchy
	{
		[Address(RVA = "0x3263F00", Offset = "0x3263300", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001B88")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000747")]
	internal bool isBoundingBoxDirty
	{
		[Address(RVA = "0x3263F10", Offset = "0x3263310", Length = "0x9")]
		[Token(Token = "0x6001AE8")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265F40", Offset = "0x3265340", Length = "0x2B")]
		[Token(Token = "0x6001AE9")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x17000730")]
	internal bool isCompositeRoot
	{
		[Address(RVA = "0x3263F20", Offset = "0x3263320", Length = "0x9")]
		[Token(Token = "0x6001AC1")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265F70", Offset = "0x3265370", Length = "0x2D")]
		[Token(Token = "0x6001AC2")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000773")]
	internal bool isDataSourcePathEmpty
	{
		[Address(RVA = "0x3263F30", Offset = "0x3263330", Length = "0x28")]
		[Token(Token = "0x6001B6A")]
		internal get { } //Length: 40
	}

	[Token(Token = "0x17000776")]
	internal bool isEventInterestParentCategoriesDirty
	{
		[Address(RVA = "0x3263F60", Offset = "0x3263360", Length = "0x9")]
		[Token(Token = "0x6001B78")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265FA0", Offset = "0x32653A0", Length = "0x2B")]
		[Token(Token = "0x6001B79")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x1700073E")]
	internal bool isLayoutManual
	{
		[Address(RVA = "0x3263F70", Offset = "0x3263370", Length = "0x9")]
		[Token(Token = "0x6001AD9")]
		internal get { } //Length: 9
		[Address(RVA = "0x3265FD0", Offset = "0x32653D0", Length = "0x2B")]
		[Token(Token = "0x6001ADA")]
		private set { } //Length: 43
	}

	[Token(Token = "0x17000745")]
	internal bool isLocalBounds3DDirty
	{
		[Address(RVA = "0x3263F80", Offset = "0x3263380", Length = "0xB")]
		[Token(Token = "0x6001AE4")]
		internal get { } //Length: 11
		[Address(RVA = "0x3266000", Offset = "0x3265400", Length = "0x2D")]
		[Token(Token = "0x6001AE5")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000746")]
	internal bool isLocalBoundsWithoutNested3DDirty
	{
		[Address(RVA = "0x3263F90", Offset = "0x3263390", Length = "0xB")]
		[Token(Token = "0x6001AE6")]
		internal get { } //Length: 11
		[Address(RVA = "0x3266030", Offset = "0x3265430", Length = "0x2D")]
		[Token(Token = "0x6001AE7")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000769")]
	private bool isParentEnabledInHierarchy
	{
		[Address(RVA = "0x3263FA0", Offset = "0x32633A0", Length = "0x67")]
		[Token(Token = "0x6001B2F")]
		private get { } //Length: 103
	}

	[Token(Token = "0x1700077A")]
	internal bool isRootVisualContainer
	{
		[Address(RVA = "0x3264010", Offset = "0x3263410", Length = "0x40")]
		[Token(Token = "0x6001B89")]
		internal get { } //Length: 64
	}

	[Token(Token = "0x17000748")]
	internal bool isWorldBoundingBoxDirty
	{
		[Address(RVA = "0x3266060", Offset = "0x3265460", Length = "0x2B")]
		[Token(Token = "0x6001AEA")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x17000749")]
	internal bool isWorldBoundingBoxOrDependenciesDirty
	{
		[Address(RVA = "0x3264050", Offset = "0x3263450", Length = "0x8")]
		[Token(Token = "0x6001AEB")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000754")]
	internal bool isWorldSpaceRootUIDocument
	{
		[Address(RVA = "0x3264060", Offset = "0x3263460", Length = "0x9")]
		[Token(Token = "0x6001AF9")]
		internal get { } //Length: 9
		[Address(RVA = "0x3266090", Offset = "0x3265490", Length = "0x2D")]
		[Token(Token = "0x6001AFA")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000755")]
	internal bool isWorldTransformDirty
	{
		[Address(RVA = "0x1F0D340", Offset = "0x1F0C740", Length = "0x7")]
		[Token(Token = "0x6001AFB")]
		internal get { } //Length: 7
		[Address(RVA = "0x2593ED0", Offset = "0x25932D0", Length = "0x2B")]
		[Token(Token = "0x6001AFC")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x17000756")]
	internal bool isWorldTransformInverseDirty
	{
		[Address(RVA = "0x2593F00", Offset = "0x2593300", Length = "0x2B")]
		[Token(Token = "0x6001AFD")]
		internal set { } //Length: 43
	}

	[Token(Token = "0x17000757")]
	internal bool isWorldTransformInverseOrDependenciesDirty
	{
		[Address(RVA = "0x3264070", Offset = "0x3263470", Length = "0x8")]
		[Token(Token = "0x6001AFE")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x17000782")]
	public VisualElement Item
	{
		[Address(RVA = "0x3262F30", Offset = "0x3262330", Length = "0x9C")]
		[Token(Token = "0x6001B9D")]
		 get { } //Length: 156
	}

	[CreateProperty]
	[Token(Token = "0x1700076C")]
	public LanguageDirection languageDirection
	{
		[Address(RVA = "0x3264080", Offset = "0x3263480", Length = "0x7")]
		[Token(Token = "0x6001B35")]
		 get { } //Length: 7
		[Address(RVA = "0x32660C0", Offset = "0x32654C0", Length = "0x89")]
		[Token(Token = "0x6001B36")]
		 set { } //Length: 137
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000741")]
	public internal Rect layout
	{
		[Address(RVA = "0x32640A0", Offset = "0x32634A0", Length = "0x106")]
		[Token(Token = "0x6001ADD")]
		 get { } //Length: 262
		[Address(RVA = "0x3266150", Offset = "0x3265550", Length = "0x8E9")]
		[Token(Token = "0x6001ADE")]
		internal set { } //Length: 2281
	}

	[Token(Token = "0x17000765")]
	internal LayoutNode layoutNode
	{
		[Address(RVA = "0x3264090", Offset = "0x3263490", Length = "0xA")]
		[Token(Token = "0x6001B1C")]
		internal get { } //Length: 10
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000752")]
	public Rect localBound
	{
		[Address(RVA = "0x32641B0", Offset = "0x32635B0", Length = "0xC1")]
		[Token(Token = "0x6001AF7")]
		 get { } //Length: 193
	}

	[Token(Token = "0x1700074E")]
	internal Bounds localBounds3D
	{
		[Address(RVA = "0x3264330", Offset = "0x3263730", Length = "0xA0")]
		[Token(Token = "0x6001AF2")]
		internal get { } //Length: 160
	}

	[Token(Token = "0x17000750")]
	internal Bounds localBounds3DWithoutNested3D
	{
		[Address(RVA = "0x3264280", Offset = "0x3263680", Length = "0xA1")]
		[Token(Token = "0x6001AF4")]
		internal get { } //Length: 161
	}

	[Token(Token = "0x1700074F")]
	internal Bounds localBoundsPicking3D
	{
		[Address(RVA = "0x32643D0", Offset = "0x32637D0", Length = "0xA0")]
		[Token(Token = "0x6001AF3")]
		internal get { } //Length: 160
	}

	[Token(Token = "0x1700076D")]
	internal LanguageDirection localLanguageDirection
	{
		[Address(RVA = "0x1DBB140", Offset = "0x1DBA540", Length = "0x7")]
		[Token(Token = "0x6001B37")]
		internal get { } //Length: 7
		[Address(RVA = "0x3266A40", Offset = "0x3265E40", Length = "0x103")]
		[Token(Token = "0x6001B38")]
		internal set { } //Length: 259
	}

	[CreateProperty]
	[Token(Token = "0x17000761")]
	public string name
	{
		[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
		[Token(Token = "0x6001B17")]
		 get { } //Length: 7
		[Address(RVA = "0x3266B50", Offset = "0x3265F50", Length = "0xBA")]
		[Token(Token = "0x6001B18")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000744")]
	internal bool needs3DBounds
	{
		[Address(RVA = "0x3264470", Offset = "0x3263870", Length = "0xB")]
		[Token(Token = "0x6001AE2")]
		internal get { } //Length: 11
		[Address(RVA = "0x3266C10", Offset = "0x3266010", Length = "0x2D")]
		[Token(Token = "0x6001AE3")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000774")]
	internal VisualElement nextParentWithEventInterests
	{
		[Address(RVA = "0x3264480", Offset = "0x3263880", Length = "0x1D5")]
		[Token(Token = "0x6001B74")]
		internal get { } //Length: 469
	}

	[Token(Token = "0x17000743")]
	protected Rect paddingRect
	{
		[Address(RVA = "0x3264660", Offset = "0x3263A60", Length = "0x1EF")]
		[Token(Token = "0x6001AE1")]
		 get { } //Length: 495
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700077F")]
	public IPanel panel
	{
		[Address(RVA = "0x3264850", Offset = "0x3263C50", Length = "0xA")]
		[Token(Token = "0x6001B92")]
		 get { } //Length: 10
	}

	[Token(Token = "0x1700077D")]
	public VisualElement parent
	{
		[Address(RVA = "0x3264860", Offset = "0x3263C60", Length = "0xA")]
		[Token(Token = "0x6001B8F")]
		 get { } //Length: 10
	}

	[CreateProperty]
	[Token(Token = "0x17000760")]
	public PickingMode pickingMode
	{
		[Address(RVA = "0x2EC3340", Offset = "0x2EC2740", Length = "0x7")]
		[Token(Token = "0x6001B15")]
		 get { } //Length: 7
		[Address(RVA = "0x3266C40", Offset = "0x3266040", Length = "0xA4")]
		[Token(Token = "0x6001B16")]
		 set { } //Length: 164
	}

	[Token(Token = "0x1700073A")]
	internal Color playModeTintColor
	{
		[Address(RVA = "0x3264870", Offset = "0x3263C70", Length = "0x39")]
		[Token(Token = "0x6001AD2")]
		internal get { } //Length: 57
	}

	[Token(Token = "0x17000784")]
	private Vector3 positionWithLayout
	{
		[Address(RVA = "0x32648B0", Offset = "0x3263CB0", Length = "0xCA")]
		[Token(Token = "0x6001BB5")]
		private get { } //Length: 202
	}

	[Token(Token = "0x1700075E")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal PseudoStates pseudoStates
	{
		[Address(RVA = "0x31809B0", Offset = "0x317FDB0", Length = "0x9")]
		[Token(Token = "0x6001B0B")]
		internal get { } //Length: 9
		[Address(RVA = "0x3266CF0", Offset = "0x32660F0", Length = "0x65")]
		[Token(Token = "0x6001B0C")]
		internal set { } //Length: 101
	}

	[Token(Token = "0x1700075C")]
	internal bool receivesHierarchyGeometryChangedEvents
	{
		[Address(RVA = "0x3264980", Offset = "0x3263D80", Length = "0x9")]
		[Token(Token = "0x6001B07")]
		internal get { } //Length: 9
		[Address(RVA = "0x3266D60", Offset = "0x3266160", Length = "0x2D")]
		[Token(Token = "0x6001B08")]
		internal set { } //Length: 45
	}

	[Token(Token = "0x17000753")]
	internal Rect rect
	{
		[Address(RVA = "0x3264990", Offset = "0x3263D90", Length = "0xA2")]
		[Token(Token = "0x6001AF8")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 162
	}

	[Token(Token = "0x1700073C")]
	internal RenderHints renderHints
	{
		[Address(RVA = "0x3264A40", Offset = "0x3263E40", Length = "0x6")]
		[Token(Token = "0x6001AD5")]
		internal get { } //Length: 6
		[Address(RVA = "0x3266D90", Offset = "0x3266190", Length = "0x61")]
		[Token(Token = "0x6001AD6")]
		internal set { } //Length: 97
	}

	[Token(Token = "0x17000770")]
	internal bool requireMeasureFunction
	{
		[Address(RVA = "0x3264A50", Offset = "0x3263E50", Length = "0x9")]
		[Token(Token = "0x6001B46")]
		internal get { } //Length: 9
		[Address(RVA = "0x3266E00", Offset = "0x3266200", Length = "0xA0")]
		[Token(Token = "0x6001B47")]
		internal set { } //Length: 160
	}

	[CreateProperty]
	[Token(Token = "0x1700078B")]
	public IResolvedStyle resolvedStyle
	{
		[Address(RVA = "0x3264A60", Offset = "0x3263E60", Length = "0x85")]
		[Token(Token = "0x6001BD0")]
		 get { } //Length: 133
	}

	[Token(Token = "0x1700073F")]
	public float scaledPixelsPerPoint
	{
		[Address(RVA = "0x3264AF0", Offset = "0x3263EF0", Length = "0x9F")]
		[Token(Token = "0x6001ADB")]
		 get { } //Length: 159
	}

	[Obsolete("scaledPixelsPerPoint_noChecks is deprecated. Use scaledPixelsPerPoint instead.")]
	[Token(Token = "0x17000740")]
	internal float scaledPixelsPerPoint_noChecks
	{
		[Address(RVA = "0x3264B90", Offset = "0x3263F90", Length = "0x5F")]
		[Token(Token = "0x6001ADC")]
		internal get { } //Length: 95
	}

	[Token(Token = "0x17000789")]
	public IVisualElementScheduler schedule
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x6001BCC")]
		 get { } //Length: 6
	}

	[CreateProperty]
	[Token(Token = "0x1700078A")]
	public IStyle style
	{
		[Address(RVA = "0x3264C30", Offset = "0x3264030", Length = "0x79")]
		[Token(Token = "0x6001BCF")]
		 get { } //Length: 121
	}

	[Token(Token = "0x1700072F")]
	internal IStylePropertyAnimations styleAnimation
	{
		[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
		[Token(Token = "0x6001AA4")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000768")]
	internal bool styleInitialized
	{
		[Address(RVA = "0x3264BF0", Offset = "0x3263FF0", Length = "0x9")]
		[Token(Token = "0x6001B1F")]
		internal get { } //Length: 9
		[Address(RVA = "0x3266EB0", Offset = "0x32662B0", Length = "0x2D")]
		[Token(Token = "0x6001B20")]
		internal set { } //Length: 45
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x1700078D")]
	public VisualElementStyleSheetSet styleSheets
	{
		[Address(RVA = "0x3264C00", Offset = "0x3264000", Length = "0x27")]
		[Token(Token = "0x6001BD2")]
		 get { } //Length: 39
	}

	[CreateProperty]
	[Token(Token = "0x1700078E")]
	public string tooltip
	{
		[Address(RVA = "0x3264CB0", Offset = "0x32640B0", Length = "0x89")]
		[Token(Token = "0x6001BD9")]
		 get { } //Length: 137
		[Address(RVA = "0x3266EE0", Offset = "0x32662E0", Length = "0x22F")]
		[Token(Token = "0x6001BDA")]
		 set { } //Length: 559
	}

	[Token(Token = "0x1700078F")]
	private TypeData typeData
	{
		[Address(RVA = "0x3264D40", Offset = "0x3264140", Length = "0x156")]
		[Token(Token = "0x6001BDB")]
		private get { } //Length: 342
	}

	[Token(Token = "0x17000764")]
	internal string typeName
	{
		[Address(RVA = "0x3264EA0", Offset = "0x32642A0", Length = "0x23")]
		[Token(Token = "0x6001B1B")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
		internal get { } //Length: 35
	}

	[Token(Token = "0x17000778")]
	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation
	{
		[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
		[Token(Token = "0x6001B87")]
		private get { } //Length: 6
	}

	[Token(Token = "0x170006D8")]
	private override Align UnityEngine.UIElements.IResolvedStyle.alignContent
	{
		[Address(RVA = "0x325AD40", Offset = "0x325A140", Length = "0x4F")]
		[Token(Token = "0x6001A4A")]
		private get { } //Length: 79
	}

	[Token(Token = "0x170006D9")]
	private override Align UnityEngine.UIElements.IResolvedStyle.alignItems
	{
		[Address(RVA = "0x325AD90", Offset = "0x325A190", Length = "0x52")]
		[Token(Token = "0x6001A4B")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006DA")]
	private override Align UnityEngine.UIElements.IResolvedStyle.alignSelf
	{
		[Address(RVA = "0x325ADF0", Offset = "0x325A1F0", Length = "0x52")]
		[Token(Token = "0x6001A4C")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006DB")]
	private override Ratio UnityEngine.UIElements.IResolvedStyle.aspectRatio
	{
		[Address(RVA = "0x325AE50", Offset = "0x325A250", Length = "0xCB")]
		[Token(Token = "0x6001A4D")]
		private get { } //Length: 203
	}

	[Token(Token = "0x170006DC")]
	private override Color UnityEngine.UIElements.IResolvedStyle.backgroundColor
	{
		[Address(RVA = "0x325AF20", Offset = "0x325A320", Length = "0xD1")]
		[Token(Token = "0x6001A4E")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006DD")]
	private override Background UnityEngine.UIElements.IResolvedStyle.backgroundImage
	{
		[Address(RVA = "0x325B000", Offset = "0x325A400", Length = "0xD9")]
		[Token(Token = "0x6001A4F")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006DE")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionX
	{
		[Address(RVA = "0x325B0E0", Offset = "0x325A4E0", Length = "0xD9")]
		[Token(Token = "0x6001A50")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006DF")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.backgroundPositionY
	{
		[Address(RVA = "0x325B1C0", Offset = "0x325A5C0", Length = "0xD9")]
		[Token(Token = "0x6001A51")]
		private get { } //Length: 217
	}

	[Token(Token = "0x170006E0")]
	private override BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.backgroundRepeat
	{
		[Address(RVA = "0x325B2A0", Offset = "0x325A6A0", Length = "0xCB")]
		[Token(Token = "0x6001A52")]
		private get { } //Length: 203
	}

	[Token(Token = "0x170006E1")]
	private override BackgroundSize UnityEngine.UIElements.IResolvedStyle.backgroundSize
	{
		[Address(RVA = "0x325B370", Offset = "0x325A770", Length = "0xD7")]
		[Token(Token = "0x6001A53")]
		private get { } //Length: 215
	}

	[Token(Token = "0x170006E2")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor
	{
		[Address(RVA = "0x325B450", Offset = "0x325A850", Length = "0xD1")]
		[Token(Token = "0x6001A54")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006E3")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius
	{
		[Address(RVA = "0x325B530", Offset = "0x325A930", Length = "0x52")]
		[Token(Token = "0x6001A55")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E4")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius
	{
		[Address(RVA = "0x325B590", Offset = "0x325A990", Length = "0x52")]
		[Token(Token = "0x6001A56")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E5")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth
	{
		[Address(RVA = "0x325B5F0", Offset = "0x325A9F0", Length = "0x52")]
		[Token(Token = "0x6001A57")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E6")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor
	{
		[Address(RVA = "0x325B650", Offset = "0x325AA50", Length = "0xD1")]
		[Token(Token = "0x6001A58")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006E7")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth
	{
		[Address(RVA = "0x325B730", Offset = "0x325AB30", Length = "0x52")]
		[Token(Token = "0x6001A59")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006E8")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderRightColor
	{
		[Address(RVA = "0x325B790", Offset = "0x325AB90", Length = "0xD1")]
		[Token(Token = "0x6001A5A")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006E9")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderRightWidth
	{
		[Address(RVA = "0x325B870", Offset = "0x325AC70", Length = "0x52")]
		[Token(Token = "0x6001A5B")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EA")]
	private override Color UnityEngine.UIElements.IResolvedStyle.borderTopColor
	{
		[Address(RVA = "0x325B8D0", Offset = "0x325ACD0", Length = "0xD1")]
		[Token(Token = "0x6001A5C")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006EB")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius
	{
		[Address(RVA = "0x325B9B0", Offset = "0x325ADB0", Length = "0x52")]
		[Token(Token = "0x6001A5D")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EC")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius
	{
		[Address(RVA = "0x325BA10", Offset = "0x325AE10", Length = "0x52")]
		[Token(Token = "0x6001A5E")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006ED")]
	private override float UnityEngine.UIElements.IResolvedStyle.borderTopWidth
	{
		[Address(RVA = "0x325BA70", Offset = "0x325AE70", Length = "0x52")]
		[Token(Token = "0x6001A5F")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EE")]
	private override float UnityEngine.UIElements.IResolvedStyle.bottom
	{
		[Address(RVA = "0x325BAD0", Offset = "0x325AED0", Length = "0x52")]
		[Token(Token = "0x6001A60")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006EF")]
	private override Color UnityEngine.UIElements.IResolvedStyle.color
	{
		[Address(RVA = "0x325BB30", Offset = "0x325AF30", Length = "0xD1")]
		[Token(Token = "0x6001A61")]
		private get { } //Length: 209
	}

	[Token(Token = "0x170006F0")]
	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.display
	{
		[Address(RVA = "0x325BC10", Offset = "0x325B010", Length = "0x52")]
		[Token(Token = "0x6001A62")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F1")]
	private override IEnumerable<FilterFunction> UnityEngine.UIElements.IResolvedStyle.filter
	{
		[Address(RVA = "0x325BC70", Offset = "0x325B070", Length = "0x52")]
		[Token(Token = "0x6001A63")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F2")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.flexBasis
	{
		[Address(RVA = "0x325BCD0", Offset = "0x325B0D0", Length = "0x52")]
		[Token(Token = "0x6001A64")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F3")]
	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection
	{
		[Address(RVA = "0x325BD30", Offset = "0x325B130", Length = "0x52")]
		[Token(Token = "0x6001A65")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F4")]
	private override float UnityEngine.UIElements.IResolvedStyle.flexGrow
	{
		[Address(RVA = "0x325BD90", Offset = "0x325B190", Length = "0x52")]
		[Token(Token = "0x6001A66")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F5")]
	private override float UnityEngine.UIElements.IResolvedStyle.flexShrink
	{
		[Address(RVA = "0x325BDF0", Offset = "0x325B1F0", Length = "0x52")]
		[Token(Token = "0x6001A67")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F6")]
	private override Wrap UnityEngine.UIElements.IResolvedStyle.flexWrap
	{
		[Address(RVA = "0x325BE50", Offset = "0x325B250", Length = "0x52")]
		[Token(Token = "0x6001A68")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F7")]
	private override float UnityEngine.UIElements.IResolvedStyle.fontSize
	{
		[Address(RVA = "0x325BEB0", Offset = "0x325B2B0", Length = "0x52")]
		[Token(Token = "0x6001A69")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F8")]
	private override float UnityEngine.UIElements.IResolvedStyle.height
	{
		[Address(RVA = "0x325BF10", Offset = "0x325B310", Length = "0x52")]
		[Token(Token = "0x6001A6A")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006F9")]
	private override Justify UnityEngine.UIElements.IResolvedStyle.justifyContent
	{
		[Address(RVA = "0x325BF70", Offset = "0x325B370", Length = "0x52")]
		[Token(Token = "0x6001A6B")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006FA")]
	private override float UnityEngine.UIElements.IResolvedStyle.left
	{
		[Address(RVA = "0x325BFD0", Offset = "0x325B3D0", Length = "0x52")]
		[Token(Token = "0x6001A6C")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006FB")]
	private override float UnityEngine.UIElements.IResolvedStyle.letterSpacing
	{
		[Address(RVA = "0x325C030", Offset = "0x325B430", Length = "0x52")]
		[Token(Token = "0x6001A6D")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006FC")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginBottom
	{
		[Address(RVA = "0x325C090", Offset = "0x325B490", Length = "0x52")]
		[Token(Token = "0x6001A6E")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006FD")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginLeft
	{
		[Address(RVA = "0x325C0F0", Offset = "0x325B4F0", Length = "0x52")]
		[Token(Token = "0x6001A6F")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006FE")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginRight
	{
		[Address(RVA = "0x325C150", Offset = "0x325B550", Length = "0x52")]
		[Token(Token = "0x6001A70")]
		private get { } //Length: 82
	}

	[Token(Token = "0x170006FF")]
	private override float UnityEngine.UIElements.IResolvedStyle.marginTop
	{
		[Address(RVA = "0x325C1B0", Offset = "0x325B5B0", Length = "0x52")]
		[Token(Token = "0x6001A71")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000700")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.maxHeight
	{
		[Address(RVA = "0x325C210", Offset = "0x325B610", Length = "0x52")]
		[Token(Token = "0x6001A72")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000701")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.maxWidth
	{
		[Address(RVA = "0x325C270", Offset = "0x325B670", Length = "0x52")]
		[Token(Token = "0x6001A73")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000702")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight
	{
		[Address(RVA = "0x325C2D0", Offset = "0x325B6D0", Length = "0x52")]
		[Token(Token = "0x6001A74")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000703")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth
	{
		[Address(RVA = "0x325C330", Offset = "0x325B730", Length = "0x52")]
		[Token(Token = "0x6001A75")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000704")]
	private override float UnityEngine.UIElements.IResolvedStyle.opacity
	{
		[Address(RVA = "0x325C390", Offset = "0x325B790", Length = "0x52")]
		[Token(Token = "0x6001A76")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000705")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingBottom
	{
		[Address(RVA = "0x325C3F0", Offset = "0x325B7F0", Length = "0x52")]
		[Token(Token = "0x6001A77")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000706")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingLeft
	{
		[Address(RVA = "0x325C450", Offset = "0x325B850", Length = "0x52")]
		[Token(Token = "0x6001A78")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000707")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingRight
	{
		[Address(RVA = "0x325C4B0", Offset = "0x325B8B0", Length = "0x52")]
		[Token(Token = "0x6001A79")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000708")]
	private override float UnityEngine.UIElements.IResolvedStyle.paddingTop
	{
		[Address(RVA = "0x325C510", Offset = "0x325B910", Length = "0x52")]
		[Token(Token = "0x6001A7A")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000709")]
	private override Position UnityEngine.UIElements.IResolvedStyle.position
	{
		[Address(RVA = "0x325C570", Offset = "0x325B970", Length = "0x52")]
		[Token(Token = "0x6001A7B")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700070A")]
	private override float UnityEngine.UIElements.IResolvedStyle.right
	{
		[Address(RVA = "0x325C5D0", Offset = "0x325B9D0", Length = "0x52")]
		[Token(Token = "0x6001A7C")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700070B")]
	private override Rotate UnityEngine.UIElements.IResolvedStyle.rotate
	{
		[Address(RVA = "0x325C630", Offset = "0x325BA30", Length = "0xDB")]
		[Token(Token = "0x6001A7D")]
		private get { } //Length: 219
	}

	[Token(Token = "0x1700070C")]
	private override Scale UnityEngine.UIElements.IResolvedStyle.scale
	{
		[Address(RVA = "0x325C710", Offset = "0x325BB10", Length = "0xD1")]
		[Token(Token = "0x6001A7E")]
		private get { } //Length: 209
	}

	[Token(Token = "0x1700070D")]
	private override TextOverflow UnityEngine.UIElements.IResolvedStyle.textOverflow
	{
		[Address(RVA = "0x325C7F0", Offset = "0x325BBF0", Length = "0x52")]
		[Token(Token = "0x6001A7F")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700070E")]
	private override float UnityEngine.UIElements.IResolvedStyle.top
	{
		[Address(RVA = "0x325C850", Offset = "0x325BC50", Length = "0x52")]
		[Token(Token = "0x6001A80")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700070F")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin
	{
		[Address(RVA = "0x325C8B0", Offset = "0x325BCB0", Length = "0xD9")]
		[Token(Token = "0x6001A81")]
		private get { } //Length: 217
	}

	[Token(Token = "0x17000710")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.transitionDelay
	{
		[Address(RVA = "0x325C990", Offset = "0x325BD90", Length = "0x52")]
		[Token(Token = "0x6001A82")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000711")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.transitionDuration
	{
		[Address(RVA = "0x325C9F0", Offset = "0x325BDF0", Length = "0x52")]
		[Token(Token = "0x6001A83")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000712")]
	private override IEnumerable<StylePropertyName> UnityEngine.UIElements.IResolvedStyle.transitionProperty
	{
		[Address(RVA = "0x325CA50", Offset = "0x325BE50", Length = "0x52")]
		[Token(Token = "0x6001A84")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000713")]
	private override IEnumerable<EasingFunction> UnityEngine.UIElements.IResolvedStyle.transitionTimingFunction
	{
		[Address(RVA = "0x325CAB0", Offset = "0x325BEB0", Length = "0x52")]
		[Token(Token = "0x6001A85")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000714")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.translate
	{
		[Address(RVA = "0x325CB10", Offset = "0x325BF10", Length = "0xD9")]
		[Token(Token = "0x6001A86")]
		private get { } //Length: 217
	}

	[Token(Token = "0x17000715")]
	private override Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor
	{
		[Address(RVA = "0x325CBF0", Offset = "0x325BFF0", Length = "0xD1")]
		[Token(Token = "0x6001A87")]
		private get { } //Length: 209
	}

	[Token(Token = "0x17000716")]
	private override EditorTextRenderingMode UnityEngine.UIElements.IResolvedStyle.unityEditorTextRenderingMode
	{
		[Address(RVA = "0x325CCD0", Offset = "0x325C0D0", Length = "0x52")]
		[Token(Token = "0x6001A88")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000717")]
	private override Font UnityEngine.UIElements.IResolvedStyle.unityFont
	{
		[Address(RVA = "0x325CE70", Offset = "0x325C270", Length = "0xCB")]
		[Token(Token = "0x6001A89")]
		private get { } //Length: 203
	}

	[Token(Token = "0x17000718")]
	private override FontDefinition UnityEngine.UIElements.IResolvedStyle.unityFontDefinition
	{
		[Address(RVA = "0x325CD30", Offset = "0x325C130", Length = "0xD1")]
		[Token(Token = "0x6001A8A")]
		private get { } //Length: 209
	}

	[Token(Token = "0x17000719")]
	private override FontStyle UnityEngine.UIElements.IResolvedStyle.unityFontStyleAndWeight
	{
		[Address(RVA = "0x325CE10", Offset = "0x325C210", Length = "0x52")]
		[Token(Token = "0x6001A8B")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700071A")]
	private override MaterialDefinition UnityEngine.UIElements.IResolvedStyle.unityMaterial
	{
		[Address(RVA = "0x325CF40", Offset = "0x325C340", Length = "0xD1")]
		[Token(Token = "0x6001A8C")]
		private get { } //Length: 209
	}

	[Token(Token = "0x1700071B")]
	private override float UnityEngine.UIElements.IResolvedStyle.unityParagraphSpacing
	{
		[Address(RVA = "0x325D020", Offset = "0x325C420", Length = "0x52")]
		[Token(Token = "0x6001A8D")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700071C")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceBottom
	{
		[Address(RVA = "0x325D080", Offset = "0x325C480", Length = "0x52")]
		[Token(Token = "0x6001A8E")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700071D")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft
	{
		[Address(RVA = "0x325D0E0", Offset = "0x325C4E0", Length = "0x52")]
		[Token(Token = "0x6001A8F")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700071E")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceRight
	{
		[Address(RVA = "0x325D140", Offset = "0x325C540", Length = "0x52")]
		[Token(Token = "0x6001A90")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700071F")]
	private override float UnityEngine.UIElements.IResolvedStyle.unitySliceScale
	{
		[Address(RVA = "0x325D1A0", Offset = "0x325C5A0", Length = "0x52")]
		[Token(Token = "0x6001A91")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000720")]
	private override int UnityEngine.UIElements.IResolvedStyle.unitySliceTop
	{
		[Address(RVA = "0x325D200", Offset = "0x325C600", Length = "0x52")]
		[Token(Token = "0x6001A92")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000721")]
	private override SliceType UnityEngine.UIElements.IResolvedStyle.unitySliceType
	{
		[Address(RVA = "0x325D260", Offset = "0x325C660", Length = "0x52")]
		[Token(Token = "0x6001A93")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000722")]
	private override TextAnchor UnityEngine.UIElements.IResolvedStyle.unityTextAlign
	{
		[Address(RVA = "0x325D2C0", Offset = "0x325C6C0", Length = "0x52")]
		[Token(Token = "0x6001A94")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000723")]
	private override TextGeneratorType UnityEngine.UIElements.IResolvedStyle.unityTextGenerator
	{
		[Address(RVA = "0x325D320", Offset = "0x325C720", Length = "0x52")]
		[Token(Token = "0x6001A95")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000724")]
	private override Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor
	{
		[Address(RVA = "0x325D380", Offset = "0x325C780", Length = "0xD1")]
		[Token(Token = "0x6001A96")]
		private get { } //Length: 209
	}

	[Token(Token = "0x17000725")]
	private override float UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth
	{
		[Address(RVA = "0x325D460", Offset = "0x325C860", Length = "0x52")]
		[Token(Token = "0x6001A97")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000726")]
	private override TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.unityTextOverflowPosition
	{
		[Address(RVA = "0x325D4C0", Offset = "0x325C8C0", Length = "0x52")]
		[Token(Token = "0x6001A98")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000727")]
	private override Visibility UnityEngine.UIElements.IResolvedStyle.visibility
	{
		[Address(RVA = "0x325D520", Offset = "0x325C920", Length = "0x52")]
		[Token(Token = "0x6001A99")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000728")]
	private override WhiteSpace UnityEngine.UIElements.IResolvedStyle.whiteSpace
	{
		[Address(RVA = "0x325D580", Offset = "0x325C980", Length = "0x52")]
		[Token(Token = "0x6001A9A")]
		private get { } //Length: 82
	}

	[Token(Token = "0x17000729")]
	private override float UnityEngine.UIElements.IResolvedStyle.width
	{
		[Address(RVA = "0x325D5E0", Offset = "0x325C9E0", Length = "0x52")]
		[Token(Token = "0x6001A9B")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700072A")]
	private override float UnityEngine.UIElements.IResolvedStyle.wordSpacing
	{
		[Address(RVA = "0x325D640", Offset = "0x325CA40", Length = "0x52")]
		[Token(Token = "0x6001A9C")]
		private get { } //Length: 82
	}

	[Token(Token = "0x1700072E")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount
	{
		[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001AA1")]
		private get { } //Length: 4
		[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001AA2")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700072D")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount
	{
		[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001A9F")]
		private get { } //Length: 4
		[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001AA0")]
		private set { } //Length: 4
	}

	[CreateProperty]
	[Token(Token = "0x1700073B")]
	public UsageHints usageHints
	{
		[Address(RVA = "0x3264ED0", Offset = "0x32642D0", Length = "0x31")]
		[Token(Token = "0x6001AD3")]
		 get { } //Length: 49
		[Address(RVA = "0x3267110", Offset = "0x3266510", Length = "0x2EA")]
		[Token(Token = "0x6001AD4")]
		 set { } //Length: 746
	}

	[CreateProperty]
	[Token(Token = "0x17000736")]
	public object userData
	{
		[Address(RVA = "0x3265400", Offset = "0x3264800", Length = "0x9E")]
		[Token(Token = "0x6001ACC")]
		 get { } //Length: 158
		[Address(RVA = "0x3267400", Offset = "0x3266800", Length = "0x145")]
		[Token(Token = "0x6001ACD")]
		 set { } //Length: 325
	}

	[Token(Token = "0x1700073D")]
	internal bool useRenderTexture
	{
		[Address(RVA = "0x3264F10", Offset = "0x3264310", Length = "0x4E9")]
		[Token(Token = "0x6001AD8")]
		internal get { } //Length: 1257
	}

	[CreateProperty]
	[Token(Token = "0x17000734")]
	public string viewDataKey
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[Token(Token = "0x6001AC9")]
		 get { } //Length: 5
		[Address(RVA = "0x3267550", Offset = "0x3266950", Length = "0xC8")]
		[Token(Token = "0x6001ACA")]
		 set { } //Length: 200
	}

	[CreateProperty]
	[Token(Token = "0x1700076E")]
	public bool visible
	{
		[Address(RVA = "0x32654A0", Offset = "0x32648A0", Length = "0x58")]
		[Token(Token = "0x6001B39")]
		 get { } //Length: 88
		[Address(RVA = "0x3267620", Offset = "0x3266A20", Length = "0x174")]
		[Token(Token = "0x6001B3A")]
		 set { } //Length: 372
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000781")]
	public internal VisualTreeAsset visualTreeAssetSource
	{
		[Address(RVA = "0x3265500", Offset = "0x3264900", Length = "0x8")]
		[Token(Token = "0x6001B94")]
		 get { } //Length: 8
		[Address(RVA = "0x32677A0", Offset = "0x3266BA0", Length = "0x13")]
		[Token(Token = "0x6001B95")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 19
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000751")]
	public Rect worldBound
	{
		[Address(RVA = "0x3265510", Offset = "0x3264910", Length = "0x12E")]
		[Token(Token = "0x6001AF6")]
		 get { } //Length: 302
	}

	[Token(Token = "0x1700074C")]
	internal Rect worldBoundingBox
	{
		[Address(RVA = "0x3265640", Offset = "0x3264A40", Length = "0xB1")]
		[Token(Token = "0x6001AEE")]
		internal get { } //Length: 177
	}

	[Token(Token = "0x1700075B")]
	internal Rect worldClip
	{
		[Address(RVA = "0x3265700", Offset = "0x3264B00", Length = "0xC7")]
		[Token(Token = "0x6001B04")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 199
	}

	[CreateProperty(ReadOnly = True)]
	[Token(Token = "0x17000758")]
	public Matrix4x4 worldTransform
	{
		[Address(RVA = "0x3265880", Offset = "0x3264C80", Length = "0x6B")]
		[Token(Token = "0x6001AFF")]
		 get { } //Length: 107
	}

	[Token(Token = "0x1700075A")]
	internal Matrix4x4 worldTransformInverse
	{
		[Address(RVA = "0x32657D0", Offset = "0x3264BD0", Length = "0x7E")]
		[Token(Token = "0x6001B01")]
		internal get { } //Length: 126
	}

	[Token(Token = "0x17000759")]
	internal Matrix4x4 worldTransformRef
	{
		[Address(RVA = "0x3265850", Offset = "0x3264C50", Length = "0x30")]
		[Token(Token = "0x6001B00")]
		internal get { } //Length: 48
	}

	[Address(RVA = "0x32615A0", Offset = "0x32609A0", Length = "0x143D")]
	[Token(Token = "0x6001BDC")]
	private static VisualElement() { }

	[Address(RVA = "0x32629E0", Offset = "0x3261DE0", Length = "0x542")]
	[Token(Token = "0x6001B22")]
	public VisualElement() { }

	[Address(RVA = "0x325AB00", Offset = "0x3259F00", Length = "0x2F")]
	[CompilerGenerated]
	[Token(Token = "0x6001BDD")]
	internal static bool <CalculateConservativeBounds>g__IsNaN|773_0(Vector3 v) { }

	[Address(RVA = "0x3251070", Offset = "0x3250470", Length = "0xCA")]
	[Token(Token = "0x6001B96")]
	public void Add(VisualElement child) { }

	[Address(RVA = "0x3250F70", Offset = "0x3250370", Length = "0xF3")]
	[Token(Token = "0x6001B97")]
	internal void Add(VisualElement child, bool ignoreContentContainer) { }

	[Address(RVA = "0x3250AD0", Offset = "0x324FED0", Length = "0x20")]
	[Token(Token = "0x6001B76")]
	internal void AddEventCallbackCategories(int eventCategories, TrickleDown trickleDown) { }

	[Address(RVA = "0x3250AF0", Offset = "0x324FEF0", Length = "0x25B")]
	[Token(Token = "0x6001BD3")]
	internal void AddStyleSheetPath(string sheetPath) { }

	[Address(RVA = "0x3250D50", Offset = "0x3250150", Length = "0x211")]
	[Token(Token = "0x6001B51")]
	public void AddToClassList(string className) { }

	[Address(RVA = "0x3251140", Offset = "0x3250540", Length = "0x31")]
	[Token(Token = "0x6001B48")]
	private void AssignMeasureFunction() { }

	[Address(RVA = "0x3251180", Offset = "0x3250580", Length = "0x1B4")]
	[Token(Token = "0x6001B62")]
	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	[Address(RVA = "0x3251E60", Offset = "0x3251260", Length = "0x18")]
	[Token(Token = "0x6001B70")]
	private void AttachDataSource() { }

	[Address(RVA = "0x3251E80", Offset = "0x3251280", Length = "0x6A")]
	[Token(Token = "0x6001BA5")]
	public void BringToFront() { }

	[Address(RVA = "0x3251EF0", Offset = "0x32512F0", Length = "0x5A2")]
	[Token(Token = "0x6001BC0")]
	internal static Bounds CalculateConservativeBounds(ref Matrix4x4 matrix, Bounds bounds) { }

	[Address(RVA = "0x32524A0", Offset = "0x32518A0", Length = "0x4B2")]
	[Token(Token = "0x6001BBF")]
	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) { }

	[Address(RVA = "0x3252960", Offset = "0x3251D60", Length = "0x49")]
	[Token(Token = "0x6001B21")]
	private void ChangeIMGUIContainerCount(int delta) { }

	[Address(RVA = "0x32529B0", Offset = "0x3251DB0", Length = "0x168")]
	[Token(Token = "0x6001B59")]
	private static void CheckUserKeyArgument(PropertyName key) { }

	[Address(RVA = "0x3252B20", Offset = "0x3251F20", Length = "0xA6")]
	[Token(Token = "0x6001B9F")]
	internal int ChildCount(bool ignoreContentContainer) { }

	[Address(RVA = "0x3252BD0", Offset = "0x3251FD0", Length = "0xC4")]
	[Token(Token = "0x6001BA4")]
	public IEnumerable<VisualElement> Children() { }

	[Address(RVA = "0x3252CA0", Offset = "0x32520A0", Length = "0xC1")]
	[Token(Token = "0x6001B54")]
	public bool ClassListContains(string cls) { }

	[Address(RVA = "0x32535A0", Offset = "0x32529A0", Length = "0x73")]
	[Token(Token = "0x6001B9B")]
	public void Clear() { }

	[Address(RVA = "0x3252D70", Offset = "0x3252170", Length = "0x79B")]
	[Token(Token = "0x6001ADF")]
	internal void ClearManualLayout() { }

	[Address(RVA = "0x3253510", Offset = "0x3252910", Length = "0x84")]
	[Token(Token = "0x6001B58")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIToolkitAuthoringModule"})]
	internal bool ClearProperty(PropertyName key) { }

	[Address(RVA = "0x3253620", Offset = "0x3252A20", Length = "0x2F5")]
	[Token(Token = "0x6001B06")]
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	[Address(RVA = "0x3253A60", Offset = "0x3252E60", Length = "0x77")]
	[Token(Token = "0x6001BAE")]
	public bool Contains(VisualElement child) { }

	[Address(RVA = "0x3253920", Offset = "0x3252D20", Length = "0x139")]
	[Token(Token = "0x6001B45")]
	public override bool ContainsPoint(Vector2 localPoint) { }

	[Address(RVA = "0x3253AE0", Offset = "0x3252EE0", Length = "0x92")]
	[Token(Token = "0x6001B6D")]
	private void CreateBindingRequests() { }

	[Address(RVA = "0x3253B80", Offset = "0x3252F80", Length = "0x28")]
	[Token(Token = "0x6001B6F")]
	private void DetachDataSource() { }

	[Address(RVA = "0x3253BB0", Offset = "0x3252FB0", Length = "0x87")]
	[Token(Token = "0x6001B71")]
	private void DirtyNextParentWithEventInterests() { }

	[Address(RVA = "0x3253C40", Offset = "0x3253040", Length = "0x14")]
	[Token(Token = "0x6001B4A")]
	protected private override Vector2 DoMeasure(float desiredWidth, MeasureMode widthMode, float desiredHeight, MeasureMode heightMode) { }

	[Address(RVA = "0x3253E30", Offset = "0x3253230", Length = "0xA")]
	[Token(Token = "0x6001B9C")]
	public VisualElement ElementAt(int index) { }

	[Address(RVA = "0x3253C60", Offset = "0x3253060", Length = "0x1C3")]
	[Token(Token = "0x6001BA2")]
	internal VisualElement ElementAtTreePath(List<Int32> childIndexes) { }

	[Address(RVA = "0x3253E40", Offset = "0x3253240", Length = "0x22")]
	[Token(Token = "0x6001B53")]
	public void EnableInClassList(string className, bool enable) { }

	[Address(RVA = "0x3253E70", Offset = "0x3253270", Length = "0x4E")]
	[Token(Token = "0x6001B05")]
	internal void EnsureWorldTransformAndClipUpToDate() { }

	[Address(RVA = "0x3253F20", Offset = "0x3253320", Length = "0x124")]
	[Token(Token = "0x6001B23")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x3253EC0", Offset = "0x32532C0", Length = "0x59")]
	[Token(Token = "0x6001B4C")]
	private void FinalizeLayout() { }

	[Address(RVA = "0x3254050", Offset = "0x3253450", Length = "0x1A8")]
	[Token(Token = "0x6001BB0")]
	public VisualElement FindCommonAncestor(VisualElement other) { }

	[Address(RVA = "0x3254200", Offset = "0x3253600", Length = "0x114")]
	[Token(Token = "0x6001BA3")]
	internal bool FindElementInTree(VisualElement element, List<Int32> outChildIndexes) { }

	[Address(RVA = "0x3254320", Offset = "0x3253720", Length = "0x95")]
	[Token(Token = "0x6001B25")]
	public virtual void Focus() { }

	[Address(RVA = "0x32543C0", Offset = "0x32537C0", Length = "0xBF")]
	[Token(Token = "0x6001BAF")]
	private void GatherAllChildren(List<VisualElement> elements) { }

	[Address(RVA = "0x3262FD0", Offset = "0x32623D0", Length = "0x9")]
	[Token(Token = "0x6001AC3")]
	internal bool get_areAncestorsAndSelfDisplayed() { }

	[Address(RVA = "0x32630F0", Offset = "0x32624F0", Length = "0x42")]
	[Token(Token = "0x6001AEC")]
	internal Rect get_boundingBox() { }

	[Address(RVA = "0x3262FE0", Offset = "0x32623E0", Length = "0x9")]
	[Token(Token = "0x6001B09")]
	internal bool get_boundingBoxDirtiedSinceLastLayoutPass() { }

	[Address(RVA = "0x3262FF0", Offset = "0x32623F0", Length = "0x51")]
	[Token(Token = "0x6001AEF")]
	private Rect get_boundingBoxInParentSpace() { }

	[Address(RVA = "0x3263050", Offset = "0x3262450", Length = "0x9F")]
	[Token(Token = "0x6001AED")]
	internal Rect get_boundingBoxWithoutNested() { }

	[Address(RVA = "0x3263140", Offset = "0x3262540", Length = "0x105")]
	[Token(Token = "0x6001ACE")]
	public virtual bool get_canGrabFocus() { }

	[Address(RVA = "0x3263250", Offset = "0x3262650", Length = "0x83")]
	[Token(Token = "0x6001B9E")]
	public int get_childCount() { }

	[Address(RVA = "0x32632E0", Offset = "0x32626E0", Length = "0xB1")]
	[Token(Token = "0x6001B19")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal List<String> get_classList() { }

	[Address(RVA = "0x32633A0", Offset = "0x32627A0", Length = "0x8")]
	[Token(Token = "0x6001B1D")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ComputedStyle get_computedStyle() { }

	[Address(RVA = "0x2EC3330", Offset = "0x2EC2730", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6001B0F")]
	internal int get_containedPointerIds() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6001B93")]
	public override VisualElement get_contentContainer() { }

	[Address(RVA = "0x32633B0", Offset = "0x32627B0", Length = "0x312")]
	[Token(Token = "0x6001AE0")]
	public Rect get_contentRect() { }

	[Address(RVA = "0x32636D0", Offset = "0x3262AD0", Length = "0x8E")]
	[Token(Token = "0x6001BD1")]
	public ICustomStyle get_customStyle() { }

	[Address(RVA = "0x28EA900", Offset = "0x28E9D00", Length = "0x8")]
	[Token(Token = "0x6001B66")]
	public object get_dataSource() { }

	[Address(RVA = "0x3263760", Offset = "0x3262B60", Length = "0xC9")]
	[Token(Token = "0x6001B68")]
	public PropertyPath get_dataSourcePath() { }

	[Address(RVA = "0x3263830", Offset = "0x3262C30", Length = "0x9")]
	[Token(Token = "0x6001B8A")]
	internal bool get_disableClipping() { }

	[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
	[Token(Token = "0x6001AD0")]
	public bool get_disablePlayModeTint() { }

	[Address(RVA = "0x3263840", Offset = "0x3262C40", Length = "0x9")]
	[Token(Token = "0x6001B8D")]
	internal bool get_disableRendering() { }

	[Address(RVA = "0x29EC880", Offset = "0x29EBC80", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001B90")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal BaseVisualElementPanel get_elementPanel() { }

	[Address(RVA = "0x3263860", Offset = "0x3262C60", Length = "0x10")]
	[Token(Token = "0x6001B30")]
	public bool get_enabledInHierarchy() { }

	[Address(RVA = "0x3263870", Offset = "0x3262C70", Length = "0x8")]
	[Token(Token = "0x6001B31")]
	public bool get_enabledSelf() { }

	[Address(RVA = "0x3263850", Offset = "0x3262C50", Length = "0x9")]
	[Token(Token = "0x6001ACB")]
	internal bool get_enableViewDataPersistence() { }

	[Address(RVA = "0x3263880", Offset = "0x3262C80", Length = "0x3B")]
	[Token(Token = "0x6001B77")]
	internal int get_eventInterestParentCategories() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6001B86")]
	public IExperimentalFeatures get_experimental() { }

	[Address(RVA = "0x32638C0", Offset = "0x3262CC0", Length = "0x56")]
	[Token(Token = "0x6001AC7")]
	internal VisualElementFlags get_flags() { }

	[Address(RVA = "0x3263920", Offset = "0x3262D20", Length = "0xD1")]
	[Token(Token = "0x6001ACF")]
	public virtual FocusController get_focusController() { }

	[Address(RVA = "0x3263A00", Offset = "0x3262E00", Length = "0x23")]
	[Token(Token = "0x6001B1A")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string get_fullTypeName() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001B3C")]
	public Action<MeshGenerationContext> get_generateVisualContent() { }

	[Address(RVA = "0x3263A30", Offset = "0x3262E30", Length = "0x112")]
	[Token(Token = "0x6001BBA")]
	private bool get_has3DRotation() { }

	[Address(RVA = "0x3263B50", Offset = "0x3262F50", Length = "0x173")]
	[Token(Token = "0x6001BB8")]
	internal bool get_has3DTransform() { }

	[Address(RVA = "0x3263CD0", Offset = "0x32630D0", Length = "0x35")]
	[Token(Token = "0x6001BB9")]
	private bool get_has3DTranslation() { }

	[Address(RVA = "0x3263D10", Offset = "0x3263110", Length = "0x4E")]
	[Token(Token = "0x6001A9E")]
	internal bool get_hasCompletedAnimations() { }

	[Address(RVA = "0x3263D60", Offset = "0x3263160", Length = "0x12B")]
	[Token(Token = "0x6001BB7")]
	internal bool get_hasDefaultRotationAndScale() { }

	[Address(RVA = "0x3263E90", Offset = "0x3263290", Length = "0xC")]
	[Token(Token = "0x6001B1E")]
	internal bool get_hasInlineStyle() { }

	[Address(RVA = "0x3263EA0", Offset = "0x32632A0", Length = "0x9")]
	[Token(Token = "0x6001AC5")]
	internal bool get_hasOneOrMorePointerCaptures() { }

	[Address(RVA = "0x3263EB0", Offset = "0x32632B0", Length = "0x4E")]
	[Token(Token = "0x6001A9D")]
	internal bool get_hasRunningAnimations() { }

	[Address(RVA = "0x3263F00", Offset = "0x3263300", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6001B88")]
	public Hierarchy get_hierarchy() { }

	[Address(RVA = "0x3263F10", Offset = "0x3263310", Length = "0x9")]
	[Token(Token = "0x6001AE8")]
	internal bool get_isBoundingBoxDirty() { }

	[Address(RVA = "0x3263F20", Offset = "0x3263320", Length = "0x9")]
	[Token(Token = "0x6001AC1")]
	internal bool get_isCompositeRoot() { }

	[Address(RVA = "0x3263F30", Offset = "0x3263330", Length = "0x28")]
	[Token(Token = "0x6001B6A")]
	internal bool get_isDataSourcePathEmpty() { }

	[Address(RVA = "0x3263F60", Offset = "0x3263360", Length = "0x9")]
	[Token(Token = "0x6001B78")]
	internal bool get_isEventInterestParentCategoriesDirty() { }

	[Address(RVA = "0x3263F70", Offset = "0x3263370", Length = "0x9")]
	[Token(Token = "0x6001AD9")]
	internal bool get_isLayoutManual() { }

	[Address(RVA = "0x3263F80", Offset = "0x3263380", Length = "0xB")]
	[Token(Token = "0x6001AE4")]
	internal bool get_isLocalBounds3DDirty() { }

	[Address(RVA = "0x3263F90", Offset = "0x3263390", Length = "0xB")]
	[Token(Token = "0x6001AE6")]
	internal bool get_isLocalBoundsWithoutNested3DDirty() { }

	[Address(RVA = "0x3263FA0", Offset = "0x32633A0", Length = "0x67")]
	[Token(Token = "0x6001B2F")]
	private bool get_isParentEnabledInHierarchy() { }

	[Address(RVA = "0x3264010", Offset = "0x3263410", Length = "0x40")]
	[Token(Token = "0x6001B89")]
	internal bool get_isRootVisualContainer() { }

	[Address(RVA = "0x3264050", Offset = "0x3263450", Length = "0x8")]
	[Token(Token = "0x6001AEB")]
	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	[Address(RVA = "0x3264060", Offset = "0x3263460", Length = "0x9")]
	[Token(Token = "0x6001AF9")]
	internal bool get_isWorldSpaceRootUIDocument() { }

	[Address(RVA = "0x1F0D340", Offset = "0x1F0C740", Length = "0x7")]
	[Token(Token = "0x6001AFB")]
	internal bool get_isWorldTransformDirty() { }

	[Address(RVA = "0x3264070", Offset = "0x3263470", Length = "0x8")]
	[Token(Token = "0x6001AFE")]
	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	[Address(RVA = "0x3262F30", Offset = "0x3262330", Length = "0x9C")]
	[Token(Token = "0x6001B9D")]
	public VisualElement get_Item(int key) { }

	[Address(RVA = "0x3264080", Offset = "0x3263480", Length = "0x7")]
	[Token(Token = "0x6001B35")]
	public LanguageDirection get_languageDirection() { }

	[Address(RVA = "0x32640A0", Offset = "0x32634A0", Length = "0x106")]
	[Token(Token = "0x6001ADD")]
	public Rect get_layout() { }

	[Address(RVA = "0x3264090", Offset = "0x3263490", Length = "0xA")]
	[Token(Token = "0x6001B1C")]
	internal LayoutNode get_layoutNode() { }

	[Address(RVA = "0x32641B0", Offset = "0x32635B0", Length = "0xC1")]
	[Token(Token = "0x6001AF7")]
	public Rect get_localBound() { }

	[Address(RVA = "0x3264330", Offset = "0x3263730", Length = "0xA0")]
	[Token(Token = "0x6001AF2")]
	internal Bounds get_localBounds3D() { }

	[Address(RVA = "0x3264280", Offset = "0x3263680", Length = "0xA1")]
	[Token(Token = "0x6001AF4")]
	internal Bounds get_localBounds3DWithoutNested3D() { }

	[Address(RVA = "0x32643D0", Offset = "0x32637D0", Length = "0xA0")]
	[Token(Token = "0x6001AF3")]
	internal Bounds get_localBoundsPicking3D() { }

	[Address(RVA = "0x1DBB140", Offset = "0x1DBA540", Length = "0x7")]
	[Token(Token = "0x6001B37")]
	internal LanguageDirection get_localLanguageDirection() { }

	[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
	[Token(Token = "0x6001B17")]
	public string get_name() { }

	[Address(RVA = "0x3264470", Offset = "0x3263870", Length = "0xB")]
	[Token(Token = "0x6001AE2")]
	internal bool get_needs3DBounds() { }

	[Address(RVA = "0x3264480", Offset = "0x3263880", Length = "0x1D5")]
	[Token(Token = "0x6001B74")]
	internal VisualElement get_nextParentWithEventInterests() { }

	[Address(RVA = "0x3264660", Offset = "0x3263A60", Length = "0x1EF")]
	[Token(Token = "0x6001AE1")]
	protected Rect get_paddingRect() { }

	[Address(RVA = "0x3264850", Offset = "0x3263C50", Length = "0xA")]
	[Token(Token = "0x6001B92")]
	public IPanel get_panel() { }

	[Address(RVA = "0x3264860", Offset = "0x3263C60", Length = "0xA")]
	[Token(Token = "0x6001B8F")]
	public VisualElement get_parent() { }

	[Address(RVA = "0x2EC3340", Offset = "0x2EC2740", Length = "0x7")]
	[Token(Token = "0x6001B15")]
	public PickingMode get_pickingMode() { }

	[Address(RVA = "0x3264870", Offset = "0x3263C70", Length = "0x39")]
	[Token(Token = "0x6001AD2")]
	internal Color get_playModeTintColor() { }

	[Address(RVA = "0x32648B0", Offset = "0x3263CB0", Length = "0xCA")]
	[Token(Token = "0x6001BB5")]
	private Vector3 get_positionWithLayout() { }

	[Address(RVA = "0x31809B0", Offset = "0x317FDB0", Length = "0x9")]
	[Token(Token = "0x6001B0B")]
	internal PseudoStates get_pseudoStates() { }

	[Address(RVA = "0x3264980", Offset = "0x3263D80", Length = "0x9")]
	[Token(Token = "0x6001B07")]
	internal bool get_receivesHierarchyGeometryChangedEvents() { }

	[Address(RVA = "0x3264990", Offset = "0x3263D90", Length = "0xA2")]
	[Token(Token = "0x6001AF8")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Rect get_rect() { }

	[Address(RVA = "0x3264A40", Offset = "0x3263E40", Length = "0x6")]
	[Token(Token = "0x6001AD5")]
	internal RenderHints get_renderHints() { }

	[Address(RVA = "0x3264A50", Offset = "0x3263E50", Length = "0x9")]
	[Token(Token = "0x6001B46")]
	internal bool get_requireMeasureFunction() { }

	[Address(RVA = "0x3264A60", Offset = "0x3263E60", Length = "0x85")]
	[Token(Token = "0x6001BD0")]
	public IResolvedStyle get_resolvedStyle() { }

	[Address(RVA = "0x3264AF0", Offset = "0x3263EF0", Length = "0x9F")]
	[Token(Token = "0x6001ADB")]
	public float get_scaledPixelsPerPoint() { }

	[Address(RVA = "0x3264B90", Offset = "0x3263F90", Length = "0x5F")]
	[Token(Token = "0x6001ADC")]
	internal float get_scaledPixelsPerPoint_noChecks() { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6001BCC")]
	public IVisualElementScheduler get_schedule() { }

	[Address(RVA = "0x3264C30", Offset = "0x3264030", Length = "0x79")]
	[Token(Token = "0x6001BCF")]
	public IStyle get_style() { }

	[Address(RVA = "0x604B40", Offset = "0x603F40", Length = "0x4")]
	[Token(Token = "0x6001AA4")]
	internal IStylePropertyAnimations get_styleAnimation() { }

	[Address(RVA = "0x3264BF0", Offset = "0x3263FF0", Length = "0x9")]
	[Token(Token = "0x6001B1F")]
	internal bool get_styleInitialized() { }

	[Address(RVA = "0x3264C00", Offset = "0x3264000", Length = "0x27")]
	[Token(Token = "0x6001BD2")]
	public VisualElementStyleSheetSet get_styleSheets() { }

	[Address(RVA = "0x3264CB0", Offset = "0x32640B0", Length = "0x89")]
	[Token(Token = "0x6001BD9")]
	public string get_tooltip() { }

	[Address(RVA = "0x3264D40", Offset = "0x3264140", Length = "0x156")]
	[Token(Token = "0x6001BDB")]
	private TypeData get_typeData() { }

	[Address(RVA = "0x3264EA0", Offset = "0x32642A0", Length = "0x23")]
	[Token(Token = "0x6001B1B")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
	internal string get_typeName() { }

	[Address(RVA = "0x3264ED0", Offset = "0x32642D0", Length = "0x31")]
	[Token(Token = "0x6001AD3")]
	public UsageHints get_usageHints() { }

	[Address(RVA = "0x3265400", Offset = "0x3264800", Length = "0x9E")]
	[Token(Token = "0x6001ACC")]
	public object get_userData() { }

	[Address(RVA = "0x3264F10", Offset = "0x3264310", Length = "0x4E9")]
	[Token(Token = "0x6001AD8")]
	internal bool get_useRenderTexture() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[Token(Token = "0x6001AC9")]
	public string get_viewDataKey() { }

	[Address(RVA = "0x32654A0", Offset = "0x32648A0", Length = "0x58")]
	[Token(Token = "0x6001B39")]
	public bool get_visible() { }

	[Address(RVA = "0x3265500", Offset = "0x3264900", Length = "0x8")]
	[Token(Token = "0x6001B94")]
	public VisualTreeAsset get_visualTreeAssetSource() { }

	[Address(RVA = "0x3265510", Offset = "0x3264910", Length = "0x12E")]
	[Token(Token = "0x6001AF6")]
	public Rect get_worldBound() { }

	[Address(RVA = "0x3265640", Offset = "0x3264A40", Length = "0xB1")]
	[Token(Token = "0x6001AEE")]
	internal Rect get_worldBoundingBox() { }

	[Address(RVA = "0x3265700", Offset = "0x3264B00", Length = "0xC7")]
	[Token(Token = "0x6001B04")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal Rect get_worldClip() { }

	[Address(RVA = "0x3265880", Offset = "0x3264C80", Length = "0x6B")]
	[Token(Token = "0x6001AFF")]
	public Matrix4x4 get_worldTransform() { }

	[Address(RVA = "0x32657D0", Offset = "0x3264BD0", Length = "0x7E")]
	[Token(Token = "0x6001B01")]
	internal Matrix4x4 get_worldTransformInverse() { }

	[Address(RVA = "0x3265850", Offset = "0x3264C50", Length = "0x30")]
	[Token(Token = "0x6001B00")]
	internal Matrix4x4 get_worldTransformRef() { }

	[Address(RVA = "0x3254480", Offset = "0x3253880", Length = "0xA4")]
	[Token(Token = "0x6001B5C")]
	private VisualElementAnimationSystem GetAnimationSystem() { }

	[Address(RVA = "0x3254530", Offset = "0x3253930", Length = "0x55")]
	[Token(Token = "0x6001B73")]
	internal bool GetCachedNextParentWithEventInterests(out VisualElement nextParent) { }

	[Address(RVA = "0x2F944C0", Offset = "0x2F938C0", Length = "0x7")]
	[Token(Token = "0x6001B50")]
	internal List<String> GetClassesForIteration() { }

	[Address(RVA = "0x9E4500", Offset = "0x9E3900", Length = "0x9F")]
	[Token(Token = "0x6001BAC")]
	public T GetFirstAncestorOfType() { }

	[Address(RVA = "0x3254590", Offset = "0x3253990", Length = "0x8F")]
	[Token(Token = "0x6001BAD")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
	internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate) { }

	[Address(RVA = "0x9E45A0", Offset = "0x9E39A0", Length = "0xF4")]
	[Token(Token = "0x6001BAB")]
	public T GetFirstOfType() { }

	[Address(RVA = "0x3254700", Offset = "0x3253B00", Length = "0x8D")]
	[Token(Token = "0x6001B3F")]
	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	[Address(RVA = "0x3254620", Offset = "0x3253A20", Length = "0xD5")]
	[Token(Token = "0x6001B40")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal string GetFullHierarchicalViewDataKey() { }

	[Address(RVA = "0x3254790", Offset = "0x3253B90", Length = "0x117")]
	[Token(Token = "0x6001BB2")]
	internal VisualElement GetNextElementDepthFirst() { }

	[Address(RVA = "0x9E46A0", Offset = "0x9E3AA0", Length = "0x3A7")]
	[Token(Token = "0x6001B41")]
	internal T GetOrCreateViewData(object existing, string key) { }

	[Address(RVA = "0x32548B0", Offset = "0x3253CB0", Length = "0x2AC")]
	[Token(Token = "0x6001AC0")]
	private Nullable<Single> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0) { }

	[Address(RVA = "0x3254B90", Offset = "0x3253F90", Length = "0x3B5")]
	[Token(Token = "0x6001BB6")]
	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) { }

	[Address(RVA = "0x3254F50", Offset = "0x3254350", Length = "0x123")]
	[Token(Token = "0x6001BB3")]
	internal VisualElement GetPreviousElementDepthFirst() { }

	[Address(RVA = "0x3255080", Offset = "0x3254480", Length = "0x99")]
	[Token(Token = "0x6001B55")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
	internal object GetProperty(PropertyName key) { }

	[Address(RVA = "0x3255120", Offset = "0x3254520", Length = "0xB2")]
	[Token(Token = "0x6001BB1")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal VisualElement GetRootVisualContainer(bool stopAtNearestRoot = false) { }

	[Address(RVA = "0x32551E0", Offset = "0x32545E0", Length = "0x2F")]
	[Token(Token = "0x6001AA3")]
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	[Address(RVA = "0x3255210", Offset = "0x3254610", Length = "0xA")]
	[Token(Token = "0x6001B83")]
	internal bool HasBubbleUpEventCallbacks(int eventCategories) { }

	[Address(RVA = "0x3255220", Offset = "0x3254620", Length = "0x12")]
	[Token(Token = "0x6001B81")]
	internal bool HasBubbleUpEventInterests(int eventCategories) { }

	[Address(RVA = "0x3255240", Offset = "0x3254640", Length = "0xA")]
	[Token(Token = "0x6001B85")]
	internal bool HasBubbleUpHandleEvent(int eventCategories) { }

	[Address(RVA = "0x3255250", Offset = "0x3254650", Length = "0x4BD")]
	[Token(Token = "0x6001B29")]
	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	[Address(RVA = "0x3255710", Offset = "0x3254B10", Length = "0x55")]
	[Token(Token = "0x6001B7D")]
	internal bool HasParentEventInterests(int eventCategories) { }

	[Address(RVA = "0x3255770", Offset = "0x3254B70", Length = "0x55")]
	[Token(Token = "0x6001B7C")]
	internal bool HasParentEventInterests(EventCategory eventCategory) { }

	[Address(RVA = "0x32557D0", Offset = "0x3254BD0", Length = "0x84")]
	[Token(Token = "0x6001B57")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
	internal bool HasProperty(PropertyName key) { }

	[Address(RVA = "0x3255860", Offset = "0x3254C60", Length = "0x1B")]
	[Token(Token = "0x6001B7E")]
	internal bool HasSelfEventInterests(EventCategory eventCategory) { }

	[Address(RVA = "0x3255880", Offset = "0x3254C80", Length = "0xA")]
	[Token(Token = "0x6001B7F")]
	internal bool HasSelfEventInterests(int eventCategories) { }

	[Address(RVA = "0x3255890", Offset = "0x3254C90", Length = "0xA")]
	[Token(Token = "0x6001B82")]
	internal bool HasTrickleDownEventCallbacks(int eventCategories) { }

	[Address(RVA = "0x32558A0", Offset = "0x3254CA0", Length = "0x12")]
	[Token(Token = "0x6001B80")]
	internal bool HasTrickleDownEventInterests(int eventCategories) { }

	[Address(RVA = "0x32558C0", Offset = "0x3254CC0", Length = "0xA")]
	[Token(Token = "0x6001B84")]
	internal bool HasTrickleDownHandleEvent(int eventCategories) { }

	[Address(RVA = "0x32558D0", Offset = "0x3254CD0", Length = "0x27")]
	[Token(Token = "0x6001B2C")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void IncrementVersion(VersionChangeType changeType) { }

	[Address(RVA = "0x3255900", Offset = "0x3254D00", Length = "0x9C")]
	[Token(Token = "0x6001BA0")]
	public int IndexOf(VisualElement element) { }

	[Address(RVA = "0x32559A0", Offset = "0x3254DA0", Length = "0xC9")]
	[Token(Token = "0x6001BA1")]
	internal int IndexOf(VisualElement element, bool ignoreContentContainer) { }

	[Address(RVA = "0x3255A70", Offset = "0x3254E70", Length = "0xB2")]
	[Token(Token = "0x6001B98")]
	public void Insert(int index, VisualElement element) { }

	[Address(RVA = "0x3255B30", Offset = "0x3254F30", Length = "0xE4")]
	[Token(Token = "0x6001B99")]
	internal void Insert(int index, VisualElement element, bool ignoreContentContainer) { }

	[Address(RVA = "0x3255C20", Offset = "0x3255020", Length = "0x12E")]
	[Token(Token = "0x6001B3E")]
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	[Address(RVA = "0x3255D50", Offset = "0x3255150", Length = "0x2F")]
	[Token(Token = "0x6001B2D")]
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	[Address(RVA = "0x3255D80", Offset = "0x3255180", Length = "0xF7")]
	[Token(Token = "0x6001B12")]
	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement) { }

	[Address(RVA = "0x3255E80", Offset = "0x3255280", Length = "0x2A")]
	[Token(Token = "0x6001B3B")]
	public void MarkDirtyRepaint() { }

	[Address(RVA = "0x3255EB0", Offset = "0x32552B0", Length = "0x8")]
	[Token(Token = "0x6001AD7")]
	internal void MarkRenderHintsClean() { }

	[Address(RVA = "0x3255EC0", Offset = "0x32552C0", Length = "0xF")]
	[Token(Token = "0x6001BBC")]
	internal static float Max(float a, float b, float c, float d) { }

	[Address(RVA = "0x3255ED0", Offset = "0x32552D0", Length = "0x244")]
	[Token(Token = "0x6001B4B")]
	internal static void Measure(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result) { }

	[Address(RVA = "0x3256120", Offset = "0x3255520", Length = "0xF")]
	[Token(Token = "0x6001BBB")]
	internal static float Min(float a, float b, float c, float d) { }

	[Address(RVA = "0x3256130", Offset = "0x3255530", Length = "0x22E")]
	[Token(Token = "0x6001BC9")]
	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) { }

	[Address(RVA = "0x32563D0", Offset = "0x32557D0", Length = "0x45")]
	[Token(Token = "0x6001BC5")]
	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) { }

	[Address(RVA = "0x3256360", Offset = "0x3255760", Length = "0x65")]
	[Token(Token = "0x6001BC6")]
	internal static Vector3 MultiplyMatrix44Point2ToPoint3(ref Matrix4x4 lhs, Vector2 point) { }

	[Address(RVA = "0x3256420", Offset = "0x3255820", Length = "0x5C")]
	[Token(Token = "0x6001BC7")]
	internal static Vector2 MultiplyMatrix44Point3ToPoint2(ref Matrix4x4 lhs, Vector3 point) { }

	[Address(RVA = "0x3256480", Offset = "0x3255880", Length = "0x3B")]
	[Token(Token = "0x6001BC8")]
	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001BA8")]
	internal override void OnChildAdded(VisualElement child) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001BA9")]
	internal override void OnChildRemoved(VisualElement child) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001B44")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal override void OnViewDataReady() { }

	[Address(RVA = "0x32564C0", Offset = "0x32558C0", Length = "0x3A")]
	[Token(Token = "0x6001BC4")]
	internal static void OrderMinMaxBounds(ref Bounds bounds) { }

	[Address(RVA = "0x3256500", Offset = "0x3255900", Length = "0xD6")]
	[Token(Token = "0x6001BC3")]
	internal static void OrderMinMaxRect(ref Rect rect) { }

	[Address(RVA = "0x32565E0", Offset = "0x32559E0", Length = "0x36B")]
	[Token(Token = "0x6001B42")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void OverwriteFromViewData(object obj, string key) { }

	[Address(RVA = "0x3256950", Offset = "0x3255D50", Length = "0x15E")]
	[Token(Token = "0x6001BA7")]
	public void PlaceBehind(VisualElement sibling) { }

	[Address(RVA = "0x3256AB0", Offset = "0x3255EB0", Length = "0xB7")]
	[Token(Token = "0x6001B6C")]
	private void ProcessBindingRequests() { }

	[Address(RVA = "0x3256B70", Offset = "0x3255F70", Length = "0x87")]
	[Token(Token = "0x6001B75")]
	private void PropagateCachedNextParentWithEventInterests(VisualElement nextParent, VisualElement stopParent) { }

	[Address(RVA = "0x3256C00", Offset = "0x3256000", Length = "0xBE")]
	[Token(Token = "0x6001B34")]
	private void PropagateEnabledToChildren(bool value) { }

	[Address(RVA = "0x3256CC0", Offset = "0x32560C0", Length = "0x8E0")]
	[Token(Token = "0x6001B63")]
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	[Address(RVA = "0x3257640", Offset = "0x3256A40", Length = "0x122")]
	[Token(Token = "0x6001B5D")]
	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x3257770", Offset = "0x3256B70", Length = "0x68")]
	[Token(Token = "0x6001B60")]
	private void RegisterRunningAnimations() { }

	[Address(RVA = "0x32579B0", Offset = "0x3256DB0", Length = "0x8C")]
	[Token(Token = "0x6001B9A")]
	public void Remove(VisualElement element) { }

	[Address(RVA = "0x32577E0", Offset = "0x3256BE0", Length = "0x129")]
	[Token(Token = "0x6001B52")]
	public void RemoveFromClassList(string className) { }

	[Address(RVA = "0x3257910", Offset = "0x3256D10", Length = "0x6A")]
	[Token(Token = "0x6001BAA")]
	public void RemoveFromHierarchy() { }

	[Address(RVA = "0x3257980", Offset = "0x3256D80", Length = "0x30")]
	[Token(Token = "0x6001B49")]
	private void RemoveMeasureFunction() { }

	[Address(RVA = "0x3257A40", Offset = "0x3256E40", Length = "0x15F")]
	[Token(Token = "0x6001BD4")]
	internal StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	[Address(RVA = "0x3257BA0", Offset = "0x3256FA0", Length = "0x145")]
	[Token(Token = "0x6001BD7")]
	private Quaternion ResolveRotation() { }

	[Address(RVA = "0x3257CF0", Offset = "0x32570F0", Length = "0xEC")]
	[Token(Token = "0x6001BD8")]
	private Vector3 ResolveScale() { }

	[Address(RVA = "0x3257DE0", Offset = "0x32571E0", Length = "0x235")]
	[Token(Token = "0x6001BD6")]
	internal Vector3 ResolveTransformOrigin() { }

	[Address(RVA = "0x3258020", Offset = "0x3257420", Length = "0x1B1")]
	[Token(Token = "0x6001BD5")]
	internal Vector3 ResolveTranslate() { }

	[Address(RVA = "0x32581E0", Offset = "0x32575E0", Length = "0x97")]
	[Token(Token = "0x6001BB4")]
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	[Address(RVA = "0x3258280", Offset = "0x3257680", Length = "0x8D")]
	[Token(Token = "0x6001B43")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void SaveViewData() { }

	[Address(RVA = "0x3258310", Offset = "0x3257710", Length = "0x1B")]
	[Token(Token = "0x6001B2A")]
	public virtual void SendEvent(EventBase e) { }

	[Address(RVA = "0x3258330", Offset = "0x3257730", Length = "0x15")]
	[Token(Token = "0x6001B2B")]
	internal virtual void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	[Address(RVA = "0x3258350", Offset = "0x3257750", Length = "0x6A")]
	[Token(Token = "0x6001BA6")]
	public void SendToBack() { }

	[Address(RVA = "0x32658F0", Offset = "0x3264CF0", Length = "0x84")]
	[Token(Token = "0x6001AC4")]
	internal void set_areAncestorsAndSelfDisplayed(bool value) { }

	[Address(RVA = "0x3265980", Offset = "0x3264D80", Length = "0x2D")]
	[Token(Token = "0x6001B0A")]
	internal void set_boundingBoxDirtiedSinceLastLayoutPass(bool value) { }

	[Address(RVA = "0x2EC3610", Offset = "0x2EC2A10", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6001B10")]
	internal void set_containedPointerIds(int value) { }

	[Address(RVA = "0x3265C60", Offset = "0x3265060", Length = "0xE0")]
	[Token(Token = "0x6001B67")]
	public void set_dataSource(object value) { }

	[Address(RVA = "0x32659B0", Offset = "0x3264DB0", Length = "0x2A0")]
	[Token(Token = "0x6001B69")]
	public void set_dataSourcePath(PropertyPath value) { }

	[Address(RVA = "0x3265D40", Offset = "0x3265140", Length = "0x2D")]
	[Token(Token = "0x6001B8B")]
	internal void set_disableClipping(bool value) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001AD1")]
	public void set_disablePlayModeTint(bool value) { }

	[Address(RVA = "0x3265D70", Offset = "0x3265170", Length = "0x56")]
	[Token(Token = "0x6001B8E")]
	internal void set_disableRendering(bool value) { }

	[Address(RVA = "0x29EC8C0", Offset = "0x29EBCC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001B91")]
	private void set_elementPanel(BaseVisualElementPanel value) { }

	[Address(RVA = "0x3265DD0", Offset = "0x32651D0", Length = "0x8E")]
	[Token(Token = "0x6001B32")]
	public void set_enabledSelf(bool value) { }

	[Address(RVA = "0x3265E60", Offset = "0x3265260", Length = "0xAA")]
	[Token(Token = "0x6001AC8")]
	internal void set_flags(VisualElementFlags value) { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6001B3D")]
	public void set_generateVisualContent(Action<MeshGenerationContext> value) { }

	[Address(RVA = "0x3265F10", Offset = "0x3265310", Length = "0x2D")]
	[Token(Token = "0x6001AC6")]
	internal void set_hasOneOrMorePointerCaptures(bool value) { }

	[Address(RVA = "0x3265F40", Offset = "0x3265340", Length = "0x2B")]
	[Token(Token = "0x6001AE9")]
	internal void set_isBoundingBoxDirty(bool value) { }

	[Address(RVA = "0x3265F70", Offset = "0x3265370", Length = "0x2D")]
	[Token(Token = "0x6001AC2")]
	internal void set_isCompositeRoot(bool value) { }

	[Address(RVA = "0x3265FA0", Offset = "0x32653A0", Length = "0x2B")]
	[Token(Token = "0x6001B79")]
	internal void set_isEventInterestParentCategoriesDirty(bool value) { }

	[Address(RVA = "0x3265FD0", Offset = "0x32653D0", Length = "0x2B")]
	[Token(Token = "0x6001ADA")]
	private void set_isLayoutManual(bool value) { }

	[Address(RVA = "0x3266000", Offset = "0x3265400", Length = "0x2D")]
	[Token(Token = "0x6001AE5")]
	internal void set_isLocalBounds3DDirty(bool value) { }

	[Address(RVA = "0x3266030", Offset = "0x3265430", Length = "0x2D")]
	[Token(Token = "0x6001AE7")]
	internal void set_isLocalBoundsWithoutNested3DDirty(bool value) { }

	[Address(RVA = "0x3266060", Offset = "0x3265460", Length = "0x2B")]
	[Token(Token = "0x6001AEA")]
	internal void set_isWorldBoundingBoxDirty(bool value) { }

	[Address(RVA = "0x3266090", Offset = "0x3265490", Length = "0x2D")]
	[Token(Token = "0x6001AFA")]
	internal void set_isWorldSpaceRootUIDocument(bool value) { }

	[Address(RVA = "0x2593ED0", Offset = "0x25932D0", Length = "0x2B")]
	[Token(Token = "0x6001AFC")]
	internal void set_isWorldTransformDirty(bool value) { }

	[Address(RVA = "0x2593F00", Offset = "0x2593300", Length = "0x2B")]
	[Token(Token = "0x6001AFD")]
	internal void set_isWorldTransformInverseDirty(bool value) { }

	[Address(RVA = "0x32660C0", Offset = "0x32654C0", Length = "0x89")]
	[Token(Token = "0x6001B36")]
	public void set_languageDirection(LanguageDirection value) { }

	[Address(RVA = "0x3266150", Offset = "0x3265550", Length = "0x8E9")]
	[Token(Token = "0x6001ADE")]
	internal void set_layout(Rect value) { }

	[Address(RVA = "0x3266A40", Offset = "0x3265E40", Length = "0x103")]
	[Token(Token = "0x6001B38")]
	internal void set_localLanguageDirection(LanguageDirection value) { }

	[Address(RVA = "0x3266B50", Offset = "0x3265F50", Length = "0xBA")]
	[Token(Token = "0x6001B18")]
	public void set_name(string value) { }

	[Address(RVA = "0x3266C10", Offset = "0x3266010", Length = "0x2D")]
	[Token(Token = "0x6001AE3")]
	internal void set_needs3DBounds(bool value) { }

	[Address(RVA = "0x3266C40", Offset = "0x3266040", Length = "0xA4")]
	[Token(Token = "0x6001B16")]
	public void set_pickingMode(PickingMode value) { }

	[Address(RVA = "0x3266CF0", Offset = "0x32660F0", Length = "0x65")]
	[Token(Token = "0x6001B0C")]
	internal void set_pseudoStates(PseudoStates value) { }

	[Address(RVA = "0x3266D60", Offset = "0x3266160", Length = "0x2D")]
	[Token(Token = "0x6001B08")]
	internal void set_receivesHierarchyGeometryChangedEvents(bool value) { }

	[Address(RVA = "0x3266D90", Offset = "0x3266190", Length = "0x61")]
	[Token(Token = "0x6001AD6")]
	internal void set_renderHints(RenderHints value) { }

	[Address(RVA = "0x3266E00", Offset = "0x3266200", Length = "0xA0")]
	[Token(Token = "0x6001B47")]
	internal void set_requireMeasureFunction(bool value) { }

	[Address(RVA = "0x3266EB0", Offset = "0x32662B0", Length = "0x2D")]
	[Token(Token = "0x6001B20")]
	internal void set_styleInitialized(bool value) { }

	[Address(RVA = "0x3266EE0", Offset = "0x32662E0", Length = "0x22F")]
	[Token(Token = "0x6001BDA")]
	public void set_tooltip(string value) { }

	[Address(RVA = "0x3267110", Offset = "0x3266510", Length = "0x2EA")]
	[Token(Token = "0x6001AD4")]
	public void set_usageHints(UsageHints value) { }

	[Address(RVA = "0x3267400", Offset = "0x3266800", Length = "0x145")]
	[Token(Token = "0x6001ACD")]
	public void set_userData(object value) { }

	[Address(RVA = "0x3267550", Offset = "0x3266950", Length = "0xC8")]
	[Token(Token = "0x6001ACA")]
	public void set_viewDataKey(string value) { }

	[Address(RVA = "0x3267620", Offset = "0x3266A20", Length = "0x174")]
	[Token(Token = "0x6001B3A")]
	public void set_visible(bool value) { }

	[Address(RVA = "0x32677A0", Offset = "0x3266BA0", Length = "0x13")]
	[Token(Token = "0x6001B95")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	[Address(RVA = "0x32583C0", Offset = "0x32577C0", Length = "0x8B")]
	[Token(Token = "0x6001B0D")]
	public void SetActivePseudoState(bool value) { }

	[Address(RVA = "0x3258450", Offset = "0x3257850", Length = "0xCE")]
	[Token(Token = "0x6001B72")]
	internal void SetAsNextParentWithEventInterests() { }

	[Address(RVA = "0x3258520", Offset = "0x3257920", Length = "0x8B")]
	[Token(Token = "0x6001B0E")]
	public void SetCheckedPseudoState(bool value) { }

	[Address(RVA = "0x32585B0", Offset = "0x32579B0", Length = "0x253")]
	[Token(Token = "0x6001B4E")]
	internal void SetComputedStyle(ref ComputedStyle newStyle) { }

	[Address(RVA = "0x3258C30", Offset = "0x3258030", Length = "0x8")]
	[Token(Token = "0x6001B33")]
	public void SetEnabled(bool value) { }

	[Address(RVA = "0x3258810", Offset = "0x3257C10", Length = "0x411")]
	[Token(Token = "0x6001B2E")]
	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	[Address(RVA = "0x3258C40", Offset = "0x3258040", Length = "0xA9")]
	[Token(Token = "0x6001B4D")]
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	[Address(RVA = "0x3258CF0", Offset = "0x32580F0", Length = "0xA0E")]
	[Token(Token = "0x6001B27")]
	internal void SetPanel(BaseVisualElementPanel p) { }

	[Address(RVA = "0x32597C0", Offset = "0x3258BC0", Length = "0x70")]
	[Token(Token = "0x6001B56")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule", "UnityEditor.UIToolkitAuthoringModule"})]
	internal void SetProperty(PropertyName key, object value) { }

	[Address(RVA = "0x3259700", Offset = "0x3258B00", Length = "0xB8")]
	[Token(Token = "0x6001B5A")]
	private void SetPropertyInternal(PropertyName key, object value) { }

	[Address(RVA = "0x3259830", Offset = "0x3258C30", Length = "0x3A0")]
	[Token(Token = "0x6001B24")]
	internal void SetTooltip(TooltipEvent e) { }

	[Address(RVA = "0x3259BE0", Offset = "0x3258FE0", Length = "0x32")]
	[Token(Token = "0x6001B8C")]
	internal bool ShouldClip() { }

	[Address(RVA = "0x3259C20", Offset = "0x3259020", Length = "0x158")]
	[Token(Token = "0x6001B65")]
	private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	[Address(RVA = "0x9E4B90", Offset = "0x9E3F90", Length = "0xB6")]
	[Token(Token = "0x6001B61")]
	private static ValueAnimation<T> StartAnimation(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged) { }

	[Address(RVA = "0x3259D80", Offset = "0x3259180", Length = "0x7C")]
	[Token(Token = "0x6001B26")]
	internal long TimeSinceStartupMs() { }

	[Address(RVA = "0x3259E00", Offset = "0x3259200", Length = "0x246")]
	[Token(Token = "0x6001B4F")]
	public virtual string ToString() { }

	[Address(RVA = "0x325A050", Offset = "0x3259450", Length = "0x8F")]
	[Token(Token = "0x6001B6E")]
	private void TrackSource(object previous, object current) { }

	[Address(RVA = "0x325A230", Offset = "0x3259630", Length = "0x9A")]
	[Token(Token = "0x6001BC2")]
	internal static void TransformAlignedBounds(ref Matrix4x4 matrix, ref Bounds bounds) { }

	[Address(RVA = "0x325A0E0", Offset = "0x32594E0", Length = "0x142")]
	[Token(Token = "0x6001BBD")]
	internal void TransformAlignedBoundsToParentSpace(ref Bounds bounds) { }

	[Address(RVA = "0x325A400", Offset = "0x3259800", Length = "0x7A")]
	[Token(Token = "0x6001BC1")]
	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) { }

	[Address(RVA = "0x325A2D0", Offset = "0x32596D0", Length = "0x128")]
	[Token(Token = "0x6001BBE")]
	private void TransformAlignedRectToParentSpace(ref Rect rect) { }

	[Address(RVA = "0x325A480", Offset = "0x3259880", Length = "0x107")]
	[Token(Token = "0x6001BCA")]
	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) { }

	[Address(RVA = "0x2C45A20", Offset = "0x2C44E20", Length = "0x8D")]
	[Token(Token = "0x6001BCB")]
	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) { }

	[Address(RVA = "0x325A590", Offset = "0x3259990", Length = "0xF1")]
	[Token(Token = "0x6001ABF")]
	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to) { }

	[Address(RVA = "0x325A690", Offset = "0x3259A90", Length = "0x252")]
	[Token(Token = "0x6001ABC")]
	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0) { }

	[Address(RVA = "0x325A8F0", Offset = "0x3259CF0", Length = "0xAD")]
	[Token(Token = "0x6001ABD")]
	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) { }

	[Address(RVA = "0x325A9A0", Offset = "0x3259DA0", Length = "0xAD")]
	[Token(Token = "0x6001ABE")]
	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) { }

	[Address(RVA = "0x325AA50", Offset = "0x3259E50", Length = "0xAB")]
	[Token(Token = "0x6001B6B")]
	public bool TryGetBinding(BindingId bindingId, out Binding binding) { }

	[Address(RVA = "0x325AB30", Offset = "0x3259F30", Length = "0x209")]
	[Token(Token = "0x6001B64")]
	private override ValueAnimation<StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	[Address(RVA = "0x2081AD0", Offset = "0x2080ED0", Length = "0x6")]
	[Token(Token = "0x6001B87")]
	private override ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	[Address(RVA = "0x325AD40", Offset = "0x325A140", Length = "0x4F")]
	[Token(Token = "0x6001A4A")]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignContent() { }

	[Address(RVA = "0x325AD90", Offset = "0x325A190", Length = "0x52")]
	[Token(Token = "0x6001A4B")]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignItems() { }

	[Address(RVA = "0x325ADF0", Offset = "0x325A1F0", Length = "0x52")]
	[Token(Token = "0x6001A4C")]
	private override Align UnityEngine.UIElements.IResolvedStyle.get_alignSelf() { }

	[Address(RVA = "0x325AE50", Offset = "0x325A250", Length = "0xCB")]
	[Token(Token = "0x6001A4D")]
	private override Ratio UnityEngine.UIElements.IResolvedStyle.get_aspectRatio() { }

	[Address(RVA = "0x325AF20", Offset = "0x325A320", Length = "0xD1")]
	[Token(Token = "0x6001A4E")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	[Address(RVA = "0x325B000", Offset = "0x325A400", Length = "0xD9")]
	[Token(Token = "0x6001A4F")]
	private override Background UnityEngine.UIElements.IResolvedStyle.get_backgroundImage() { }

	[Address(RVA = "0x325B0E0", Offset = "0x325A4E0", Length = "0xD9")]
	[Token(Token = "0x6001A50")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionX() { }

	[Address(RVA = "0x325B1C0", Offset = "0x325A5C0", Length = "0xD9")]
	[Token(Token = "0x6001A51")]
	private override BackgroundPosition UnityEngine.UIElements.IResolvedStyle.get_backgroundPositionY() { }

	[Address(RVA = "0x325B2A0", Offset = "0x325A6A0", Length = "0xCB")]
	[Token(Token = "0x6001A52")]
	private override BackgroundRepeat UnityEngine.UIElements.IResolvedStyle.get_backgroundRepeat() { }

	[Address(RVA = "0x325B370", Offset = "0x325A770", Length = "0xD7")]
	[Token(Token = "0x6001A53")]
	private override BackgroundSize UnityEngine.UIElements.IResolvedStyle.get_backgroundSize() { }

	[Address(RVA = "0x325B450", Offset = "0x325A850", Length = "0xD1")]
	[Token(Token = "0x6001A54")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	[Address(RVA = "0x325B530", Offset = "0x325A930", Length = "0x52")]
	[Token(Token = "0x6001A55")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	[Address(RVA = "0x325B590", Offset = "0x325A990", Length = "0x52")]
	[Token(Token = "0x6001A56")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	[Address(RVA = "0x325B5F0", Offset = "0x325A9F0", Length = "0x52")]
	[Token(Token = "0x6001A57")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	[Address(RVA = "0x325B650", Offset = "0x325AA50", Length = "0xD1")]
	[Token(Token = "0x6001A58")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	[Address(RVA = "0x325B730", Offset = "0x325AB30", Length = "0x52")]
	[Token(Token = "0x6001A59")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	[Address(RVA = "0x325B790", Offset = "0x325AB90", Length = "0xD1")]
	[Token(Token = "0x6001A5A")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	[Address(RVA = "0x325B870", Offset = "0x325AC70", Length = "0x52")]
	[Token(Token = "0x6001A5B")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	[Address(RVA = "0x325B8D0", Offset = "0x325ACD0", Length = "0xD1")]
	[Token(Token = "0x6001A5C")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	[Address(RVA = "0x325B9B0", Offset = "0x325ADB0", Length = "0x52")]
	[Token(Token = "0x6001A5D")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	[Address(RVA = "0x325BA10", Offset = "0x325AE10", Length = "0x52")]
	[Token(Token = "0x6001A5E")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	[Address(RVA = "0x325BA70", Offset = "0x325AE70", Length = "0x52")]
	[Token(Token = "0x6001A5F")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	[Address(RVA = "0x325BAD0", Offset = "0x325AED0", Length = "0x52")]
	[Token(Token = "0x6001A60")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	[Address(RVA = "0x325BB30", Offset = "0x325AF30", Length = "0xD1")]
	[Token(Token = "0x6001A61")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	[Address(RVA = "0x325BC10", Offset = "0x325B010", Length = "0x52")]
	[Token(Token = "0x6001A62")]
	private override DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	[Address(RVA = "0x325BC70", Offset = "0x325B070", Length = "0x52")]
	[Token(Token = "0x6001A63")]
	private override IEnumerable<FilterFunction> UnityEngine.UIElements.IResolvedStyle.get_filter() { }

	[Address(RVA = "0x325BCD0", Offset = "0x325B0D0", Length = "0x52")]
	[Token(Token = "0x6001A64")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_flexBasis() { }

	[Address(RVA = "0x325BD30", Offset = "0x325B130", Length = "0x52")]
	[Token(Token = "0x6001A65")]
	private override FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	[Address(RVA = "0x325BD90", Offset = "0x325B190", Length = "0x52")]
	[Token(Token = "0x6001A66")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	[Address(RVA = "0x325BDF0", Offset = "0x325B1F0", Length = "0x52")]
	[Token(Token = "0x6001A67")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	[Address(RVA = "0x325BE50", Offset = "0x325B250", Length = "0x52")]
	[Token(Token = "0x6001A68")]
	private override Wrap UnityEngine.UIElements.IResolvedStyle.get_flexWrap() { }

	[Address(RVA = "0x325BEB0", Offset = "0x325B2B0", Length = "0x52")]
	[Token(Token = "0x6001A69")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_fontSize() { }

	[Address(RVA = "0x325BF10", Offset = "0x325B310", Length = "0x52")]
	[Token(Token = "0x6001A6A")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	[Address(RVA = "0x325BF70", Offset = "0x325B370", Length = "0x52")]
	[Token(Token = "0x6001A6B")]
	private override Justify UnityEngine.UIElements.IResolvedStyle.get_justifyContent() { }

	[Address(RVA = "0x325BFD0", Offset = "0x325B3D0", Length = "0x52")]
	[Token(Token = "0x6001A6C")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	[Address(RVA = "0x325C030", Offset = "0x325B430", Length = "0x52")]
	[Token(Token = "0x6001A6D")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_letterSpacing() { }

	[Address(RVA = "0x325C090", Offset = "0x325B490", Length = "0x52")]
	[Token(Token = "0x6001A6E")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	[Address(RVA = "0x325C0F0", Offset = "0x325B4F0", Length = "0x52")]
	[Token(Token = "0x6001A6F")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	[Address(RVA = "0x325C150", Offset = "0x325B550", Length = "0x52")]
	[Token(Token = "0x6001A70")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	[Address(RVA = "0x325C1B0", Offset = "0x325B5B0", Length = "0x52")]
	[Token(Token = "0x6001A71")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	[Address(RVA = "0x325C210", Offset = "0x325B610", Length = "0x52")]
	[Token(Token = "0x6001A72")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_maxHeight() { }

	[Address(RVA = "0x325C270", Offset = "0x325B670", Length = "0x52")]
	[Token(Token = "0x6001A73")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_maxWidth() { }

	[Address(RVA = "0x325C2D0", Offset = "0x325B6D0", Length = "0x52")]
	[Token(Token = "0x6001A74")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	[Address(RVA = "0x325C330", Offset = "0x325B730", Length = "0x52")]
	[Token(Token = "0x6001A75")]
	private override StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	[Address(RVA = "0x325C390", Offset = "0x325B790", Length = "0x52")]
	[Token(Token = "0x6001A76")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	[Address(RVA = "0x325C3F0", Offset = "0x325B7F0", Length = "0x52")]
	[Token(Token = "0x6001A77")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	[Address(RVA = "0x325C450", Offset = "0x325B850", Length = "0x52")]
	[Token(Token = "0x6001A78")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	[Address(RVA = "0x325C4B0", Offset = "0x325B8B0", Length = "0x52")]
	[Token(Token = "0x6001A79")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	[Address(RVA = "0x325C510", Offset = "0x325B910", Length = "0x52")]
	[Token(Token = "0x6001A7A")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	[Address(RVA = "0x325C570", Offset = "0x325B970", Length = "0x52")]
	[Token(Token = "0x6001A7B")]
	private override Position UnityEngine.UIElements.IResolvedStyle.get_position() { }

	[Address(RVA = "0x325C5D0", Offset = "0x325B9D0", Length = "0x52")]
	[Token(Token = "0x6001A7C")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	[Address(RVA = "0x325C630", Offset = "0x325BA30", Length = "0xDB")]
	[Token(Token = "0x6001A7D")]
	private override Rotate UnityEngine.UIElements.IResolvedStyle.get_rotate() { }

	[Address(RVA = "0x325C710", Offset = "0x325BB10", Length = "0xD1")]
	[Token(Token = "0x6001A7E")]
	private override Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	[Address(RVA = "0x325C7F0", Offset = "0x325BBF0", Length = "0x52")]
	[Token(Token = "0x6001A7F")]
	private override TextOverflow UnityEngine.UIElements.IResolvedStyle.get_textOverflow() { }

	[Address(RVA = "0x325C850", Offset = "0x325BC50", Length = "0x52")]
	[Token(Token = "0x6001A80")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	[Address(RVA = "0x325C8B0", Offset = "0x325BCB0", Length = "0xD9")]
	[Token(Token = "0x6001A81")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	[Address(RVA = "0x325C990", Offset = "0x325BD90", Length = "0x52")]
	[Token(Token = "0x6001A82")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.get_transitionDelay() { }

	[Address(RVA = "0x325C9F0", Offset = "0x325BDF0", Length = "0x52")]
	[Token(Token = "0x6001A83")]
	private override IEnumerable<TimeValue> UnityEngine.UIElements.IResolvedStyle.get_transitionDuration() { }

	[Address(RVA = "0x325CA50", Offset = "0x325BE50", Length = "0x52")]
	[Token(Token = "0x6001A84")]
	private override IEnumerable<StylePropertyName> UnityEngine.UIElements.IResolvedStyle.get_transitionProperty() { }

	[Address(RVA = "0x325CAB0", Offset = "0x325BEB0", Length = "0x52")]
	[Token(Token = "0x6001A85")]
	private override IEnumerable<EasingFunction> UnityEngine.UIElements.IResolvedStyle.get_transitionTimingFunction() { }

	[Address(RVA = "0x325CB10", Offset = "0x325BF10", Length = "0xD9")]
	[Token(Token = "0x6001A86")]
	private override Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	[Address(RVA = "0x325CBF0", Offset = "0x325BFF0", Length = "0xD1")]
	[Token(Token = "0x6001A87")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	[Address(RVA = "0x325CCD0", Offset = "0x325C0D0", Length = "0x52")]
	[Token(Token = "0x6001A88")]
	private override EditorTextRenderingMode UnityEngine.UIElements.IResolvedStyle.get_unityEditorTextRenderingMode() { }

	[Address(RVA = "0x325CE70", Offset = "0x325C270", Length = "0xCB")]
	[Token(Token = "0x6001A89")]
	private override Font UnityEngine.UIElements.IResolvedStyle.get_unityFont() { }

	[Address(RVA = "0x325CD30", Offset = "0x325C130", Length = "0xD1")]
	[Token(Token = "0x6001A8A")]
	private override FontDefinition UnityEngine.UIElements.IResolvedStyle.get_unityFontDefinition() { }

	[Address(RVA = "0x325CE10", Offset = "0x325C210", Length = "0x52")]
	[Token(Token = "0x6001A8B")]
	private override FontStyle UnityEngine.UIElements.IResolvedStyle.get_unityFontStyleAndWeight() { }

	[Address(RVA = "0x325CF40", Offset = "0x325C340", Length = "0xD1")]
	[Token(Token = "0x6001A8C")]
	private override MaterialDefinition UnityEngine.UIElements.IResolvedStyle.get_unityMaterial() { }

	[Address(RVA = "0x325D020", Offset = "0x325C420", Length = "0x52")]
	[Token(Token = "0x6001A8D")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unityParagraphSpacing() { }

	[Address(RVA = "0x325D080", Offset = "0x325C480", Length = "0x52")]
	[Token(Token = "0x6001A8E")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceBottom() { }

	[Address(RVA = "0x325D0E0", Offset = "0x325C4E0", Length = "0x52")]
	[Token(Token = "0x6001A8F")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	[Address(RVA = "0x325D140", Offset = "0x325C540", Length = "0x52")]
	[Token(Token = "0x6001A90")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	[Address(RVA = "0x325D1A0", Offset = "0x325C5A0", Length = "0x52")]
	[Token(Token = "0x6001A91")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	[Address(RVA = "0x325D200", Offset = "0x325C600", Length = "0x52")]
	[Token(Token = "0x6001A92")]
	private override int UnityEngine.UIElements.IResolvedStyle.get_unitySliceTop() { }

	[Address(RVA = "0x325D260", Offset = "0x325C660", Length = "0x52")]
	[Token(Token = "0x6001A93")]
	private override SliceType UnityEngine.UIElements.IResolvedStyle.get_unitySliceType() { }

	[Address(RVA = "0x325D2C0", Offset = "0x325C6C0", Length = "0x52")]
	[Token(Token = "0x6001A94")]
	private override TextAnchor UnityEngine.UIElements.IResolvedStyle.get_unityTextAlign() { }

	[Address(RVA = "0x325D320", Offset = "0x325C720", Length = "0x52")]
	[Token(Token = "0x6001A95")]
	private override TextGeneratorType UnityEngine.UIElements.IResolvedStyle.get_unityTextGenerator() { }

	[Address(RVA = "0x325D380", Offset = "0x325C780", Length = "0xD1")]
	[Token(Token = "0x6001A96")]
	private override Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	[Address(RVA = "0x325D460", Offset = "0x325C860", Length = "0x52")]
	[Token(Token = "0x6001A97")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	[Address(RVA = "0x325D4C0", Offset = "0x325C8C0", Length = "0x52")]
	[Token(Token = "0x6001A98")]
	private override TextOverflowPosition UnityEngine.UIElements.IResolvedStyle.get_unityTextOverflowPosition() { }

	[Address(RVA = "0x325D520", Offset = "0x325C920", Length = "0x52")]
	[Token(Token = "0x6001A99")]
	private override Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	[Address(RVA = "0x325D580", Offset = "0x325C980", Length = "0x52")]
	[Token(Token = "0x6001A9A")]
	private override WhiteSpace UnityEngine.UIElements.IResolvedStyle.get_whiteSpace() { }

	[Address(RVA = "0x325D5E0", Offset = "0x325C9E0", Length = "0x52")]
	[Token(Token = "0x6001A9B")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	[Address(RVA = "0x325D640", Offset = "0x325CA40", Length = "0x52")]
	[Token(Token = "0x6001A9C")]
	private override float UnityEngine.UIElements.IResolvedStyle.get_wordSpacing() { }

	[Address(RVA = "0x325D6A0", Offset = "0x325CAA0", Length = "0x154")]
	[Token(Token = "0x6001AB9")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	[Address(RVA = "0x325D800", Offset = "0x325CC00", Length = "0x75")]
	[Token(Token = "0x6001AB8")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	[Address(RVA = "0x1BBC140", Offset = "0x1BBB540", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001AA1")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	[Address(RVA = "0xB0A070", Offset = "0xB09470", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001A9F")]
	private override int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	[Address(RVA = "0x325D880", Offset = "0x325CC80", Length = "0x16C")]
	[Token(Token = "0x6001ABB")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	[Address(RVA = "0x1BBC2A0", Offset = "0x1BBB6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001AA2")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	[Address(RVA = "0xB0A080", Offset = "0xB09480", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6001AA0")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	[Address(RVA = "0x325EA10", Offset = "0x325DE10", Length = "0xBF")]
	[Token(Token = "0x6001AA6")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325E320", Offset = "0x325D720", Length = "0x149")]
	[Token(Token = "0x6001AA5")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325E470", Offset = "0x325D870", Length = "0x16A")]
	[Token(Token = "0x6001AB7")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, MaterialDefinition from, MaterialDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325E750", Offset = "0x325DB50", Length = "0x138")]
	[Token(Token = "0x6001AB6")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, List<FilterFunction> from, List<FilterFunction> to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325DE90", Offset = "0x325D290", Length = "0x17E")]
	[Token(Token = "0x6001AB5")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325EAD0", Offset = "0x325DED0", Length = "0x138")]
	[Token(Token = "0x6001AB4")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325DD50", Offset = "0x325D150", Length = "0x138")]
	[Token(Token = "0x6001AA7")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325E890", Offset = "0x325DC90", Length = "0x17E")]
	[Token(Token = "0x6001AB2")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325E010", Offset = "0x325D410", Length = "0x17C")]
	[Token(Token = "0x6001AB3")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325E190", Offset = "0x325D590", Length = "0x186")]
	[Token(Token = "0x6001AB0")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325ED80", Offset = "0x325E180", Length = "0x186")]
	[Token(Token = "0x6001AAF")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325E5E0", Offset = "0x325D9E0", Length = "0x16A")]
	[Token(Token = "0x6001AAE")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325F080", Offset = "0x325E480", Length = "0x19C")]
	[Token(Token = "0x6001AAD")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325DAB0", Offset = "0x325CEB0", Length = "0x138")]
	[Token(Token = "0x6001AAC")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325EF10", Offset = "0x325E310", Length = "0x16A")]
	[Token(Token = "0x6001AAB")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325F220", Offset = "0x325E620", Length = "0x182")]
	[Token(Token = "0x6001AAA")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325DBF0", Offset = "0x325CFF0", Length = "0x152")]
	[Token(Token = "0x6001AB1")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Ratio from, Ratio to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325EC10", Offset = "0x325E010", Length = "0x16A")]
	[Token(Token = "0x6001AA8")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325D9F0", Offset = "0x325CDF0", Length = "0xBF")]
	[Token(Token = "0x6001AA9")]
	private override bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x325F3B0", Offset = "0x325E7B0", Length = "0x7A")]
	[Token(Token = "0x6001ABA")]
	private override void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	[Address(RVA = "0x325F4F0", Offset = "0x325E8F0", Length = "0xBA")]
	[Token(Token = "0x6001BCE")]
	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	[Address(RVA = "0x325F430", Offset = "0x325E830", Length = "0xBA")]
	[Token(Token = "0x6001BCD")]
	private override IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action<TimerState> timerUpdateEvent) { }

	[Address(RVA = "0x325F5B0", Offset = "0x325E9B0", Length = "0x74")]
	[Token(Token = "0x6001B5E")]
	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x325F630", Offset = "0x325EA30", Length = "0x82")]
	[Token(Token = "0x6001B5F")]
	private void UnregisterRunningAnimations() { }

	[Address(RVA = "0x325F6C0", Offset = "0x325EAC0", Length = "0x78C")]
	[Token(Token = "0x6001AF0")]
	internal void UpdateBoundingBox() { }

	[Address(RVA = "0x325FE50", Offset = "0x325F250", Length = "0x6F1")]
	[Token(Token = "0x6001AF5")]
	private void UpdateBounds3D() { }

	[Address(RVA = "0x3260550", Offset = "0x325F950", Length = "0x320")]
	[Token(Token = "0x6001B5B")]
	internal void UpdateCursorStyle(long eventType) { }

	[Address(RVA = "0x3260880", Offset = "0x325FC80", Length = "0x267")]
	[Token(Token = "0x6001B7B")]
	private void UpdateEventInterestParentCategories() { }

	[Address(RVA = "0x3260AF0", Offset = "0x325FEF0", Length = "0x159")]
	[Token(Token = "0x6001B7A")]
	private void UpdateEventInterestSelfCategories() { }

	[Address(RVA = "0x3260CD0", Offset = "0x32600D0", Length = "0x168")]
	[Token(Token = "0x6001B11")]
	internal void UpdateHoverPseudoState() { }

	[Address(RVA = "0x3260C50", Offset = "0x3260050", Length = "0x80")]
	[Token(Token = "0x6001B13")]
	internal void UpdateHoverPseudoStateAfterCaptureChange(int pointerId) { }

	[Address(RVA = "0x3260E40", Offset = "0x3260240", Length = "0xB2")]
	[Token(Token = "0x6001B14")]
	internal void UpdatePointerCaptureFlag() { }

	[Address(RVA = "0x3260F00", Offset = "0x3260300", Length = "0x87")]
	[Token(Token = "0x6001AF1")]
	internal void UpdateWorldBoundingBox() { }

	[Address(RVA = "0x3261000", Offset = "0x3260400", Length = "0x2D1")]
	[Token(Token = "0x6001B02")]
	internal void UpdateWorldTransform() { }

	[Address(RVA = "0x3260F90", Offset = "0x3260390", Length = "0x64")]
	[Token(Token = "0x6001B03")]
	internal void UpdateWorldTransformInverse() { }

	[Address(RVA = "0x32612E0", Offset = "0x32606E0", Length = "0x2B2")]
	[Token(Token = "0x6001B28")]
	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

}

