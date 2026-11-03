namespace UnityEngine.UIElements;

[Token(Token = "0x2000033")]
internal sealed class DataBindingManager : IDisposable
{
	[Token(Token = "0x2000036")]
	public class BindingData
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000122")]
		public long version; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000123")]
		public BindingTarget target; //Field offset: 0x18
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000124")]
		public Binding binding; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000125")]
		private DataSourceContext m_LastContext; //Field offset: 0xC0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x158")]
		[Token(Token = "0x4000126")]
		private object <localDataSource>k__BackingField; //Field offset: 0x158
		[FieldOffset(Offset = "0x160")]
		[Token(Token = "0x4000127")]
		public Nullable<BindingResult> m_SourceToUILastUpdate; //Field offset: 0x160
		[FieldOffset(Offset = "0x178")]
		[Token(Token = "0x4000128")]
		public Nullable<BindingResult> m_UIToSourceLastUpdate; //Field offset: 0x178

		[Token(Token = "0x1700003B")]
		public DataSourceContext context
		{
			[Address(RVA = "0x31EF250", Offset = "0x31EE650", Length = "0x36D")]
			[Token(Token = "0x60001C9")]
			 set { } //Length: 877
		}

		[Token(Token = "0x1700003A")]
		public object localDataSource
		{
			[Address(RVA = "0x1E16810", Offset = "0x1E15C10", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x60001C6")]
			 get { } //Length: 8
			[Address(RVA = "0x31EF5C0", Offset = "0x31EE9C0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x60001C7")]
			 set { } //Length: 19
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60001CA")]
		public BindingData() { }

		[Address(RVA = "0x1E16810", Offset = "0x1E15C10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60001C6")]
		public object get_localDataSource() { }

		[Address(RVA = "0x31EF190", Offset = "0x31EE590", Length = "0xBD")]
		[Token(Token = "0x60001C8")]
		public void Reset() { }

		[Address(RVA = "0x31EF250", Offset = "0x31EE650", Length = "0x36D")]
		[Token(Token = "0x60001C9")]
		public void set_context(DataSourceContext value) { }

		[Address(RVA = "0x31EF5C0", Offset = "0x31EE9C0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x60001C7")]
		public void set_localDataSource(object value) { }

	}

	[Token(Token = "0x2000035")]
	private struct BindingDataCollection : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000120")]
		private Dictionary<BindingId, BindingData> m_BindingPerId; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000121")]
		private List<BindingData> m_Bindings; //Field offset: 0x8

		[Address(RVA = "0x31EEAF0", Offset = "0x31EDEF0", Length = "0x20A")]
		[Token(Token = "0x60001C0")]
		public void AddBindingData(BindingData bindingData) { }

		[Address(RVA = "0x31EED00", Offset = "0x31EE100", Length = "0xCB")]
		[Token(Token = "0x60001BF")]
		public static BindingDataCollection Create() { }

		[Address(RVA = "0x31EEDD0", Offset = "0x31EE1D0", Length = "0xD8")]
		[Token(Token = "0x60001C5")]
		public override void Dispose() { }

		[Address(RVA = "0x31EEEB0", Offset = "0x31EE2B0", Length = "0x3C")]
		[Token(Token = "0x60001C4")]
		public int GetBindingCount() { }

		[Address(RVA = "0x20939E0", Offset = "0x2092DE0", Length = "0x7")]
		[Token(Token = "0x60001C3")]
		public List<BindingData> GetBindings() { }

		[Address(RVA = "0x31EEEF0", Offset = "0x31EE2F0", Length = "0x1B2")]
		[Token(Token = "0x60001C2")]
		public bool RemoveBindingData(BindingData bindingData) { }

		[Address(RVA = "0x31EF0B0", Offset = "0x31EE4B0", Length = "0xDE")]
		[Token(Token = "0x60001C1")]
		public bool TryGetBindingData(in BindingId bindingId, out BindingData data) { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000034")]
	private struct BindingRequest
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400011D")]
		public readonly BindingId bindingId; //Field offset: 0x0
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400011E")]
		public readonly Binding binding; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400011F")]
		public readonly bool shouldProcess; //Field offset: 0xA0

		[Address(RVA = "0x31EF6C0", Offset = "0x31EEAC0", Length = "0xDD")]
		[Token(Token = "0x60001BD")]
		public BindingRequest(in BindingId bindingId, Binding binding, bool shouldProcess = true) { }

		[Address(RVA = "0x31EF5E0", Offset = "0x31EE9E0", Length = "0xD3")]
		[Token(Token = "0x60001BE")]
		public BindingRequest CancelRequest() { }

	}

	[IsReadOnly]
	[Token(Token = "0x2000037")]
	public struct ChangesFromUI
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000129")]
		public readonly long version; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400012A")]
		public readonly Binding binding; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012B")]
		public readonly BindingData bindingData; //Field offset: 0x10

		[Token(Token = "0x1700003C")]
		public bool IsValid
		{
			[Address(RVA = "0x31F2450", Offset = "0x31F1850", Length = "0x3C")]
			[Token(Token = "0x60001CC")]
			 get { } //Length: 60
		}

		[Address(RVA = "0x31F2400", Offset = "0x31F1800", Length = "0x4C")]
		[Token(Token = "0x60001CB")]
		public ChangesFromUI(BindingData bindingData) { }

		[Address(RVA = "0x31F2450", Offset = "0x31F1850", Length = "0x3C")]
		[Token(Token = "0x60001CC")]
		public bool get_IsValid() { }

	}

	[Token(Token = "0x2000038")]
	private class HierarchyBindingTracker : IDisposable
	{
		[Token(Token = "0x2000039")]
		private class HierarchicalBindingsSorter : HierarchyTraversal
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000133")]
			private HashSet<VisualElement> <boundElements>k__BackingField; //Field offset: 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000134")]
			private List<VisualElement> <results>k__BackingField; //Field offset: 0x18

			[Token(Token = "0x1700003D")]
			public HashSet<VisualElement> boundElements
			{
				[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60001D9")]
				 get { } //Length: 5
				[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
				[CompilerGenerated]
				[Token(Token = "0x60001DA")]
				 set { } //Length: 13
			}

			[Token(Token = "0x1700003E")]
			public List<VisualElement> results
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60001DB")]
				 get { } //Length: 5
				[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
				[CompilerGenerated]
				[Token(Token = "0x60001DC")]
				 set { } //Length: 13
			}

			[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
			[Token(Token = "0x60001DE")]
			public HierarchicalBindingsSorter() { }

			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60001D9")]
			public HashSet<VisualElement> get_boundElements() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60001DB")]
			public List<VisualElement> get_results() { }

			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60001DA")]
			public void set_boundElements(HashSet<VisualElement> value) { }

			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60001DC")]
			public void set_results(List<VisualElement> value) { }

			[Address(RVA = "0x320B960", Offset = "0x320AD60", Length = "0xC3")]
			[Token(Token = "0x60001DD")]
			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400012C")]
		private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400012D")]
		private readonly HierarchicalBindingsSorter m_BindingSorter; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400012E")]
		private readonly Dictionary<VisualElement, BindingDataCollection> m_BindingDataPerElement; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400012F")]
		private readonly HashSet<VisualElement> m_BoundElements; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000130")]
		private readonly List<VisualElement> m_OrderedBindings; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000131")]
		private bool m_IsDirty; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000132")]
		private EventCallback<PropertyChangedEvent, Dictionary`2<VisualElement, BindingDataCollection>> m_OnPropertyChanged; //Field offset: 0x40

		[Address(RVA = "0x320C960", Offset = "0x320BD60", Length = "0x19B")]
		[Token(Token = "0x60001CF")]
		public HierarchyBindingTracker(BaseVisualElementPanel panel) { }

		[Address(RVA = "0x320BA30", Offset = "0x320AE30", Length = "0x1C2")]
		[Token(Token = "0x60001D7")]
		public override void Dispose() { }

		[Address(RVA = "0x320BC00", Offset = "0x320B000", Length = "0xEF")]
		[Token(Token = "0x60001CE")]
		public List<VisualElement> GetBoundElements() { }

		[Address(RVA = "0x320BCF0", Offset = "0x320B0F0", Length = "0x3C")]
		[Token(Token = "0x60001CD")]
		public int GetTrackedElementsCount() { }

		[Address(RVA = "0x320BD30", Offset = "0x320B130", Length = "0x53")]
		[Token(Token = "0x60001D2")]
		public bool IsTrackingElement(VisualElement element) { }

		[Address(RVA = "0x320BD90", Offset = "0x320B190", Length = "0x5AD")]
		[Token(Token = "0x60001D4")]
		private void OnPropertyChanged(PropertyChangedEvent evt, Dictionary<VisualElement, BindingDataCollection> bindingCollection) { }

		[Address(RVA = "0x320C340", Offset = "0x320B740", Length = "0xC1")]
		[Token(Token = "0x60001D8")]
		private void OrderBindings(VisualElement root) { }

		[Address(RVA = "0x262C670", Offset = "0x262BA70", Length = "0x5")]
		[Token(Token = "0x60001D0")]
		public void SetDirty() { }

		[Address(RVA = "0x320C410", Offset = "0x320B810", Length = "0x271")]
		[Token(Token = "0x60001D3")]
		public void StartTrackingBinding(VisualElement element, BindingData binding) { }

		[Address(RVA = "0x320C690", Offset = "0x320BA90", Length = "0x19E")]
		[Token(Token = "0x60001D5")]
		public void StopTrackingBinding(VisualElement element, BindingData binding) { }

		[Address(RVA = "0x320C830", Offset = "0x320BC30", Length = "0xBD")]
		[Token(Token = "0x60001D6")]
		public void StopTrackingElement(VisualElement element) { }

		[Address(RVA = "0x320C8F0", Offset = "0x320BCF0", Length = "0x63")]
		[Token(Token = "0x60001D1")]
		public bool TryGetBindingCollection(VisualElement element, out BindingDataCollection collection) { }

	}

	[Token(Token = "0x200003A")]
	private class HierarchyDataSourceTracker : IDisposable
	{
		[Token(Token = "0x200003C")]
		private class InvalidateDataSourcesTraversal : HierarchyTraversal
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000141")]
			private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000142")]
			private readonly HashSet<VisualElement> m_VisitedElements; //Field offset: 0x18

			[Address(RVA = "0x3224440", Offset = "0x3223840", Length = "0x8A")]
			[Token(Token = "0x60001FB")]
			public InvalidateDataSourcesTraversal(HierarchyDataSourceTracker dataSourceTracker) { }

			[Address(RVA = "0x3224180", Offset = "0x3223580", Length = "0x1E7")]
			[Token(Token = "0x60001FC")]
			public void Invalidate(List<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

			[Address(RVA = "0x3224370", Offset = "0x3223770", Length = "0xC1")]
			[Token(Token = "0x60001FD")]
			public virtual void TraverseRecursive(VisualElement element, int depth) { }

		}

		[Token(Token = "0x200003D")]
		private class ObjectComparer : IEqualityComparer<Object>
		{

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000200")]
			public ObjectComparer() { }

			[Address(RVA = "0x3225850", Offset = "0x3224C50", Length = "0x180")]
			[Token(Token = "0x60001FE")]
			private override bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

			[Address(RVA = "0x2152370", Offset = "0x2151770", Length = "0xA")]
			[Token(Token = "0x60001FF")]
			private override int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

		}

		[Token(Token = "0x200003B")]
		private class SourceInfo
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x400013E")]
			private HashSet<PropertyPath> m_DetectedChanges; //Field offset: 0x10
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x400013F")]
			private long <lastVersion>k__BackingField; //Field offset: 0x18
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
			[FieldOffset(Offset = "0x20")]
			[Token(Token = "0x4000140")]
			private int <refCount>k__BackingField; //Field offset: 0x20

			[Token(Token = "0x17000041")]
			public HashSet<PropertyPath> detectedChanges
			{
				[Address(RVA = "0x32288C0", Offset = "0x3227CC0", Length = "0x7B")]
				[Token(Token = "0x60001F8")]
				 get { } //Length: 123
			}

			[Token(Token = "0x17000042")]
			public HashSet<PropertyPath> detectedChangesNoAlloc
			{
				[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
				[Token(Token = "0x60001F9")]
				 get { } //Length: 5
			}

			[Token(Token = "0x1700003F")]
			public long lastVersion
			{
				[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60001F4")]
				 get { } //Length: 5
				[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
				[CompilerGenerated]
				[Token(Token = "0x60001F5")]
				 set { } //Length: 5
			}

			[Token(Token = "0x17000040")]
			public int refCount
			{
				[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x60001F6")]
				 get { } //Length: 4
				[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
				[CompilerGenerated]
				[Token(Token = "0x60001F7")]
				 set { } //Length: 4
			}

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60001FA")]
			public SourceInfo() { }

			[Address(RVA = "0x32288C0", Offset = "0x3227CC0", Length = "0x7B")]
			[Token(Token = "0x60001F8")]
			public HashSet<PropertyPath> get_detectedChanges() { }

			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[Token(Token = "0x60001F9")]
			public HashSet<PropertyPath> get_detectedChangesNoAlloc() { }

			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60001F4")]
			public long get_lastVersion() { }

			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60001F6")]
			public int get_refCount() { }

			[Address(RVA = "0xF4AFC0", Offset = "0xF4A3C0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60001F5")]
			public void set_lastVersion(long value) { }

			[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60001F7")]
			public void set_refCount(int value) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000135")]
		private readonly List<SourceInfo> m_SourceInfosPool; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000136")]
		private readonly DataBindingManager m_DataBindingManager; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000137")]
		private readonly Dictionary<VisualElement, DataSourceContext> m_ResolvedHierarchicalDataSourceContext; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000138")]
		private readonly Dictionary<Binding, Int32> m_BindingRefCount; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000139")]
		private readonly Dictionary<Object, SourceInfo> m_SourceInfos; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400013A")]
		private readonly HashSet<Object> m_SourcesToRemove; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400013B")]
		private readonly InvalidateDataSourcesTraversal m_InvalidateResolvedDataSources; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400013C")]
		private readonly EventHandler<BindablePropertyChangedEventArgs> m_Handler; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x400013D")]
		private readonly EventCallback<PropertyChangedEvent, VisualElement> m_VisualElementHandler; //Field offset: 0x50

		[Address(RVA = "0x320F020", Offset = "0x320E420", Length = "0x2AC")]
		[Token(Token = "0x60001E1")]
		public HierarchyDataSourceTracker(DataBindingManager manager) { }

		[Address(RVA = "0x320CB00", Offset = "0x320BF00", Length = "0x91")]
		[Token(Token = "0x60001E9")]
		public void ClearChangesFromSource(object dataSource) { }

		[Address(RVA = "0x320CBA0", Offset = "0x320BFA0", Length = "0x300")]
		[Token(Token = "0x60001F3")]
		public void ClearSourceCache() { }

		[Address(RVA = "0x320CEB0", Offset = "0x320C2B0", Length = "0x159")]
		[Token(Token = "0x60001E3")]
		internal void DecreaseBindingRefCount(ref BindingData bindingData) { }

		[Address(RVA = "0x320D010", Offset = "0x320C410", Length = "0x1AC")]
		[Token(Token = "0x60001E6")]
		internal void DecreaseRefCount(object dataSource) { }

		[Address(RVA = "0x320D1C0", Offset = "0x320C5C0", Length = "0xDD")]
		[Token(Token = "0x60001F2")]
		public override void Dispose() { }

		[Address(RVA = "0x320D2A0", Offset = "0x320C6A0", Length = "0x7F")]
		[Token(Token = "0x60001E8")]
		public HashSet<PropertyPath> GetChangesFromSource(object dataSource) { }

		[Address(RVA = "0x320D320", Offset = "0x320C720", Length = "0x6D2")]
		[Token(Token = "0x60001F0")]
		internal DataSourceContext GetHierarchicalDataSourceContext(VisualElement element) { }

		[Address(RVA = "0x320DA00", Offset = "0x320CE00", Length = "0xD1")]
		[Token(Token = "0x60001DF")]
		private SourceInfo GetPooledSourceInfo() { }

		[Address(RVA = "0x320DAE0", Offset = "0x320CEE0", Length = "0x7F8")]
		[Token(Token = "0x60001EB")]
		public DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

		[Address(RVA = "0x320E2E0", Offset = "0x320D6E0", Length = "0x44")]
		[Token(Token = "0x60001E7")]
		public int GetTrackedDataSourcesCount() { }

		[Address(RVA = "0x320E330", Offset = "0x320D730", Length = "0x138")]
		[Token(Token = "0x60001E2")]
		internal void IncreaseBindingRefCount(ref BindingData bindingData) { }

		[Address(RVA = "0x320E470", Offset = "0x320D870", Length = "0x242")]
		[Token(Token = "0x60001E4")]
		internal void IncreaseRefCount(object dataSource) { }

		[Address(RVA = "0x320E6C0", Offset = "0x320DAC0", Length = "0x290")]
		[Token(Token = "0x60001EA")]
		public void InvalidateCachedDataSource(HashSet<VisualElement> elements, HashSet<VisualElement> removedElements) { }

		[Address(RVA = "0x320E960", Offset = "0x320DD60", Length = "0x18F")]
		[Token(Token = "0x60001E5")]
		private void OnVisualElementPropertyChanged(PropertyChangedEvent evt, VisualElement element) { }

		[Address(RVA = "0x320EAF0", Offset = "0x320DEF0", Length = "0xE8")]
		[Token(Token = "0x60001E0")]
		private void ReleasePooledSourceInfo(SourceInfo info) { }

		[Address(RVA = "0x320EBE0", Offset = "0x320DFE0", Length = "0x53")]
		[Token(Token = "0x60001F1")]
		internal void RemoveHierarchyDataSourceContextFromElement(VisualElement element) { }

		[Address(RVA = "0x320EC40", Offset = "0x320E040", Length = "0x167")]
		[Token(Token = "0x60001EC")]
		private void TrackPropertyChanges(object sender, BindablePropertyChangedEventArgs args) { }

		[Address(RVA = "0x320EDB0", Offset = "0x320E1B0", Length = "0x126")]
		[Token(Token = "0x60001ED")]
		private void TrackPropertyChanges(object sender, PropertyPath propertyPath) { }

		[Address(RVA = "0x320EEE0", Offset = "0x320E2E0", Length = "0x99")]
		[Token(Token = "0x60001EE")]
		public bool TryGetLastVersion(object source, out long version) { }

		[Address(RVA = "0x320EF80", Offset = "0x320E380", Length = "0x90")]
		[Token(Token = "0x60001EF")]
		public void UpdateVersion(object source, long version) { }

	}

	[Token(Token = "0x200003E")]
	private struct IgnoreUIChangesData
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000143")]
		public VisualElement element; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000144")]
		public Binding binding; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000145")]
		public BindingId bindingId; //Field offset: 0x10

		[Address(RVA = "0x3223C90", Offset = "0x3223090", Length = "0x84")]
		[Token(Token = "0x6000201")]
		public bool ShouldIgnoreChange(VisualElement ve, Binding b, BindingId id) { }

	}

	[Token(Token = "0x200003F")]
	internal struct IgnoreUIChangesScope : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000146")]
		private IgnoreUIChangesData m_ScopeData; //Field offset: 0x0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000147")]
		private DataBindingManager manager; //Field offset: 0xA8

		[Address(RVA = "0x3223E40", Offset = "0x3223240", Length = "0x334")]
		[Token(Token = "0x6000202")]
		internal IgnoreUIChangesScope(DataBindingManager manager, VisualElement target, BindingId bindingId, Binding binding) { }

		[Address(RVA = "0x3223D20", Offset = "0x3223120", Length = "0x11F")]
		[Token(Token = "0x6000203")]
		public override void Dispose() { }

	}

	[Token(Token = "0x4000113")]
	private static readonly PropertyName k_RequestBindingPropertyName; //Field offset: 0x0
	[Token(Token = "0x4000114")]
	private static readonly BindingId k_ClearBindingsToken; //Field offset: 0x8
	[Token(Token = "0x4000115")]
	internal static BindingLogLevel globalLogLevel; //Field offset: 0xA0
	[Token(Token = "0x4000117")]
	private static readonly List<BindingData> s_Empty; //Field offset: 0xA8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000112")]
	private readonly List<BindingData> m_BindingDataLocalPool; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000116")]
	private Nullable<BindingLogLevel> m_LogLevel; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000118")]
	private readonly BaseVisualElementPanel m_Panel; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000119")]
	private readonly HierarchyDataSourceTracker m_DataSourceTracker; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400011A")]
	private readonly HierarchyBindingTracker m_BindingsTracker; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400011B")]
	private readonly List<ChangesFromUI> m_DetectedChangesFromUI; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400011C")]
	private IgnoreUIChangesData m_IgnoreUIChangesData; //Field offset: 0x40

	[Token(Token = "0x17000039")]
	internal BindingLogLevel logLevel
	{
		[Address(RVA = "0x3209FA0", Offset = "0x32093A0", Length = "0x81")]
		[Token(Token = "0x6000199")]
		internal get { } //Length: 129
		[Address(RVA = "0x320A030", Offset = "0x3209430", Length = "0x5B")]
		[Token(Token = "0x600019A")]
		internal set { } //Length: 91
	}

	[Address(RVA = "0x3209B00", Offset = "0x3208F00", Length = "0x1CC")]
	[Token(Token = "0x60001BC")]
	private static DataBindingManager() { }

	[Address(RVA = "0x3209CD0", Offset = "0x32090D0", Length = "0x2CE")]
	[Token(Token = "0x600019C")]
	internal DataBindingManager(BaseVisualElementPanel panel) { }

	[Address(RVA = "0x3205CC0", Offset = "0x32050C0", Length = "0xCA")]
	[Token(Token = "0x60001B5")]
	internal static bool AnyPendingBindingRequests(VisualElement element) { }

	[Address(RVA = "0x3205D90", Offset = "0x3205190", Length = "0x96")]
	[Token(Token = "0x60001A2")]
	internal void CacheSourceBindingResult(BindingData bindingData, BindingResult result) { }

	[Address(RVA = "0x3205E30", Offset = "0x3205230", Length = "0x96")]
	[Token(Token = "0x60001A0")]
	internal void CacheUIBindingResult(BindingData bindingData, BindingResult result) { }

	[Address(RVA = "0x3205ED0", Offset = "0x32052D0", Length = "0x317")]
	[Token(Token = "0x60001B4")]
	private void ClearAllBindings(VisualElement element) { }

	[Address(RVA = "0x32061F0", Offset = "0x32055F0", Length = "0x9D")]
	[Token(Token = "0x60001AA")]
	internal void ClearChangesFromSource(object dataSource) { }

	[Address(RVA = "0x3206290", Offset = "0x3205690", Length = "0x1D")]
	[Token(Token = "0x60001B9")]
	public void ClearSourceCache() { }

	[Address(RVA = "0x32062B0", Offset = "0x32056B0", Length = "0x53E")]
	[Token(Token = "0x60001B2")]
	private static void CreateBindingRequest(VisualElement target, in BindingId bindingId, Binding binding, bool isTransferring) { }

	[Address(RVA = "0x32067F0", Offset = "0x3205BF0", Length = "0x1B")]
	[Token(Token = "0x60001B7")]
	public void DirtyBindingOrder() { }

	[Address(RVA = "0x3206810", Offset = "0x3205C10", Length = "0x15B")]
	[Token(Token = "0x60001B1")]
	public override void Dispose() { }

	[Address(RVA = "0x3209FA0", Offset = "0x32093A0", Length = "0x81")]
	[Token(Token = "0x6000199")]
	internal BindingLogLevel get_logLevel() { }

	[Address(RVA = "0x3206970", Offset = "0x3205D70", Length = "0xE4")]
	[Token(Token = "0x60001AB")]
	internal List<BindingData> GetBindingData(VisualElement element) { }

	[Address(RVA = "0x3206AB0", Offset = "0x3205EB0", Length = "0xFA")]
	[Token(Token = "0x60001A6")]
	internal IEnumerable<VisualElement> GetBoundElements() { }

	[Address(RVA = "0x3206A60", Offset = "0x3205E60", Length = "0x42")]
	[Token(Token = "0x60001A5")]
	internal int GetBoundElementsCount() { }

	[Address(RVA = "0x3206BB0", Offset = "0x3205FB0", Length = "0x8B")]
	[Token(Token = "0x60001A9")]
	internal HashSet<PropertyPath> GetChangedDetectedFromSource(object dataSource) { }

	[Address(RVA = "0x2F944A0", Offset = "0x2F938A0", Length = "0x7")]
	[Token(Token = "0x60001A8")]
	internal List<ChangesFromUI> GetChangedDetectedFromUI() { }

	[Address(RVA = "0x3206C40", Offset = "0x3206040", Length = "0x172")]
	[Token(Token = "0x60001BA")]
	public BindingData GetPooledBindingData(BindingTarget target, Binding binding) { }

	[Address(RVA = "0x3206DC0", Offset = "0x32061C0", Length = "0x16D")]
	[Token(Token = "0x60001A4")]
	internal DataSourceContext GetResolvedDataSourceContext(VisualElement element, BindingData bindingData) { }

	[Address(RVA = "0x3206F30", Offset = "0x3206330", Length = "0x4A")]
	[Token(Token = "0x600019D")]
	internal int GetTrackedDataSourcesCount() { }

	[Address(RVA = "0x3206F80", Offset = "0x3206380", Length = "0x170")]
	[Token(Token = "0x60001A7")]
	public IgnoreUIChangesScope IgnoreChangesScope(VisualElement target, BindingId bindingId, Binding binding) { }

	[Address(RVA = "0x32070F0", Offset = "0x32064F0", Length = "0x1E")]
	[Token(Token = "0x60001B0")]
	public void InvalidateCachedDataSource(HashSet<VisualElement> addedOrMovedElements, HashSet<VisualElement> removedElements) { }

	[Address(RVA = "0x3207110", Offset = "0x3206510", Length = "0x59D")]
	[Token(Token = "0x60001B3")]
	public void ProcessBindingRequests(VisualElement element) { }

	[Address(RVA = "0x32076B0", Offset = "0x3206AB0", Length = "0xE1E")]
	[Token(Token = "0x60001AD")]
	internal void RegisterBinding(VisualElement element, in BindingId bindingId, Binding binding) { }

	[Address(RVA = "0x32084D0", Offset = "0x32078D0", Length = "0x160")]
	[Token(Token = "0x60001BB")]
	public void ReleasePoolBindingData(BindingData data) { }

	[Address(RVA = "0x3208640", Offset = "0x3207A40", Length = "0x7")]
	[Token(Token = "0x600019B")]
	internal void ResetLogLevel() { }

	[Address(RVA = "0x320A030", Offset = "0x3209430", Length = "0x5B")]
	[Token(Token = "0x600019A")]
	internal void set_logLevel(BindingLogLevel value) { }

	[Address(RVA = "0x3208650", Offset = "0x3207A50", Length = "0x44")]
	[Token(Token = "0x60001B8")]
	public void TrackDataSource(object previous, object current) { }

	[Address(RVA = "0x32086A0", Offset = "0x3207AA0", Length = "0x1B3")]
	[Token(Token = "0x60001AF")]
	internal void TransferBindingRequests(VisualElement element) { }

	[Address(RVA = "0x3208860", Offset = "0x3207C60", Length = "0xDA")]
	[Token(Token = "0x60001AC")]
	internal bool TryGetBindingData(VisualElement element, in BindingId bindingId, out BindingData bindingData) { }

	[Address(RVA = "0x3208940", Offset = "0x3207D40", Length = "0x220")]
	[Token(Token = "0x60001B6")]
	internal static bool TryGetBindingRequest(VisualElement element, in BindingId bindingId, out Binding binding) { }

	[Address(RVA = "0x3208B70", Offset = "0x3207F70", Length = "0x96")]
	[Token(Token = "0x60001A3")]
	internal bool TryGetLastSourceBindingResult(BindingData bindingData, out BindingResult result) { }

	[Address(RVA = "0x3208C10", Offset = "0x3208010", Length = "0x96")]
	[Token(Token = "0x60001A1")]
	internal bool TryGetLastUIBindingResult(BindingData bindingData, out BindingResult result) { }

	[Address(RVA = "0x3208CB0", Offset = "0x32080B0", Length = "0xA5")]
	[Token(Token = "0x600019E")]
	internal bool TryGetLastVersion(object source, out long version) { }

	[Address(RVA = "0x3208D60", Offset = "0x3208160", Length = "0xCF0")]
	[Token(Token = "0x60001AE")]
	internal void UnregisterBinding(VisualElement element, in BindingId bindingId) { }

	[Address(RVA = "0x3209A60", Offset = "0x3208E60", Length = "0x96")]
	[Token(Token = "0x600019F")]
	internal void UpdateVersion(object source, long version) { }

}

